namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsBFEResponse_NCM
    {
        private string nCM_CodigoField;
        private string nCM_DsField;
        private string nCM_NotaField;
        private string nCM_vig_desdeField;
        private string nCM_vig_hastaField;

        public string NCM_Codigo
        {
            get
            {
                return this.nCM_CodigoField;
            }
            set
            {
                this.nCM_CodigoField = value;
            }
        }

        public string NCM_Ds
        {
            get
            {
                return this.nCM_DsField;
            }
            set
            {
                this.nCM_DsField = value;
            }
        }

        public string NCM_Nota
        {
            get
            {
                return this.nCM_NotaField;
            }
            set
            {
                this.nCM_NotaField = value;
            }
        }

        public string NCM_vig_desde
        {
            get
            {
                return this.nCM_vig_desdeField;
            }
            set
            {
                this.nCM_vig_desdeField = value;
            }
        }

        public string NCM_vig_hasta
        {
            get
            {
                return this.nCM_vig_hastaField;
            }
            set
            {
                this.nCM_vig_hastaField = value;
            }
        }
    }
}

