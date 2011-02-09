namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class consultarTiposDocumentoCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarTiposDocumentoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public CodigoDescripcionType evento
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType) this.results[1];
            }
        }

        public CodigoDescripcionType[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[0];
            }
        }
    }
}

