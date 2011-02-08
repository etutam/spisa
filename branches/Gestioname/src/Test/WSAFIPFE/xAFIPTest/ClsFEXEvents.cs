namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsFEXEvents
    {
        private int eventCodeField;
        private string eventMsgField;

        public int EventCode
        {
            get
            {
                return this.eventCodeField;
            }
            set
            {
                this.eventCodeField = value;
            }
        }

        public string EventMsg
        {
            get
            {
                return this.eventMsgField;
            }
            set
            {
                this.eventMsgField = value;
            }
        }
    }
}

