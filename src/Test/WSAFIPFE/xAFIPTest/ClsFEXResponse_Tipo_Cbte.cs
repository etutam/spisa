namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsFEXResponse_Tipo_Cbte
    {
        private string cbte_DsField;
        private short cbte_IdField;
        private string cbte_vig_desdeField;
        private string cbte_vig_hastaField;

        public string Cbte_Ds
        {
            get
            {
                return this.cbte_DsField;
            }
            set
            {
                this.cbte_DsField = value;
            }
        }

        public short Cbte_Id
        {
            get
            {
                return this.cbte_IdField;
            }
            set
            {
                this.cbte_IdField = value;
            }
        }

        public string Cbte_vig_desde
        {
            get
            {
                return this.cbte_vig_desdeField;
            }
            set
            {
                this.cbte_vig_desdeField = value;
            }
        }

        public string Cbte_vig_hasta
        {
            get
            {
                return this.cbte_vig_hastaField;
            }
            set
            {
                this.cbte_vig_hastaField = value;
            }
        }
    }
}

