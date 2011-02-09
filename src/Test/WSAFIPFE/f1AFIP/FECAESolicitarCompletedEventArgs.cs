using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FECAESolicitarCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FECAESolicitarCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FECAEResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FECAEResponse) this.results[0];
            }
        }
    }
}

