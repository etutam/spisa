using System.Runtime.CompilerServices;

namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class FEConsultaCAERequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEConsultaCAERequestCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEConsultaCAEResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEConsultaCAEResponse) this.results[0];
            }
        }
    }
}

