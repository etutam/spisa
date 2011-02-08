namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), XmlInclude(typeof(FECAEADetResponse)), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlInclude(typeof(FECAEDetResponse))]
    public class FEDetResponse
    {
        private long cbteDesdeField;
        private string cbteFchField;
        private long cbteHastaField;
        private int conceptoField;
        private long docNroField;
        private int docTipoField;
        private Obs[] observacionesField;
        private string resultadoField;

        public long CbteDesde
        {
            get
            {
                return this.cbteDesdeField;
            }
            set
            {
                this.cbteDesdeField = value;
            }
        }

        public string CbteFch
        {
            get
            {
                return this.cbteFchField;
            }
            set
            {
                this.cbteFchField = value;
            }
        }

        public long CbteHasta
        {
            get
            {
                return this.cbteHastaField;
            }
            set
            {
                this.cbteHastaField = value;
            }
        }

        public int Concepto
        {
            get
            {
                return this.conceptoField;
            }
            set
            {
                this.conceptoField = value;
            }
        }

        public long DocNro
        {
            get
            {
                return this.docNroField;
            }
            set
            {
                this.docNroField = value;
            }
        }

        public int DocTipo
        {
            get
            {
                return this.docTipoField;
            }
            set
            {
                this.docTipoField = value;
            }
        }

        public Obs[] Observaciones
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

        public string Resultado
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

