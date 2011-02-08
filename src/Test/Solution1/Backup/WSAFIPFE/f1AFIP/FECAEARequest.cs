﻿namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class FECAEARequest
    {
        private FECAEACabRequest feCabReqField;
        private FECAEADetRequest[] feDetReqField;

        public FECAEACabRequest FeCabReq
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

        public FECAEADetRequest[] FeDetReq
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

