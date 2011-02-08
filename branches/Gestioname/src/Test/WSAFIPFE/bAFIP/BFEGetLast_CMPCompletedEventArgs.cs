using System.Runtime.CompilerServices;

namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class BFEGetLast_CMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEGetLast_CMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponseLast_CMP Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponseLast_CMP) this.results[0];
            }
        }
    }
}

