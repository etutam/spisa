﻿namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class ConsultaComprobanteRequestType
    {
        private short codigoTipoComprobanteField;
        private long numeroComprobanteField;
        private short numeroPuntoVentaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short codigoTipoComprobante
        {
            get
            {
                return this.codigoTipoComprobanteField;
            }
            set
            {
                this.codigoTipoComprobanteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long numeroComprobante
        {
            get
            {
                return this.numeroComprobanteField;
            }
            set
            {
                this.numeroComprobanteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short numeroPuntoVenta
        {
            get
            {
                return this.numeroPuntoVentaField;
            }
            set
            {
                this.numeroPuntoVentaField = value;
            }
        }
    }
}

