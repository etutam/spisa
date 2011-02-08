namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ComprobanteType
    {
        private ComprobanteAsociadoType[] arrayComprobantesAsociadosField;
        private ItemType[] arrayItemsField;
        private OtroTributoType[] arrayOtrosTributosField;
        private SubtotalIVAType[] arraySubtotalesIVAField;
        private long codigoAutorizacionField;
        private bool codigoAutorizacionFieldSpecified;
        private short codigoConceptoField;
        private string codigoMonedaField;
        private CodigoTipoAutorizacionSimpleType codigoTipoAutorizacionField;
        private bool codigoTipoAutorizacionFieldSpecified;
        private short codigoTipoComprobanteField;
        private short codigoTipoDocumentoField;
        private bool codigoTipoDocumentoFieldSpecified;
        private decimal cotizacionMonedaField;
        private DateTime fechaEmisionField;
        private bool fechaEmisionFieldSpecified;
        private DateTime fechaServicioDesdeField;
        private bool fechaServicioDesdeFieldSpecified;
        private DateTime fechaServicioHastaField;
        private bool fechaServicioHastaFieldSpecified;
        private DateTime fechaVencimientoField;
        private bool fechaVencimientoFieldSpecified;
        private DateTime fechaVencimientoPagoField;
        private bool fechaVencimientoPagoFieldSpecified;
        private decimal importeExentoField;
        private bool importeExentoFieldSpecified;
        private decimal importeGravadoField;
        private bool importeGravadoFieldSpecified;
        private decimal importeNoGravadoField;
        private bool importeNoGravadoFieldSpecified;
        private decimal importeOtrosTributosField;
        private bool importeOtrosTributosFieldSpecified;
        private decimal importeSubtotalField;
        private decimal importeTotalField;
        private long numeroComprobanteField;
        private long numeroDocumentoField;
        private bool numeroDocumentoFieldSpecified;
        private short numeroPuntoVentaField;
        private string observacionesField;

        [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("comprobanteAsociado", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        public ComprobanteAsociadoType[] arrayComprobantesAsociados
        {
            get
            {
                return this.arrayComprobantesAsociadosField;
            }
            set
            {
                this.arrayComprobantesAsociadosField = value;
            }
        }

        [XmlArray(Form=XmlSchemaForm.Unqualified), XmlArrayItem("item", Form=XmlSchemaForm.Unqualified, IsNullable=false)]
        public ItemType[] arrayItems
        {
            get
            {
                return this.arrayItemsField;
            }
            set
            {
                this.arrayItemsField = value;
            }
        }

        [XmlArrayItem("otroTributo", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)]
        public OtroTributoType[] arrayOtrosTributos
        {
            get
            {
                return this.arrayOtrosTributosField;
            }
            set
            {
                this.arrayOtrosTributosField = value;
            }
        }

        [XmlArrayItem("subtotalIVA", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray(Form=XmlSchemaForm.Unqualified)]
        public SubtotalIVAType[] arraySubtotalesIVA
        {
            get
            {
                return this.arraySubtotalesIVAField;
            }
            set
            {
                this.arraySubtotalesIVAField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long codigoAutorizacion
        {
            get
            {
                return this.codigoAutorizacionField;
            }
            set
            {
                this.codigoAutorizacionField = value;
            }
        }

        [XmlIgnore]
        public bool codigoAutorizacionSpecified
        {
            get
            {
                return this.codigoAutorizacionFieldSpecified;
            }
            set
            {
                this.codigoAutorizacionFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short codigoConcepto
        {
            get
            {
                return this.codigoConceptoField;
            }
            set
            {
                this.codigoConceptoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string codigoMoneda
        {
            get
            {
                return this.codigoMonedaField;
            }
            set
            {
                this.codigoMonedaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public CodigoTipoAutorizacionSimpleType codigoTipoAutorizacion
        {
            get
            {
                return this.codigoTipoAutorizacionField;
            }
            set
            {
                this.codigoTipoAutorizacionField = value;
            }
        }

        [XmlIgnore]
        public bool codigoTipoAutorizacionSpecified
        {
            get
            {
                return this.codigoTipoAutorizacionFieldSpecified;
            }
            set
            {
                this.codigoTipoAutorizacionFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short codigoTipoComprobante
        {
            get
            {
                return this.codigoTipoComprobanteField;
            }
            set
            {
                this.codigoTipoComprobanteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short codigoTipoDocumento
        {
            get
            {
                return this.codigoTipoDocumentoField;
            }
            set
            {
                this.codigoTipoDocumentoField = value;
            }
        }

        [XmlIgnore]
        public bool codigoTipoDocumentoSpecified
        {
            get
            {
                return this.codigoTipoDocumentoFieldSpecified;
            }
            set
            {
                this.codigoTipoDocumentoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal cotizacionMoneda
        {
            get
            {
                return this.cotizacionMonedaField;
            }
            set
            {
                this.cotizacionMonedaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaEmision
        {
            get
            {
                return this.fechaEmisionField;
            }
            set
            {
                this.fechaEmisionField = value;
            }
        }

        [XmlIgnore]
        public bool fechaEmisionSpecified
        {
            get
            {
                return this.fechaEmisionFieldSpecified;
            }
            set
            {
                this.fechaEmisionFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaServicioDesde
        {
            get
            {
                return this.fechaServicioDesdeField;
            }
            set
            {
                this.fechaServicioDesdeField = value;
            }
        }

        [XmlIgnore]
        public bool fechaServicioDesdeSpecified
        {
            get
            {
                return this.fechaServicioDesdeFieldSpecified;
            }
            set
            {
                this.fechaServicioDesdeFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaServicioHasta
        {
            get
            {
                return this.fechaServicioHastaField;
            }
            set
            {
                this.fechaServicioHastaField = value;
            }
        }

        [XmlIgnore]
        public bool fechaServicioHastaSpecified
        {
            get
            {
                return this.fechaServicioHastaFieldSpecified;
            }
            set
            {
                this.fechaServicioHastaFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaVencimiento
        {
            get
            {
                return this.fechaVencimientoField;
            }
            set
            {
                this.fechaVencimientoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaVencimientoPago
        {
            get
            {
                return this.fechaVencimientoPagoField;
            }
            set
            {
                this.fechaVencimientoPagoField = value;
            }
        }

        [XmlIgnore]
        public bool fechaVencimientoPagoSpecified
        {
            get
            {
                return this.fechaVencimientoPagoFieldSpecified;
            }
            set
            {
                this.fechaVencimientoPagoFieldSpecified = value;
            }
        }

        [XmlIgnore]
        public bool fechaVencimientoSpecified
        {
            get
            {
                return this.fechaVencimientoFieldSpecified;
            }
            set
            {
                this.fechaVencimientoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeExento
        {
            get
            {
                return this.importeExentoField;
            }
            set
            {
                this.importeExentoField = value;
            }
        }

        [XmlIgnore]
        public bool importeExentoSpecified
        {
            get
            {
                return this.importeExentoFieldSpecified;
            }
            set
            {
                this.importeExentoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeGravado
        {
            get
            {
                return this.importeGravadoField;
            }
            set
            {
                this.importeGravadoField = value;
            }
        }

        [XmlIgnore]
        public bool importeGravadoSpecified
        {
            get
            {
                return this.importeGravadoFieldSpecified;
            }
            set
            {
                this.importeGravadoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeNoGravado
        {
            get
            {
                return this.importeNoGravadoField;
            }
            set
            {
                this.importeNoGravadoField = value;
            }
        }

        [XmlIgnore]
        public bool importeNoGravadoSpecified
        {
            get
            {
                return this.importeNoGravadoFieldSpecified;
            }
            set
            {
                this.importeNoGravadoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeOtrosTributos
        {
            get
            {
                return this.importeOtrosTributosField;
            }
            set
            {
                this.importeOtrosTributosField = value;
            }
        }

        [XmlIgnore]
        public bool importeOtrosTributosSpecified
        {
            get
            {
                return this.importeOtrosTributosFieldSpecified;
            }
            set
            {
                this.importeOtrosTributosFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeSubtotal
        {
            get
            {
                return this.importeSubtotalField;
            }
            set
            {
                this.importeSubtotalField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeTotal
        {
            get
            {
                return this.importeTotalField;
            }
            set
            {
                this.importeTotalField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long numeroComprobante
        {
            get
            {
                return this.numeroComprobanteField;
            }
            set
            {
                this.numeroComprobanteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long numeroDocumento
        {
            get
            {
                return this.numeroDocumentoField;
            }
            set
            {
                this.numeroDocumentoField = value;
            }
        }

        [XmlIgnore]
        public bool numeroDocumentoSpecified
        {
            get
            {
                return this.numeroDocumentoFieldSpecified;
            }
            set
            {
                this.numeroDocumentoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short numeroPuntoVenta
        {
            get
            {
                return this.numeroPuntoVentaField;
            }
            set
            {
                this.numeroPuntoVentaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
    }
}

