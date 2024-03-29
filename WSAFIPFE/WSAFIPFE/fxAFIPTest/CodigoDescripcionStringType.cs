﻿namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class CodigoDescripcionStringType
    {
        private string codigoField;
        private string descripcionField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }
    }
}

