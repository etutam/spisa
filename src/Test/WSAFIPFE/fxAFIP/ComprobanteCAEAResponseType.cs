namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ComprobanteCAEAResponseType
    {
        private long cAEAField;
        private short codigoTipoComprobanteField;
        private long numeroComprobanteField;
        private short numeroPuntoVentaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long CAEA
        {
            get
            {
                return this.cAEAField;
            }
            set
            {
                this.cAEAField = value;
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

