namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://ar.gov.afip.dif.fex/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code")]
    public class Permiso
    {
        private int dst_mercField;
        private string id_permisoField;

        public int Dst_merc
        {
            get
            {
                return this.dst_mercField;
            }
            set
            {
                this.dst_mercField = value;
            }
        }

        public string Id_permiso
        {
            get
            {
                return this.id_permisoField;
            }
            set
            {
                this.id_permisoField = value;
            }
        }
    }
}

