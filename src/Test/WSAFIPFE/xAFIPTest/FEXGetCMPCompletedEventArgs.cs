using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXGetCMPCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetCMPCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXGetCMPResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXGetCMPResponse) this.results[0];
            }
        }
    }
}

