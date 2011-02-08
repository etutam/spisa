namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FECAEAResponse
    {
        private Err[] errorsField;
        private Evt[] eventsField;
        private FECAEACabResponse feCabRespField;
        private FECAEADetResponse[] feDetRespField;

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

        public FECAEACabResponse FeCabResp
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

        public FECAEADetResponse[] FeDetResp
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

