namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsFEXOutAuthorize
    {
        private string caeField;
        private long cbte_nroField;
        private long cuitField;
        private string fch_cbteField;
        private string fch_venc_CaeField;
        private long idField;
        private string motivos_ObsField;
        private short punto_vtaField;
        private string reprocesoField;
        private string resultadoField;
        private short tipo_cbteField;

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

        public long Cbte_nro
        {
            get
            {
                return this.cbte_nroField;
            }
            set
            {
                this.cbte_nroField = value;
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

        public string Motivos_Obs
        {
            get
            {
                return this.motivos_ObsField;
            }
            set
            {
                this.motivos_ObsField = value;
            }
        }

        public short Punto_vta
        {
            get
            {
                return this.punto_vtaField;
            }
            set
            {
                this.punto_vtaField = value;
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

        public short Tipo_cbte
        {
            get
            {
                return this.tipo_cbteField;
            }
            set
            {
                this.tipo_cbteField = value;
            }
        }
    }
}

