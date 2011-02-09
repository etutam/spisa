namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ConfirmarCTGResponse
    {
        private long codigoTransaccionField;
        private string observacionesField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long codigoTransaccion
        {
            get
            {
                return this.codigoTransaccionField;
            }
            set
            {
                this.codigoTransaccionField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
    }
}

