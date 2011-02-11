namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class SEGResponse_LastID
    {
        private ClsSEGErr sEGErrField;
        private ClsSEGEvents sEGEventsField;
        private ClsSEGResponse_LastID sEGResultGetField;

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

        public ClsSEGResponse_LastID SEGResultGet
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

