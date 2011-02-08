namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
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

