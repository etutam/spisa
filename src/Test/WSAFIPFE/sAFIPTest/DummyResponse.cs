namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code")]
    public class DummyResponse
    {
        private string appServerField;
        private string authServerField;
        private string dbServerField;

        public string AppServer
        {
            get
            {
                return this.appServerField;
            }
            set
            {
                this.appServerField = value;
            }
        }

        public string AuthServer
        {
            get
            {
                return this.authServerField;
            }
            set
            {
                this.authServerField = value;
            }
        }

        public string DbServer
        {
            get
            {
                return this.dbServerField;
            }
            set
            {
                this.dbServerField = value;
            }
        }
    }
}

