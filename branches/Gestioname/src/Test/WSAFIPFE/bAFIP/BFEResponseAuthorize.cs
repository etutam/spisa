namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class BFEResponseAuthorize
    {
        private ClsBFEErr bFEErrField;
        private ClsBFEEvents bFEEventsField;
        private ClsBFEOutAuthorize bFEResultAuthField;

        public ClsBFEErr BFEErr
        {
            get
            {
                return this.bFEErrField;
            }
            set
            {
                this.bFEErrField = value;
            }
        }

        public ClsBFEEvents BFEEvents
        {
            get
            {
                return this.bFEEventsField;
            }
            set
            {
                this.bFEEventsField = value;
            }
        }

        public ClsBFEOutAuthorize BFEResultAuth
        {
            get
            {
                return this.bFEResultAuthField;
            }
            set
            {
                this.bFEResultAuthField = value;
            }
        }
    }
}

