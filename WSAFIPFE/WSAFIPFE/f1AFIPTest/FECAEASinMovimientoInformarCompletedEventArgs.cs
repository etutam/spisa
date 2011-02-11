using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class FECAEASinMovimientoInformarCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FECAEASinMovimientoInformarCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FECAEASinMovResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FECAEASinMovResponse) this.results[0];
            }
        }
    }
}

