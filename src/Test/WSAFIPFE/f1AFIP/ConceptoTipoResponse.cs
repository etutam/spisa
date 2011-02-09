namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ConceptoTipoResponse
    {
        private Err[] errorsField;
        private Evt[] eventsField;
        private ConceptoTipo[] resultGetField;

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

        public ConceptoTipo[] ResultGet
        {
            get
            {
                return this.resultGetField;
            }
            set
            {
                this.resultGetField = value;
            }
        }
    }
}

