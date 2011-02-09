namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), DebuggerStepThrough]
    public class SubtotalIVAType
    {
        private short codigoField;
        private decimal importeField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short codigo
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importe
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

