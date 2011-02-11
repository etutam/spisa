namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class AlicIva
    {
        private double baseImpField;
        private int idField;
        private double importeField;

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

        public int Id
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

