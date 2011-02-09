namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ArrayProvinciasResponse
    {
        private sbyte codigoProvinciaField;
        private string descripcionProvinciaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public sbyte codigoProvincia
        {
            get
            {
                return this.codigoProvinciaField;
            }
            set
            {
                this.codigoProvinciaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string descripcionProvincia
        {
            get
            {
                return this.descripcionProvinciaField;
            }
            set
            {
                this.descripcionProvinciaField = value;
            }
        }
    }
}

