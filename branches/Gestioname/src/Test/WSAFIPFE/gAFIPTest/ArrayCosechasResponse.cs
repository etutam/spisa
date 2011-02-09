namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), DesignerCategory("code")]
    public class ArrayCosechasResponse
    {
        private string codigoCosechaField;
        private string descripcionCosechaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string codigoCosecha
        {
            get
            {
                return this.codigoCosechaField;
            }
            set
            {
                this.codigoCosechaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string descripcionCosecha
        {
            get
            {
                return this.descripcionCosechaField;
            }
            set
            {
                this.descripcionCosechaField = value;
            }
        }
    }
}

