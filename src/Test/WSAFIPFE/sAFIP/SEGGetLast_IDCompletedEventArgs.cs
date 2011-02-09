namespace WSAFIPFE.sAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class SEGGetLast_IDCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGGetLast_IDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGResponse_LastID Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGResponse_LastID) this.results[0];
            }
        }
    }
}

