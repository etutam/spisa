namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://impl.service.wsctg.afip.gov.ar/CTGService/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class SolicitarCTGRequest
    {
        private int cantHorasField;
        private string codigoCosechaField;
        private int codigoEspecieField;
        private int codigoLocalidadDestinoField;
        private int codigoLocalidadOrigenField;
        private long cuitDestinatarioField;
        private long cuitDestinoField;
        private long cuitRemitenteComercialField;
        private long cuitTransportistaField;
        private long numeroCartaDePorteField;
        private string patenteVehiculoField;
        private long pesoNetoCargaField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int cantHoras
        {
            get
            {
                return this.cantHorasField;
            }
            set
            {
                this.cantHorasField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string codigoCosecha
        {
            get
            {
                return this.codigoCosechaField;
            }
            set
            {
                this.codigoCosechaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int codigoEspecie
        {
            get
            {
                return this.codigoEspecieField;
            }
            set
            {
                this.codigoEspecieField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int codigoLocalidadDestino
        {
            get
            {
                return this.codigoLocalidadDestinoField;
            }
            set
            {
                this.codigoLocalidadDestinoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int codigoLocalidadOrigen
        {
            get
            {
                return this.codigoLocalidadOrigenField;
            }
            set
            {
                this.codigoLocalidadOrigenField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitDestinatario
        {
            get
            {
                return this.cuitDestinatarioField;
            }
            set
            {
                this.cuitDestinatarioField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitDestino
        {
            get
            {
                return this.cuitDestinoField;
            }
            set
            {
                this.cuitDestinoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitRemitenteComercial
        {
            get
            {
                return this.cuitRemitenteComercialField;
            }
            set
            {
                this.cuitRemitenteComercialField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long cuitTransportista
        {
            get
            {
                return this.cuitTransportistaField;
            }
            set
            {
                this.cuitTransportistaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long numeroCartaDePorte
        {
            get
            {
                return this.numeroCartaDePorteField;
            }
            set
            {
                this.numeroCartaDePorteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string patenteVehiculo
        {
            get
            {
                return this.patenteVehiculoField;
            }
            set
            {
                this.patenteVehiculoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long pesoNetoCarga
        {
            get
            {
                return this.pesoNetoCargaField;
            }
            set
            {
                this.pesoNetoCargaField = value;
            }
        }
    }
}

