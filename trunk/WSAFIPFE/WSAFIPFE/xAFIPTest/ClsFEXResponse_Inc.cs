namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsFEXResponse_Inc
    {
        private string inc_DsField;
        private string inc_IdField;
        private string inc_vig_desdeField;
        private string inc_vig_hastaField;

        public string Inc_Ds
        {
            get
            {
                return this.inc_DsField;
            }
            set
            {
                this.inc_DsField = value;
            }
        }

        public string Inc_Id
        {
            get
            {
                return this.inc_IdField;
            }
            set
            {
                this.inc_IdField = value;
            }
        }

        public string Inc_vig_desde
        {
            get
            {
                return this.inc_vig_desdeField;
            }
            set
            {
                this.inc_vig_desdeField = value;
            }
        }

        public string Inc_vig_hasta
        {
            get
            {
                return this.inc_vig_hastaField;
            }
            set
            {
                this.inc_vig_hastaField = value;
            }
        }
    }
}

