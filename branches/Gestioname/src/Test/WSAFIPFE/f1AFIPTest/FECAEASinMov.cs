namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(FECAEASinMovResponse))]
    public class FECAEASinMov
    {
        private string cAEAField;
        private string fchProcesoField;
        private int ptoVtaField;

        public string CAEA
        {
            get
            {
                return this.cAEAField;
            }
            set
            {
                this.cAEAField = value;
            }
        }

        public string FchProceso
        {
            get
            {
                return this.fchProcesoField;
            }
            set
            {
                this.fchProcesoField = value;
            }
        }

        public int PtoVta
        {
            get
            {
                return this.ptoVtaField;
            }
            set
            {
                this.ptoVtaField = value;
            }
        }
    }
}

