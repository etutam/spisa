using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FECompUltimoAutorizadoCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FECompUltimoAutorizadoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FERecuperaLastCbteResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FERecuperaLastCbteResponse) this.results[0];
            }
        }
    }
}

