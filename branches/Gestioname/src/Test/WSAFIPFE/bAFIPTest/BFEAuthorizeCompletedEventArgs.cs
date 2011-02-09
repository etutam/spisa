namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class BFEAuthorizeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEAuthorizeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponseAuthorize Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponseAuthorize) this.results[0];
            }
        }
    }
}

