using System.Runtime.CompilerServices;

namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough, DesignerCategory("code")]
    public class SEGGetPARAM_Tipo_docCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGGetPARAM_Tipo_docCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGResponse_Tipo_doc Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGResponse_Tipo_doc) this.results[0];
            }
        }
    }
}

