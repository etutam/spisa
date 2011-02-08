namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DesignerCategory("code")]
    public class vError
    {
        private int percodeField;
        private string perrmsgField;

        public int percode
        {
            get
            {
                return this.percodeField;
            }
            set
            {
                this.percodeField = value;
            }
        }

        public string perrmsg
        {
            get
            {
                return this.perrmsgField;
            }
            set
            {
                this.perrmsgField = value;
            }
        }
    }
}

