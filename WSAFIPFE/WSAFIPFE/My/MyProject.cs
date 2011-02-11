namespace WSAFIPFE.My
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using Microsoft.VisualBasic.MyServices.Internal;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using WSAFIPFE.afip;
    using WSAFIPFE.afipTest;
    using WSAFIPFE.bAFIP;
    using WSAFIPFE.bAFIPTest;
    using WSAFIPFE.dAFIPTest;
    using WSAFIPFE.f1AFIP;
    using WSAFIPFE.f1AFIPTest;
    using WSAFIPFE.fxAFIP;
    using WSAFIPFE.fxAFIPTest;
    using WSAFIPFE.gAFIPTest;
    using WSAFIPFE.sAFIP;
    using WSAFIPFE.sAFIPTest;
    using WSAFIPFE.wsaa;
    using WSAFIPFE.wsaaTest;
    using WSAFIPFE.xAFIP;
    using WSAFIPFE.xAFIPTest;

    [StandardModule, GeneratedCode("MyTemplate", "8.0.0.0"), HideModuleName]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User
        {
            [DebuggerHidden]
            get
            {
                return m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return m_MyWebServicesObjectProvider.GetInstance;
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            public WSAFIPFE.gAFIPTest.CTGService m_CTGService;
            public WSAFIPFE.dAFIPTest.wDigDepFiel m_wDigDepFiel;
            public WSAFIPFE.afip.Service m_WSAFIPFE_afip_Service;
            public WSAFIPFE.afipTest.Service m_WSAFIPFE_afipTest_Service;
            public WSAFIPFE.bAFIP.Service m_WSAFIPFE_bAFIP_Service;
            public WSAFIPFE.bAFIPTest.Service m_WSAFIPFE_bAFIPTest_Service;
            public WSAFIPFE.f1AFIP.Service m_WSAFIPFE_f1AFIP_Service;
            public WSAFIPFE.f1AFIPTest.Service m_WSAFIPFE_f1AFIPTest_Service;
            public WSAFIPFE.fxAFIP.MTXCAService m_WSAFIPFE_fxAFIP_MTXCAService;
            public WSAFIPFE.fxAFIPTest.MTXCAService m_WSAFIPFE_fxAFIPTest_MTXCAService;
            public WSAFIPFE.sAFIP.Service m_WSAFIPFE_sAFIP_Service;
            public WSAFIPFE.sAFIPTest.Service m_WSAFIPFE_sAFIPTest_Service;
            public WSAFIPFE.wsaa.LoginCMSService m_WSAFIPFE_wsaa_LoginCMSService;
            public WSAFIPFE.wsaaTest.LoginCMSService m_WSAFIPFE_wsaaTest_LoginCMSService;
            public WSAFIPFE.xAFIP.Service m_WSAFIPFE_xAFIP_Service;
            public WSAFIPFE.xAFIPTest.Service m_WSAFIPFE_xAFIPTest_Service;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType()
            {
                return typeof(MyProject.MyWebServices);
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            public WSAFIPFE.gAFIPTest.CTGService CTGService
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_CTGService = Create__Instance__<WSAFIPFE.gAFIPTest.CTGService>(this.m_CTGService);
                    return this.m_CTGService;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_CTGService)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.gAFIPTest.CTGService>(ref this.m_CTGService);
                    }
                }
            }

            public WSAFIPFE.dAFIPTest.wDigDepFiel wDigDepFiel
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_wDigDepFiel = Create__Instance__<WSAFIPFE.dAFIPTest.wDigDepFiel>(this.m_wDigDepFiel);
                    return this.m_wDigDepFiel;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_wDigDepFiel)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.dAFIPTest.wDigDepFiel>(ref this.m_wDigDepFiel);
                    }
                }
            }

            public WSAFIPFE.afip.Service WSAFIPFE_afip_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_afip_Service = Create__Instance__<WSAFIPFE.afip.Service>(this.m_WSAFIPFE_afip_Service);
                    return this.m_WSAFIPFE_afip_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_afip_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.afip.Service>(ref this.m_WSAFIPFE_afip_Service);
                    }
                }
            }

            public WSAFIPFE.afipTest.Service WSAFIPFE_afipTest_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_afipTest_Service = Create__Instance__<WSAFIPFE.afipTest.Service>(this.m_WSAFIPFE_afipTest_Service);
                    return this.m_WSAFIPFE_afipTest_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_afipTest_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.afipTest.Service>(ref this.m_WSAFIPFE_afipTest_Service);
                    }
                }
            }

            public WSAFIPFE.bAFIP.Service WSAFIPFE_bAFIP_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_bAFIP_Service = Create__Instance__<WSAFIPFE.bAFIP.Service>(this.m_WSAFIPFE_bAFIP_Service);
                    return this.m_WSAFIPFE_bAFIP_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_bAFIP_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.bAFIP.Service>(ref this.m_WSAFIPFE_bAFIP_Service);
                    }
                }
            }

            public WSAFIPFE.bAFIPTest.Service WSAFIPFE_bAFIPTest_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_bAFIPTest_Service = Create__Instance__<WSAFIPFE.bAFIPTest.Service>(this.m_WSAFIPFE_bAFIPTest_Service);
                    return this.m_WSAFIPFE_bAFIPTest_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_bAFIPTest_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.bAFIPTest.Service>(ref this.m_WSAFIPFE_bAFIPTest_Service);
                    }
                }
            }

            public WSAFIPFE.f1AFIP.Service WSAFIPFE_f1AFIP_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_f1AFIP_Service = Create__Instance__<WSAFIPFE.f1AFIP.Service>(this.m_WSAFIPFE_f1AFIP_Service);
                    return this.m_WSAFIPFE_f1AFIP_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_f1AFIP_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.f1AFIP.Service>(ref this.m_WSAFIPFE_f1AFIP_Service);
                    }
                }
            }

            public WSAFIPFE.f1AFIPTest.Service WSAFIPFE_f1AFIPTest_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_f1AFIPTest_Service = Create__Instance__<WSAFIPFE.f1AFIPTest.Service>(this.m_WSAFIPFE_f1AFIPTest_Service);
                    return this.m_WSAFIPFE_f1AFIPTest_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_f1AFIPTest_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.f1AFIPTest.Service>(ref this.m_WSAFIPFE_f1AFIPTest_Service);
                    }
                }
            }

            public WSAFIPFE.fxAFIP.MTXCAService WSAFIPFE_fxAFIP_MTXCAService
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_fxAFIP_MTXCAService = Create__Instance__<WSAFIPFE.fxAFIP.MTXCAService>(this.m_WSAFIPFE_fxAFIP_MTXCAService);
                    return this.m_WSAFIPFE_fxAFIP_MTXCAService;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_fxAFIP_MTXCAService)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.fxAFIP.MTXCAService>(ref this.m_WSAFIPFE_fxAFIP_MTXCAService);
                    }
                }
            }

            public WSAFIPFE.fxAFIPTest.MTXCAService WSAFIPFE_fxAFIPTest_MTXCAService
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_fxAFIPTest_MTXCAService = Create__Instance__<WSAFIPFE.fxAFIPTest.MTXCAService>(this.m_WSAFIPFE_fxAFIPTest_MTXCAService);
                    return this.m_WSAFIPFE_fxAFIPTest_MTXCAService;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_fxAFIPTest_MTXCAService)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.fxAFIPTest.MTXCAService>(ref this.m_WSAFIPFE_fxAFIPTest_MTXCAService);
                    }
                }
            }

            public WSAFIPFE.sAFIP.Service WSAFIPFE_sAFIP_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_sAFIP_Service = Create__Instance__<WSAFIPFE.sAFIP.Service>(this.m_WSAFIPFE_sAFIP_Service);
                    return this.m_WSAFIPFE_sAFIP_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_sAFIP_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.sAFIP.Service>(ref this.m_WSAFIPFE_sAFIP_Service);
                    }
                }
            }

            public WSAFIPFE.sAFIPTest.Service WSAFIPFE_sAFIPTest_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_sAFIPTest_Service = Create__Instance__<WSAFIPFE.sAFIPTest.Service>(this.m_WSAFIPFE_sAFIPTest_Service);
                    return this.m_WSAFIPFE_sAFIPTest_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_sAFIPTest_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.sAFIPTest.Service>(ref this.m_WSAFIPFE_sAFIPTest_Service);
                    }
                }
            }

            public WSAFIPFE.wsaa.LoginCMSService WSAFIPFE_wsaa_LoginCMSService
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_wsaa_LoginCMSService = Create__Instance__<WSAFIPFE.wsaa.LoginCMSService>(this.m_WSAFIPFE_wsaa_LoginCMSService);
                    return this.m_WSAFIPFE_wsaa_LoginCMSService;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_wsaa_LoginCMSService)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.wsaa.LoginCMSService>(ref this.m_WSAFIPFE_wsaa_LoginCMSService);
                    }
                }
            }

            public WSAFIPFE.wsaaTest.LoginCMSService WSAFIPFE_wsaaTest_LoginCMSService
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_wsaaTest_LoginCMSService = Create__Instance__<WSAFIPFE.wsaaTest.LoginCMSService>(this.m_WSAFIPFE_wsaaTest_LoginCMSService);
                    return this.m_WSAFIPFE_wsaaTest_LoginCMSService;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_wsaaTest_LoginCMSService)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.wsaaTest.LoginCMSService>(ref this.m_WSAFIPFE_wsaaTest_LoginCMSService);
                    }
                }
            }

            public WSAFIPFE.xAFIP.Service WSAFIPFE_xAFIP_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_xAFIP_Service = Create__Instance__<WSAFIPFE.xAFIP.Service>(this.m_WSAFIPFE_xAFIP_Service);
                    return this.m_WSAFIPFE_xAFIP_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_xAFIP_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.xAFIP.Service>(ref this.m_WSAFIPFE_xAFIP_Service);
                    }
                }
            }

            public WSAFIPFE.xAFIPTest.Service WSAFIPFE_xAFIPTest_Service
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_WSAFIPFE_xAFIPTest_Service = Create__Instance__<WSAFIPFE.xAFIPTest.Service>(this.m_WSAFIPFE_xAFIPTest_Service);
                    return this.m_WSAFIPFE_xAFIPTest_Service;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_WSAFIPFE_xAFIPTest_Service)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<WSAFIPFE.xAFIPTest.Service>(ref this.m_WSAFIPFE_xAFIPTest_Service);
                    }
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            private readonly ContextValue<T> m_Context;

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public ThreadSafeObjectProvider()
            {
                this.m_Context = new ContextValue<T>();
            }

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    T Value = this.m_Context.Value;
                    if (Value == null)
                    {
                        Value = Activator.CreateInstance<T>();
                        this.m_Context.Value = Value;
                    }
                    return Value;
                }
            }
        }
    }
}

