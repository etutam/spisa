namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using WSAFIPFE.My;

    [WebServiceBinding(Name="wDigDepFielSoap", Namespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class wDigDepFiel : SoapHttpClientProtocol
    {
        private SendOrPostCallback AvisoDigitOperationCompleted;
        private SendOrPostCallback AvisoRecepAceptOperationCompleted;
        private SendOrPostCallback DummyOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event AvisoDigitCompletedEventHandler AvisoDigitCompleted;

        public event AvisoRecepAceptCompletedEventHandler AvisoRecepAceptCompleted;

        public event DummyCompletedEventHandler DummyCompleted;

        public wDigDepFiel()
        {
            this.Url = MySettings.Default.WSAFIPFE_dAFIP_wDigDepFiel;
            if (this.IsLocalFileSystemWebService(this.Url))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        [SoapDocumentMethod("ar.gov.afip.dia.serviciosWeb.wDigDepFiel/AvisoDigit", RequestNamespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel", ResponseNamespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public Recibo AvisoDigit(Autenticacion autentica, string nroLegajo, string cuitDeclarante, string cuitPSAD, string cuitIE, string cuitATA, string codigo, string url, [XmlArrayItem(IsNullable=false)] Familia[] familias, string ticket, string hashing, int cantidadTotal)
        {
            return (Recibo) this.Invoke("AvisoDigit", new object[] { autentica, nroLegajo, cuitDeclarante, cuitPSAD, cuitIE, cuitATA, codigo, url, familias, ticket, hashing, cantidadTotal })[0];
        }

        public void AvisoDigitAsync(Autenticacion autentica, string nroLegajo, string cuitDeclarante, string cuitPSAD, string cuitIE, string cuitATA, string codigo, string url, Familia[] familias, string ticket, string hashing, int cantidadTotal)
        {
            this.AvisoDigitAsync(autentica, nroLegajo, cuitDeclarante, cuitPSAD, cuitIE, cuitATA, codigo, url, familias, ticket, hashing, cantidadTotal, null);
        }

        public void AvisoDigitAsync(Autenticacion autentica, string nroLegajo, string cuitDeclarante, string cuitPSAD, string cuitIE, string cuitATA, string codigo, string url, Familia[] familias, string ticket, string hashing, int cantidadTotal, object userState)
        {
            if (this.AvisoDigitOperationCompleted == null)
            {
                this.AvisoDigitOperationCompleted = new SendOrPostCallback(this.OnAvisoDigitOperationCompleted);
            }
            this.InvokeAsync("AvisoDigit", new object[] { autentica, nroLegajo, cuitDeclarante, cuitPSAD, cuitIE, cuitATA, codigo, url, familias, ticket, hashing, cantidadTotal }, this.AvisoDigitOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("ar.gov.afip.dia.serviciosWeb.wDigDepFiel/AvisoRecepAcept", RequestNamespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel", ResponseNamespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public Recibo AvisoRecepAcept(Autenticacion autentica, string nroLegajo, string cuitDeclarante, string cuitPSAD, string cuitIE, string codigo, DateTime fechaHoraAcept, string ticket)
        {
            return (Recibo) this.Invoke("AvisoRecepAcept", new object[] { autentica, nroLegajo, cuitDeclarante, cuitPSAD, cuitIE, codigo, fechaHoraAcept, ticket })[0];
        }

        public void AvisoRecepAceptAsync(Autenticacion autentica, string nroLegajo, string cuitDeclarante, string cuitPSAD, string cuitIE, string codigo, DateTime fechaHoraAcept, string ticket)
        {
            this.AvisoRecepAceptAsync(autentica, nroLegajo, cuitDeclarante, cuitPSAD, cuitIE, codigo, fechaHoraAcept, ticket, null);
        }

        public void AvisoRecepAceptAsync(Autenticacion autentica, string nroLegajo, string cuitDeclarante, string cuitPSAD, string cuitIE, string codigo, DateTime fechaHoraAcept, string ticket, object userState)
        {
            if (this.AvisoRecepAceptOperationCompleted == null)
            {
                this.AvisoRecepAceptOperationCompleted = new SendOrPostCallback(this.OnAvisoRecepAceptOperationCompleted);
            }
            this.InvokeAsync("AvisoRecepAcept", new object[] { autentica, nroLegajo, cuitDeclarante, cuitPSAD, cuitIE, codigo, fechaHoraAcept, ticket }, this.AvisoRecepAceptOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        public void CancelAsync(object userState)
        {
            base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("ar.gov.afip.dia.serviciosWeb.wDigDepFiel/Dummy", RequestNamespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel", ResponseNamespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public WsDummyResponse Dummy()
        {
            return (WsDummyResponse) this.Invoke("Dummy", new object[0])[0];
        }

        public void DummyAsync()
        {
            this.DummyAsync(null);
        }

        public void DummyAsync(object userState)
        {
            if (this.DummyOperationCompleted == null)
            {
                this.DummyOperationCompleted = new SendOrPostCallback(this.OnDummyOperationCompleted);
            }
            this.InvokeAsync("Dummy", new object[0], this.DummyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }
            Uri wsUri = new Uri(url);
            return ((wsUri.Port >= 0x400) && (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0));
        }

        private void OnAvisoDigitOperationCompleted(object arg)
        {
            if (this.AvisoDigitCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                AvisoDigitCompletedEventHandler VB$t_ref$S0 = this.AvisoDigitCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new AvisoDigitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnAvisoRecepAceptOperationCompleted(object arg)
        {
            if (this.AvisoRecepAceptCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                AvisoRecepAceptCompletedEventHandler VB$t_ref$S0 = this.AvisoRecepAceptCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new AvisoRecepAceptCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnDummyOperationCompleted(object arg)
        {
            if (this.DummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                DummyCompletedEventHandler VB$t_ref$S0 = this.DummyCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new DummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        public string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly) && !this.IsLocalFileSystemWebService(value))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
    }
}

