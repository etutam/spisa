namespace WSAFIPFE.wsaa
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using WSAFIPFE.My;

    [WebServiceBinding(Name="LoginCmsSoapBinding", Namespace="https://wsaahomo.afip.gov.ar/ws/services/LoginCms"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class LoginCMSService : SoapHttpClientProtocol
    {
        private SendOrPostCallback loginCmsOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event loginCmsCompletedEventHandler loginCmsCompletedEvent;

        public LoginCMSService()
        {
            this.Url = MySettings.Default.WSAFIPFE_wsaa_LoginCMSService;
            if (this.IsLocalFileSystemWebService(this.Url))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public void CancelAsync(object userState)
        {
            base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }
            Uri wsUri = new Uri(url);
            return ((wsUri.Port >= 0x400) && (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0));
        }

        [return: XmlElement("loginCmsReturn")]
        [SoapDocumentMethod("", RequestNamespace="http://wsaa.view.sua.dvadac.desein.afip.gov", ResponseNamespace="http://wsaa.view.sua.dvadac.desein.afip.gov", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string loginCms(string in0)
        {
            return Conversions.ToString(this.Invoke("loginCms", new object[] { in0 })[0]);
        }

        public void loginCmsAsync(string in0)
        {
            this.loginCmsAsync(in0, null);
        }

        public void loginCmsAsync(string in0, object userState)
        {
            if (this.loginCmsOperationCompleted == null)
            {
                this.loginCmsOperationCompleted = new SendOrPostCallback(this.OnloginCmsOperationCompleted);
            }
            this.InvokeAsync("loginCms", new object[] { in0 }, this.loginCmsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        private void OnloginCmsOperationCompleted(object arg)
        {
            if (this.loginCmsCompletedEvent != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs) arg;
                loginCmsCompletedEventHandler VB_t_ref_S0 = this.loginCmsCompletedEvent;
                if (VB_t_ref_S0 != null)
                {
                    VB_t_ref_S0(this, new loginCmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
                }
            }
        }

        public string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly) && !this.IsLocalFileSystemWebService(value))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
    }
}

