namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FECAERequest
    {
        private FECAECabRequest feCabReqField;
        private FECAEDetRequest[] feDetReqField;

        public FECAECabRequest FeCabReq
        {
            get
            {
                return this.feCabReqField;
            }
            set
            {
                this.feCabReqField = value;
            }
        }

        public FECAEDetRequest[] FeDetReq
        {
            get
            {
                return this.feDetReqField;
            }
            set
            {
                this.feDetReqField = value;
            }
        }
    }
}

