namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class SEGAuthorizeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGAuthorizeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGResponseAuthorize Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGResponseAuthorize) this.results[0];
            }
        }
    }
}

