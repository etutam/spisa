namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FEXResponse_Tex
    {
        private ClsFEXErr fEXErrField;
        private ClsFEXEvents fEXEventsField;
        private ClsFEXResponse_Tex[] fEXResultGetField;

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

        public ClsFEXResponse_Tex[] FEXResultGet
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

