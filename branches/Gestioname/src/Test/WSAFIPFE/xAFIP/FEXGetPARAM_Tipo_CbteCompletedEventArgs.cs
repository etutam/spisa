namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXGetPARAM_Tipo_CbteCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetPARAM_Tipo_CbteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponse_Tipo_Cbte Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponse_Tipo_Cbte) this.results[0];
            }
        }
    }
}

