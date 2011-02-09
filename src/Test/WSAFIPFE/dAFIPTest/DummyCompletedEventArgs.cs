namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class DummyCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal DummyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public WsDummyResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (WsDummyResponse) this.results[0];
            }
        }
    }
}

