﻿namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class ClsFEXErr
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

