namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXAuthorizeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXAuthorizeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponseAuthorize Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponseAuthorize) this.results[0];
            }
        }
    }
}

