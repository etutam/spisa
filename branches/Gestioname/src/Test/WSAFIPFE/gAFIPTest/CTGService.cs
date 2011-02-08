namespace WSAFIPFE.gAFIPTest
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
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using WSAFIPFE.My;

    [WebServiceBinding(Name="CTGServiceSoap11Binding", Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class CTGService : SoapHttpClientProtocol
    {
        private SendOrPostCallback confirmarCTGOperationCompleted;
        private SendOrPostCallback dummyOperationCompleted;
        private SendOrPostCallback obtenerCosechasOperationCompleted;
        private SendOrPostCallback obtenerEspeciesOperationCompleted;
        private SendOrPostCallback obtenerLocalidadesPorCodigoProvinciaOperationCompleted;
        private SendOrPostCallback obtenerProvinciasOperationCompleted;
        private SendOrPostCallback solicitarCTGOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event confirmarCTGCompletedEventHandler confirmarCTGCompleted;

        public event dummyCompletedEventHandler dummyCompleted;

        public event obtenerCosechasCompletedEventHandler obtenerCosechasCompleted;

        public event obtenerEspeciesCompletedEventHandler obtenerEspeciesCompleted;

        public event obtenerLocalidadesPorCodigoProvinciaCompletedEventHandler obtenerLocalidadesPorCodigoProvinciaCompleted;

        public event obtenerProvinciasCompletedEventHandler obtenerProvinciasCompleted;

        public event solicitarCTGCompletedEventHandler solicitarCTGCompleted;

        public CTGService()
        {
            this.Url = MySettings.Default.WSAFIPFE_gAFIPTest_CTGService;
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

        public void CancelAsync(object userState)
        {
            base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("return", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/confirmarCTG", RequestNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", ResponseNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ConfirmarCTGResponse confirmarCTG([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequest auth, [XmlElement(Form=XmlSchemaForm.Unqualified)] ConfirmarCTGRequest confirmarCTGRequest)
        {
            return (ConfirmarCTGResponse) this.Invoke("confirmarCTG", new object[] { auth, confirmarCTGRequest })[0];
        }

        public void confirmarCTGAsync(AuthRequest auth, ConfirmarCTGRequest confirmarCTGRequest)
        {
            this.confirmarCTGAsync(auth, confirmarCTGRequest, null);
        }

        public void confirmarCTGAsync(AuthRequest auth, ConfirmarCTGRequest confirmarCTGRequest, object userState)
        {
            if (this.confirmarCTGOperationCompleted == null)
            {
                this.confirmarCTGOperationCompleted = new SendOrPostCallback(this.OnconfirmarCTGOperationCompleted);
            }
            this.InvokeAsync("confirmarCTG", new object[] { auth, confirmarCTGRequest }, this.confirmarCTGOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("dummyResponse", Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/")]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/dummy", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        public DummyResponse dummy()
        {
            return (DummyResponse) this.Invoke("dummy", new object[0])[0];
        }

        public void dummyAsync()
        {
            this.dummyAsync(null);
        }

        public void dummyAsync(object userState)
        {
            if (this.dummyOperationCompleted == null)
            {
                this.dummyOperationCompleted = new SendOrPostCallback(this.OndummyOperationCompleted);
            }
            this.InvokeAsync("dummy", new object[0], this.dummyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

        [return: XmlElement("return", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/obtenerCosechas", RequestNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", ResponseNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ArrayCosechasResponse[] obtenerCosechas([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequest auth)
        {
            return (ArrayCosechasResponse[]) this.Invoke("obtenerCosechas", new object[] { auth })[0];
        }

        public void obtenerCosechasAsync(AuthRequest auth)
        {
            this.obtenerCosechasAsync(auth, null);
        }

        public void obtenerCosechasAsync(AuthRequest auth, object userState)
        {
            if (this.obtenerCosechasOperationCompleted == null)
            {
                this.obtenerCosechasOperationCompleted = new SendOrPostCallback(this.OnobtenerCosechasOperationCompleted);
            }
            this.InvokeAsync("obtenerCosechas", new object[] { auth }, this.obtenerCosechasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("return", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/obtenerEspecies", RequestNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", ResponseNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ArrayEspeciesResponse[] obtenerEspecies([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequest auth)
        {
            return (ArrayEspeciesResponse[]) this.Invoke("obtenerEspecies", new object[] { auth })[0];
        }

        public void obtenerEspeciesAsync(AuthRequest auth)
        {
            this.obtenerEspeciesAsync(auth, null);
        }

        public void obtenerEspeciesAsync(AuthRequest auth, object userState)
        {
            if (this.obtenerEspeciesOperationCompleted == null)
            {
                this.obtenerEspeciesOperationCompleted = new SendOrPostCallback(this.OnobtenerEspeciesOperationCompleted);
            }
            this.InvokeAsync("obtenerEspecies", new object[] { auth }, this.obtenerEspeciesOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("return", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/obtenerLocalidadesPorCodigoProvincia", RequestNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", ResponseNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ArrayLocalidadesPorCodigoProvinciaResponse[] obtenerLocalidadesPorCodigoProvincia([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequest auth, [XmlElement(Form=XmlSchemaForm.Unqualified)] ObtenerLocalidadesPorCodigoProvinciaRequest obtenerLocalidadesPorCodigoProvinciaRequest)
        {
            return (ArrayLocalidadesPorCodigoProvinciaResponse[]) this.Invoke("obtenerLocalidadesPorCodigoProvincia", new object[] { auth, obtenerLocalidadesPorCodigoProvinciaRequest })[0];
        }

        public void obtenerLocalidadesPorCodigoProvinciaAsync(AuthRequest auth, ObtenerLocalidadesPorCodigoProvinciaRequest obtenerLocalidadesPorCodigoProvinciaRequest)
        {
            this.obtenerLocalidadesPorCodigoProvinciaAsync(auth, obtenerLocalidadesPorCodigoProvinciaRequest, null);
        }

        public void obtenerLocalidadesPorCodigoProvinciaAsync(AuthRequest auth, ObtenerLocalidadesPorCodigoProvinciaRequest obtenerLocalidadesPorCodigoProvinciaRequest, object userState)
        {
            if (this.obtenerLocalidadesPorCodigoProvinciaOperationCompleted == null)
            {
                this.obtenerLocalidadesPorCodigoProvinciaOperationCompleted = new SendOrPostCallback(this.OnobtenerLocalidadesPorCodigoProvinciaOperationCompleted);
            }
            this.InvokeAsync("obtenerLocalidadesPorCodigoProvincia", new object[] { auth, obtenerLocalidadesPorCodigoProvinciaRequest }, this.obtenerLocalidadesPorCodigoProvinciaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("return", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/obtenerProvincias", RequestNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", ResponseNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ArrayProvinciasResponse[] obtenerProvincias([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequest auth)
        {
            return (ArrayProvinciasResponse[]) this.Invoke("obtenerProvincias", new object[] { auth })[0];
        }

        public void obtenerProvinciasAsync(AuthRequest auth)
        {
            this.obtenerProvinciasAsync(auth, null);
        }

        public void obtenerProvinciasAsync(AuthRequest auth, object userState)
        {
            if (this.obtenerProvinciasOperationCompleted == null)
            {
                this.obtenerProvinciasOperationCompleted = new SendOrPostCallback(this.OnobtenerProvinciasOperationCompleted);
            }
            this.InvokeAsync("obtenerProvincias", new object[] { auth }, this.obtenerProvinciasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        private void OnconfirmarCTGOperationCompleted(object arg)
        {
            if (this.confirmarCTGCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                confirmarCTGCompletedEventHandler VB_t_ref_S0 = this.confirmarCTGCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new confirmarCTGCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OndummyOperationCompleted(object arg)
        {
            if (this.dummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                dummyCompletedEventHandler VB_t_ref_S0 = this.dummyCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new dummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnobtenerCosechasOperationCompleted(object arg)
        {
            if (this.obtenerCosechasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                obtenerCosechasCompletedEventHandler VB_t_ref_S0 = this.obtenerCosechasCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new obtenerCosechasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnobtenerEspeciesOperationCompleted(object arg)
        {
            if (this.obtenerEspeciesCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                obtenerEspeciesCompletedEventHandler VB_t_ref_S0 = this.obtenerEspeciesCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new obtenerEspeciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnobtenerLocalidadesPorCodigoProvinciaOperationCompleted(object arg)
        {
            if (this.obtenerLocalidadesPorCodigoProvinciaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                obtenerLocalidadesPorCodigoProvinciaCompletedEventHandler VB_t_ref_S0 = this.obtenerLocalidadesPorCodigoProvinciaCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new obtenerLocalidadesPorCodigoProvinciaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnobtenerProvinciasOperationCompleted(object arg)
        {
            if (this.obtenerProvinciasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                obtenerProvinciasCompletedEventHandler VB_t_ref_S0 = this.obtenerProvinciasCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new obtenerProvinciasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnsolicitarCTGOperationCompleted(object arg)
        {
            if (this.solicitarCTGCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                solicitarCTGCompletedEventHandler VB_t_ref_S0 = this.solicitarCTGCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new solicitarCTGCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        [return: XmlElement("return", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsctg.afip.gov.ar/CTGService/solicitarCTG", RequestNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", ResponseNamespace="http://impl.service.wsctg.afip.gov.ar/CTGService/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SolicitarCTGResponse solicitarCTG([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequest auth, [XmlElement(Form=XmlSchemaForm.Unqualified)] SolicitarCTGRequest solicitarCTGRequest)
        {
            return (SolicitarCTGResponse) this.Invoke("solicitarCTG", new object[] { auth, solicitarCTGRequest })[0];
        }

        public void solicitarCTGAsync(AuthRequest auth, SolicitarCTGRequest solicitarCTGRequest)
        {
            this.solicitarCTGAsync(auth, solicitarCTGRequest, null);
        }

        public void solicitarCTGAsync(AuthRequest auth, SolicitarCTGRequest solicitarCTGRequest, object userState)
        {
            if (this.solicitarCTGOperationCompleted == null)
            {
                this.solicitarCTGOperationCompleted = new SendOrPostCallback(this.OnsolicitarCTGOperationCompleted);
            }
            this.InvokeAsync("solicitarCTG", new object[] { auth, solicitarCTGRequest }, this.solicitarCTGOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

