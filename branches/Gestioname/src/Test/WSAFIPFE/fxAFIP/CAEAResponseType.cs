namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://impl.service.wsmtxca.afip.gov.ar/service/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class CAEAResponseType
    {
        private long cAEAField;
        private DateTime fechaDesdeField;
        private DateTime fechaHastaField;
        private DateTime fechaProcesoField;
        private DateTime fechaTopeInformeField;
        private short ordenField;
        private int periodoField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public long CAEA
        {
            get
            {
                return this.cAEAField;
            }
            set
            {
                this.cAEAField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaDesde
        {
            get
            {
                return this.fechaDesdeField;
            }
            set
            {
                this.fechaDesdeField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaHasta
        {
            get
            {
                return this.fechaHastaField;
            }
            set
            {
                this.fechaHastaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaProceso
        {
            get
            {
                return this.fechaProcesoField;
            }
            set
            {
                this.fechaProcesoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime fechaTopeInforme
        {
            get
            {
                return this.fechaTopeInformeField;
            }
            set
            {
                this.fechaTopeInformeField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public short orden
        {
            get
            {
                return this.ordenField;
            }
            set
            {
                this.ordenField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int periodo
        {
            get
            {
                return this.periodoField;
            }
            set
            {
                this.periodoField = value;
            }
        }
    }
}

