namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsFEXGetCMPR
    {
        private string caeField;
        private long cbte_nroField;
        private string clienteField;
        private Cmp_asoc[] cmps_asocField;
        private long cuit_pais_clienteField;
        private string domicilio_clienteField;
        private short dst_cmpField;
        private string fch_venc_CaeField;
        private string fecha_cbte_caeField;
        private string fecha_cbteField;
        private string forma_pagoField;
        private string id_impositivoField;
        private long idField;
        private short idioma_cbteField;
        private double imp_totalField;
        private string incoterms_DsField;
        private string incotermsField;
        private Item[] itemsField;
        private double moneda_ctzField;
        private string moneda_IdField;
        private string motivos_ObsField;
        private string obs_comercialesField;
        private string obsField;
        private string permiso_existenteField;
        private Permiso[] permisosField;
        private short punto_vtaField;
        private string resultadoField;
        private short tipo_cbteField;
        private short tipo_expoField;

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

        public string Cliente
        {
            get
            {
                return this.clienteField;
            }
            set
            {
                this.clienteField = value;
            }
        }

        public Cmp_asoc[] Cmps_asoc
        {
            get
            {
                return this.cmps_asocField;
            }
            set
            {
                this.cmps_asocField = value;
            }
        }

        public long Cuit_pais_cliente
        {
            get
            {
                return this.cuit_pais_clienteField;
            }
            set
            {
                this.cuit_pais_clienteField = value;
            }
        }

        public string Domicilio_cliente
        {
            get
            {
                return this.domicilio_clienteField;
            }
            set
            {
                this.domicilio_clienteField = value;
            }
        }

        public short Dst_cmp
        {
            get
            {
                return this.dst_cmpField;
            }
            set
            {
                this.dst_cmpField = value;
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

        public string Fecha_cbte
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

        public string Forma_pago
        {
            get
            {
                return this.forma_pagoField;
            }
            set
            {
                this.forma_pagoField = value;
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

        public string Id_impositivo
        {
            get
            {
                return this.id_impositivoField;
            }
            set
            {
                this.id_impositivoField = value;
            }
        }

        public short Idioma_cbte
        {
            get
            {
                return this.idioma_cbteField;
            }
            set
            {
                this.idioma_cbteField = value;
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

        public string Incoterms
        {
            get
            {
                return this.incotermsField;
            }
            set
            {
                this.incotermsField = value;
            }
        }

        public string Incoterms_Ds
        {
            get
            {
                return this.incoterms_DsField;
            }
            set
            {
                this.incoterms_DsField = value;
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

        public double Moneda_ctz
        {
            get
            {
                return this.moneda_ctzField;
            }
            set
            {
                this.moneda_ctzField = value;
            }
        }

        public string Moneda_Id
        {
            get
            {
                return this.moneda_IdField;
            }
            set
            {
                this.moneda_IdField = value;
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

        public string Obs_comerciales
        {
            get
            {
                return this.obs_comercialesField;
            }
            set
            {
                this.obs_comercialesField = value;
            }
        }

        public string Permiso_existente
        {
            get
            {
                return this.permiso_existenteField;
            }
            set
            {
                this.permiso_existenteField = value;
            }
        }

        public Permiso[] Permisos
        {
            get
            {
                return this.permisosField;
            }
            set
            {
                this.permisosField = value;
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

        public short Tipo_expo
        {
            get
            {
                return this.tipo_expoField;
            }
            set
            {
                this.tipo_expoField = value;
            }
        }
    }
}

