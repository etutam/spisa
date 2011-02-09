namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class BFEGetPARAM_MONCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEGetPARAM_MONCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponse_Mon Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponse_Mon) this.results[0];
            }
        }
    }
}

