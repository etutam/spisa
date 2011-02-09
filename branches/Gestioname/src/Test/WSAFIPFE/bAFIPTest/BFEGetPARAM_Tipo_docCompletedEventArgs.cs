namespace WSAFIPFE.bAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class BFEGetPARAM_Tipo_docCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEGetPARAM_Tipo_docCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponse_Tipo_doc Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponse_Tipo_doc) this.results[0];
            }
        }
    }
}

