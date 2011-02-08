namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEDetalleResponse
    {
        private string caeField;
        private long cbt_desdeField;
        private long cbt_hastaField;
        private string fecha_cbteField;
        private string fecha_serv_desdeField;
        private string fecha_serv_hastaField;
        private string fecha_venc_pagoField;
        private string fecha_vtoField;
        private double imp_netoField;
        private double imp_op_exField;
        private double imp_tot_concField;
        private double imp_totalField;
        private double impto_liq_rniField;
        private double impto_liqField;
        private string motivoField;
        private long nro_docField;
        private int punto_vtaField;
        private string resultadoField;
        private int tipo_cbteField;
        private int tipo_docField;

        public string cae
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

        public long cbt_desde
        {
            get
            {
                return this.cbt_desdeField;
            }
            set
            {
                this.cbt_desdeField = value;
            }
        }

        public long cbt_hasta
        {
            get
            {
                return this.cbt_hastaField;
            }
            set
            {
                this.cbt_hastaField = value;
            }
        }

        public string fecha_cbte
        {
            get
            {
                return this.fecha_cbteField;
            }
            set
            {
                this.fecha_cbteField = value;
            }
        }

        public string fecha_serv_desde
        {
            get
            {
                return this.fecha_serv_desdeField;
            }
            set
            {
                this.fecha_serv_desdeField = value;
            }
        }

        public string fecha_serv_hasta
        {
            get
            {
                return this.fecha_serv_hastaField;
            }
            set
            {
                this.fecha_serv_hastaField = value;
            }
        }

        public string fecha_venc_pago
        {
            get
            {
                return this.fecha_venc_pagoField;
            }
            set
            {
                this.fecha_venc_pagoField = value;
            }
        }

        public string fecha_vto
        {
            get
            {
                return this.fecha_vtoField;
            }
            set
            {
                this.fecha_vtoField = value;
            }
        }

        public double imp_neto
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

        public double imp_op_ex
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

        public double imp_tot_conc
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

        public double imp_total
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

        public double impto_liq
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

        public double impto_liq_rni
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

        public string motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
            }
        }

        public long nro_doc
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

        public int punto_vta
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

        public string resultado
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

        public int tipo_cbte
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

        public int tipo_doc
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

