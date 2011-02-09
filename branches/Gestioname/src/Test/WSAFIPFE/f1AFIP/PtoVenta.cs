namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
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

