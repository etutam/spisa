namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, DesignerCategory("code")]
    public class ClsBFEErr
    {
        private int errCodeField;
        private string errMsgField;

        public int ErrCode
        {
            get
            {
                return this.errCodeField;
            }
            set
            {
                this.errCodeField = value;
            }
        }

        public string ErrMsg
        {
            get
            {
                return this.errMsgField;
            }
            set
            {
                this.errMsgField = value;
            }
        }
    }
}

