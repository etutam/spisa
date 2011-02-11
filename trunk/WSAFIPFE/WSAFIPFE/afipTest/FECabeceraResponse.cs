namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DesignerCategory("code")]
    public class FECabeceraResponse
    {
        private int cantidadregField;
        private long cuitField;
        private string fecha_caeField;
        private long idField;
        private string motivoField;
        private int presta_servField;
        private string reprocesoField;
        private string resultadoField;

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

        public long cuit
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

        public string fecha_cae
        {
            get
            {
                return this.fecha_caeField;
            }
            set
            {
                this.fecha_caeField = value;
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

        public string motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
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

        public string reproceso
        {
            get
            {
                return this.reprocesoField;
            }
            set
            {
                this.reprocesoField = value;
            }
        }

        public string resultado
        {
            get
            {
                return this.resultadoField;
            }
            set
            {
                this.resultadoField = value;
            }
        }
    }
}

