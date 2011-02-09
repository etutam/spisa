namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code")]
    public class consultarComprobanteCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarComprobanteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public CodigoDescripcionType[] arrayErrores
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[2];
            }
        }

        public CodigoDescripcionType[] arrayObservaciones
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
                return (CodigoDescripcionType) this.results[3];
            }
        }

        public ComprobanteType Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ComprobanteType) this.results[0];
            }
        }
    }
}

