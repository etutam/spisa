namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Item
    {
        private string pro_codigoField;
        private string pro_dsField;
        private double pro_precio_uniField;
        private double pro_qtyField;
        private double pro_total_itemField;
        private int pro_umedField;

        public string Pro_codigo
        {
            get
            {
                return this.pro_codigoField;
            }
            set
            {
                this.pro_codigoField = value;
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

        public double Pro_total_item
        {
            get
            {
                return this.pro_total_itemField;
            }
            set
            {
                this.pro_total_itemField = value;
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

