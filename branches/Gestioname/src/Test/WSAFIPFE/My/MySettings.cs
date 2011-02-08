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

        [SpecialSetting(SpecialSetting.WebServiceUrl), ApplicationScopedSetting, DebuggerNonUserCode, DefaultSettingValue("http://servicios1.afip.gov.ar/wsfe/service.asmx")]
        public string WSAFIPFE_afip_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_afip_Service"]);
            }
        }

        [ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode, DefaultSettingValue("https://wswhomo.afip.gov.ar/wsfe/service.asmx")]
        public string WSAFIPFE_afipTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_afipTest_Service"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode, ApplicationScopedSetting, DefaultSettingValue("http://servicios1.afip.gov.ar/wsbfe/service.asmx")]
        public string WSAFIPFE_bAFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_bAFIP_Service"]);
            }
        }

        [DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://wswhomo.afip.gov.ar/wsbfe/service.asmx")]
        public string WSAFIPFE_bAFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_bAFIPTest_Service"]);
            }
        }

        [ApplicationScopedSetting, DefaultSettingValue("https://testdia.afip.gov.ar/Dia/Ws/wDigDepFiel/wDigDepFiel.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
        public string WSAFIPFE_dAFIP_wDigDepFiel
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_dAFIP_wDigDepFiel"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), ApplicationScopedSetting, DebuggerNonUserCode, DefaultSettingValue("http://servicios1.afip.gov.ar/wsfev1/service.asmx")]
        public string WSAFIPFE_f1AFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_f1AFIP_Service"]);
            }
        }

        [DefaultSettingValue("http://wswhomo.afip.gov.ar/wsfev1/service.asmx"), DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl)]
        public string WSAFIPFE_f1AFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_f1AFIPTest_Service"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), ApplicationScopedSetting, DefaultSettingValue("https://serviciosjava.afip.gob.ar/wsmtxca/services/MTXCAService"), DebuggerNonUserCode]
        public string WSAFIPFE_fxAFIP_MTXCAService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_fxAFIP_MTXCAService"]);
            }
        }

        [DefaultSettingValue("https://fwshomo.afip.gov.ar/wsmtxca/services/MTXCAService"), ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
        public string WSAFIPFE_fxAFIPTest_MTXCAService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_fxAFIPTest_MTXCAService"]);
            }
        }

        [DefaultSettingValue("https://fwshomo.afip.gov.ar/wsctg/services/CTGService"), DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.WebServiceUrl)]
        public string WSAFIPFE_gAFIPTest_CTGService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_gAFIPTest_CTGService"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode, DefaultSettingValue("http://servicios1.afip.gov.ar/wsseg/service.asmx"), ApplicationScopedSetting]
        public string WSAFIPFE_sAFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_sAFIP_Service"]);
            }
        }

        [ApplicationScopedSetting, DefaultSettingValue("https://wswhomo.afip.gov.ar/wsseg/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
        public string WSAFIPFE_sAFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_sAFIPTest_Service"]);
            }
        }

        [SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("https://wsaa.afip.gov.ar/ws/services/LoginCms"), DebuggerNonUserCode, ApplicationScopedSetting]
        public string WSAFIPFE_wsaa_LoginCMSService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_wsaa_LoginCMSService"]);
            }
        }

        [DefaultSettingValue("https://wsaahomo.afip.gov.ar/ws/services/LoginCms"), SpecialSetting(SpecialSetting.WebServiceUrl), ApplicationScopedSetting, DebuggerNonUserCode]
        public string WSAFIPFE_wsaaTest_LoginCMSService
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_wsaaTest_LoginCMSService"]);
            }
        }

        [ApplicationScopedSetting, DefaultSettingValue("http://servicios1.afip.gov.ar/wsfex/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
        public string WSAFIPFE_xAFIP_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_xAFIP_Service"]);
            }
        }

        [DebuggerNonUserCode, SpecialSetting(SpecialSetting.WebServiceUrl), ApplicationScopedSetting, DefaultSettingValue("https://wswhomo.afip.gov.ar/wsfex/service.asmx")]
        public string WSAFIPFE_xAFIPTest_Service
        {
            get
            {
                return Conversions.ToString(this["WSAFIPFE_xAFIPTest_Service"]);
            }
        }
    }
}

