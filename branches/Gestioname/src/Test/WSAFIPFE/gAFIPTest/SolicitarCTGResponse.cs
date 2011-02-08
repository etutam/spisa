namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class SolicitarCTGResponse
    {
        private long numeroCartaDePorteField;
        private long numeroCTGField;

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
    }
}

