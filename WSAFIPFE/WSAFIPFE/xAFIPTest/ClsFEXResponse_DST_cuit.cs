namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/")]
    public class ClsFEXResponse_DST_cuit
    {
        private long dST_CUITField;
        private string dST_DsField;

        public long DST_CUIT
        {
            get
            {
                return this.dST_CUITField;
            }
            set
            {
                this.dST_CUITField = value;
            }
        }

        public string DST_Ds
        {
            get
            {
                return this.dST_DsField;
            }
            set
            {
                this.dST_DsField = value;
            }
        }
    }
}

