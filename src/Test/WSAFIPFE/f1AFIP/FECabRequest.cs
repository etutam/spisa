namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), XmlInclude(typeof(FECAEACabRequest)), GeneratedCode("System.Xml", "2.0.50727.3053"), XmlInclude(typeof(FECAECabRequest))]
    public class FECabRequest
    {
        private int cantRegField;
        private int cbteTipoField;
        private int ptoVtaField;

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
    }
}

