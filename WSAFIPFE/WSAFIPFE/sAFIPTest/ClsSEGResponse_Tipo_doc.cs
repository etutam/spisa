namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.seg/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsSEGResponse_Tipo_doc
    {
        private string doc_DsField;
        private short doc_IdField;
        private string doc_vig_desdeField;
        private string doc_vig_hastaField;

        public string Doc_Ds
        {
            get
            {
                return this.doc_DsField;
            }
            set
            {
                this.doc_DsField = value;
            }
        }

        public short Doc_Id
        {
            get
            {
                return this.doc_IdField;
            }
            set
            {
                this.doc_IdField = value;
            }
        }

        public string Doc_vig_desde
        {
            get
            {
                return this.doc_vig_desdeField;
            }
            set
            {
                this.doc_vig_desdeField = value;
            }
        }

        public string Doc_vig_hasta
        {
            get
            {
                return this.doc_vig_hastaField;
            }
            set
            {
                this.doc_vig_hastaField = value;
            }
        }
    }
}

