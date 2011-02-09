namespace WSAFIPFE.bAFIP
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

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), WebServiceBinding(Name="ServiceSoap", Namespace="http://ar.gov.afip.dif.bfe/"), DebuggerStepThrough, DesignerCategory("code")]
    public class Service : SoapHttpClientProtocol
    {
        private SendOrPostCallback BFEAuthorizeOperationCompleted;
        private SendOrPostCallback BFEDummyOperationCompleted;
        private SendOrPostCallback BFEGetCMPOperationCompleted;
        private SendOrPostCallback BFEGetLast_CMPOperationCompleted;
        private SendOrPostCallback BFEGetLast_IDOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_MONOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_NCMOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_Tipo_CbteOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_Tipo_docOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_Tipo_IVAOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_UMedOperationCompleted;
        private SendOrPostCallback BFEGetPARAM_ZonasOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event BFEAuthorizeCompletedEventHandler BFEAuthorizeCompletedEvent;

        public event BFEDummyCompletedEventHandler BFEDummyCompletedEvent;

        public event BFEGetCMPCompletedEventHandler BFEGetCMPCompletedEvent;

        public event BFEGetLast_CMPCompletedEventHandler BFEGetLast_CMPCompletedEvent;

        public event BFEGetLast_IDCompletedEventHandler BFEGetLast_IDCompletedEvent;

        public event BFEGetPARAM_MONCompletedEventHandler BFEGetPARAM_MONCompletedEvent;

        public event BFEGetPARAM_NCMCompletedEventHandler BFEGetPARAM_NCMCompletedEvent;

        public event BFEGetPARAM_Tipo_CbteCompletedEventHandler BFEGetPARAM_Tipo_CbteCompletedEvent;

        public event BFEGetPARAM_Tipo_docCompletedEventHandler BFEGetPARAM_Tipo_docCompletedEvent;

        public event BFEGetPARAM_Tipo_IVACompletedEventHandler BFEGetPARAM_Tipo_IVACompletedEvent;

        public event BFEGetPARAM_UMedCompletedEventHandler BFEGetPARAM_UMedCompletedEvent;

        public event BFEGetPARAM_ZonasCompletedEventHandler BFEGetPARAM_ZonasCompletedEvent;

        public Service()
        {
            this.Url = MySettings.Default.WSAFIPFE_bAFIP_Service;
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

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEAuthorize", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponseAuthorize BFEAuthorize(ClsBFEAuthRequest Auth, ClsBFERequest Cmp)
        {
            return (BFEResponseAuthorize) this.Invoke("BFEAuthorize", new object[] { Auth, Cmp })[0];
        }

        public void BFEAuthorizeAsync(ClsBFEAuthRequest Auth, ClsBFERequest Cmp)
        {
            this.BFEAuthorizeAsync(Auth, Cmp, null);
        }

        public void BFEAuthorizeAsync(ClsBFEAuthRequest Auth, ClsBFERequest Cmp, object userState)
        {
            if (this.BFEAuthorizeOperationCompleted == null)
            {
                this.BFEAuthorizeOperationCompleted = new SendOrPostCallback(this.OnBFEAuthorizeOperationCompleted);
            }
            this.InvokeAsync("BFEAuthorize", new object[] { Auth, Cmp }, this.BFEAuthorizeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEDummy", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public DummyResponse BFEDummy()
        {
            return (DummyResponse) this.Invoke("BFEDummy", new object[0])[0];
        }

        public void BFEDummyAsync()
        {
            this.BFEDummyAsync(null);
        }

        public void BFEDummyAsync(object userState)
        {
            if (this.BFEDummyOperationCompleted == null)
            {
                this.BFEDummyOperationCompleted = new SendOrPostCallback(this.OnBFEDummyOperationCompleted);
            }
            this.InvokeAsync("BFEDummy", new object[0], this.BFEDummyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetCMP", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEGetCMPResponse BFEGetCMP(ClsBFEAuthRequest Auth, ClsBFEGetCMP Cmp)
        {
            return (BFEGetCMPResponse) this.Invoke("BFEGetCMP", new object[] { Auth, Cmp })[0];
        }

        public void BFEGetCMPAsync(ClsBFEAuthRequest Auth, ClsBFEGetCMP Cmp)
        {
            this.BFEGetCMPAsync(Auth, Cmp, null);
        }

        public void BFEGetCMPAsync(ClsBFEAuthRequest Auth, ClsBFEGetCMP Cmp, object userState)
        {
            if (this.BFEGetCMPOperationCompleted == null)
            {
                this.BFEGetCMPOperationCompleted = new SendOrPostCallback(this.OnBFEGetCMPOperationCompleted);
            }
            this.InvokeAsync("BFEGetCMP", new object[] { Auth, Cmp }, this.BFEGetCMPOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetLast_CMP", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponseLast_CMP BFEGetLast_CMP(ClsBFE_LastCMP Auth)
        {
            return (BFEResponseLast_CMP) this.Invoke("BFEGetLast_CMP", new object[] { Auth })[0];
        }

        public void BFEGetLast_CMPAsync(ClsBFE_LastCMP Auth)
        {
            this.BFEGetLast_CMPAsync(Auth, null);
        }

        public void BFEGetLast_CMPAsync(ClsBFE_LastCMP Auth, object userState)
        {
            if (this.BFEGetLast_CMPOperationCompleted == null)
            {
                this.BFEGetLast_CMPOperationCompleted = new SendOrPostCallback(this.OnBFEGetLast_CMPOperationCompleted);
            }
            this.InvokeAsync("BFEGetLast_CMP", new object[] { Auth }, this.BFEGetLast_CMPOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetLast_ID", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_LastID BFEGetLast_ID(ClsBFEAuthRequest Auth)
        {
            return (BFEResponse_LastID) this.Invoke("BFEGetLast_ID", new object[] { Auth })[0];
        }

        public void BFEGetLast_IDAsync(ClsBFEAuthRequest Auth)
        {
            this.BFEGetLast_IDAsync(Auth, null);
        }

        public void BFEGetLast_IDAsync(ClsBFEAuthRequest Auth, object userState)
        {
            if (this.BFEGetLast_IDOperationCompleted == null)
            {
                this.BFEGetLast_IDOperationCompleted = new SendOrPostCallback(this.OnBFEGetLast_IDOperationCompleted);
            }
            this.InvokeAsync("BFEGetLast_ID", new object[] { Auth }, this.BFEGetLast_IDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_MON", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_Mon BFEGetPARAM_MON(ClsBFEAuthRequest auth)
        {
            return (BFEResponse_Mon) this.Invoke("BFEGetPARAM_MON", new object[] { auth })[0];
        }

        public void BFEGetPARAM_MONAsync(ClsBFEAuthRequest auth)
        {
            this.BFEGetPARAM_MONAsync(auth, null);
        }

        public void BFEGetPARAM_MONAsync(ClsBFEAuthRequest auth, object userState)
        {
            if (this.BFEGetPARAM_MONOperationCompleted == null)
            {
                this.BFEGetPARAM_MONOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_MONOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_MON", new object[] { auth }, this.BFEGetPARAM_MONOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_NCM", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_NCM BFEGetPARAM_NCM(ClsBFEAuthRequest Auth)
        {
            return (BFEResponse_NCM) this.Invoke("BFEGetPARAM_NCM", new object[] { Auth })[0];
        }

        public void BFEGetPARAM_NCMAsync(ClsBFEAuthRequest Auth)
        {
            this.BFEGetPARAM_NCMAsync(Auth, null);
        }

        public void BFEGetPARAM_NCMAsync(ClsBFEAuthRequest Auth, object userState)
        {
            if (this.BFEGetPARAM_NCMOperationCompleted == null)
            {
                this.BFEGetPARAM_NCMOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_NCMOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_NCM", new object[] { Auth }, this.BFEGetPARAM_NCMOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_Tipo_Cbte", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_Tipo_Cbte BFEGetPARAM_Tipo_Cbte(ClsBFEAuthRequest auth)
        {
            return (BFEResponse_Tipo_Cbte) this.Invoke("BFEGetPARAM_Tipo_Cbte", new object[] { auth })[0];
        }

        public void BFEGetPARAM_Tipo_CbteAsync(ClsBFEAuthRequest auth)
        {
            this.BFEGetPARAM_Tipo_CbteAsync(auth, null);
        }

        public void BFEGetPARAM_Tipo_CbteAsync(ClsBFEAuthRequest auth, object userState)
        {
            if (this.BFEGetPARAM_Tipo_CbteOperationCompleted == null)
            {
                this.BFEGetPARAM_Tipo_CbteOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_Tipo_CbteOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_Tipo_Cbte", new object[] { auth }, this.BFEGetPARAM_Tipo_CbteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_Tipo_doc", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_Tipo_doc BFEGetPARAM_Tipo_doc(ClsBFEAuthRequest auth)
        {
            return (BFEResponse_Tipo_doc) this.Invoke("BFEGetPARAM_Tipo_doc", new object[] { auth })[0];
        }

        public void BFEGetPARAM_Tipo_docAsync(ClsBFEAuthRequest auth)
        {
            this.BFEGetPARAM_Tipo_docAsync(auth, null);
        }

        public void BFEGetPARAM_Tipo_docAsync(ClsBFEAuthRequest auth, object userState)
        {
            if (this.BFEGetPARAM_Tipo_docOperationCompleted == null)
            {
                this.BFEGetPARAM_Tipo_docOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_Tipo_docOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_Tipo_doc", new object[] { auth }, this.BFEGetPARAM_Tipo_docOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_Tipo_IVA", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_Tipo_IVA BFEGetPARAM_Tipo_IVA(ClsBFEAuthRequest auth)
        {
            return (BFEResponse_Tipo_IVA) this.Invoke("BFEGetPARAM_Tipo_IVA", new object[] { auth })[0];
        }

        public void BFEGetPARAM_Tipo_IVAAsync(ClsBFEAuthRequest auth)
        {
            this.BFEGetPARAM_Tipo_IVAAsync(auth, null);
        }

        public void BFEGetPARAM_Tipo_IVAAsync(ClsBFEAuthRequest auth, object userState)
        {
            if (this.BFEGetPARAM_Tipo_IVAOperationCompleted == null)
            {
                this.BFEGetPARAM_Tipo_IVAOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_Tipo_IVAOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_Tipo_IVA", new object[] { auth }, this.BFEGetPARAM_Tipo_IVAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_UMed", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_Umed BFEGetPARAM_UMed(ClsBFEAuthRequest auth)
        {
            return (BFEResponse_Umed) this.Invoke("BFEGetPARAM_UMed", new object[] { auth })[0];
        }

        public void BFEGetPARAM_UMedAsync(ClsBFEAuthRequest auth)
        {
            this.BFEGetPARAM_UMedAsync(auth, null);
        }

        public void BFEGetPARAM_UMedAsync(ClsBFEAuthRequest auth, object userState)
        {
            if (this.BFEGetPARAM_UMedOperationCompleted == null)
            {
                this.BFEGetPARAM_UMedOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_UMedOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_UMed", new object[] { auth }, this.BFEGetPARAM_UMedOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.bfe/BFEGetPARAM_Zonas", RequestNamespace="http://ar.gov.afip.dif.bfe/", ResponseNamespace="http://ar.gov.afip.dif.bfe/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public BFEResponse_Zon BFEGetPARAM_Zonas(ClsBFEAuthRequest auth)
        {
            return (BFEResponse_Zon) this.Invoke("BFEGetPARAM_Zonas", new object[] { auth })[0];
        }

        public void BFEGetPARAM_ZonasAsync(ClsBFEAuthRequest auth)
        {
            this.BFEGetPARAM_ZonasAsync(auth, null);
        }

        public void BFEGetPARAM_ZonasAsync(ClsBFEAuthRequest auth, object userState)
        {
            if (this.BFEGetPARAM_ZonasOperationCompleted == null)
            {
                this.BFEGetPARAM_ZonasOperationCompleted = new SendOrPostCallback(this.OnBFEGetPARAM_ZonasOperationCompleted);
            }
            this.InvokeAsync("BFEGetPARAM_Zonas", new object[] { auth }, this.BFEGetPARAM_ZonasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

        private void OnBFEAuthorizeOperationCompleted(object arg)
        {
            if (this.BFEAuthorizeCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEAuthorizeCompletedEventHandler VB_t_ref_S0 = this.BFEAuthorizeCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEAuthorizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEDummyOperationCompleted(object arg)
        {
            if (this.BFEDummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEDummyCompletedEventHandler VB_t_ref_S0 = this.BFEDummyCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEDummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetCMPOperationCompleted(object arg)
        {
            if (this.BFEGetCMPCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetCMPCompletedEventHandler VB_t_ref_S0 = this.BFEGetCMPCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetCMPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetLast_CMPOperationCompleted(object arg)
        {
            if (this.BFEGetLast_CMPCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetLast_CMPCompletedEventHandler VB_t_ref_S0 = this.BFEGetLast_CMPCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetLast_CMPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetLast_IDOperationCompleted(object arg)
        {
            if (this.BFEGetLast_IDCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetLast_IDCompletedEventHandler VB_t_ref_S0 = this.BFEGetLast_IDCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetLast_IDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_MONOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_MONCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_MONCompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_MONCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_MONCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_NCMOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_NCMCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_NCMCompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_NCMCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_NCMCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_Tipo_CbteOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_Tipo_CbteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_Tipo_CbteCompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_Tipo_CbteCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_Tipo_CbteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_Tipo_docOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_Tipo_docCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_Tipo_docCompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_Tipo_docCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_Tipo_docCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_Tipo_IVAOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_Tipo_IVACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_Tipo_IVACompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_Tipo_IVACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_Tipo_IVACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_UMedOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_UMedCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_UMedCompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_UMedCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_UMedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnBFEGetPARAM_ZonasOperationCompleted(object arg)
        {
            if (this.BFEGetPARAM_ZonasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                BFEGetPARAM_ZonasCompletedEventHandler VB_t_ref_S0 = this.BFEGetPARAM_ZonasCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new BFEGetPARAM_ZonasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
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

