namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsFEXResponse_Tex
    {
        private string tex_DsField;
        private short tex_IdField;
        private string tex_vig_desdeField;
        private string tex_vig_hastaField;

        public string Tex_Ds
        {
            get
            {
                return this.tex_DsField;
            }
            set
            {
                this.tex_DsField = value;
            }
        }

        public short Tex_Id
        {
            get
            {
                return this.tex_IdField;
            }
            set
            {
                this.tex_IdField = value;
            }
        }

        public string Tex_vig_desde
        {
            get
            {
                return this.tex_vig_desdeField;
            }
            set
            {
                this.tex_vig_desdeField = value;
            }
        }

        public string Tex_vig_hasta
        {
            get
            {
                return this.tex_vig_hastaField;
            }
            set
            {
                this.tex_vig_hastaField = value;
            }
        }
    }
}

