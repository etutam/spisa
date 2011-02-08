namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code"), DebuggerStepThrough]
    public class SEGResponseLast_CMP
    {
        private ClsSEGErr sEGErrField;
        private ClsSEGEvents sEGEventsField;
        private ClsSEG_LastCMP_Response sEGResult_LastCMPField;

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

        public ClsSEG_LastCMP_Response SEGResult_LastCMP
        {
            get
            {
                return this.sEGResult_LastCMPField;
            }
            set
            {
                this.sEGResult_LastCMPField = value;
            }
        }
    }
}

