namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), XmlInclude(typeof(FECAECabResponse)), XmlInclude(typeof(FECAEACabResponse)), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code")]
    public class FECabResponse
    {
        private int cantRegField;
        private int cbteTipoField;
        private long cuitField;
        private string fchProcesoField;
        private int ptoVtaField;
        private string reprocesoField;
        private string resultadoField;

        public int CantReg
        {
            get
            {
                return this.cantRegField;
            }
            set
            {
                this.cantRegField = value;
            }
        }

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

        public long Cuit
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

        public string Reproceso
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

