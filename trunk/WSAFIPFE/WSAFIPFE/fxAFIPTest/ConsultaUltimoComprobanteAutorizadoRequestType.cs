namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ConsultaUltimoComprobanteAutorizadoRequestType
    {
        private short codigoTipoComprobanteField;
        private short numeroPuntoVentaField;

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

