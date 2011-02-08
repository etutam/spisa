namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Familia
    {
        private int cantidadField;
        private string codigoField;

        public int cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
    }
}

