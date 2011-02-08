namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class Item
    {
        private double imp_bonifField;
        private double imp_totalField;
        private short iva_idField;
        private string pro_codigo_ncmField;
        private string pro_codigo_secField;
        private string pro_dsField;
        private double pro_precio_uniField;
        private double pro_qtyField;
        private int pro_umedField;

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

        public string Pro_codigo_ncm
        {
            get
            {
                return this.pro_codigo_ncmField;
            }
            set
            {
                this.pro_codigo_ncmField = value;
            }
        }

        public string Pro_codigo_sec
        {
            get
            {
                return this.pro_codigo_secField;
            }
            set
            {
                this.pro_codigo_secField = value;
            }
        }

        public string Pro_ds
        {
            get
            {
                return this.pro_dsField;
            }
            set
            {
                this.pro_dsField = value;
            }
        }

        public double Pro_precio_uni
        {
            get
            {
                return this.pro_precio_uniField;
            }
            set
            {
                this.pro_precio_uniField = value;
            }
        }

        public double Pro_qty
        {
            get
            {
                return this.pro_qtyField;
            }
            set
            {
                this.pro_qtyField = value;
            }
        }

        public int Pro_umed
        {
            get
            {
                return this.pro_umedField;
            }
            set
            {
                this.pro_umedField = value;
            }
        }
    }
}

