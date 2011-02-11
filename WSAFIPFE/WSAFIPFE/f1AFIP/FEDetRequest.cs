namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), XmlInclude(typeof(FECompConsResponse)), XmlInclude(typeof(FECAEDetRequest)), XmlInclude(typeof(FECAEADetRequest))]
    public class FEDetRequest
    {
        private long cbteDesdeField;
        private string cbteFchField;
        private long cbteHastaField;
        private CbteAsoc[] cbtesAsocField;
        private int conceptoField;
        private long docNroField;
        private int docTipoField;
        private string fchServDesdeField;
        private string fchServHastaField;
        private string fchVtoPagoField;
        private double impIVAField;
        private double impNetoField;
        private double impOpExField;
        private double impTotalField;
        private double impTotConcField;
        private double impTribField;
        private AlicIva[] ivaField;
        private double monCotizField;
        private string monIdField;
        private Opcional[] opcionalesField;
        private Tributo[] tributosField;

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

        public CbteAsoc[] CbtesAsoc
        {
            get
            {
                return this.cbtesAsocField;
            }
            set
            {
                this.cbtesAsocField = value;
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

        public string FchServDesde
        {
            get
            {
                return this.fchServDesdeField;
            }
            set
            {
                this.fchServDesdeField = value;
            }
        }

        public string FchServHasta
        {
            get
            {
                return this.fchServHastaField;
            }
            set
            {
                this.fchServHastaField = value;
            }
        }

        public string FchVtoPago
        {
            get
            {
                return this.fchVtoPagoField;
            }
            set
            {
                this.fchVtoPagoField = value;
            }
        }

        public double ImpIVA
        {
            get
            {
                return this.impIVAField;
            }
            set
            {
                this.impIVAField = value;
            }
        }

        public double ImpNeto
        {
            get
            {
                return this.impNetoField;
            }
            set
            {
                this.impNetoField = value;
            }
        }

        public double ImpOpEx
        {
            get
            {
                return this.impOpExField;
            }
            set
            {
                this.impOpExField = value;
            }
        }

        public double ImpTotal
        {
            get
            {
                return this.impTotalField;
            }
            set
            {
                this.impTotalField = value;
            }
        }

        public double ImpTotConc
        {
            get
            {
                return this.impTotConcField;
            }
            set
            {
                this.impTotConcField = value;
            }
        }

        public double ImpTrib
        {
            get
            {
                return this.impTribField;
            }
            set
            {
                this.impTribField = value;
            }
        }

        public AlicIva[] Iva
        {
            get
            {
                return this.ivaField;
            }
            set
            {
                this.ivaField = value;
            }
        }

        public double MonCotiz
        {
            get
            {
                return this.monCotizField;
            }
            set
            {
                this.monCotizField = value;
            }
        }

        public string MonId
        {
            get
            {
                return this.monIdField;
            }
            set
            {
                this.monIdField = value;
            }
        }

        public Opcional[] Opcionales
        {
            get
            {
                return this.opcionalesField;
            }
            set
            {
                this.opcionalesField = value;
            }
        }

        public Tributo[] Tributos
        {
            get
            {
                return this.tributosField;
            }
            set
            {
                this.tributosField = value;
            }
        }
    }
}

