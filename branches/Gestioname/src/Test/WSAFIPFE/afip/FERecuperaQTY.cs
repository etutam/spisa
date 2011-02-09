namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DebuggerStepThrough]
    public class FERecuperaQTY
    {
        private int valueField;

        public int value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}

