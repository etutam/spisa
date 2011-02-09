namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class dummyCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal dummyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public DummyResponseType Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DummyResponseType) this.results[0];
            }
        }
    }
}

