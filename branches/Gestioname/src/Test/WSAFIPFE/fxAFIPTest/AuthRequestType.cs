namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class AuthRequestType
    {
        private long cuitRepresentadaField;
        private string signField;
        private string tokenField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitRepresentada
        {
            get
            {
                return this.cuitRepresentadaField;
            }
            set
            {
                this.cuitRepresentadaField = value;
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

