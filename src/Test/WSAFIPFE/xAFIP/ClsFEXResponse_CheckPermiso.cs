﻿namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ClsFEXResponse_CheckPermiso
    {
        private string statusField;

        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
}
