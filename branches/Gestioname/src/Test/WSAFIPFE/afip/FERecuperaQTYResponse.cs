namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code")]
    public class FERecuperaQTYResponse
    {
        private FERecuperaQTY qtyField;
        private vError rErrorField;

        public FERecuperaQTY qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }

        public vError RError
        {
            get
            {
                return this.rErrorField;
            }
            set
            {
                this.rErrorField = value;
            }
        }
    }
}

