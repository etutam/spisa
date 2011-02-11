namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code")]
    public class PuntoVentaType
    {
        private SiNoSimpleType bloqueadoField;
        private DateTime fechaBajaField;
        private bool fechaBajaFieldSpecified;
        private short numeroPuntoVentaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public SiNoSimpleType bloqueado
        {
            get
            {
                return this.bloqueadoField;
            }
            set
            {
                this.bloqueadoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaBaja
        {
            get
            {
                return this.fechaBajaField;
            }
            set
            {
                this.fechaBajaField = value;
            }
        }

        [XmlIgnore]
        public bool fechaBajaSpecified
        {
            get
            {
                return this.fechaBajaFieldSpecified;
            }
            set
            {
                this.fechaBajaFieldSpecified = value;
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

