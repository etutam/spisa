namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FECompConsResponse : FECAEDetRequest
    {
        private int cbteTipoField;
        private string codAutorizacionField;
        private string emisionTipoField;
        private string fchProcesoField;
        private string fchVtoField;
        private Obs[] observacionesField;
        private int ptoVtaField;
        private string resultadoField;

        public int CbteTipo
        {
            get
            {
                return this.cbteTipoField;
            }
            set
            {
                this.cbteTipoField = value;
            }
        }

        public string CodAutorizacion
        {
            get
            {
                return this.codAutorizacionField;
            }
            set
            {
                this.codAutorizacionField = value;
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

        public string FchProceso
        {
            get
            {
                return this.fchProcesoField;
            }
            set
            {
                this.fchProcesoField = value;
            }
        }

        public string FchVto
        {
            get
            {
                return this.fchVtoField;
            }
            set
            {
                this.fchVtoField = value;
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

        public int PtoVta
        {
            get
            {
                return this.ptoVtaField;
            }
            set
            {
                this.ptoVtaField = value;
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

