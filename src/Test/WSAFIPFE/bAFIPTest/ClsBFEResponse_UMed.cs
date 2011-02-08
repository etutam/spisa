namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class ClsBFEResponse_UMed
    {
        private string umed_DsField;
        private short umed_IdField;
        private string umed_vig_desdeField;
        private string umed_vig_hastaField;

        public string Umed_Ds
        {
            get
            {
                return this.umed_DsField;
            }
            set
            {
                this.umed_DsField = value;
            }
        }

        public short Umed_Id
        {
            get
            {
                return this.umed_IdField;
            }
            set
            {
                this.umed_IdField = value;
            }
        }

        public string Umed_vig_desde
        {
            get
            {
                return this.umed_vig_desdeField;
            }
            set
            {
                this.umed_vig_desdeField = value;
            }
        }

        public string Umed_vig_hasta
        {
            get
            {
                return this.umed_vig_hastaField;
            }
            set
            {
                this.umed_vig_hastaField = value;
            }
        }
    }
}

