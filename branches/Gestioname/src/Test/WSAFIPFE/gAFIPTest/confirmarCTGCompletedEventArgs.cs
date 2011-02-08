using System.Runtime.CompilerServices;

namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class confirmarCTGCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal confirmarCTGCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public ConfirmarCTGResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ConfirmarCTGResponse) this.results[0];
            }
        }
    }
}

