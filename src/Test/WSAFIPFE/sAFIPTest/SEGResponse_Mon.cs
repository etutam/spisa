namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.seg/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class SEGResponse_Mon
    {
        private ClsSEGErr sEGErrField;
        private ClsSEGEvents sEGEventsField;
        private ClsSEGResponse_Mon[] sEGResultGetField;

        public ClsSEGErr SEGErr
        {
            get
            {
                return this.sEGErrField;
            }
            set
            {
                this.sEGErrField = value;
            }
        }

        public ClsSEGEvents SEGEvents
        {
            get
            {
                return this.sEGEventsField;
            }
            set
            {
                this.sEGEventsField = value;
            }
        }

        public ClsSEGResponse_Mon[] SEGResultGet
        {
            get
            {
                return this.sEGResultGetField;
            }
            set
            {
                this.sEGResultGetField = value;
            }
        }
    }
}

