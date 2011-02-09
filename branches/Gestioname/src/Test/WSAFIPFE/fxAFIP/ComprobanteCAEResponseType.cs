namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ComprobanteCAEResponseType
    {
        private long cAEField;
        private short codigoTipoComprobanteField;
        private long cuitField;
        private DateTime fechaEmisionField;
        private DateTime fechaVencimientoCAEField;
        private long numeroComprobanteField;
        private short numeroPuntoVentaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long CAE
        {
            get
            {
                return this.cAEField;
            }
            set
            {
                this.cAEField = value;
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
        public long cuit
        {
            get
            {
                return this.cuitField;
            }
            set
            {
                this.cuitField = value;
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

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaVencimientoCAE
        {
            get
            {
                return this.fechaVencimientoCAEField;
            }
            set
            {
                this.fechaVencimientoCAEField = value;
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
    }
}

