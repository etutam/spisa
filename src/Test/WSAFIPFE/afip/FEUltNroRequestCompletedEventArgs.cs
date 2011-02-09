namespace WSAFIPFE.afip
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEUltNroRequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEUltNroRequestCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEUltNroResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEUltNroResponse) this.results[0];
            }
        }
    }
}

