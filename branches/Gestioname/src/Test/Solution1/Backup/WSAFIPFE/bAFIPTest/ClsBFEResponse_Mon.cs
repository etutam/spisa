﻿namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.3053"), XmlType(Namespace="http://ar.gov.afip.dif.bfe/"), DebuggerStepThrough]
    public class ClsBFEResponse_Mon
    {
        private string mon_DsField;
        private string mon_IdField;
        private string mon_vig_desdeField;
        private string mon_vig_hastaField;

        public string Mon_Ds
        {
            get
            {
                return this.mon_DsField;
            }
            set
            {
                this.mon_DsField = value;
            }
        }

        public string Mon_Id
        {
            get
            {
                return this.mon_IdField;
            }
            set
            {
                this.mon_IdField = value;
            }
        }

        public string Mon_vig_desde
        {
            get
            {
                return this.mon_vig_desdeField;
            }
            set
            {
                this.mon_vig_desdeField = value;
            }
        }

        public string Mon_vig_hasta
        {
            get
            {
                return this.mon_vig_hastaField;
            }
            set
            {
                this.mon_vig_hastaField = value;
            }
        }
    }
}

