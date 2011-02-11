namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FECAEASinMovResponse : FECAEASinMov
    {
        private Err[] errorsField;
        private Evt[] eventsField;
        private string resultadoField;

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

