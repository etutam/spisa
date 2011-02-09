using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXGetPARAM_MONCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetPARAM_MONCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponse_Mon Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponse_Mon) this.results[0];
            }
        }
    }
}

