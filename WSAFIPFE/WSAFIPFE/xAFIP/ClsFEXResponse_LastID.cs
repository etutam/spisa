namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code")]
    public class ClsFEXResponse_LastID
    {
        private long idField;

        public long Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}

