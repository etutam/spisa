namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class BFEGetCMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEGetCMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEGetCMPResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEGetCMPResponse) this.results[0];
            }
        }
    }
}

