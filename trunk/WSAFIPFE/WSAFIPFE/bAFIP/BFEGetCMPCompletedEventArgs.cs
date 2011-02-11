using System.Runtime.CompilerServices;

namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
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

