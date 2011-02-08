namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FEConsultaCAEReq
    {
        private string caeField;
        private long cbt_nroField;
        private long cuit_emisorField;
        private string fecha_cbteField;
        private double imp_totalField;
        private int punto_vtaField;
        private int tipo_cbteField;

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

        public long cbt_nro
        {
            get
            {
                return this.cbt_nroField;
            }
            set
            {
                this.cbt_nroField = value;
            }
        }

        public long cuit_emisor
        {
            get
            {
                return this.cuit_emisorField;
            }
            set
            {
                this.cuit_emisorField = value;
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
    }
}

