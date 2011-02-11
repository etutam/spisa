namespace WSAFIPFE.My
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) SettingsBase.Synchronized(new MySettings()));

        public static MySettings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [DebuggerNonUserCode, ApplicationScopedSetting, DefaultSettingValue("http://servicios1.afip.gov.ar/wsfe/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl)]
        public string WSAFIPFE_afip_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_afip_Service"]);
            }
        }

        [DefaultSettingValue("https://wswhomo.afip.gov.ar/wsfe/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_afipTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_afipTest_Service"]);
            }
        }

        [ApplicationScopedSetting, DefaultSettingValue("http://servicios1.afip.gov.ar/wsbfe/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
        public string WSAFIPFE_bAFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_bAFIP_Service"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://wswhomo.afip.gov.ar/wsbfe/service.asmx"), ApplicationScopedSetting, DebuggerNonUserCode]
        public string WSAFIPFE_bAFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_bAFIPTest_Service"]);
            }
        }

        [DefaultSettingValue("https://testdia.afip.gov.ar/Dia/Ws/wDigDepFiel/wDigDepFiel.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_dAFIP_wDigDepFiel
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_dAFIP_wDigDepFiel"]);
            }
        }

        [DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://servicios1.afip.gov.ar/wsfev1/service.asmx")]
        public string WSAFIPFE_f1AFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_f1AFIP_Service"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://wswhomo.afip.gov.ar/wsfev1/service.asmx"), ApplicationScopedSetting, DebuggerNonUserCode]
        public string WSAFIPFE_f1AFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_f1AFIPTest_Service"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("https://serviciosjava.afip.gob.ar/wsmtxca/services/MTXCAService"), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_fxAFIP_MTXCAService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_fxAFIP_MTXCAService"]);
            }
        }

        [DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("https://fwshomo.afip.gov.ar/wsmtxca/services/MTXCAService")]
        public string WSAFIPFE_fxAFIPTest_MTXCAService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_fxAFIPTest_MTXCAService"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("https://fwshomo.afip.gov.ar/wsctg/services/CTGService"), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_gAFIPTest_CTGService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_gAFIPTest_CTGService"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), ApplicationScopedSetting, DefaultSettingValue("http://servicios1.afip.gov.ar/wsseg/service.asmx"), DebuggerNonUserCode]
        public string WSAFIPFE_sAFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_sAFIP_Service"]);
            }
        }

        [DefaultSettingValue("https://wswhomo.afip.gov.ar/wsseg/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_sAFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_sAFIPTest_Service"]);
            }
        }

        [ApplicationScopedSetting, DefaultSettingValue("https://wsaa.afip.gov.ar/ws/services/LoginCms"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
        public string WSAFIPFE_wsaa_LoginCMSService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_wsaa_LoginCMSService"]);
            }
        }

        [ApplicationScopedSetting, DebuggerNonUserCode, DefaultSettingValue("https://wsaahomo.afip.gov.ar/ws/services/LoginCms"), SpecialSetting(SpecialSetting.WebServiceUrl)]
        public string WSAFIPFE_wsaaTest_LoginCMSService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_wsaaTest_LoginCMSService"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://servicios1.afip.gov.ar/wsfex/service.asmx"), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_xAFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_xAFIP_Service"]);
            }
        }

        [DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("https://wswhomo.afip.gov.ar/wsfex/service.asmx")]
        public string WSAFIPFE_xAFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_xAFIPTest_Service"]);
            }
        }
    }
}

