namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/"), DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FEResponse
    {
        private FECabeceraResponse fecRespField;
        private FEDetalleResponse[] fedRespField;
        private vError rErrorField;

        public FECabeceraResponse FecResp
        {
            get
            {
                return this.fecRespField;
            }
            set
            {
                this.fecRespField = value;
            }
        }

        public FEDetalleResponse[] FedResp
        {
            get
            {
                return this.fedRespField;
            }
            set
            {
                this.fedRespField = value;
            }
        }

        public vError RError
        {
            get
            {
                return this.rErrorField;
            }
            set
            {
                this.rErrorField = value;
            }
        }
    }
}

