namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class Autenticacion
    {
        private string cuitField;
        private string rolField;
        private string signField;
        private string tipoAgenteField;
        private string tokenField;

        public string Cuit
        {
            get
            {
                return this.cuitField;
            }
            set
            {
                this.cuitField = value;
            }
        }

        public string Rol
        {
            get
            {
                return this.rolField;
            }
            set
            {
                this.rolField = value;
            }
        }

        public string Sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }

        public string TipoAgente
        {
            get
            {
                return this.tipoAgenteField;
            }
            set
            {
                this.tipoAgenteField = value;
            }
        }

        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }
}

