namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.fex/")]
    public class ClsFEXGetCMP
    {
        private long cbte_nroField;
        private short punto_vtaField;
        private short tipo_cbteField;

        public long Cbte_nro
        {
            get
            {
                return this.cbte_nroField;
            }
            set
            {
                this.cbte_nroField = value;
            }
        }

        public short Punto_vta
        {
            get
            {
                return this.punto_vtaField;
            }
            set
            {
                this.punto_vtaField = value;
            }
        }

        public short Tipo_cbte
        {
            get
            {
                return this.tipo_cbteField;
            }
            set
            {
                this.tipo_cbteField = value;
            }
        }
    }
}

