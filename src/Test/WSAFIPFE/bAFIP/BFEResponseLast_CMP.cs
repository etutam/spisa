namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DesignerCategory("code"), DebuggerStepThrough]
    public class BFEResponseLast_CMP
    {
        private ClsBFEErr bFEErrField;
        private ClsBFEEvents bFEEventsField;
        private ClsBFE_LastCMP_Response bFEResult_LastCMPField;

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

        public ClsBFE_LastCMP_Response BFEResult_LastCMP
        {
            get
            {
                return this.bFEResult_LastCMPField;
            }
            set
            {
                this.bFEResult_LastCMPField = value;
            }
        }
    }
}

