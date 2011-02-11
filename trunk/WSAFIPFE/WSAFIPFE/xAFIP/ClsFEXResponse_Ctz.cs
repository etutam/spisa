namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.fex/")]
    public class ClsFEXResponse_Ctz
    {
        private double mon_ctzField;
        private string mon_fechaField;

        public double Mon_ctz
        {
            get
            {
                return this.mon_ctzField;
            }
            set
            {
                this.mon_ctzField = value;
            }
        }

        public string Mon_fecha
        {
            get
            {
                return this.mon_fechaField;
            }
            set
            {
                this.mon_fechaField = value;
            }
        }
    }
}

