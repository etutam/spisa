namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class AuthRequest
    {
        private long cuitRepresentadoField;
        private string signField;
        private string tokenField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitRepresentado
        {
            get
            {
                return this.cuitRepresentadoField;
            }
            set
            {
                this.cuitRepresentadoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }
}

