namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class Recibo
    {
        private int codErrorField;
        private string descErrorField;

        public int codError
        {
            get
            {
                return this.codErrorField;
            }
            set
            {
                this.codErrorField = value;
            }
        }

        public string descError
        {
            get
            {
                return this.descErrorField;
            }
            set
            {
                this.descErrorField = value;
            }
        }
    }
}

