namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsBFEResponse_Zon
    {
        private string zon_DsField;
        private short zon_IdField;
        private string zon_vig_desdeField;
        private string zon_vig_hastaField;

        public string Zon_Ds
        {
            get
            {
                return this.zon_DsField;
            }
            set
            {
                this.zon_DsField = value;
            }
        }

        public short Zon_Id
        {
            get
            {
                return this.zon_IdField;
            }
            set
            {
                this.zon_IdField = value;
            }
        }

        public string Zon_vig_desde
        {
            get
            {
                return this.zon_vig_desdeField;
            }
            set
            {
                this.zon_vig_desdeField = value;
            }
        }

        public string Zon_vig_hasta
        {
            get
            {
                return this.zon_vig_hastaField;
            }
            set
            {
                this.zon_vig_hastaField = value;
            }
        }
    }
}

