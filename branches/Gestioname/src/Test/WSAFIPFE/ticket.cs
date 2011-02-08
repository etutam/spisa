namespace WSAFIPFE
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Net;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Xml;
    using WSAFIPFE.wsaa;
    using WSAFIPFE.wsaaTest;

    internal class ticket
    {
        internal static int _globalUniqueID = 0;
        internal DateTime ExpirationTime;
        internal DateTime GenerationTime;
        internal Factura.modoFiscal iModo;
        internal string lastErrorMensaje;
        internal int lastErrorNumero;
        internal string RutaDelCertificadoFirmante;
        internal string Service;
        internal string Sign;
        private string strProxyDomain;
        private string strProxyHost;
        private int strProxyPort;
        private string strProxyUserName;
        private string strProxyUserPassword;
        internal string Token;
        internal uint UniqueId;
        internal XmlDocument XmlLoginTicketRequest = null;
        internal string XmlLoginTicketRequestFirmado;
        internal XmlDocument XmlLoginTicketResponse = null;
        internal string XmlStrLoginTicketRequestTemplate = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>";

        internal string ObtenerLoginTicketResponse(string argServicio, string argUrlWsaa, string argRutaCertX509Firmante, Factura.modoFiscal Modo, long xiIdentificador)
        {
            long iIdentificador = 0L;
            this.RutaDelCertificadoFirmante = argRutaCertX509Firmante;
            string cmsFirmadoBase64 = "";
            string strLoginTicketResponse = "";
            this.lastErrorMensaje = "";
            this.lastErrorNumero = 0;
            try
            {
                if (iIdentificador == 0L)
                {
                    _globalUniqueID++;
                    iIdentificador = _globalUniqueID;
                }
                this.XmlLoginTicketRequest = new XmlDocument();
                this.XmlLoginTicketRequest.LoadXml(this.XmlStrLoginTicketRequestTemplate);
                XmlNode xmlNodoUniqueId = this.XmlLoginTicketRequest.SelectSingleNode("//uniqueId");
                XmlNode xmlNodoGenerationTime = this.XmlLoginTicketRequest.SelectSingleNode("//generationTime");
                XmlNode xmlNodoExpirationTime = this.XmlLoginTicketRequest.SelectSingleNode("//expirationTime");
                XmlNode xmlNodoService = this.XmlLoginTicketRequest.SelectSingleNode("//service");
                xmlNodoGenerationTime.InnerText = DateTime.UtcNow.AddMinutes(-10.0).ToString("s") + "Z";
                xmlNodoExpirationTime.InnerText = DateTime.UtcNow.AddMinutes(10.0).ToString("s") + "Z";
                xmlNodoUniqueId.InnerText = Conversions.ToString(iIdentificador);
                xmlNodoService.InnerText = argServicio;
                this.Service = argServicio;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception excepcionAlGenerarLoginTicketRequest = exception1;
                this.lastErrorMensaje = excepcionAlGenerarLoginTicketRequest.Message;
                this.lastErrorNumero = 1;
                ProjectData.ClearProjectError();
            }
            if (this.lastErrorNumero == 0)
            {
                try
                {
                    X509Certificate2 certFirmante = Certificado.ObtieneCertificadoDesdeArchivo(this.RutaDelCertificadoFirmante);
                    cmsFirmadoBase64 = Convert.ToBase64String(Certificado.FirmaBytesMensaje(Encoding.UTF8.GetBytes(this.XmlLoginTicketRequest.OuterXml), certFirmante));
                    this.XmlLoginTicketRequestFirmado = cmsFirmadoBase64;
                }
                catch (Exception exception2)
                {
                    ProjectData.SetProjectError(exception2);
                    Exception excepcionAlFirmar = exception2;
                    this.lastErrorNumero = 2;
                    this.lastErrorMensaje = excepcionAlFirmar.Message;
                    ProjectData.ClearProjectError();
                }
            }
            if (this.lastErrorNumero == 0)
            {
                try
                {
                    if (this.iModo == Factura.modoFiscal.Test)
                    {
                        WSAFIPFE.wsaaTest.LoginCMSService servicioWsaa = new WSAFIPFE.wsaaTest.LoginCMSService();
                        servicioWsaa.Url = argUrlWsaa;
                        if (this.ProxyUserName != "")
                        {
                            NetworkCredential cr = new NetworkCredential();
                            WebProxy pr = new WebProxy(this.ProxyHost, this.ProxyPort);
                            cr.Domain = this.ProxyDomain;
                            cr.Password = this.ProxyUserPassword;
                            cr.UserName = this.ProxyUserName;
                            pr.Credentials = cr;
                            servicioWsaa.Proxy = pr;
                        }
                        strLoginTicketResponse = servicioWsaa.loginCms(cmsFirmadoBase64);
                    }
                    else
                    {
                        WSAFIPFE.wsaa.LoginCMSService servicioWsaa = new WSAFIPFE.wsaa.LoginCMSService();
                        servicioWsaa.Url = argUrlWsaa;
                        if (this.ProxyUserName != "")
                        {
                            NetworkCredential cr = new NetworkCredential();
                            WebProxy pr = new WebProxy(this.ProxyHost, this.ProxyPort);
                            cr.Domain = this.ProxyDomain;
                            cr.Password = this.ProxyUserPassword;
                            cr.UserName = this.ProxyUserName;
                            pr.Credentials = cr;
                            servicioWsaa.Proxy = pr;
                        }
                        strLoginTicketResponse = servicioWsaa.loginCms(cmsFirmadoBase64);
                    }
                }
                catch (Exception exception3)
                {
                    ProjectData.SetProjectError(exception3);
                    Exception excepcionAlInvocarWsaa = exception3;
                    this.lastErrorNumero = 3;
                    this.lastErrorMensaje = excepcionAlInvocarWsaa.Message;
                    ProjectData.ClearProjectError();
                }
            }
            if (this.lastErrorNumero != 0)
            {
                return "";
            }
            try
            {
                this.XmlLoginTicketResponse = new XmlDocument();
                this.XmlLoginTicketResponse.LoadXml(strLoginTicketResponse);
                this.UniqueId = uint.Parse(this.XmlLoginTicketResponse.SelectSingleNode("//uniqueId").InnerText);
                this.GenerationTime = DateTime.Parse(this.XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText);
                this.ExpirationTime = DateTime.Parse(this.XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText);
                this.Sign = this.XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText;
                this.Token = this.XmlLoginTicketResponse.SelectSingleNode("//token").InnerText;
            }
            catch (Exception exception4)
            {
                ProjectData.SetProjectError(exception4);
                Exception exception = exception4;
                this.lastErrorNumero = 4;
                this.lastErrorMensaje = exception.Message;
                ProjectData.ClearProjectError();
            }
            return strLoginTicketResponse;
        }

        internal string ProxyDomain
        {
            get
            {
                return this.strProxyDomain;
            }
            set
            {
                this.strProxyDomain = value;
            }
        }

        internal string ProxyHost
        {
            get
            {
                return this.strProxyHost;
            }
            set
            {
                this.strProxyHost = value;
            }
        }

        internal int ProxyPort
        {
            get
            {
                return this.strProxyPort;
            }
            set
            {
                this.strProxyPort = value;
            }
        }

        internal string ProxyUserName
        {
            get
            {
                return this.strProxyUserName;
            }
            set
            {
                this.strProxyUserName = value;
            }
        }

        internal string ProxyUserPassword
        {
            get
            {
                return this.strProxyUserPassword;
            }
            set
            {
                this.strProxyUserPassword = value;
            }
        }

        internal string UltimoPedidoFirmadoXML
        {
            get
            {
                return this.XmlLoginTicketRequestFirmado;
            }
        }

        internal XmlDocument UltimoPedidoXML
        {
            get
            {
                return this.XmlLoginTicketRequest;
            }
        }
    }
}

