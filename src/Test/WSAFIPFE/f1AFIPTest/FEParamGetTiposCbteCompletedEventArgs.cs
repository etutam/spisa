using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEParamGetTiposCbteCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEParamGetTiposCbteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public CbteTipoResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CbteTipoResponse) this.results[0];
            }
        }
    }
}

