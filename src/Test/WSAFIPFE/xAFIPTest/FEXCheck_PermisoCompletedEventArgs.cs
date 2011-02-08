using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code")]
    public class FEXCheck_PermisoCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXCheck_PermisoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponse_CheckPermiso Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponse_CheckPermiso) this.results[0];
            }
        }
    }
}

