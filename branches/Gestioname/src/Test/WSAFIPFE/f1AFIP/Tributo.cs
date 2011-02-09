namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Tributo
    {
        private double alicField;
        private double baseImpField;
        private string descField;
        private short idField;
        private double importeField;

        public double Alic
        {
            get
            {
                return this.alicField;
            }
            set
            {
                this.alicField = value;
            }
        }

        public double BaseImp
        {
            get
            {
                return this.baseImpField;
            }
            set
            {
                this.baseImpField = value;
            }
        }

        public string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        public short Id
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

        public double Importe
        {
            get
            {
                return this.importeField;
            }
            set
            {
                this.importeField = value;
            }
        }
    }
}

