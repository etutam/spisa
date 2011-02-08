namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsBFEGetCMPR
    {
        private string caeField;
        private long cbte_nroField;
        private long cuitField;
        private string fch_venc_CaeField;
        private string fecha_cbte_caeField;
        private string fecha_cbte_origField;
        private long idField;
        private double imp_iibbField;
        private double imp_internosField;
        private double imp_moneda_ctzField;
        private string imp_moneda_IdField;
        private double imp_netoField;
        private double imp_op_exField;
        private double imp_perc_munField;
        private double imp_percField;
        private double imp_tot_concField;
        private double imp_totalField;
        private double impto_liq_rniField;
        private double impto_liqField;
        private Item[] itemsField;
        private long nro_docField;
        private string obsField;
        private int punto_vtaField;
        private string resultadoField;
        private short tipo_cbteField;
        private short tipo_docField;

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

        public string Fecha_cbte_cae
        {
            get
            {
                return this.fecha_cbte_caeField;
            }
            set
            {
                this.fecha_cbte_caeField = value;
            }
        }

        public string Fecha_cbte_orig
        {
            get
            {
                return this.fecha_cbte_origField;
            }
            set
            {
                this.fecha_cbte_origField = value;
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

        public double Imp_iibb
        {
            get
            {
                return this.imp_iibbField;
            }
            set
            {
                this.imp_iibbField = value;
            }
        }

        public double Imp_internos
        {
            get
            {
                return this.imp_internosField;
            }
            set
            {
                this.imp_internosField = value;
            }
        }

        public double Imp_moneda_ctz
        {
            get
            {
                return this.imp_moneda_ctzField;
            }
            set
            {
                this.imp_moneda_ctzField = value;
            }
        }

        public string Imp_moneda_Id
        {
            get
            {
                return this.imp_moneda_IdField;
            }
            set
            {
                this.imp_moneda_IdField = value;
            }
        }

        public double Imp_neto
        {
            get
            {
                return this.imp_netoField;
            }
            set
            {
                this.imp_netoField = value;
            }
        }

        public double Imp_op_ex
        {
            get
            {
                return this.imp_op_exField;
            }
            set
            {
                this.imp_op_exField = value;
            }
        }

        public double Imp_perc
        {
            get
            {
                return this.imp_percField;
            }
            set
            {
                this.imp_percField = value;
            }
        }

        public double Imp_perc_mun
        {
            get
            {
                return this.imp_perc_munField;
            }
            set
            {
                this.imp_perc_munField = value;
            }
        }

        public double Imp_tot_conc
        {
            get
            {
                return this.imp_tot_concField;
            }
            set
            {
                this.imp_tot_concField = value;
            }
        }

        public double Imp_total
        {
            get
            {
                return this.imp_totalField;
            }
            set
            {
                this.imp_totalField = value;
            }
        }

        public double Impto_liq
        {
            get
            {
                return this.impto_liqField;
            }
            set
            {
                this.impto_liqField = value;
            }
        }

        public double Impto_liq_rni
        {
            get
            {
                return this.impto_liq_rniField;
            }
            set
            {
                this.impto_liq_rniField = value;
            }
        }

        public Item[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        public long Nro_doc
        {
            get
            {
                return this.nro_docField;
            }
            set
            {
                this.nro_docField = value;
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

        public int Punto_vta
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

        public short Tipo_doc
        {
            get
            {
                return this.tipo_docField;
            }
            set
            {
                this.tipo_docField = value;
            }
        }
    }
}

