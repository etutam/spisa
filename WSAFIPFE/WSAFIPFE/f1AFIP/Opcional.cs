namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class Opcional
    {
        private string idField;
        private string valorField;

        public string Id
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

        public string Valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }
    }
}

