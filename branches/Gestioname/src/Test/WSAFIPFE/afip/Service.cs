namespace WSAFIPFE.afip
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
    using WSAFIPFE.My;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), WebServiceBinding(Name="ServiceSoap", Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DesignerCategory("code"), DebuggerStepThrough]
    public class Service : SoapHttpClientProtocol
    {
        private SendOrPostCallback FEAutRequestOperationCompleted;
        private SendOrPostCallback FEConsultaCAERequestOperationCompleted;
        private SendOrPostCallback FEDummyOperationCompleted;
        private SendOrPostCallback FERecuperaLastCMPRequestOperationCompleted;
        private SendOrPostCallback FERecuperaQTYRequestOperationCompleted;
        private SendOrPostCallback FEUltNroRequestOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event FEAutRequestCompletedEventHandler FEAutRequestCompleted;

        public event FEConsultaCAERequestCompletedEventHandler FEConsultaCAERequestCompleted;

        public event FEDummyCompletedEventHandler FEDummyCompleted;

        public event FERecuperaLastCMPRequestCompletedEventHandler FERecuperaLastCMPRequestCompleted;

        public event FERecuperaQTYRequestCompletedEventHandler FERecuperaQTYRequestCompleted;

        public event FEUltNroRequestCompletedEventHandler FEUltNroRequestCompleted;

        public Service()
        {
            this.Url = MySettings.Default.WSAFIPFE_afip_Service;
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

        [SoapDocumentMethod("http://ar.gov.afip.dif.facturaelectronica/FEAutRequest", RequestNamespace="http://ar.gov.afip.dif.facturaelectronica/", ResponseNamespace="http://ar.gov.afip.dif.facturaelectronica/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEResponse FEAutRequest(FEAuthRequest argAuth, FERequest Fer)
        {
            return (FEResponse) this.Invoke("FEAutRequest", new object[] { argAuth, Fer })[0];
        }

        public void FEAutRequestAsync(FEAuthRequest argAuth, FERequest Fer)
        {
            this.FEAutRequestAsync(argAuth, Fer, null);
        }

        public void FEAutRequestAsync(FEAuthRequest argAuth, FERequest Fer, object userState)
        {
            if (this.FEAutRequestOperationCompleted == null)
            {
                this.FEAutRequestOperationCompleted = new SendOrPostCallback(this.OnFEAutRequestOperationCompleted);
            }
            this.InvokeAsync("FEAutRequest", new object[] { argAuth, Fer }, this.FEAutRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.facturaelectronica/FEConsultaCAERequest", RequestNamespace="http://ar.gov.afip.dif.facturaelectronica/", ResponseNamespace="http://ar.gov.afip.dif.facturaelectronica/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEConsultaCAEResponse FEConsultaCAERequest(FEAuthRequest argAuth, FEConsultaCAEReq argCAERequest)
        {
            return (FEConsultaCAEResponse) this.Invoke("FEConsultaCAERequest", new object[] { argAuth, argCAERequest })[0];
        }

        public void FEConsultaCAERequestAsync(FEAuthRequest argAuth, FEConsultaCAEReq argCAERequest)
        {
            this.FEConsultaCAERequestAsync(argAuth, argCAERequest, null);
        }

        public void FEConsultaCAERequestAsync(FEAuthRequest argAuth, FEConsultaCAEReq argCAERequest, object userState)
        {
            if (this.FEConsultaCAERequestOperationCompleted == null)
            {
                this.FEConsultaCAERequestOperationCompleted = new SendOrPostCallback(this.OnFEConsultaCAERequestOperationCompleted);
            }
            this.InvokeAsync("FEConsultaCAERequest", new object[] { argAuth, argCAERequest }, this.FEConsultaCAERequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.facturaelectronica/FEDummy", RequestNamespace="http://ar.gov.afip.dif.facturaelectronica/", ResponseNamespace="http://ar.gov.afip.dif.facturaelectronica/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public DummyResponse FEDummy()
        {
            return (DummyResponse) this.Invoke("FEDummy", new object[0])[0];
        }

        public void FEDummyAsync()
        {
            this.FEDummyAsync(null);
        }

        public void FEDummyAsync(object userState)
        {
            if (this.FEDummyOperationCompleted == null)
            {
                this.FEDummyOperationCompleted = new SendOrPostCallback(this.OnFEDummyOperationCompleted);
            }
            this.InvokeAsync("FEDummy", new object[0], this.FEDummyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.facturaelectronica/FERecuperaLastCMPRequest", RequestNamespace="http://ar.gov.afip.dif.facturaelectronica/", ResponseNamespace="http://ar.gov.afip.dif.facturaelectronica/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FERecuperaLastCMPResponse FERecuperaLastCMPRequest(FEAuthRequest argAuth, FELastCMPtype argTCMP)
        {
            return (FERecuperaLastCMPResponse) this.Invoke("FERecuperaLastCMPRequest", new object[] { argAuth, argTCMP })[0];
        }

        public void FERecuperaLastCMPRequestAsync(FEAuthRequest argAuth, FELastCMPtype argTCMP)
        {
            this.FERecuperaLastCMPRequestAsync(argAuth, argTCMP, null);
        }

        public void FERecuperaLastCMPRequestAsync(FEAuthRequest argAuth, FELastCMPtype argTCMP, object userState)
        {
            if (this.FERecuperaLastCMPRequestOperationCompleted == null)
            {
                this.FERecuperaLastCMPRequestOperationCompleted = new SendOrPostCallback(this.OnFERecuperaLastCMPRequestOperationCompleted);
            }
            this.InvokeAsync("FERecuperaLastCMPRequest", new object[] { argAuth, argTCMP }, this.FERecuperaLastCMPRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.facturaelectronica/FERecuperaQTYRequest", RequestNamespace="http://ar.gov.afip.dif.facturaelectronica/", ResponseNamespace="http://ar.gov.afip.dif.facturaelectronica/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FERecuperaQTYResponse FERecuperaQTYRequest(FEAuthRequest argAuth)
        {
            return (FERecuperaQTYResponse) this.Invoke("FERecuperaQTYRequest", new object[] { argAuth })[0];
        }

        public void FERecuperaQTYRequestAsync(FEAuthRequest argAuth)
        {
            this.FERecuperaQTYRequestAsync(argAuth, null);
        }

        public void FERecuperaQTYRequestAsync(FEAuthRequest argAuth, object userState)
        {
            if (this.FERecuperaQTYRequestOperationCompleted == null)
            {
                this.FERecuperaQTYRequestOperationCompleted = new SendOrPostCallback(this.OnFERecuperaQTYRequestOperationCompleted);
            }
            this.InvokeAsync("FERecuperaQTYRequest", new object[] { argAuth }, this.FERecuperaQTYRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.facturaelectronica/FEUltNroRequest", RequestNamespace="http://ar.gov.afip.dif.facturaelectronica/", ResponseNamespace="http://ar.gov.afip.dif.facturaelectronica/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEUltNroResponse FEUltNroRequest(FEAuthRequest argAuth)
        {
            return (FEUltNroResponse) this.Invoke("FEUltNroRequest", new object[] { argAuth })[0];
        }

        public void FEUltNroRequestAsync(FEAuthRequest argAuth)
        {
            this.FEUltNroRequestAsync(argAuth, null);
        }

        public void FEUltNroRequestAsync(FEAuthRequest argAuth, object userState)
        {
            if (this.FEUltNroRequestOperationCompleted == null)
            {
                this.FEUltNroRequestOperationCompleted = new SendOrPostCallback(this.OnFEUltNroRequestOperationCompleted);
            }
            this.InvokeAsync("FEUltNroRequest", new object[] { argAuth }, this.FEUltNroRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

        private void OnFEAutRequestOperationCompleted(object arg)
        {
            if (this.FEAutRequestCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEAutRequestCompletedEventHandler VB_t_ref_S0 = this.FEAutRequestCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEAutRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEConsultaCAERequestOperationCompleted(object arg)
        {
            if (this.FEConsultaCAERequestCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEConsultaCAERequestCompletedEventHandler VB_t_ref_S0 = this.FEConsultaCAERequestCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEConsultaCAERequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEDummyOperationCompleted(object arg)
        {
            if (this.FEDummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEDummyCompletedEventHandler VB_t_ref_S0 = this.FEDummyCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEDummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFERecuperaLastCMPRequestOperationCompleted(object arg)
        {
            if (this.FERecuperaLastCMPRequestCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FERecuperaLastCMPRequestCompletedEventHandler VB_t_ref_S0 = this.FERecuperaLastCMPRequestCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FERecuperaLastCMPRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFERecuperaQTYRequestOperationCompleted(object arg)
        {
            if (this.FERecuperaQTYRequestCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FERecuperaQTYRequestCompletedEventHandler VB_t_ref_S0 = this.FERecuperaQTYRequestCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FERecuperaQTYRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEUltNroRequestOperationCompleted(object arg)
        {
            if (this.FEUltNroRequestCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEUltNroRequestCompletedEventHandler VB_t_ref_S0 = this.FEUltNroRequestCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEUltNroRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
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

