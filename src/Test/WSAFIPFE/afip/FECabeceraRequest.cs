namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/")]
    public class FECabeceraRequest
    {
        private int cantidadregField;
        private long idField;
        private int presta_servField;

        public int cantidadreg
        {
            get
            {
                return this.cantidadregField;
            }
            set
            {
                this.cantidadregField = value;
            }
        }

        public long id
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

        public int presta_serv
        {
            get
            {
                return this.presta_servField;
            }
            set
            {
                this.presta_servField = value;
            }
        }
    }
}

