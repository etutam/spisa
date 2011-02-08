namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ArrayEspeciesResponse
    {
        private int codigoEspecieField;
        private string descripcionEspecieField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int codigoEspecie
        {
            get
            {
                return this.codigoEspecieField;
            }
            set
            {
                this.codigoEspecieField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string descripcionEspecie
        {
            get
            {
                return this.descripcionEspecieField;
            }
            set
            {
                this.descripcionEspecieField = value;
            }
        }
    }
}

