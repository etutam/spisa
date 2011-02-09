namespace WSAFIPFE.f1AFIP
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

    [XmlInclude(typeof(FEDetResponse)), XmlInclude(typeof(FECabRequest)), XmlInclude(typeof(FEDetRequest)), XmlInclude(typeof(FECabResponse)), DebuggerStepThrough, WebServiceBinding(Name="ServiceSoap", Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class Service : SoapHttpClientProtocol
    {
        private SendOrPostCallback FECAEAConsultarOperationCompleted;
        private SendOrPostCallback FECAEARegInformativoOperationCompleted;
        private SendOrPostCallback FECAEASinMovimientoConsultarOperationCompleted;
        private SendOrPostCallback FECAEASinMovimientoInformarOperationCompleted;
        private SendOrPostCallback FECAEASolicitarOperationCompleted;
        private SendOrPostCallback FECAESolicitarOperationCompleted;
        private SendOrPostCallback FECompConsultarOperationCompleted;
        private SendOrPostCallback FECompTotXRequestOperationCompleted;
        private SendOrPostCallback FECompUltimoAutorizadoOperationCompleted;
        private SendOrPostCallback FEDummyOperationCompleted;
        private SendOrPostCallback FEParamGetCotizacionOperationCompleted;
        private SendOrPostCallback FEParamGetPtosVentaOperationCompleted;
        private SendOrPostCallback FEParamGetTiposCbteOperationCompleted;
        private SendOrPostCallback FEParamGetTiposConceptoOperationCompleted;
        private SendOrPostCallback FEParamGetTiposDocOperationCompleted;
        private SendOrPostCallback FEParamGetTiposIvaOperationCompleted;
        private SendOrPostCallback FEParamGetTiposMonedasOperationCompleted;
        private SendOrPostCallback FEParamGetTiposOpcionalOperationCompleted;
        private SendOrPostCallback FEParamGetTiposTributosOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event FECAEAConsultarCompletedEventHandler FECAEAConsultarCompleted;

        public event FECAEARegInformativoCompletedEventHandler FECAEARegInformativoCompleted;

        public event FECAEASinMovimientoConsultarCompletedEventHandler FECAEASinMovimientoConsultarCompleted;

        public event FECAEASinMovimientoInformarCompletedEventHandler FECAEASinMovimientoInformarCompleted;

        public event FECAEASolicitarCompletedEventHandler FECAEASolicitarCompleted;

        public event FECAESolicitarCompletedEventHandler FECAESolicitarCompleted;

        public event FECompConsultarCompletedEventHandler FECompConsultarCompleted;

        public event FECompTotXRequestCompletedEventHandler FECompTotXRequestCompleted;

        public event FECompUltimoAutorizadoCompletedEventHandler FECompUltimoAutorizadoCompleted;

        public event FEDummyCompletedEventHandler FEDummyCompleted;

        public event FEParamGetCotizacionCompletedEventHandler FEParamGetCotizacionCompleted;

        public event FEParamGetPtosVentaCompletedEventHandler FEParamGetPtosVentaCompleted;

        public event FEParamGetTiposCbteCompletedEventHandler FEParamGetTiposCbteCompleted;

        public event FEParamGetTiposConceptoCompletedEventHandler FEParamGetTiposConceptoCompleted;

        public event FEParamGetTiposDocCompletedEventHandler FEParamGetTiposDocCompleted;

        public event FEParamGetTiposIvaCompletedEventHandler FEParamGetTiposIvaCompleted;

        public event FEParamGetTiposMonedasCompletedEventHandler FEParamGetTiposMonedasCompleted;

        public event FEParamGetTiposOpcionalCompletedEventHandler FEParamGetTiposOpcionalCompleted;

        public event FEParamGetTiposTributosCompletedEventHandler FEParamGetTiposTributosCompleted;

        public Service()
        {
            this.Url = MySettings.Default.WSAFIPFE_f1AFIP_Service;
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

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECAEAConsultar", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECAEAGetResponse FECAEAConsultar(FEAuthRequest Auth, int Periodo, short Orden)
        {
            return (FECAEAGetResponse) this.Invoke("FECAEAConsultar", new object[] { Auth, Periodo, Orden })[0];
        }

        public void FECAEAConsultarAsync(FEAuthRequest Auth, int Periodo, short Orden)
        {
            this.FECAEAConsultarAsync(Auth, Periodo, Orden, null);
        }

        public void FECAEAConsultarAsync(FEAuthRequest Auth, int Periodo, short Orden, object userState)
        {
            if (this.FECAEAConsultarOperationCompleted == null)
            {
                this.FECAEAConsultarOperationCompleted = new SendOrPostCallback(this.OnFECAEAConsultarOperationCompleted);
            }
            this.InvokeAsync("FECAEAConsultar", new object[] { Auth, Periodo, Orden }, this.FECAEAConsultarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECAEARegInformativo", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECAEAResponse FECAEARegInformativo(FEAuthRequest Auth, FECAEARequest FeCAEARegInfReq)
        {
            return (FECAEAResponse) this.Invoke("FECAEARegInformativo", new object[] { Auth, FeCAEARegInfReq })[0];
        }

        public void FECAEARegInformativoAsync(FEAuthRequest Auth, FECAEARequest FeCAEARegInfReq)
        {
            this.FECAEARegInformativoAsync(Auth, FeCAEARegInfReq, null);
        }

        public void FECAEARegInformativoAsync(FEAuthRequest Auth, FECAEARequest FeCAEARegInfReq, object userState)
        {
            if (this.FECAEARegInformativoOperationCompleted == null)
            {
                this.FECAEARegInformativoOperationCompleted = new SendOrPostCallback(this.OnFECAEARegInformativoOperationCompleted);
            }
            this.InvokeAsync("FECAEARegInformativo", new object[] { Auth, FeCAEARegInfReq }, this.FECAEARegInformativoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECAEASinMovimientoConsultar", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECAEASinMovConsResponse FECAEASinMovimientoConsultar(FEAuthRequest Auth, string CAEA, int PtoVta)
        {
            return (FECAEASinMovConsResponse) this.Invoke("FECAEASinMovimientoConsultar", new object[] { Auth, CAEA, PtoVta })[0];
        }

        public void FECAEASinMovimientoConsultarAsync(FEAuthRequest Auth, string CAEA, int PtoVta)
        {
            this.FECAEASinMovimientoConsultarAsync(Auth, CAEA, PtoVta, null);
        }

        public void FECAEASinMovimientoConsultarAsync(FEAuthRequest Auth, string CAEA, int PtoVta, object userState)
        {
            if (this.FECAEASinMovimientoConsultarOperationCompleted == null)
            {
                this.FECAEASinMovimientoConsultarOperationCompleted = new SendOrPostCallback(this.OnFECAEASinMovimientoConsultarOperationCompleted);
            }
            this.InvokeAsync("FECAEASinMovimientoConsultar", new object[] { Auth, CAEA, PtoVta }, this.FECAEASinMovimientoConsultarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECAEASinMovimientoInformar", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECAEASinMovResponse FECAEASinMovimientoInformar(FEAuthRequest Auth, int PtoVta, string CAEA)
        {
            return (FECAEASinMovResponse) this.Invoke("FECAEASinMovimientoInformar", new object[] { Auth, PtoVta, CAEA })[0];
        }

        public void FECAEASinMovimientoInformarAsync(FEAuthRequest Auth, int PtoVta, string CAEA)
        {
            this.FECAEASinMovimientoInformarAsync(Auth, PtoVta, CAEA, null);
        }

        public void FECAEASinMovimientoInformarAsync(FEAuthRequest Auth, int PtoVta, string CAEA, object userState)
        {
            if (this.FECAEASinMovimientoInformarOperationCompleted == null)
            {
                this.FECAEASinMovimientoInformarOperationCompleted = new SendOrPostCallback(this.OnFECAEASinMovimientoInformarOperationCompleted);
            }
            this.InvokeAsync("FECAEASinMovimientoInformar", new object[] { Auth, PtoVta, CAEA }, this.FECAEASinMovimientoInformarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECAEASolicitar", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECAEAGetResponse FECAEASolicitar(FEAuthRequest Auth, int Periodo, short Orden)
        {
            return (FECAEAGetResponse) this.Invoke("FECAEASolicitar", new object[] { Auth, Periodo, Orden })[0];
        }

        public void FECAEASolicitarAsync(FEAuthRequest Auth, int Periodo, short Orden)
        {
            this.FECAEASolicitarAsync(Auth, Periodo, Orden, null);
        }

        public void FECAEASolicitarAsync(FEAuthRequest Auth, int Periodo, short Orden, object userState)
        {
            if (this.FECAEASolicitarOperationCompleted == null)
            {
                this.FECAEASolicitarOperationCompleted = new SendOrPostCallback(this.OnFECAEASolicitarOperationCompleted);
            }
            this.InvokeAsync("FECAEASolicitar", new object[] { Auth, Periodo, Orden }, this.FECAEASolicitarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECAESolicitar", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECAEResponse FECAESolicitar(FEAuthRequest Auth, FECAERequest FeCAEReq)
        {
            return (FECAEResponse) this.Invoke("FECAESolicitar", new object[] { Auth, FeCAEReq })[0];
        }

        public void FECAESolicitarAsync(FEAuthRequest Auth, FECAERequest FeCAEReq)
        {
            this.FECAESolicitarAsync(Auth, FeCAEReq, null);
        }

        public void FECAESolicitarAsync(FEAuthRequest Auth, FECAERequest FeCAEReq, object userState)
        {
            if (this.FECAESolicitarOperationCompleted == null)
            {
                this.FECAESolicitarOperationCompleted = new SendOrPostCallback(this.OnFECAESolicitarOperationCompleted);
            }
            this.InvokeAsync("FECAESolicitar", new object[] { Auth, FeCAEReq }, this.FECAESolicitarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECompConsultar", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECompConsultaResponse FECompConsultar(FEAuthRequest Auth, FECompConsultaReq FeCompConsReq)
        {
            return (FECompConsultaResponse) this.Invoke("FECompConsultar", new object[] { Auth, FeCompConsReq })[0];
        }

        public void FECompConsultarAsync(FEAuthRequest Auth, FECompConsultaReq FeCompConsReq)
        {
            this.FECompConsultarAsync(Auth, FeCompConsReq, null);
        }

        public void FECompConsultarAsync(FEAuthRequest Auth, FECompConsultaReq FeCompConsReq, object userState)
        {
            if (this.FECompConsultarOperationCompleted == null)
            {
                this.FECompConsultarOperationCompleted = new SendOrPostCallback(this.OnFECompConsultarOperationCompleted);
            }
            this.InvokeAsync("FECompConsultar", new object[] { Auth, FeCompConsReq }, this.FECompConsultarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECompTotXRequest", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FERegXReqResponse FECompTotXRequest(FEAuthRequest Auth)
        {
            return (FERegXReqResponse) this.Invoke("FECompTotXRequest", new object[] { Auth })[0];
        }

        public void FECompTotXRequestAsync(FEAuthRequest Auth)
        {
            this.FECompTotXRequestAsync(Auth, null);
        }

        public void FECompTotXRequestAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FECompTotXRequestOperationCompleted == null)
            {
                this.FECompTotXRequestOperationCompleted = new SendOrPostCallback(this.OnFECompTotXRequestOperationCompleted);
            }
            this.InvokeAsync("FECompTotXRequest", new object[] { Auth }, this.FECompTotXRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FECompUltimoAutorizado", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FERecuperaLastCbteResponse FECompUltimoAutorizado(FEAuthRequest Auth, int PtoVta, int CbteTipo)
        {
            return (FERecuperaLastCbteResponse) this.Invoke("FECompUltimoAutorizado", new object[] { Auth, PtoVta, CbteTipo })[0];
        }

        public void FECompUltimoAutorizadoAsync(FEAuthRequest Auth, int PtoVta, int CbteTipo)
        {
            this.FECompUltimoAutorizadoAsync(Auth, PtoVta, CbteTipo, null);
        }

        public void FECompUltimoAutorizadoAsync(FEAuthRequest Auth, int PtoVta, int CbteTipo, object userState)
        {
            if (this.FECompUltimoAutorizadoOperationCompleted == null)
            {
                this.FECompUltimoAutorizadoOperationCompleted = new SendOrPostCallback(this.OnFECompUltimoAutorizadoOperationCompleted);
            }
            this.InvokeAsync("FECompUltimoAutorizado", new object[] { Auth, PtoVta, CbteTipo }, this.FECompUltimoAutorizadoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEDummy", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
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

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetCotizacion", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FECotizacionResponse FEParamGetCotizacion(FEAuthRequest Auth, string MonId)
        {
            return (FECotizacionResponse) this.Invoke("FEParamGetCotizacion", new object[] { Auth, MonId })[0];
        }

        public void FEParamGetCotizacionAsync(FEAuthRequest Auth, string MonId)
        {
            this.FEParamGetCotizacionAsync(Auth, MonId, null);
        }

        public void FEParamGetCotizacionAsync(FEAuthRequest Auth, string MonId, object userState)
        {
            if (this.FEParamGetCotizacionOperationCompleted == null)
            {
                this.FEParamGetCotizacionOperationCompleted = new SendOrPostCallback(this.OnFEParamGetCotizacionOperationCompleted);
            }
            this.InvokeAsync("FEParamGetCotizacion", new object[] { Auth, MonId }, this.FEParamGetCotizacionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetPtosVenta", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FEPtoVentaResponse FEParamGetPtosVenta(FEAuthRequest Auth)
        {
            return (FEPtoVentaResponse) this.Invoke("FEParamGetPtosVenta", new object[] { Auth })[0];
        }

        public void FEParamGetPtosVentaAsync(FEAuthRequest Auth)
        {
            this.FEParamGetPtosVentaAsync(Auth, null);
        }

        public void FEParamGetPtosVentaAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetPtosVentaOperationCompleted == null)
            {
                this.FEParamGetPtosVentaOperationCompleted = new SendOrPostCallback(this.OnFEParamGetPtosVentaOperationCompleted);
            }
            this.InvokeAsync("FEParamGetPtosVenta", new object[] { Auth }, this.FEParamGetPtosVentaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposCbte", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CbteTipoResponse FEParamGetTiposCbte(FEAuthRequest Auth)
        {
            return (CbteTipoResponse) this.Invoke("FEParamGetTiposCbte", new object[] { Auth })[0];
        }

        public void FEParamGetTiposCbteAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposCbteAsync(Auth, null);
        }

        public void FEParamGetTiposCbteAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposCbteOperationCompleted == null)
            {
                this.FEParamGetTiposCbteOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposCbteOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposCbte", new object[] { Auth }, this.FEParamGetTiposCbteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposConcepto", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ConceptoTipoResponse FEParamGetTiposConcepto(FEAuthRequest Auth)
        {
            return (ConceptoTipoResponse) this.Invoke("FEParamGetTiposConcepto", new object[] { Auth })[0];
        }

        public void FEParamGetTiposConceptoAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposConceptoAsync(Auth, null);
        }

        public void FEParamGetTiposConceptoAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposConceptoOperationCompleted == null)
            {
                this.FEParamGetTiposConceptoOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposConceptoOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposConcepto", new object[] { Auth }, this.FEParamGetTiposConceptoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposDoc", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public DocTipoResponse FEParamGetTiposDoc(FEAuthRequest Auth)
        {
            return (DocTipoResponse) this.Invoke("FEParamGetTiposDoc", new object[] { Auth })[0];
        }

        public void FEParamGetTiposDocAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposDocAsync(Auth, null);
        }

        public void FEParamGetTiposDocAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposDocOperationCompleted == null)
            {
                this.FEParamGetTiposDocOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposDocOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposDoc", new object[] { Auth }, this.FEParamGetTiposDocOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposIva", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public IvaTipoResponse FEParamGetTiposIva(FEAuthRequest Auth)
        {
            return (IvaTipoResponse) this.Invoke("FEParamGetTiposIva", new object[] { Auth })[0];
        }

        public void FEParamGetTiposIvaAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposIvaAsync(Auth, null);
        }

        public void FEParamGetTiposIvaAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposIvaOperationCompleted == null)
            {
                this.FEParamGetTiposIvaOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposIvaOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposIva", new object[] { Auth }, this.FEParamGetTiposIvaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposMonedas", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public MonedaResponse FEParamGetTiposMonedas(FEAuthRequest Auth)
        {
            return (MonedaResponse) this.Invoke("FEParamGetTiposMonedas", new object[] { Auth })[0];
        }

        public void FEParamGetTiposMonedasAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposMonedasAsync(Auth, null);
        }

        public void FEParamGetTiposMonedasAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposMonedasOperationCompleted == null)
            {
                this.FEParamGetTiposMonedasOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposMonedasOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposMonedas", new object[] { Auth }, this.FEParamGetTiposMonedasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposOpcional", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public OpcionalTipoResponse FEParamGetTiposOpcional(FEAuthRequest Auth)
        {
            return (OpcionalTipoResponse) this.Invoke("FEParamGetTiposOpcional", new object[] { Auth })[0];
        }

        public void FEParamGetTiposOpcionalAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposOpcionalAsync(Auth, null);
        }

        public void FEParamGetTiposOpcionalAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposOpcionalOperationCompleted == null)
            {
                this.FEParamGetTiposOpcionalOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposOpcionalOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposOpcional", new object[] { Auth }, this.FEParamGetTiposOpcionalOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://ar.gov.afip.dif.FEV1/FEParamGetTiposTributos", RequestNamespace="http://ar.gov.afip.dif.FEV1/", ResponseNamespace="http://ar.gov.afip.dif.FEV1/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public FETributoResponse FEParamGetTiposTributos(FEAuthRequest Auth)
        {
            return (FETributoResponse) this.Invoke("FEParamGetTiposTributos", new object[] { Auth })[0];
        }

        public void FEParamGetTiposTributosAsync(FEAuthRequest Auth)
        {
            this.FEParamGetTiposTributosAsync(Auth, null);
        }

        public void FEParamGetTiposTributosAsync(FEAuthRequest Auth, object userState)
        {
            if (this.FEParamGetTiposTributosOperationCompleted == null)
            {
                this.FEParamGetTiposTributosOperationCompleted = new SendOrPostCallback(this.OnFEParamGetTiposTributosOperationCompleted);
            }
            this.InvokeAsync("FEParamGetTiposTributos", new object[] { Auth }, this.FEParamGetTiposTributosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

        private void OnFECAEAConsultarOperationCompleted(object arg)
        {
            if (this.FECAEAConsultarCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECAEAConsultarCompletedEventHandler VB$t_ref$S0 = this.FECAEAConsultarCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECAEAConsultarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECAEARegInformativoOperationCompleted(object arg)
        {
            if (this.FECAEARegInformativoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECAEARegInformativoCompletedEventHandler VB$t_ref$S0 = this.FECAEARegInformativoCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECAEARegInformativoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECAEASinMovimientoConsultarOperationCompleted(object arg)
        {
            if (this.FECAEASinMovimientoConsultarCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECAEASinMovimientoConsultarCompletedEventHandler VB$t_ref$S0 = this.FECAEASinMovimientoConsultarCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECAEASinMovimientoConsultarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECAEASinMovimientoInformarOperationCompleted(object arg)
        {
            if (this.FECAEASinMovimientoInformarCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECAEASinMovimientoInformarCompletedEventHandler VB$t_ref$S0 = this.FECAEASinMovimientoInformarCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECAEASinMovimientoInformarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECAEASolicitarOperationCompleted(object arg)
        {
            if (this.FECAEASolicitarCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECAEASolicitarCompletedEventHandler VB$t_ref$S0 = this.FECAEASolicitarCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECAEASolicitarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECAESolicitarOperationCompleted(object arg)
        {
            if (this.FECAESolicitarCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECAESolicitarCompletedEventHandler VB$t_ref$S0 = this.FECAESolicitarCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECAESolicitarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECompConsultarOperationCompleted(object arg)
        {
            if (this.FECompConsultarCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECompConsultarCompletedEventHandler VB$t_ref$S0 = this.FECompConsultarCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECompConsultarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECompTotXRequestOperationCompleted(object arg)
        {
            if (this.FECompTotXRequestCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECompTotXRequestCompletedEventHandler VB$t_ref$S0 = this.FECompTotXRequestCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECompTotXRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFECompUltimoAutorizadoOperationCompleted(object arg)
        {
            if (this.FECompUltimoAutorizadoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FECompUltimoAutorizadoCompletedEventHandler VB$t_ref$S0 = this.FECompUltimoAutorizadoCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FECompUltimoAutorizadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEDummyOperationCompleted(object arg)
        {
            if (this.FEDummyCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEDummyCompletedEventHandler VB$t_ref$S0 = this.FEDummyCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEDummyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetCotizacionOperationCompleted(object arg)
        {
            if (this.FEParamGetCotizacionCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetCotizacionCompletedEventHandler VB$t_ref$S0 = this.FEParamGetCotizacionCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetCotizacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetPtosVentaOperationCompleted(object arg)
        {
            if (this.FEParamGetPtosVentaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetPtosVentaCompletedEventHandler VB$t_ref$S0 = this.FEParamGetPtosVentaCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetPtosVentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposCbteOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposCbteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposCbteCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposCbteCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposCbteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposConceptoOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposConceptoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposConceptoCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposConceptoCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposConceptoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposDocOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposDocCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposDocCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposDocCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposDocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposIvaOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposIvaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposIvaCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposIvaCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposIvaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposMonedasOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposMonedasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposMonedasCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposMonedasCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposMonedasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposOpcionalOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposOpcionalCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposOpcionalCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposOpcionalCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposOpcionalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnFEParamGetTiposTributosOperationCompleted(object arg)
        {
            if (this.FEParamGetTiposTributosCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                FEParamGetTiposTributosCompletedEventHandler VB$t_ref$S0 = this.FEParamGetTiposTributosCompletedEvent;
                if (VB$t_ref$S0 != null)
                {
                    VB$t_ref$S0(this, new FEParamGetTiposTributosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
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

