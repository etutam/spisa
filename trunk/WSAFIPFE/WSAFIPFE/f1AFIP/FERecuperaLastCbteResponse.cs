namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FERecuperaLastCbteResponse
    {
        private int cbteNroField;
        private int cbteTipoField;
        private Err[] errorsField;
        private Evt[] eventsField;
        private int ptoVtaField;

        public int CbteNro
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

        public Err[] Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        public Evt[] Events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
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

