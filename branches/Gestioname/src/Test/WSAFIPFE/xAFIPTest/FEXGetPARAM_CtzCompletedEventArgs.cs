namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class FEXGetPARAM_CtzCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetPARAM_CtzCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponse_Ctz Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponse_Ctz) this.results[0];
            }
        }
    }
}

