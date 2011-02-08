namespace WSAFIPFE.fxAFIPTest
{
    using Microsoft.VisualBasic.CompilerServices;
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

    [WebServiceBinding(Name="MTXCAServiceSoap11Binding", Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class MTXCAService : SoapHttpClientProtocol
    {
        private SendOrPostCallback autorizarComprobanteOperationCompleted;
        private SendOrPostCallback consultarAlicuotasIVAOperationCompleted;
        private SendOrPostCallback consultarCAEAEntreFechasOperationCompleted;
        private SendOrPostCallback consultarCAEAOperationCompleted;
        private SendOrPostCallback consultarComprobanteOperationCompleted;
        private SendOrPostCallback consultarCondicionesIVAOperationCompleted;
        private SendOrPostCallback consultarCotizacionMonedaOperationCompleted;
        private SendOrPostCallback consultarMonedasOperationCompleted;
        private SendOrPostCallback consultarPtosVtaCAEANoInformadosOperationCompleted;
        private SendOrPostCallback consultarPuntosVentaCAEAOperationCompleted;
        private SendOrPostCallback consultarPuntosVentaCAEOperationCompleted;
        private SendOrPostCallback consultarPuntosVentaOperationCompleted;
        private SendOrPostCallback consultarTiposComprobanteOperationCompleted;
        private SendOrPostCallback consultarTiposDocumentoOperationCompleted;
        private SendOrPostCallback consultarTiposTributoOperationCompleted;
        private SendOrPostCallback consultarUltimoComprobanteAutorizadoOperationCompleted;
        private SendOrPostCallback consultarUnidadesMedidaOperationCompleted;
        private SendOrPostCallback dummyOperationCompleted;
        private SendOrPostCallback informarCAEANoUtilizadoOperationCompleted;
        private SendOrPostCallback informarCAEANoUtilizadoPtoVtaOperationCompleted;
        private SendOrPostCallback informarComprobanteCAEAOperationCompleted;
        private SendOrPostCallback solicitarCAEAOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event autorizarComprobanteCompletedEventHandler autorizarComprobanteCompleted;

        public event consultarAlicuotasIVACompletedEventHandler consultarAlicuotasIVACompleted;

        public event consultarCAEACompletedEventHandler consultarCAEACompleted;

        public event consultarCAEAEntreFechasCompletedEventHandler consultarCAEAEntreFechasCompleted;

        public event consultarComprobanteCompletedEventHandler consultarComprobanteCompleted;

        public event consultarCondicionesIVACompletedEventHandler consultarCondicionesIVACompleted;

        public event consultarCotizacionMonedaCompletedEventHandler consultarCotizacionMonedaCompleted;

        public event consultarMonedasCompletedEventHandler consultarMonedasCompleted;

        public event consultarPtosVtaCAEANoInformadosCompletedEventHandler consultarPtosVtaCAEANoInformadosCompleted;

        public event consultarPuntosVentaCAEACompletedEventHandler consultarPuntosVentaCAEACompleted;

        public event consultarPuntosVentaCAECompletedEventHandler consultarPuntosVentaCAECompleted;

        public event consultarPuntosVentaCompletedEventHandler consultarPuntosVentaCompleted;

        public event consultarTiposComprobanteCompletedEventHandler consultarTiposComprobanteCompleted;

        public event consultarTiposDocumentoCompletedEventHandler consultarTiposDocumentoCompleted;

        public event consultarTiposTributoCompletedEventHandler consultarTiposTributoCompleted;

        public event consultarUltimoComprobanteAutorizadoCompletedEventHandler consultarUltimoComprobanteAutorizadoCompleted;

        public event consultarUnidadesMedidaCompletedEventHandler consultarUnidadesMedidaCompleted;

        public event dummyCompletedEventHandler dummyCompleted;

        public event informarCAEANoUtilizadoCompletedEventHandler informarCAEANoUtilizadoCompleted;

        public event informarCAEANoUtilizadoPtoVtaCompletedEventHandler informarCAEANoUtilizadoPtoVtaCompleted;

        public event informarComprobanteCAEACompletedEventHandler informarComprobanteCAEACompleted;

        public event solicitarCAEACompletedEventHandler solicitarCAEACompleted;

        public MTXCAService()
        {
            this.Url = MySettings.Default.WSAFIPFE_fxAFIPTest_MTXCAService;
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

        [return: XmlElement("resultado", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/autorizarComprobante", RequestElementName="autorizarComprobanteRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ResultadoSimpleType autorizarComprobante([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ComprobanteType comprobanteCAERequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref ComprobanteCAEResponseType comprobanteResponse, [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)] ref CodigoDescripcionType[] arrayObservaciones, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("autorizarComprobante", new object[] { authRequest, comprobanteCAERequest });
            comprobanteResponse = (ComprobanteCAEResponseType) results[1];
            arrayObservaciones = (CodigoDescripcionType[]) results[2];
            arrayErrores = (CodigoDescripcionType[]) results[3];
            evento = (CodigoDescripcionType) results[4];
            return (ResultadoSimpleType) Conversions.ToInteger(results[0]);
        }

        public void autorizarComprobanteAsync(AuthRequestType authRequest, ComprobanteType comprobanteCAERequest)
        {
            this.autorizarComprobanteAsync(authRequest, comprobanteCAERequest, null);
        }

        public void autorizarComprobanteAsync(AuthRequestType authRequest, ComprobanteType comprobanteCAERequest, object userState)
        {
            if (this.autorizarComprobanteOperationCompleted == null)
            {
                this.autorizarComprobanteOperationCompleted = new SendOrPostCallback(this.OnautorizarComprobanteOperationCompleted);
            }
            this.InvokeAsync("autorizarComprobante", new object[] { authRequest, comprobanteCAERequest }, this.autorizarComprobanteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        public void CancelAsync(object userState)
        {
            base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArray("arrayAlicuotasIVA", Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarAlicuotasIVA", RequestElementName="consultarAlicuotasIVARequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionType[] consultarAlicuotasIVA([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarAlicuotasIVA", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionType[]) results[0];
        }

        public void consultarAlicuotasIVAAsync(AuthRequestType authRequest)
        {
            this.consultarAlicuotasIVAAsync(authRequest, null);
        }

        public void consultarAlicuotasIVAAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarAlicuotasIVAOperationCompleted == null)
            {
                this.consultarAlicuotasIVAOperationCompleted = new SendOrPostCallback(this.OnconsultarAlicuotasIVAOperationCompleted);
            }
            this.InvokeAsync("consultarAlicuotasIVA", new object[] { authRequest }, this.consultarAlicuotasIVAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("CAEAResponse", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarCAEA", RequestElementName="consultarCAEARequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CAEAResponseType consultarCAEA([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] long CAEA, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarCAEA", new object[] { authRequest, CAEA });
            arrayErrores = (CodigoDescripcionType[]) results[1];
            evento = (CodigoDescripcionType) results[2];
            return (CAEAResponseType) results[0];
        }

        public void consultarCAEAAsync(AuthRequestType authRequest, long CAEA)
        {
            this.consultarCAEAAsync(authRequest, CAEA, null);
        }

        public void consultarCAEAAsync(AuthRequestType authRequest, long CAEA, object userState)
        {
            if (this.consultarCAEAOperationCompleted == null)
            {
                this.consultarCAEAOperationCompleted = new SendOrPostCallback(this.OnconsultarCAEAOperationCompleted);
            }
            this.InvokeAsync("consultarCAEA", new object[] { authRequest, CAEA }, this.consultarCAEAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArrayItem("CAEAResponse", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("arrayCAEAResponse", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarCAEAEntreFechas", RequestElementName="consultarCAEAEntreFechasRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CAEAResponseType[] consultarCAEAEntreFechas([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")] DateTime fechaDesde, [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")] DateTime fechaHasta, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarCAEAEntreFechas", new object[] { authRequest, fechaDesde, fechaHasta });
            arrayErrores = (CodigoDescripcionType[]) results[1];
            evento = (CodigoDescripcionType) results[2];
            return (CAEAResponseType[]) results[0];
        }

        public void consultarCAEAEntreFechasAsync(AuthRequestType authRequest, DateTime fechaDesde, DateTime fechaHasta)
        {
            this.consultarCAEAEntreFechasAsync(authRequest, fechaDesde, fechaHasta, null);
        }

        public void consultarCAEAEntreFechasAsync(AuthRequestType authRequest, DateTime fechaDesde, DateTime fechaHasta, object userState)
        {
            if (this.consultarCAEAEntreFechasOperationCompleted == null)
            {
                this.consultarCAEAEntreFechasOperationCompleted = new SendOrPostCallback(this.OnconsultarCAEAEntreFechasOperationCompleted);
            }
            this.InvokeAsync("consultarCAEAEntreFechas", new object[] { authRequest, fechaDesde, fechaHasta }, this.consultarCAEAEntreFechasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("comprobante", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarComprobante", RequestElementName="consultarComprobanteRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ComprobanteType consultarComprobante([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ConsultaComprobanteRequestType consultaComprobanteRequest, [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)] ref CodigoDescripcionType[] arrayObservaciones, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarComprobante", new object[] { authRequest, consultaComprobanteRequest });
            arrayObservaciones = (CodigoDescripcionType[]) results[1];
            arrayErrores = (CodigoDescripcionType[]) results[2];
            evento = (CodigoDescripcionType) results[3];
            return (ComprobanteType) results[0];
        }

        public void consultarComprobanteAsync(AuthRequestType authRequest, ConsultaComprobanteRequestType consultaComprobanteRequest)
        {
            this.consultarComprobanteAsync(authRequest, consultaComprobanteRequest, null);
        }

        public void consultarComprobanteAsync(AuthRequestType authRequest, ConsultaComprobanteRequestType consultaComprobanteRequest, object userState)
        {
            if (this.consultarComprobanteOperationCompleted == null)
            {
                this.consultarComprobanteOperationCompleted = new SendOrPostCallback(this.OnconsultarComprobanteOperationCompleted);
            }
            this.InvokeAsync("consultarComprobante", new object[] { authRequest, consultaComprobanteRequest }, this.consultarComprobanteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("arrayCondicionesIVA", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarCondicionesIVA", RequestElementName="consultarCondicionesIVARequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionType[] consultarCondicionesIVA([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarCondicionesIVA", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionType[]) results[0];
        }

        public void consultarCondicionesIVAAsync(AuthRequestType authRequest)
        {
            this.consultarCondicionesIVAAsync(authRequest, null);
        }

        public void consultarCondicionesIVAAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarCondicionesIVAOperationCompleted == null)
            {
                this.consultarCondicionesIVAOperationCompleted = new SendOrPostCallback(this.OnconsultarCondicionesIVAOperationCompleted);
            }
            this.InvokeAsync("consultarCondicionesIVA", new object[] { authRequest }, this.consultarCondicionesIVAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarCotizacionMoneda", RequestElementName="consultarCotizacionMonedaRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public void consultarCotizacionMoneda([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] string codigoMoneda, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref decimal cotizacionMoneda, [XmlIgnore, XmlElement(Form=XmlSchemaForm.Unqualified)] ref bool cotizacionMonedaSpecified, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarCotizacionMoneda", new object[] { authRequest, codigoMoneda });
            cotizacionMoneda = Conversions.ToDecimal(results[0]);
            cotizacionMonedaSpecified = Conversions.ToBoolean(results[1]);
            arrayErrores = (CodigoDescripcionType[]) results[2];
            evento = (CodigoDescripcionType) results[3];
        }

        public void consultarCotizacionMonedaAsync(AuthRequestType authRequest, string codigoMoneda)
        {
            this.consultarCotizacionMonedaAsync(authRequest, codigoMoneda, null);
        }

        public void consultarCotizacionMonedaAsync(AuthRequestType authRequest, string codigoMoneda, object userState)
        {
            if (this.consultarCotizacionMonedaOperationCompleted == null)
            {
                this.consultarCotizacionMonedaOperationCompleted = new SendOrPostCallback(this.OnconsultarCotizacionMonedaOperationCompleted);
            }
            this.InvokeAsync("consultarCotizacionMoneda", new object[] { authRequest, codigoMoneda }, this.consultarCotizacionMonedaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("arrayMonedas", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarMonedas", RequestElementName="consultarMonedasRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionStringType[] consultarMonedas([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarMonedas", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionStringType[]) results[0];
        }

        public void consultarMonedasAsync(AuthRequestType authRequest)
        {
            this.consultarMonedasAsync(authRequest, null);
        }

        public void consultarMonedasAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarMonedasOperationCompleted == null)
            {
                this.consultarMonedasOperationCompleted = new SendOrPostCallback(this.OnconsultarMonedasOperationCompleted);
            }
            this.InvokeAsync("consultarMonedas", new object[] { authRequest }, this.consultarMonedasOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArray("arrayPuntosVenta", Form=XmlSchemaForm.Unqualified), XmlArrayItem("puntoVenta", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarPtosVtaCAEANoInformados", RequestElementName="consultarPtosVtaCAEANoInformadosRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public PuntoVentaType[] consultarPtosVtaCAEANoInformados([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] long CAEA, [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarPtosVtaCAEANoInformados", new object[] { authRequest, CAEA });
            arrayErrores = (CodigoDescripcionType[]) results[1];
            evento = (CodigoDescripcionType) results[2];
            return (PuntoVentaType[]) results[0];
        }

        public void consultarPtosVtaCAEANoInformadosAsync(AuthRequestType authRequest, long CAEA)
        {
            this.consultarPtosVtaCAEANoInformadosAsync(authRequest, CAEA, null);
        }

        public void consultarPtosVtaCAEANoInformadosAsync(AuthRequestType authRequest, long CAEA, object userState)
        {
            if (this.consultarPtosVtaCAEANoInformadosOperationCompleted == null)
            {
                this.consultarPtosVtaCAEANoInformadosOperationCompleted = new SendOrPostCallback(this.OnconsultarPtosVtaCAEANoInformadosOperationCompleted);
            }
            this.InvokeAsync("consultarPtosVtaCAEANoInformados", new object[] { authRequest, CAEA }, this.consultarPtosVtaCAEANoInformadosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArray("arrayPuntosVenta", Form=XmlSchemaForm.Unqualified), XmlArrayItem("puntoVenta", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarPuntosVenta", RequestElementName="consultarPuntosVentaRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public PuntoVentaType[] consultarPuntosVenta([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarPuntosVenta", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (PuntoVentaType[]) results[0];
        }

        public void consultarPuntosVentaAsync(AuthRequestType authRequest)
        {
            this.consultarPuntosVentaAsync(authRequest, null);
        }

        public void consultarPuntosVentaAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarPuntosVentaOperationCompleted == null)
            {
                this.consultarPuntosVentaOperationCompleted = new SendOrPostCallback(this.OnconsultarPuntosVentaOperationCompleted);
            }
            this.InvokeAsync("consultarPuntosVenta", new object[] { authRequest }, this.consultarPuntosVentaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArrayItem("puntoVenta", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("arrayPuntosVenta", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarPuntosVentaCAE", RequestElementName="consultarPuntosVentaCAERequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public PuntoVentaType[] consultarPuntosVentaCAE([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarPuntosVentaCAE", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (PuntoVentaType[]) results[0];
        }

        [return: XmlArray("arrayPuntosVenta", Form=XmlSchemaForm.Unqualified), XmlArrayItem("puntoVenta", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarPuntosVentaCAEA", RequestElementName="consultarPuntosVentaCAEARequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public PuntoVentaType[] consultarPuntosVentaCAEA([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarPuntosVentaCAEA", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (PuntoVentaType[]) results[0];
        }

        public void consultarPuntosVentaCAEAAsync(AuthRequestType authRequest)
        {
            this.consultarPuntosVentaCAEAAsync(authRequest, null);
        }

        public void consultarPuntosVentaCAEAAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarPuntosVentaCAEAOperationCompleted == null)
            {
                this.consultarPuntosVentaCAEAOperationCompleted = new SendOrPostCallback(this.OnconsultarPuntosVentaCAEAOperationCompleted);
            }
            this.InvokeAsync("consultarPuntosVentaCAEA", new object[] { authRequest }, this.consultarPuntosVentaCAEAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        public void consultarPuntosVentaCAEAsync(AuthRequestType authRequest)
        {
            this.consultarPuntosVentaCAEAsync(authRequest, null);
        }

        public void consultarPuntosVentaCAEAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarPuntosVentaCAEOperationCompleted == null)
            {
                this.consultarPuntosVentaCAEOperationCompleted = new SendOrPostCallback(this.OnconsultarPuntosVentaCAEOperationCompleted);
            }
            this.InvokeAsync("consultarPuntosVentaCAE", new object[] { authRequest }, this.consultarPuntosVentaCAEOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("arrayTiposComprobante", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarTiposComprobante", RequestElementName="consultarTiposComprobanteRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionType[] consultarTiposComprobante([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarTiposComprobante", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionType[]) results[0];
        }

        public void consultarTiposComprobanteAsync(AuthRequestType authRequest)
        {
            this.consultarTiposComprobanteAsync(authRequest, null);
        }

        public void consultarTiposComprobanteAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarTiposComprobanteOperationCompleted == null)
            {
                this.consultarTiposComprobanteOperationCompleted = new SendOrPostCallback(this.OnconsultarTiposComprobanteOperationCompleted);
            }
            this.InvokeAsync("consultarTiposComprobante", new object[] { authRequest }, this.consultarTiposComprobanteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArray("arrayTiposDocumento", Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarTiposDocumento", RequestElementName="consultarTiposDocumentoRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionType[] consultarTiposDocumento([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarTiposDocumento", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionType[]) results[0];
        }

        public void consultarTiposDocumentoAsync(AuthRequestType authRequest)
        {
            this.consultarTiposDocumentoAsync(authRequest, null);
        }

        public void consultarTiposDocumentoAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarTiposDocumentoOperationCompleted == null)
            {
                this.consultarTiposDocumentoOperationCompleted = new SendOrPostCallback(this.OnconsultarTiposDocumentoOperationCompleted);
            }
            this.InvokeAsync("consultarTiposDocumento", new object[] { authRequest }, this.consultarTiposDocumentoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArray("arrayTiposTributo", Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarTiposTributo", RequestElementName="consultarTiposTributoRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionType[] consultarTiposTributo([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarTiposTributo", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionType[]) results[0];
        }

        public void consultarTiposTributoAsync(AuthRequestType authRequest)
        {
            this.consultarTiposTributoAsync(authRequest, null);
        }

        public void consultarTiposTributoAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarTiposTributoOperationCompleted == null)
            {
                this.consultarTiposTributoOperationCompleted = new SendOrPostCallback(this.OnconsultarTiposTributoOperationCompleted);
            }
            this.InvokeAsync("consultarTiposTributo", new object[] { authRequest }, this.consultarTiposTributoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarUltimoComprobanteAutorizado", RequestElementName="consultarUltimoComprobanteAutorizadoRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public void consultarUltimoComprobanteAutorizado([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ConsultaUltimoComprobanteAutorizadoRequestType consultaUltimoComprobanteAutorizadoRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref long numeroComprobante, [XmlElement(Form=XmlSchemaForm.Unqualified), XmlIgnore] ref bool numeroComprobanteSpecified, [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarUltimoComprobanteAutorizado", new object[] { authRequest, consultaUltimoComprobanteAutorizadoRequest });
            numeroComprobante = Conversions.ToLong(results[0]);
            numeroComprobanteSpecified = Conversions.ToBoolean(results[1]);
            arrayErrores = (CodigoDescripcionType[]) results[2];
            evento = (CodigoDescripcionType) results[3];
        }

        public void consultarUltimoComprobanteAutorizadoAsync(AuthRequestType authRequest, ConsultaUltimoComprobanteAutorizadoRequestType consultaUltimoComprobanteAutorizadoRequest)
        {
            this.consultarUltimoComprobanteAutorizadoAsync(authRequest, consultaUltimoComprobanteAutorizadoRequest, null);
        }

        public void consultarUltimoComprobanteAutorizadoAsync(AuthRequestType authRequest, ConsultaUltimoComprobanteAutorizadoRequestType consultaUltimoComprobanteAutorizadoRequest, object userState)
        {
            if (this.consultarUltimoComprobanteAutorizadoOperationCompleted == null)
            {
                this.consultarUltimoComprobanteAutorizadoOperationCompleted = new SendOrPostCallback(this.OnconsultarUltimoComprobanteAutorizadoOperationCompleted);
            }
            this.InvokeAsync("consultarUltimoComprobanteAutorizado", new object[] { authRequest, consultaUltimoComprobanteAutorizadoRequest }, this.consultarUltimoComprobanteAutorizadoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("arrayUnidadesMedida", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/consultarUnidadesMedida", RequestElementName="consultarUnidadesMedidaRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CodigoDescripcionType[] consultarUnidadesMedida([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("consultarUnidadesMedida", new object[] { authRequest });
            evento = (CodigoDescripcionType) results[1];
            return (CodigoDescripcionType[]) results[0];
        }

        public void consultarUnidadesMedidaAsync(AuthRequestType authRequest)
        {
            this.consultarUnidadesMedidaAsync(authRequest, null);
        }

        public void consultarUnidadesMedidaAsync(AuthRequestType authRequest, object userState)
        {
            if (this.consultarUnidadesMedidaOperationCompleted == null)
            {
                this.consultarUnidadesMedidaOperationCompleted = new SendOrPostCallback(this.OnconsultarUnidadesMedidaOperationCompleted);
            }
            this.InvokeAsync("consultarUnidadesMedida", new object[] { authRequest }, this.consultarUnidadesMedidaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("dummyResponse", Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/")]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/dummy", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        public DummyResponseType dummy()
        {
            return (DummyResponseType) this.Invoke("dummy", new object[0])[0];
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

        [return: XmlElement("resultado", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/informarCAEANoUtilizado", RequestElementName="informarCAEANoUtilizadoRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ResultadoSimpleType informarCAEANoUtilizado([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref long CAEA, [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")] ref DateTime fechaProceso, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("informarCAEANoUtilizado", new object[] { authRequest, (long) CAEA });
            CAEA = Conversions.ToLong(results[1]);
            fechaProceso = Conversions.ToDate(results[2]);
            arrayErrores = (CodigoDescripcionType[]) results[3];
            evento = (CodigoDescripcionType) results[4];
            return (ResultadoSimpleType) Conversions.ToInteger(results[0]);
        }

        public void informarCAEANoUtilizadoAsync(AuthRequestType authRequest, long CAEA)
        {
            this.informarCAEANoUtilizadoAsync(authRequest, CAEA, null);
        }

        public void informarCAEANoUtilizadoAsync(AuthRequestType authRequest, long CAEA, object userState)
        {
            if (this.informarCAEANoUtilizadoOperationCompleted == null)
            {
                this.informarCAEANoUtilizadoOperationCompleted = new SendOrPostCallback(this.OninformarCAEANoUtilizadoOperationCompleted);
            }
            this.InvokeAsync("informarCAEANoUtilizado", new object[] { authRequest, CAEA }, this.informarCAEANoUtilizadoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("resultado", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/informarCAEANoUtilizadoPtoVta", RequestElementName="informarCAEANoUtilizadoPtoVtaRequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ResultadoSimpleType informarCAEANoUtilizadoPtoVta([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref long CAEA, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref short numeroPuntoVenta, [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")] ref DateTime fechaProceso, [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("informarCAEANoUtilizadoPtoVta", new object[] { authRequest, (long) CAEA, (short) numeroPuntoVenta });
            CAEA = Conversions.ToLong(results[1]);
            numeroPuntoVenta = Conversions.ToShort(results[2]);
            fechaProceso = Conversions.ToDate(results[3]);
            arrayErrores = (CodigoDescripcionType[]) results[4];
            evento = (CodigoDescripcionType) results[5];
            return (ResultadoSimpleType) Conversions.ToInteger(results[0]);
        }

        public void informarCAEANoUtilizadoPtoVtaAsync(AuthRequestType authRequest, long CAEA, short numeroPuntoVenta)
        {
            this.informarCAEANoUtilizadoPtoVtaAsync(authRequest, CAEA, numeroPuntoVenta, null);
        }

        public void informarCAEANoUtilizadoPtoVtaAsync(AuthRequestType authRequest, long CAEA, short numeroPuntoVenta, object userState)
        {
            if (this.informarCAEANoUtilizadoPtoVtaOperationCompleted == null)
            {
                this.informarCAEANoUtilizadoPtoVtaOperationCompleted = new SendOrPostCallback(this.OninformarCAEANoUtilizadoPtoVtaOperationCompleted);
            }
            this.InvokeAsync("informarCAEANoUtilizadoPtoVta", new object[] { authRequest, CAEA, numeroPuntoVenta }, this.informarCAEANoUtilizadoPtoVtaOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("resultado", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/informarComprobanteCAEA", RequestElementName="informarComprobanteCAEARequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public ResultadoSimpleType informarComprobanteCAEA([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] ComprobanteType comprobanteCAEARequest, [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")] ref DateTime fechaProceso, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref ComprobanteCAEAResponseType comprobanteCAEAResponse, [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false)] ref CodigoDescripcionType[] arrayObservaciones, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("informarComprobanteCAEA", new object[] { authRequest, comprobanteCAEARequest });
            fechaProceso = Conversions.ToDate(results[1]);
            comprobanteCAEAResponse = (ComprobanteCAEAResponseType) results[2];
            arrayObservaciones = (CodigoDescripcionType[]) results[3];
            arrayErrores = (CodigoDescripcionType[]) results[4];
            evento = (CodigoDescripcionType) results[5];
            return (ResultadoSimpleType) Conversions.ToInteger(results[0]);
        }

        public void informarComprobanteCAEAAsync(AuthRequestType authRequest, ComprobanteType comprobanteCAEARequest)
        {
            this.informarComprobanteCAEAAsync(authRequest, comprobanteCAEARequest, null);
        }

        public void informarComprobanteCAEAAsync(AuthRequestType authRequest, ComprobanteType comprobanteCAEARequest, object userState)
        {
            if (this.informarComprobanteCAEAOperationCompleted == null)
            {
                this.informarComprobanteCAEAOperationCompleted = new SendOrPostCallback(this.OninformarComprobanteCAEAOperationCompleted);
            }
            this.InvokeAsync("informarComprobanteCAEA", new object[] { authRequest, comprobanteCAEARequest }, this.informarComprobanteCAEAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

        private void OnautorizarComprobanteOperationCompleted(object arg)
        {
            if (this.autorizarComprobanteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                autorizarComprobanteCompletedEventHandler VB_t_ref_S0 = this.autorizarComprobanteCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new autorizarComprobanteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarAlicuotasIVAOperationCompleted(object arg)
        {
            if (this.consultarAlicuotasIVACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarAlicuotasIVACompletedEventHandler VB_t_ref_S0 = this.consultarAlicuotasIVACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarAlicuotasIVACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarCAEAEntreFechasOperationCompleted(object arg)
        {
            if (this.consultarCAEAEntreFechasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarCAEAEntreFechasCompletedEventHandler VB_t_ref_S0 = this.consultarCAEAEntreFechasCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarCAEAEntreFechasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarCAEAOperationCompleted(object arg)
        {
            if (this.consultarCAEACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarCAEACompletedEventHandler VB_t_ref_S0 = this.consultarCAEACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarCAEACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarComprobanteOperationCompleted(object arg)
        {
            if (this.consultarComprobanteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarComprobanteCompletedEventHandler VB_t_ref_S0 = this.consultarComprobanteCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarComprobanteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarCondicionesIVAOperationCompleted(object arg)
        {
            if (this.consultarCondicionesIVACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarCondicionesIVACompletedEventHandler VB_t_ref_S0 = this.consultarCondicionesIVACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarCondicionesIVACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarCotizacionMonedaOperationCompleted(object arg)
        {
            if (this.consultarCotizacionMonedaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarCotizacionMonedaCompletedEventHandler VB_t_ref_S0 = this.consultarCotizacionMonedaCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarCotizacionMonedaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarMonedasOperationCompleted(object arg)
        {
            if (this.consultarMonedasCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarMonedasCompletedEventHandler VB_t_ref_S0 = this.consultarMonedasCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarMonedasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarPtosVtaCAEANoInformadosOperationCompleted(object arg)
        {
            if (this.consultarPtosVtaCAEANoInformadosCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarPtosVtaCAEANoInformadosCompletedEventHandler VB_t_ref_S0 = this.consultarPtosVtaCAEANoInformadosCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarPtosVtaCAEANoInformadosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarPuntosVentaCAEAOperationCompleted(object arg)
        {
            if (this.consultarPuntosVentaCAEACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarPuntosVentaCAEACompletedEventHandler VB_t_ref_S0 = this.consultarPuntosVentaCAEACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarPuntosVentaCAEACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarPuntosVentaCAEOperationCompleted(object arg)
        {
            if (this.consultarPuntosVentaCAECompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarPuntosVentaCAECompletedEventHandler VB_t_ref_S0 = this.consultarPuntosVentaCAECompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarPuntosVentaCAECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarPuntosVentaOperationCompleted(object arg)
        {
            if (this.consultarPuntosVentaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarPuntosVentaCompletedEventHandler VB_t_ref_S0 = this.consultarPuntosVentaCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarPuntosVentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarTiposComprobanteOperationCompleted(object arg)
        {
            if (this.consultarTiposComprobanteCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarTiposComprobanteCompletedEventHandler VB_t_ref_S0 = this.consultarTiposComprobanteCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarTiposComprobanteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarTiposDocumentoOperationCompleted(object arg)
        {
            if (this.consultarTiposDocumentoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarTiposDocumentoCompletedEventHandler VB_t_ref_S0 = this.consultarTiposDocumentoCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarTiposDocumentoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarTiposTributoOperationCompleted(object arg)
        {
            if (this.consultarTiposTributoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarTiposTributoCompletedEventHandler VB_t_ref_S0 = this.consultarTiposTributoCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarTiposTributoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarUltimoComprobanteAutorizadoOperationCompleted(object arg)
        {
            if (this.consultarUltimoComprobanteAutorizadoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarUltimoComprobanteAutorizadoCompletedEventHandler VB_t_ref_S0 = this.consultarUltimoComprobanteAutorizadoCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarUltimoComprobanteAutorizadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnconsultarUnidadesMedidaOperationCompleted(object arg)
        {
            if (this.consultarUnidadesMedidaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                consultarUnidadesMedidaCompletedEventHandler VB_t_ref_S0 = this.consultarUnidadesMedidaCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new consultarUnidadesMedidaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
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

        private void OninformarCAEANoUtilizadoOperationCompleted(object arg)
        {
            if (this.informarCAEANoUtilizadoCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                informarCAEANoUtilizadoCompletedEventHandler VB_t_ref_S0 = this.informarCAEANoUtilizadoCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new informarCAEANoUtilizadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OninformarCAEANoUtilizadoPtoVtaOperationCompleted(object arg)
        {
            if (this.informarCAEANoUtilizadoPtoVtaCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                informarCAEANoUtilizadoPtoVtaCompletedEventHandler VB_t_ref_S0 = this.informarCAEANoUtilizadoPtoVtaCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new informarCAEANoUtilizadoPtoVtaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OninformarComprobanteCAEAOperationCompleted(object arg)
        {
            if (this.informarComprobanteCAEACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                informarComprobanteCAEACompletedEventHandler VB_t_ref_S0 = this.informarComprobanteCAEACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new informarComprobanteCAEACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        private void OnsolicitarCAEAOperationCompleted(object arg)
        {
            if (this.solicitarCAEACompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                solicitarCAEACompletedEventHandler VB_t_ref_S0 = this.solicitarCAEACompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new solicitarCAEACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        [return: XmlElement("CAEAResponse", Form=XmlSchemaForm.Unqualified)]
        [SoapDocumentMethod("http://impl.service.wsmtxca.afip.gov.ar/service/solicitarCAEA", RequestElementName="solicitarCAEARequest", RequestNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", ResponseNamespace="http://impl.service.wsmtxca.afip.gov.ar/service/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public CAEAResponseType solicitarCAEA([XmlElement(Form=XmlSchemaForm.Unqualified)] AuthRequestType authRequest, [XmlElement(Form=XmlSchemaForm.Unqualified)] SolicitudCAEAType solicitudCAEA, [XmlArrayItem("codigoDescripcion", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType[] arrayErrores, [XmlElement(Form=XmlSchemaForm.Unqualified)] ref CodigoDescripcionType evento)
        {
            object[] results = this.Invoke("solicitarCAEA", new object[] { authRequest, solicitudCAEA });
            arrayErrores = (CodigoDescripcionType[]) results[1];
            evento = (CodigoDescripcionType) results[2];
            return (CAEAResponseType) results[0];
        }

        public void solicitarCAEAAsync(AuthRequestType authRequest, SolicitudCAEAType solicitudCAEA)
        {
            this.solicitarCAEAAsync(authRequest, solicitudCAEA, null);
        }

        public void solicitarCAEAAsync(AuthRequestType authRequest, SolicitudCAEAType solicitudCAEA, object userState)
        {
            if (this.solicitarCAEAOperationCompleted == null)
            {
                this.solicitarCAEAOperationCompleted = new SendOrPostCallback(this.OnsolicitarCAEAOperationCompleted);
            }
            this.InvokeAsync("solicitarCAEA", new object[] { authRequest, solicitudCAEA }, this.solicitarCAEAOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
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

