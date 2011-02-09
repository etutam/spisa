namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXGetCMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetCMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXGetCMPResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXGetCMPResponse) this.results[0];
            }
        }
    }
}

