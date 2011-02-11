namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/")]
    public class FEConsultaCAEResponse
    {
        private vError rErrorField;
        private int resultadoField;

        public vError RError
        {
            get
            {
                return this.rErrorField;
            }
            set
            {
                this.rErrorField = value;
            }
        }

        public int Resultado
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

