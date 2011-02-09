using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIPTest
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class consultarUltimoComprobanteAutorizadoCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarUltimoComprobanteAutorizadoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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

        public CodigoDescripcionType evento
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType) this.results[3];
            }
        }

        public long numeroComprobante
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToLong(this.results[0]);
            }
        }

        public bool numeroComprobanteSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToBoolean(this.results[1]);
            }
        }
    }
}

