namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsBFE_LastCMP_Response
    {
        private string cbte_fechaField;
        private long cbte_nroField;

        public string Cbte_fecha
        {
            get
            {
                return this.cbte_fechaField;
            }
            set
            {
                this.cbte_fechaField = value;
            }
        }

        public long Cbte_nro
        {
            get
            {
                return this.cbte_nroField;
            }
            set
            {
                this.cbte_nroField = value;
            }
        }
    }
}

