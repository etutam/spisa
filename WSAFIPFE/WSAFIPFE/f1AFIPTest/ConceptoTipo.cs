﻿namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class ConceptoTipo
    {
        private string descField;
        private string fchDesdeField;
        private string fchHastaField;
        private int idField;

        public string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        public string FchDesde
        {
            get
            {
                return this.fchDesdeField;
            }
            set
            {
                this.fchDesdeField = value;
            }
        }

        public string FchHasta
        {
            get
            {
                return this.fchHastaField;
            }
            set
            {
                this.fchHastaField = value;
            }
        }

        public int Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}

