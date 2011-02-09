namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FECAEARegInformativoCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FECAEARegInformativoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FECAEAResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FECAEAResponse) this.results[0];
            }
        }
    }
}

