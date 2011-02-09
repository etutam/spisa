namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, DesignerCategory("code")]
    public class ClsFEXResponse_DST_pais
    {
        private string dST_CodigoField;
        private string dST_DsField;

        public string DST_Codigo
        {
            get
            {
                return this.dST_CodigoField;
            }
            set
            {
                this.dST_CodigoField = value;
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

