namespace WSAFIPFE.xAFIP
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

    [WebServiceBinding(Name="ServiceSoap", Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class Service : SoapHttpClientProtocol
    {
        private SendOrPostCallback FEXAuthorizeOperationCompleted;
        private SendOrPostCallback FEXCheck_PermisoOperationCompleted ;
        private SendOrPostCallback FEXDummyOperationCompleted ;
        private SendOrPostCallback FEXGetCMPOperationCompleted ;
        private SendOrPostCallback FEXGetLast_CMPOperationCompleted ;
        private SendOrPostCallback FEXGetLast_IDOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_CtzOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_DST_CUITOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_DST_paisOperationCompleted;
        private SendOrPostCallback FEXGetPARAM_IdiomasOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_IncotermsOperationCompleted;
        private SendOrPostCallback FEXGetPARAM_MONOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_PtoVentaOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_Tipo_CbteOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_Tipo_ExpoOperationCompleted ;
        private SendOrPostCallback FEXGetPARAM_UMedOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event FEXAuthorizeCompletedEventHandler FEXAuthorizeCompletedEvent;

        public event FEXCheck_PermisoCompletedEventHandler FEXCheck_PermisoCompletedEvent;

        public event FEXDummyCompletedEventHandler FEXDummyCompletedEvent;

        public event FEXGetCMPCompletedEventHandler FEXGetCMPCompletedEvent;

        public event FEXGetLast_CMPCompletedEventHandler FEXGetLast_CMPCompletedEvent;

        public event FEXGetLast_IDCompletedEventHandler FEXGetLast_IDCompletedEvent;

        public event FEXGetPARAM_CtzCompletedEventHandler FEXGetPARAM_CtzCompletedEvent;

        public event FEXGetPARAM_DST_CUITCompletedEventHandler FEXGetPARAM_DST_CUITCompletedEvent;

        public event FEXGetPARAM_DST_paisCompletedEventHandler FEXGetPARAM_DST_paisCompletedEvent;

        public event FEXGetPARAM_IdiomasCompletedEventHandler FEXGetPARAM_IdiomasCompletedEvent;

        public event FEXGetPARAM_IncotermsCompletedEventHandler FEXGetPARAM_IncotermsCompletedEvent;

        public event FEXGetPARAM_MONCompletedEventHandler FEXGetPARAM_MONCompletedEvent;

        public event FEXGetPARAM_PtoVentaCompletedEventHandler FEXGetPARAM_PtoVentaCompletedEvent;

        public event FEXGetPARAM_Tipo_CbteCompletedEventHandler FEXGetPARAM_Tipo_CbteCompletedEvent;

        public event FEXGetPARAM_Tipo_ExpoCompletedEventHandler FEXGetPARAM_Tipo_ExpoCompletedEvent;

        public event FEXGetPARAM_UMedCompletedEventHandler FEXGetPARAM_UMedCompletedEvent;

        public Service()
        {
            this.Url = MySettings.Default.WSAFIPFE_xAFIP_Service;
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

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXAuthorize", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponseAuthorize FEXAuthorize(ClsFEXAuthRequest Auth, ClsFEXRequest Cmp)
        {
            return (FEXResponseAuthorize) this.Invoke("FEXAuthorize", new object[] { Auth, Cmp })[0];
        }

        public void FEXAuthorizeAsync(ClsFEXAuthRequest Auth, ClsFEXRequest Cmp)
        {
            this.FEXAuthorizeAsync(Auth, Cmp, null);
        }

        public void FEXAuthorizeAsync(ClsFEXAuthRequest Auth, ClsFEXRequest Cmp, object userState)
        {
            if (this.FEXAuthorizeOperationCompleted == null)
            {
                this.FEXAuthorizeOperationCompleted = new SendOrPostCallback(this.OnFEXAuthorizeOperationCompleted);
            }
            this.InvokeAsync("FEXAuthorize", new object[] { Auth, Cmp }, this.FEXAuthorizeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXCheck_Permiso", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_CheckPermiso FEXCheck_Permiso(ClsFEXAuthRequest Auth, string ID_Permiso, int Dst_merc)
        {
            return (FEXResponse_CheckPermiso) this.Invoke("FEXCheck_Permiso", new object[] { Auth, ID_Permiso, Dst_merc })[0];
        }

        public void FEXCheck_PermisoAsync(ClsFEXAuthRequest Auth, string ID_Permiso, int Dst_merc)
        {
            this.FEXCheck_PermisoAsync(Auth, ID_Permiso, Dst_merc, null);
        }

        public void FEXCheck_PermisoAsync(ClsFEXAuthRequest Auth, string ID_Permiso, int Dst_merc, object userState)
        {
            if (this.FEXCheck_PermisoOperationCompleted == null)
            {
                this.FEXCheck_PermisoOperationCompleted = new SendOrPostCallback(this.OnFEXCheck_PermisoOperationCompleted);
            }
            this.InvokeAsync("FEXCheck_Permiso", new object[] { Auth, ID_Permiso, Dst_merc }, this.FEXCheck_PermisoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXDummy", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public DummyResponse FEXDummy()
        {
            return (DummyResponse) this.Invoke("FEXDummy", new object[0])[0];
        }

        public void FEXDummyAsync()
        {
            this.FEXDummyAsync(null);
        }

        public void FEXDummyAsync(object userState)
        {
            if (this.FEXDummyOperationCompleted == null)
            {
                this.FEXDummyOperationCompleted = new SendOrPostCallback(this.OnFEXDummyOperationCompleted);
            }
            this.InvokeAsync("FEXDummy", new object[0], this.FEXDummyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetCMP", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXGetCMPResponse FEXGetCMP(ClsFEXAuthRequest Auth, ClsFEXGetCMP Cmp)
        {
            return (FEXGetCMPResponse) this.Invoke("FEXGetCMP", new object[] { Auth, Cmp })[0];
        }

        public void FEXGetCMPAsync(ClsFEXAuthRequest Auth, ClsFEXGetCMP Cmp)
        {
            this.FEXGetCMPAsync(Auth, Cmp, null);
        }

        public void FEXGetCMPAsync(ClsFEXAuthRequest Auth, ClsFEXGetCMP Cmp, object userState)
        {
            if (this.FEXGetCMPOperationCompleted == null)
            {
                this.FEXGetCMPOperationCompleted = new SendOrPostCallback(this.OnFEXGetCMPOperationCompleted);
            }
            this.InvokeAsync("FEXGetCMP", new object[] { Auth, Cmp }, this.FEXGetCMPOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetLast_CMP", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponseLast_CMP FEXGetLast_CMP(ClsFEX_LastCMP Auth)
        {
            return (FEXResponseLast_CMP) this.Invoke("FEXGetLast_CMP", new object[] { Auth })[0];
        }

        public void FEXGetLast_CMPAsync(ClsFEX_LastCMP Auth)
        {
            this.FEXGetLast_CMPAsync(Auth, null);
        }

        public void FEXGetLast_CMPAsync(ClsFEX_LastCMP Auth, object userState)
        {
            if (this.FEXGetLast_CMPOperationCompleted == null)
            {
                this.FEXGetLast_CMPOperationCompleted = new SendOrPostCallback(this.OnFEXGetLast_CMPOperationCompleted);
            }
            this.InvokeAsync("FEXGetLast_CMP", new object[] { Auth }, this.FEXGetLast_CMPOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetLast_ID", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_LastID FEXGetLast_ID(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_LastID) this.Invoke("FEXGetLast_ID", new object[] { Auth })[0];
        }

        public void FEXGetLast_IDAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetLast_IDAsync(Auth, null);
        }

        public void FEXGetLast_IDAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetLast_IDOperationCompleted == null)
            {
                this.FEXGetLast_IDOperationCompleted = new SendOrPostCallback(this.OnFEXGetLast_IDOperationCompleted);
            }
            this.InvokeAsync("FEXGetLast_ID", new object[] { Auth }, this.FEXGetLast_IDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_Ctz", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Ctz FEXGetPARAM_Ctz(ClsFEXAuthRequest Auth, string Mon_id)
        {
            return (FEXResponse_Ctz) this.Invoke("FEXGetPARAM_Ctz", new object[] { Auth, Mon_id })[0];
        }

        public void FEXGetPARAM_CtzAsync(ClsFEXAuthRequest Auth, string Mon_id)
        {
            this.FEXGetPARAM_CtzAsync(Auth, Mon_id, null);
        }

        public void FEXGetPARAM_CtzAsync(ClsFEXAuthRequest Auth, string Mon_id, object userState)
        {
            if (this.FEXGetPARAM_CtzOperationCompleted == null)
            {
                this.FEXGetPARAM_CtzOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_CtzOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_Ctz", new object[] { Auth, Mon_id }, this.FEXGetPARAM_CtzOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_DST_CUIT", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_DST_cuit FEXGetPARAM_DST_CUIT(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_DST_cuit) this.Invoke("FEXGetPARAM_DST_CUIT", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_DST_CUITAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_DST_CUITAsync(Auth, null);
        }

        public void FEXGetPARAM_DST_CUITAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_DST_CUITOperationCompleted == null)
            {
                this.FEXGetPARAM_DST_CUITOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_DST_CUITOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_DST_CUIT", new object[] { Auth }, this.FEXGetPARAM_DST_CUITOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_DST_pais", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_DST_pais FEXGetPARAM_DST_pais(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_DST_pais) this.Invoke("FEXGetPARAM_DST_pais", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_DST_paisAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_DST_paisAsync(Auth, null);
        }

        public void FEXGetPARAM_DST_paisAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_DST_paisOperationCompleted == null)
            {
                this.FEXGetPARAM_DST_paisOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_DST_paisOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_DST_pais", new object[] { Auth }, this.FEXGetPARAM_DST_paisOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_Idiomas", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Idi FEXGetPARAM_Idiomas(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_Idi) this.Invoke("FEXGetPARAM_Idiomas", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_IdiomasAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_IdiomasAsync(Auth, null);
        }

        public void FEXGetPARAM_IdiomasAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_IdiomasOperationCompleted == null)
            {
                this.FEXGetPARAM_IdiomasOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_IdiomasOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_Idiomas", new object[] { Auth }, this.FEXGetPARAM_IdiomasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_Incoterms", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Inc FEXGetPARAM_Incoterms(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_Inc) this.Invoke("FEXGetPARAM_Incoterms", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_IncotermsAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_IncotermsAsync(Auth, null);
        }

        public void FEXGetPARAM_IncotermsAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_IncotermsOperationCompleted == null)
            {
                this.FEXGetPARAM_IncotermsOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_IncotermsOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_Incoterms", new object[] { Auth }, this.FEXGetPARAM_IncotermsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_MON", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Mon FEXGetPARAM_MON(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_Mon) this.Invoke("FEXGetPARAM_MON", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_MONAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_MONAsync(Auth, null);
        }

        public void FEXGetPARAM_MONAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_MONOperationCompleted == null)
            {
                this.FEXGetPARAM_MONOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_MONOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_MON", new object[] { Auth }, this.FEXGetPARAM_MONOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_PtoVenta", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_PtoVenta FEXGetPARAM_PtoVenta(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_PtoVenta) this.Invoke("FEXGetPARAM_PtoVenta", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_PtoVentaAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_PtoVentaAsync(Auth, null);
        }

        public void FEXGetPARAM_PtoVentaAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_PtoVentaOperationCompleted == null)
            {
                this.FEXGetPARAM_PtoVentaOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_PtoVentaOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_PtoVenta", new object[] { Auth }, this.FEXGetPARAM_PtoVentaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_Tipo_Cbte", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Tipo_Cbte FEXGetPARAM_Tipo_Cbte(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_Tipo_Cbte) this.Invoke("FEXGetPARAM_Tipo_Cbte", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_Tipo_CbteAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_Tipo_CbteAsync(Auth, null);
        }

        public void FEXGetPARAM_Tipo_CbteAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_Tipo_CbteOperationCompleted == null)
            {
                this.FEXGetPARAM_Tipo_CbteOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_Tipo_CbteOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_Tipo_Cbte", new object[] { Auth }, this.FEXGetPARAM_Tipo_CbteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_Tipo_Expo", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Tex FEXGetPARAM_Tipo_Expo(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_Tex) this.Invoke("FEXGetPARAM_Tipo_Expo", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_Tipo_ExpoAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_Tipo_ExpoAsync(Auth, null);
        }

        public void FEXGetPARAM_Tipo_ExpoAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_Tipo_ExpoOperationCompleted == null)
            {
                this.FEXGetPARAM_Tipo_ExpoOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_Tipo_ExpoOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_Tipo_Expo", new object[] { Auth }, this.FEXGetPARAM_Tipo_ExpoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.fex/FEXGetPARAM_UMed", RequestNamespace="http://ar.gov.afip.dif.fex/", ResponseNamespace="http://ar.gov.afip.dif.fex/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEXResponse_Umed FEXGetPARAM_UMed(ClsFEXAuthRequest Auth)
        {
            return (FEXResponse_Umed) this.Invoke("FEXGetPARAM_UMed", new object[] { Auth })[0];
        }

        public void FEXGetPARAM_UMedAsync(ClsFEXAuthRequest Auth)
        {
            this.FEXGetPARAM_UMedAsync(Auth, null);
        }

        public void FEXGetPARAM_UMedAsync(ClsFEXAuthRequest Auth, object userState)
        {
            if (this.FEXGetPARAM_UMedOperationCompleted == null)
            {
                this.FEXGetPARAM_UMedOperationCompleted = new SendOrPostCallback(this.OnFEXGetPARAM_UMedOperationCompleted);
            }
            this.InvokeAsync("FEXGetPARAM_UMed", new object[] { Auth }, this.FEXGetPARAM_UMedOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

        private void OnFEXAuthorizeOperationCompleted(object arg)
        {
            if (this.FEXAuthorizeCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXAuthorizeCompletedEventHandler VB_t_ref_S0 = this.FEXAuthorizeCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXAuthorizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXCheck_PermisoOperationCompleted(object arg)
        {
            if (this.FEXCheck_PermisoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXCheck_PermisoCompletedEventHandler VB_t_ref_S0 = this.FEXCheck_PermisoCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXCheck_PermisoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXDummyOperationCompleted(object arg)
        {
            if (this.FEXDummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXDummyCompletedEventHandler VB_t_ref_S0 = this.FEXDummyCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXDummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetCMPOperationCompleted(object arg)
        {
            if (this.FEXGetCMPCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetCMPCompletedEventHandler VB_t_ref_S0 = this.FEXGetCMPCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetCMPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetLast_CMPOperationCompleted(object arg)
        {
            if (this.FEXGetLast_CMPCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetLast_CMPCompletedEventHandler VB_t_ref_S0 = this.FEXGetLast_CMPCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetLast_CMPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetLast_IDOperationCompleted(object arg)
        {
            if (this.FEXGetLast_IDCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetLast_IDCompletedEventHandler VB_t_ref_S0 = this.FEXGetLast_IDCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetLast_IDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_CtzOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_CtzCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_CtzCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_CtzCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_CtzCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_DST_CUITOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_DST_CUITCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_DST_CUITCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_DST_CUITCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_DST_CUITCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_DST_paisOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_DST_paisCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_DST_paisCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_DST_paisCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_DST_paisCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_IdiomasOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_IdiomasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_IdiomasCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_IdiomasCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_IdiomasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_IncotermsOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_IncotermsCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_IncotermsCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_IncotermsCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_IncotermsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_MONOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_MONCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_MONCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_MONCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_MONCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_PtoVentaOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_PtoVentaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_PtoVentaCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_PtoVentaCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_PtoVentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_Tipo_CbteOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_Tipo_CbteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_Tipo_CbteCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_Tipo_CbteCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_Tipo_CbteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_Tipo_ExpoOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_Tipo_ExpoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_Tipo_ExpoCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_Tipo_ExpoCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_Tipo_ExpoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEXGetPARAM_UMedOperationCompleted(object arg)
        {
            if (this.FEXGetPARAM_UMedCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEXGetPARAM_UMedCompletedEventHandler VB_t_ref_S0 = this.FEXGetPARAM_UMedCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new FEXGetPARAM_UMedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
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

