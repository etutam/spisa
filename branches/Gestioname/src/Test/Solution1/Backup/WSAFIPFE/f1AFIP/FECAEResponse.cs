namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough]
    public class FECAEResponse
    {
        private Err[] errorsField;
        private Evt[] eventsField;
        private FECAECabResponse feCabRespField;
        private FECAEDetResponse[] feDetRespField;

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

        public FECAECabResponse FeCabResp
        {
            get
            {
                return this.feCabRespField;
            }
            set
            {
                this.feCabRespField = value;
            }
        }

        public FECAEDetResponse[] FeDetResp
        {
            get
            {
                return this.feDetRespField;
            }
            set
            {
                this.feDetRespField = value;
            }
        }
    }
}

