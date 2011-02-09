namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsSEGEvents
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

