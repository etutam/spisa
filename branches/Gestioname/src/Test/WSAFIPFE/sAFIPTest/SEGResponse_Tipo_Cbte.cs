namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.seg/"), DesignerCategory("code"), DebuggerStepThrough]
    public class SEGResponse_Tipo_Cbte
    {
        private ClsSEGErr sEGErrField;
        private ClsSEGEvents sEGEventsField;
        private ClsSEGResponse_Tipo_Cbte[] sEGResultGetField;

        public ClsSEGErr SEGErr
        {
            get
            {
                return this.sEGErrField;
            }
            set
            {
                this.sEGErrField = value;
            }
        }

        public ClsSEGEvents SEGEvents
        {
            get
            {
                return this.sEGEventsField;
            }
            set
            {
                this.sEGEventsField = value;
            }
        }

        public ClsSEGResponse_Tipo_Cbte[] SEGResultGet
        {
            get
            {
                return this.sEGResultGetField;
            }
            set
            {
                this.sEGResultGetField = value;
            }
        }
    }
}

