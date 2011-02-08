using System.Runtime.CompilerServices;

namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class SEGGetLast_CMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGGetLast_CMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGResponseLast_CMP Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGResponseLast_CMP) this.results[0];
            }
        }
    }
}

