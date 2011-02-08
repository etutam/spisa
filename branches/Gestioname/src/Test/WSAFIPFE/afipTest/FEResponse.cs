namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.facturaelectronica/")]
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

