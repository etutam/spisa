namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ItemType
    {
        private decimal cantidadField;
        private bool cantidadFieldSpecified;
        private short codigoCondicionIVAField;
        private string codigoField;
        private string codigoMtxField;
        private short codigoUnidadMedidaField;
        private string descripcionField;
        private decimal importeBonificacionField;
        private bool importeBonificacionFieldSpecified;
        private decimal importeItemField;
        private decimal importeIVAField;
        private bool importeIVAFieldSpecified;
        private decimal precioUnitarioField;
        private bool precioUnitarioFieldSpecified;
        private int unidadesMtxField;
        private bool unidadesMtxFieldSpecified;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        [XmlIgnore]
        public bool cantidadSpecified
        {
            get
            {
                return this.cantidadFieldSpecified;
            }
            set
            {
                this.cantidadFieldSpecified = value;
            }
        }

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
        public short codigoCondicionIVA
        {
            get
            {
                return this.codigoCondicionIVAField;
            }
            set
            {
                this.codigoCondicionIVAField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string codigoMtx
        {
            get
            {
                return this.codigoMtxField;
            }
            set
            {
                this.codigoMtxField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short codigoUnidadMedida
        {
            get
            {
                return this.codigoUnidadMedidaField;
            }
            set
            {
                this.codigoUnidadMedidaField = value;
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeBonificacion
        {
            get
            {
                return this.importeBonificacionField;
            }
            set
            {
                this.importeBonificacionField = value;
            }
        }

        [XmlIgnore]
        public bool importeBonificacionSpecified
        {
            get
            {
                return this.importeBonificacionFieldSpecified;
            }
            set
            {
                this.importeBonificacionFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeItem
        {
            get
            {
                return this.importeItemField;
            }
            set
            {
                this.importeItemField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal importeIVA
        {
            get
            {
                return this.importeIVAField;
            }
            set
            {
                this.importeIVAField = value;
            }
        }

        [XmlIgnore]
        public bool importeIVASpecified
        {
            get
            {
                return this.importeIVAFieldSpecified;
            }
            set
            {
                this.importeIVAFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public decimal precioUnitario
        {
            get
            {
                return this.precioUnitarioField;
            }
            set
            {
                this.precioUnitarioField = value;
            }
        }

        [XmlIgnore]
        public bool precioUnitarioSpecified
        {
            get
            {
                return this.precioUnitarioFieldSpecified;
            }
            set
            {
                this.precioUnitarioFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int unidadesMtx
        {
            get
            {
                return this.unidadesMtxField;
            }
            set
            {
                this.unidadesMtxField = value;
            }
        }

        [XmlIgnore]
        public bool unidadesMtxSpecified
        {
            get
            {
                return this.unidadesMtxFieldSpecified;
            }
            set
            {
                this.unidadesMtxFieldSpecified = value;
            }
        }
    }
}

