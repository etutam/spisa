using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXDummyCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXDummyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public DummyResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DummyResponse) this.results[0];
            }
        }
    }
}

