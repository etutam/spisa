namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEAuthRequest
    {
        private long cuitField;
        private string signField;
        private string tokenField;

        public long Cuit
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

        public string Sign
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

        public string Token
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

