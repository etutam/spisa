namespace WSAFIPFE.dAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class AvisoRecepAceptCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal AvisoRecepAceptCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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

