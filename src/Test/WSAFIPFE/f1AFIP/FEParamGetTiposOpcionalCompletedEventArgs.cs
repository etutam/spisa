using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEParamGetTiposOpcionalCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEParamGetTiposOpcionalCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public OpcionalTipoResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (OpcionalTipoResponse) this.results[0];
            }
        }
    }
}

