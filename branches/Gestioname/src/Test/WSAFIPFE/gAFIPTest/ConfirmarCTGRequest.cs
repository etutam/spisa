namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ConfirmarCTGRequest
    {
        private long cuitTransportistaField;
        private long numeroCartaDePorteField;
        private long numeroCTGField;
        private long pesoNetoCargaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitTransportista
        {
            get
            {
                return this.cuitTransportistaField;
            }
            set
            {
                this.cuitTransportistaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long numeroCartaDePorte
        {
            get
            {
                return this.numeroCartaDePorteField;
            }
            set
            {
                this.numeroCartaDePorteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long numeroCTG
        {
            get
            {
                return this.numeroCTGField;
            }
            set
            {
                this.numeroCTGField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long pesoNetoCarga
        {
            get
            {
                return this.pesoNetoCargaField;
            }
            set
            {
                this.pesoNetoCargaField = value;
            }
        }
    }
}

