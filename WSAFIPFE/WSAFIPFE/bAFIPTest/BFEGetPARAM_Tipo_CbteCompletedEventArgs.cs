using System.Runtime.CompilerServices;

namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class BFEGetPARAM_Tipo_CbteCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEGetPARAM_Tipo_CbteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponse_Tipo_Cbte Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponse_Tipo_Cbte) this.results[0];
            }
        }
    }
}

