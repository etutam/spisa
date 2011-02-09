namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class BFEResponse_LastID
    {
        private ClsBFEErr bFEErrField;
        private ClsBFEEvents bFEEventsField;
        private ClsBFEResponse_LastID bFEResultGetField;

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

        public ClsBFEResponse_LastID BFEResultGet
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

