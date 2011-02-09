namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code")]
    public class FELastCMPtype
    {
        private int ptoVtaField;
        private int tipoCbteField;

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

        public int TipoCbte
        {
            get
            {
                return this.tipoCbteField;
            }
            set
            {
                this.tipoCbteField = value;
            }
        }
    }
}

