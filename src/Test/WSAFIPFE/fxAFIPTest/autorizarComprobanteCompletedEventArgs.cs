using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIPTest
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class autorizarComprobanteCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal autorizarComprobanteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public CodigoDescripcionType[] arrayErrores
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[3];
            }
        }

        public CodigoDescripcionType[] arrayObservaciones
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[2];
            }
        }

        public ComprobanteCAEResponseType comprobanteResponse
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ComprobanteCAEResponseType) this.results[1];
            }
        }

        public CodigoDescripcionType evento
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType) this.results[4];
            }
        }

        public ResultadoSimpleType Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ResultadoSimpleType) Conversions.ToInteger(this.results[0]);
            }
        }
    }
}

