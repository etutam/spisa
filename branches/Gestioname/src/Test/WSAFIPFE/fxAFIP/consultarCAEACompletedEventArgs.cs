namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class consultarCAEACompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarCAEACompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public CodigoDescripcionType[] arrayErrores
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[1];
            }
        }

        public CodigoDescripcionType evento
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType) this.results[2];
            }
        }

        public CAEAResponseType Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CAEAResponseType) this.results[0];
            }
        }
    }
}

