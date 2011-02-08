namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.fex/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsFEXResponse_PtoVenta
    {
        private string pve_BloqueadoField;
        private string pve_FchBajaField;
        private short pve_NroField;

        public string Pve_Bloqueado
        {
            get
            {
                return this.pve_BloqueadoField;
            }
            set
            {
                this.pve_BloqueadoField = value;
            }
        }

        public string Pve_FchBaja
        {
            get
            {
                return this.pve_FchBajaField;
            }
            set
            {
                this.pve_FchBajaField = value;
            }
        }

        public short Pve_Nro
        {
            get
            {
                return this.pve_NroField;
            }
            set
            {
                this.pve_NroField = value;
            }
        }
    }
}

