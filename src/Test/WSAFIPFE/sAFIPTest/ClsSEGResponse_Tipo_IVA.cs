namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsSEGResponse_Tipo_IVA
    {
        private string iVA_DsField;
        private short iVA_IdField;
        private string iVA_vig_desdeField;
        private string iVA_vig_hastaField;

        public string IVA_Ds
        {
            get
            {
                return this.iVA_DsField;
            }
            set
            {
                this.iVA_DsField = value;
            }
        }

        public short IVA_Id
        {
            get
            {
                return this.iVA_IdField;
            }
            set
            {
                this.iVA_IdField = value;
            }
        }

        public string IVA_vig_desde
        {
            get
            {
                return this.iVA_vig_desdeField;
            }
            set
            {
                this.iVA_vig_desdeField = value;
            }
        }

        public string IVA_vig_hasta
        {
            get
            {
                return this.iVA_vig_hastaField;
            }
            set
            {
                this.iVA_vig_hastaField = value;
            }
        }
    }
}

