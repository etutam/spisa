namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FEXResponseAuthorize
    {
        private ClsFEXErr fEXErrField;
        private ClsFEXEvents fEXEventsField;
        private ClsFEXOutAuthorize fEXResultAuthField;

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

        public ClsFEXOutAuthorize FEXResultAuth
        {
            get
            {
                return this.fEXResultAuthField;
            }
            set
            {
                this.fEXResultAuthField = value;
            }
        }
    }
}

