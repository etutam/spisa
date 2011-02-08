namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Cotizacion
    {
        private string fchCotizField;
        private double monCotizField;
        private string monIdField;

        public string FchCotiz
        {
            get
            {
                return this.fchCotizField;
            }
            set
            {
                this.fchCotizField = value;
            }
        }

        public double MonCotiz
        {
            get
            {
                return this.monCotizField;
            }
            set
            {
                this.monCotizField = value;
            }
        }

        public string MonId
        {
            get
            {
                return this.monIdField;
            }
            set
            {
                this.monIdField = value;
            }
        }
    }
}

