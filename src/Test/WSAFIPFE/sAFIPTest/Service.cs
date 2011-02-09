namespace WSAFIPFE.sAFIPTest
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

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), WebServiceBinding(Name="ServiceSoap", Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code"), DebuggerStepThrough]
    public class Service : SoapHttpClientProtocol
    {
        private SendOrPostCallback SEGAuthorizeOperationCompleted;
        private SendOrPostCallback SEGDummyOperationCompleted;
        private SendOrPostCallback SEGGetCMPOperationCompleted;
        private SendOrPostCallback SEGGetLast_CMPOperationCompleted;
        private SendOrPostCallback SEGGetLast_IDOperationCompleted;
        private SendOrPostCallback SEGGetPARAM_MONOperationCompleted;
        private SendOrPostCallback SEGGetPARAM_Tipo_CbteOperationCompleted;
        private SendOrPostCallback SEGGetPARAM_Tipo_docOperationCompleted;
        private SendOrPostCallback SEGGetPARAM_Tipo_IVAOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event SEGAuthorizeCompletedEventHandler SEGAuthorizeCompleted;

        public event SEGDummyCompletedEventHandler SEGDummyCompleted;

        public event SEGGetCMPCompletedEventHandler SEGGetCMPCompleted;

        public event SEGGetLast_CMPCompletedEventHandler SEGGetLast_CMPCompleted;

        public event SEGGetLast_IDCompletedEventHandler SEGGetLast_IDCompleted;

        public event SEGGetPARAM_MONCompletedEventHandler SEGGetPARAM_MONCompleted;

        public event SEGGetPARAM_Tipo_CbteCompletedEventHandler SEGGetPARAM_Tipo_CbteCompleted;

        public event SEGGetPARAM_Tipo_docCompletedEventHandler SEGGetPARAM_Tipo_docCompleted;

        public event SEGGetPARAM_Tipo_IVACompletedEventHandler SEGGetPARAM_Tipo_IVACompleted;

        public Service()
        {
            this.Url = MySettings.Default.WSAFIPFE_sAFIPTest_Service;
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

        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }
            Uri wsUri = new Uri(url);
            return ((wsUri.Port >= 0x400) && (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0));
        }

        private void OnSEGAuthorizeOperationCompleted(object arg)
        {
            if (this.SEGAuthorizeCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGAuthorizeCompletedEventHandler VB$t_ref$S0 = this.SEGAuthorizeCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGAuthorizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGDummyOperationCompleted(object arg)
        {
            if (this.SEGDummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGDummyCompletedEventHandler VB$t_ref$S0 = this.SEGDummyCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGDummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetCMPOperationCompleted(object arg)
        {
            if (this.SEGGetCMPCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetCMPCompletedEventHandler VB$t_ref$S0 = this.SEGGetCMPCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetCMPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetLast_CMPOperationCompleted(object arg)
        {
            if (this.SEGGetLast_CMPCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetLast_CMPCompletedEventHandler VB$t_ref$S0 = this.SEGGetLast_CMPCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetLast_CMPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetLast_IDOperationCompleted(object arg)
        {
            if (this.SEGGetLast_IDCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetLast_IDCompletedEventHandler VB$t_ref$S0 = this.SEGGetLast_IDCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetLast_IDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetPARAM_MONOperationCompleted(object arg)
        {
            if (this.SEGGetPARAM_MONCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetPARAM_MONCompletedEventHandler VB$t_ref$S0 = this.SEGGetPARAM_MONCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetPARAM_MONCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetPARAM_Tipo_CbteOperationCompleted(object arg)
        {
            if (this.SEGGetPARAM_Tipo_CbteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetPARAM_Tipo_CbteCompletedEventHandler VB$t_ref$S0 = this.SEGGetPARAM_Tipo_CbteCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetPARAM_Tipo_CbteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetPARAM_Tipo_docOperationCompleted(object arg)
        {
            if (this.SEGGetPARAM_Tipo_docCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetPARAM_Tipo_docCompletedEventHandler VB$t_ref$S0 = this.SEGGetPARAM_Tipo_docCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetPARAM_Tipo_docCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnSEGGetPARAM_Tipo_IVAOperationCompleted(object arg)
        {
            if (this.SEGGetPARAM_Tipo_IVACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                SEGGetPARAM_Tipo_IVACompletedEventHandler VB$t_ref$S0 = this.SEGGetPARAM_Tipo_IVACompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new SEGGetPARAM_Tipo_IVACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGAuthorize", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponseAuthorize SEGAuthorize(ClsSEGAuthRequest Auth, ClsSEGRequest Cmp)
        {
            return (SEGResponseAuthorize) this.Invoke("SEGAuthorize", new object[] { Auth, Cmp })[0];
        }

        public void SEGAuthorizeAsync(ClsSEGAuthRequest Auth, ClsSEGRequest Cmp)
        {
            this.SEGAuthorizeAsync(Auth, Cmp, null);
        }

        public void SEGAuthorizeAsync(ClsSEGAuthRequest Auth, ClsSEGRequest Cmp, object userState)
        {
            if (this.SEGAuthorizeOperationCompleted == null)
            {
                this.SEGAuthorizeOperationCompleted = new SendOrPostCallback(this.OnSEGAuthorizeOperationCompleted);
            }
            this.InvokeAsync("SEGAuthorize", new object[] { Auth, Cmp }, this.SEGAuthorizeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGDummy", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public DummyResponse SEGDummy()
        {
            return (DummyResponse) this.Invoke("SEGDummy", new object[0])[0];
        }

        public void SEGDummyAsync()
        {
            this.SEGDummyAsync(null);
        }

        public void SEGDummyAsync(object userState)
        {
            if (this.SEGDummyOperationCompleted == null)
            {
                this.SEGDummyOperationCompleted = new SendOrPostCallback(this.OnSEGDummyOperationCompleted);
            }
            this.InvokeAsync("SEGDummy", new object[0], this.SEGDummyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetCMP", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGGetCMPResponse SEGGetCMP(ClsSEGAuthRequest Auth, ClsSEGGetCMP Cmp)
        {
            return (SEGGetCMPResponse) this.Invoke("SEGGetCMP", new object[] { Auth, Cmp })[0];
        }

        public void SEGGetCMPAsync(ClsSEGAuthRequest Auth, ClsSEGGetCMP Cmp)
        {
            this.SEGGetCMPAsync(Auth, Cmp, null);
        }

        public void SEGGetCMPAsync(ClsSEGAuthRequest Auth, ClsSEGGetCMP Cmp, object userState)
        {
            if (this.SEGGetCMPOperationCompleted == null)
            {
                this.SEGGetCMPOperationCompleted = new SendOrPostCallback(this.OnSEGGetCMPOperationCompleted);
            }
            this.InvokeAsync("SEGGetCMP", new object[] { Auth, Cmp }, this.SEGGetCMPOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetLast_CMP", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponseLast_CMP SEGGetLast_CMP(ClsSEG_LastCMP Auth)
        {
            return (SEGResponseLast_CMP) this.Invoke("SEGGetLast_CMP", new object[] { Auth })[0];
        }

        public void SEGGetLast_CMPAsync(ClsSEG_LastCMP Auth)
        {
            this.SEGGetLast_CMPAsync(Auth, null);
        }

        public void SEGGetLast_CMPAsync(ClsSEG_LastCMP Auth, object userState)
        {
            if (this.SEGGetLast_CMPOperationCompleted == null)
            {
                this.SEGGetLast_CMPOperationCompleted = new SendOrPostCallback(this.OnSEGGetLast_CMPOperationCompleted);
            }
            this.InvokeAsync("SEGGetLast_CMP", new object[] { Auth }, this.SEGGetLast_CMPOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetLast_ID", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponse_LastID SEGGetLast_ID(ClsSEGAuthRequest Auth)
        {
            return (SEGResponse_LastID) this.Invoke("SEGGetLast_ID", new object[] { Auth })[0];
        }

        public void SEGGetLast_IDAsync(ClsSEGAuthRequest Auth)
        {
            this.SEGGetLast_IDAsync(Auth, null);
        }

        public void SEGGetLast_IDAsync(ClsSEGAuthRequest Auth, object userState)
        {
            if (this.SEGGetLast_IDOperationCompleted == null)
            {
                this.SEGGetLast_IDOperationCompleted = new SendOrPostCallback(this.OnSEGGetLast_IDOperationCompleted);
            }
            this.InvokeAsync("SEGGetLast_ID", new object[] { Auth }, this.SEGGetLast_IDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetPARAM_MON", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponse_Mon SEGGetPARAM_MON(ClsSEGAuthRequest auth)
        {
            return (SEGResponse_Mon) this.Invoke("SEGGetPARAM_MON", new object[] { auth })[0];
        }

        public void SEGGetPARAM_MONAsync(ClsSEGAuthRequest auth)
        {
            this.SEGGetPARAM_MONAsync(auth, null);
        }

        public void SEGGetPARAM_MONAsync(ClsSEGAuthRequest auth, object userState)
        {
            if (this.SEGGetPARAM_MONOperationCompleted == null)
            {
                this.SEGGetPARAM_MONOperationCompleted = new SendOrPostCallback(this.OnSEGGetPARAM_MONOperationCompleted);
            }
            this.InvokeAsync("SEGGetPARAM_MON", new object[] { auth }, this.SEGGetPARAM_MONOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetPARAM_Tipo_Cbte", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponse_Tipo_Cbte SEGGetPARAM_Tipo_Cbte(ClsSEGAuthRequest auth)
        {
            return (SEGResponse_Tipo_Cbte) this.Invoke("SEGGetPARAM_Tipo_Cbte", new object[] { auth })[0];
        }

        public void SEGGetPARAM_Tipo_CbteAsync(ClsSEGAuthRequest auth)
        {
            this.SEGGetPARAM_Tipo_CbteAsync(auth, null);
        }

        public void SEGGetPARAM_Tipo_CbteAsync(ClsSEGAuthRequest auth, object userState)
        {
            if (this.SEGGetPARAM_Tipo_CbteOperationCompleted == null)
            {
                this.SEGGetPARAM_Tipo_CbteOperationCompleted = new SendOrPostCallback(this.OnSEGGetPARAM_Tipo_CbteOperationCompleted);
            }
            this.InvokeAsync("SEGGetPARAM_Tipo_Cbte", new object[] { auth }, this.SEGGetPARAM_Tipo_CbteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetPARAM_Tipo_doc", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponse_Tipo_doc SEGGetPARAM_Tipo_doc(ClsSEGAuthRequest auth)
        {
            return (SEGResponse_Tipo_doc) this.Invoke("SEGGetPARAM_Tipo_doc", new object[] { auth })[0];
        }

        public void SEGGetPARAM_Tipo_docAsync(ClsSEGAuthRequest auth)
        {
            this.SEGGetPARAM_Tipo_docAsync(auth, null);
        }

        public void SEGGetPARAM_Tipo_docAsync(ClsSEGAuthRequest auth, object userState)
        {
            if (this.SEGGetPARAM_Tipo_docOperationCompleted == null)
            {
                this.SEGGetPARAM_Tipo_docOperationCompleted = new SendOrPostCallback(this.OnSEGGetPARAM_Tipo_docOperationCompleted);
            }
            this.InvokeAsync("SEGGetPARAM_Tipo_doc", new object[] { auth }, this.SEGGetPARAM_Tipo_docOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.seg/SEGGetPARAM_Tipo_IVA", RequestNamespace="http://ar.gov.afip.dif.seg/", ResponseNamespace="http://ar.gov.afip.dif.seg/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public SEGResponse_Tipo_IVA SEGGetPARAM_Tipo_IVA(ClsSEGAuthRequest auth)
        {
            return (SEGResponse_Tipo_IVA) this.Invoke("SEGGetPARAM_Tipo_IVA", new object[] { auth })[0];
        }

        public void SEGGetPARAM_Tipo_IVAAsync(ClsSEGAuthRequest auth)
        {
            this.SEGGetPARAM_Tipo_IVAAsync(auth, null);
        }

        public void SEGGetPARAM_Tipo_IVAAsync(ClsSEGAuthRequest auth, object userState)
        {
            if (this.SEGGetPARAM_Tipo_IVAOperationCompleted == null)
            {
                this.SEGGetPARAM_Tipo_IVAOperationCompleted = new SendOrPostCallback(this.OnSEGGetPARAM_Tipo_IVAOperationCompleted);
            }
            this.InvokeAsync("SEGGetPARAM_Tipo_IVA", new object[] { auth }, this.SEGGetPARAM_Tipo_IVAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

