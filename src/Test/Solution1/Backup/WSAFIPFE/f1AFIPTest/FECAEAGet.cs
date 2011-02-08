namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FECAEAGet
    {
        private string cAEAField;
        private string fchProcesoField;
        private string fchTopeInfField;
        private string fchVigDesdeField;
        private string fchVigHastaField;
        private short ordenField;
        private int periodoField;

        public string CAEA
        {
            get
            {
                return this.cAEAField;
            }
            set
            {
                this.cAEAField = value;
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

        public string FchTopeInf
        {
            get
            {
                return this.fchTopeInfField;
            }
            set
            {
                this.fchTopeInfField = value;
            }
        }

        public string FchVigDesde
        {
            get
            {
                return this.fchVigDesdeField;
            }
            set
            {
                this.fchVigDesdeField = value;
            }
        }

        public string FchVigHasta
        {
            get
            {
                return this.fchVigHastaField;
            }
            set
            {
                this.fchVigHastaField = value;
            }
        }

        public short Orden
        {
            get
            {
                return this.ordenField;
            }
            set
            {
                this.ordenField = value;
            }
        }

        public int Periodo
        {
            get
            {
                return this.periodoField;
            }
            set
            {
                this.periodoField = value;
            }
        }
    }
}

