namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class SEGGetCMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGGetCMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGGetCMPResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGGetCMPResponse) this.results[0];
            }
        }
    }
}

