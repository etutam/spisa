namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class SEGResponseAuthorize
    {
        private ClsSEGErr sEGErrField;
        private ClsSEGEvents sEGEventsField;
        private ClsSEGOutAuthorize sEGResultAuthField;

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

        public ClsSEGOutAuthorize SEGResultAuth
        {
            get
            {
                return this.sEGResultAuthField;
            }
            set
            {
                this.sEGResultAuthField = value;
            }
        }
    }
}

