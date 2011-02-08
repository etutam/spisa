namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class DummyResponseType
    {
        private string appserverField;
        private string authserverField;
        private string dbserverField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string appserver
        {
            get
            {
                return this.appserverField;
            }
            set
            {
                this.appserverField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string authserver
        {
            get
            {
                return this.authserverField;
            }
            set
            {
                this.authserverField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string dbserver
        {
            get
            {
                return this.dbserverField;
            }
            set
            {
                this.dbserverField = value;
            }
        }
    }
}

