namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DebuggerStepThrough]
    public class FERequest
    {
        private FECabeceraRequest fecrField;
        private FEDetalleRequest[] fedrField;

        public FECabeceraRequest Fecr
        {
            get
            {
                return this.fecrField;
            }
            set
            {
                this.fecrField = value;
            }
        }

        public FEDetalleRequest[] Fedr
        {
            get
            {
                return this.fedrField;
            }
            set
            {
                this.fedrField = value;
            }
        }
    }
}

