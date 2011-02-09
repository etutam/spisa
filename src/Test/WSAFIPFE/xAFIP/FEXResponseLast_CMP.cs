namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEXResponseLast_CMP
    {
        private ClsFEXErr fEXErrField;
        private ClsFEXEvents fEXEventsField;
        private ClsFEX_LastCMP_Response fEXResult_LastCMPField;

        public ClsFEXErr FEXErr
        {
            get
            {
                return this.fEXErrField;
            }
            set
            {
                this.fEXErrField = value;
            }
        }

        public ClsFEXEvents FEXEvents
        {
            get
            {
                return this.fEXEventsField;
            }
            set
            {
                this.fEXEventsField = value;
            }
        }

        public ClsFEX_LastCMP_Response FEXResult_LastCMP
        {
            get
            {
                return this.fEXResult_LastCMPField;
            }
            set
            {
                this.fEXResult_LastCMPField = value;
            }
        }
    }
}

