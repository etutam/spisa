﻿namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class ArrayLocalidadesPorCodigoProvinciaResponse
    {
        private int codigoLocalidadField;
        private string descripcionLocalidadField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int codigoLocalidad
        {
            get
            {
                return this.codigoLocalidadField;
            }
            set
            {
                this.codigoLocalidadField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string descripcionLocalidad
        {
            get
            {
                return this.descripcionLocalidadField;
            }
            set
            {
                this.descripcionLocalidadField = value;
            }
        }
    }
}
