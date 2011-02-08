using System.Runtime.CompilerServices;

namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class BFEGetPARAM_Tipo_IVACompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEGetPARAM_Tipo_IVACompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponse_Tipo_IVA Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponse_Tipo_IVA) this.results[0];
            }
        }
    }
}

