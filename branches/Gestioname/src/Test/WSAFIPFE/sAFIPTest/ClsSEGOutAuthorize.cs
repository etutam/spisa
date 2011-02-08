namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.seg/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsSEGOutAuthorize
    {
        private string caeField;
        private long cuitField;
        private string fch_cbteField;
        private string fch_venc_CaeField;
        private long idField;
        private string obsField;
        private string reprocesoField;
        private string resultadoField;

        public string Cae
        {
            get
            {
                return this.caeField;
            }
            set
            {
                this.caeField = value;
            }
        }

        public long Cuit
        {
            get
            {
                return this.cuitField;
            }
            set
            {
                this.cuitField = value;
            }
        }

        public string Fch_cbte
        {
            get
            {
                return this.fch_cbteField;
            }
            set
            {
                this.fch_cbteField = value;
            }
        }

        public string Fch_venc_Cae
        {
            get
            {
                return this.fch_venc_CaeField;
            }
            set
            {
                this.fch_venc_CaeField = value;
            }
        }

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

        public string Obs
        {
            get
            {
                return this.obsField;
            }
            set
            {
                this.obsField = value;
            }
        }

        public string Reproceso
        {
            get
            {
                return this.reprocesoField;
            }
            set
            {
                this.reprocesoField = value;
            }
        }

        public string Resultado
        {
            get
            {
                return this.resultadoField;
            }
            set
            {
                this.resultadoField = value;
            }
        }
    }
}

