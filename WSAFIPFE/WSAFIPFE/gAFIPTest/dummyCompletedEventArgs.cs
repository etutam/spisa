using System.Runtime.CompilerServices;

namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class dummyCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal dummyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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

