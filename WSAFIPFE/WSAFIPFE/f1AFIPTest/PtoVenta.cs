namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough]
    public class PtoVenta
    {
        private string bloqueadoField;
        private string emisionTipoField;
        private string fchBajaField;
        private short nroField;

        public string Bloqueado
        {
            get
            {
                return this.bloqueadoField;
            }
            set
            {
                this.bloqueadoField = value;
            }
        }

        public string EmisionTipo
        {
            get
            {
                return this.emisionTipoField;
            }
            set
            {
                this.emisionTipoField = value;
            }
        }

        public string FchBaja
        {
            get
            {
                return this.fchBajaField;
            }
            set
            {
                this.fchBajaField = value;
            }
        }

        public short Nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }
    }
}

