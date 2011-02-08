namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
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

