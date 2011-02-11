namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEXGetCMPResponse
    {
        private ClsFEXErr fEXErrField;
        private ClsFEXEvents fEXEventsField;
        private ClsFEXGetCMPR fEXResultGetField;

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

        public ClsFEXGetCMPR FEXResultGet
        {
            get
            {
                return this.fEXResultGetField;
            }
            set
            {
                this.fEXResultGetField = value;
            }
        }
    }
}

