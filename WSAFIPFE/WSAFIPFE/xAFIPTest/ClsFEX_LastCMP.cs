﻿namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class ClsFEX_LastCMP
    {
        private long cuitField;
        private short pto_ventaField;
        private string signField;
        private short tipo_cbteField;
        private string tokenField;

        public long Cuit
        {
            get
            {
                return this.cuitField;
            }
            set
            {
                this.cuitField = value;
            }
        }

        public short Pto_venta
        {
            get
            {
                return this.pto_ventaField;
            }
            set
            {
                this.pto_ventaField = value;
            }
        }

        public string Sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }

        public short Tipo_cbte
        {
            get
            {
                return this.tipo_cbteField;
            }
            set
            {
                this.tipo_cbteField = value;
            }
        }

        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }
}

