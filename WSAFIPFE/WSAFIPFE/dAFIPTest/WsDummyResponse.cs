﻿namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="ar.gov.afip.dia.serviciosWeb.wDigDepFiel"), GeneratedCode("System.Xml", "2.0.50727.3053"), DebuggerStepThrough]
    public class WsDummyResponse
    {
        private string appserverField;
        private string authserverField;
        private string dbserverField;

        public string appserver
        {
            get
            {
                return this.appserverField;
            }
            set
            {
                this.appserverField = value;
            }
        }

        public string authserver
        {
            get
            {
                return this.authserverField;
            }
            set
            {
                this.authserverField = value;
            }
        }

        public string dbserver
        {
            get
            {
                return this.dbserverField;
            }
            set
            {
                this.dbserverField = value;
            }
        }
    }
}

