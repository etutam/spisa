namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DebuggerStepThrough]
    public class BFEResponse_Umed
    {
        private ClsBFEErr bFEErrField;
        private ClsBFEEvents bFEEventsField;
        private ClsBFEResponse_UMed[] bFEResultGetField;

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

        public ClsBFEResponse_UMed[] BFEResultGet
        {
            get
            {
                return this.bFEResultGetField;
            }
            set
            {
                this.bFEResultGetField = value;
            }
        }
    }
}

