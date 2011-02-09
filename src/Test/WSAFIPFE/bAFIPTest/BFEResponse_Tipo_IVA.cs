namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DebuggerStepThrough]
    public class BFEResponse_Tipo_IVA
    {
        private ClsBFEErr bFEErrField;
        private ClsBFEEvents bFEEventsField;
        private ClsBFEResponse_Tipo_IVA[] bFEResultGetField;

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

        public ClsBFEResponse_Tipo_IVA[] BFEResultGet
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

