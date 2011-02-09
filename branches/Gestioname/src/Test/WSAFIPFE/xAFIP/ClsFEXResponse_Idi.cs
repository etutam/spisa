namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code")]
    public class ClsFEXResponse_Idi
    {
        private string idi_DsField;
        private short idi_IdField;
        private string idi_vig_desdeField;
        private string idi_vig_hastaField;

        public string Idi_Ds
        {
            get
            {
                return this.idi_DsField;
            }
            set
            {
                this.idi_DsField = value;
            }
        }

        public short Idi_Id
        {
            get
            {
                return this.idi_IdField;
            }
            set
            {
                this.idi_IdField = value;
            }
        }

        public string Idi_vig_desde
        {
            get
            {
                return this.idi_vig_desdeField;
            }
            set
            {
                this.idi_vig_desdeField = value;
            }
        }

        public string Idi_vig_hasta
        {
            get
            {
                return this.idi_vig_hastaField;
            }
            set
            {
                this.idi_vig_hastaField = value;
            }
        }
    }
}

