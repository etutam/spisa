namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FECompConsultaReq
    {
        private long cbteNroField;
        private int cbteTipoField;
        private int ptoVtaField;

        public long CbteNro
        {
            get
            {
                return this.cbteNroField;
            }
            set
            {
                this.cbteNroField = value;
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

