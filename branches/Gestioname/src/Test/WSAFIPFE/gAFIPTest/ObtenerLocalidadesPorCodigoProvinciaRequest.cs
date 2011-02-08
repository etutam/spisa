namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ObtenerLocalidadesPorCodigoProvinciaRequest
    {
        private sbyte codigoProvinciaField;

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
    }
}

