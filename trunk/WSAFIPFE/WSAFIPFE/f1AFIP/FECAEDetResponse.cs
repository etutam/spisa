namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough]
    public class FECAEDetResponse : FEDetResponse
    {
        private string cAEFchVtoField;
        private string cAEField;

        public string CAE
        {
            get
            {
                return this.cAEField;
            }
            set
            {
                this.cAEField = value;
            }
        }

        public string CAEFchVto
        {
            get
            {
                return this.cAEFchVtoField;
            }
            set
            {
                this.cAEFchVtoField = value;
            }
        }
    }
}

