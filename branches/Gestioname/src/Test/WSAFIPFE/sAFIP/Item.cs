namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Item
    {
        private string dsField;
        private string endosoField;
        private double imp_bonifField;
        private string imp_moneda_vasegField;
        private double imp_totalField;
        private double imp_valor_asegField;
        private short iva_idField;
        private string polizaField;
        private double precio_uniField;
        private double qtyField;

        public string Ds
        {
            get
            {
                return this.dsField;
            }
            set
            {
                this.dsField = value;
            }
        }

        public string Endoso
        {
            get
            {
                return this.endosoField;
            }
            set
            {
                this.endosoField = value;
            }
        }

        public double Imp_bonif
        {
            get
            {
                return this.imp_bonifField;
            }
            set
            {
                this.imp_bonifField = value;
            }
        }

        public string Imp_moneda_vaseg
        {
            get
            {
                return this.imp_moneda_vasegField;
            }
            set
            {
                this.imp_moneda_vasegField = value;
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

        public double Imp_valor_aseg
        {
            get
            {
                return this.imp_valor_asegField;
            }
            set
            {
                this.imp_valor_asegField = value;
            }
        }

        public short Iva_id
        {
            get
            {
                return this.iva_idField;
            }
            set
            {
                this.iva_idField = value;
            }
        }

        public string Poliza
        {
            get
            {
                return this.polizaField;
            }
            set
            {
                this.polizaField = value;
            }
        }

        public double Precio_uni
        {
            get
            {
                return this.precio_uniField;
            }
            set
            {
                this.precio_uniField = value;
            }
        }

        public double Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }
}

