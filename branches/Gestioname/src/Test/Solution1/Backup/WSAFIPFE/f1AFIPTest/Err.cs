namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Err
    {
        private int codeField;
        private string msgField;

        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }
}

