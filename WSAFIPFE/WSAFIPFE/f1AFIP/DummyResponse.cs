﻿namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://ar.gov.afip.dif.FEV1/"), GeneratedCode("System.Xml", "2.0.50727.3053")]
    public class DummyResponse
    {
        private string appServerField;
        private string authServerField;
        private string dbServerField;

        public string AppServer
        {
            get
            {
                return this.appServerField;
            }
            set
            {
                this.appServerField = value;
            }
        }

        public string AuthServer
        {
            get
            {
                return this.authServerField;
            }
            set
            {
                this.authServerField = value;
            }
        }

        public string DbServer
        {
            get
            {
                return this.dbServerField;
            }
            set
            {
                this.dbServerField = value;
            }
        }
    }
}

