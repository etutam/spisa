namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class AvisoDigitCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal AvisoDigitCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public Recibo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Recibo) this.results[0];
            }
        }
    }
}

