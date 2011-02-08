using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class FEXGetLast_IDCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetLast_IDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponse_LastID Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponse_LastID) this.results[0];
            }
        }
    }
}

