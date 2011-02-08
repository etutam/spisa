using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEXGetLast_CMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetLast_CMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponseLast_CMP Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponseLast_CMP) this.results[0];
            }
        }
    }
}

