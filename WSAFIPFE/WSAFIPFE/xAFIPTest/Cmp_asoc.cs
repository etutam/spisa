﻿namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough, XmlType(Namespace="http://ar.gov.afip.dif.fex/")]
    public class Cmp_asoc
    {
        private long cbte_nroField;
        private short cbte_punto_vtaField;
        private short cBte_tipoField;

        public long Cbte_nro
        {
            get
            {
                return this.cbte_nroField;
            }
            set
            {
                this.cbte_nroField = value;
            }
        }

        public short Cbte_punto_vta
        {
            get
            {
                return this.cbte_punto_vtaField;
            }
            set
            {
                this.cbte_punto_vtaField = value;
            }
        }

        public short CBte_tipo
        {
            get
            {
                return this.cBte_tipoField;
            }
            set
            {
                this.cBte_tipoField = value;
            }
        }
    }
}

