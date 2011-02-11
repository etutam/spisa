using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIPTest
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough, DesignerCategory("code")]
    public class informarComprobanteCAEACompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal informarComprobanteCAEACompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public CodigoDescripcionType[] arrayErrores
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[4];
            }
        }

        public CodigoDescripcionType[] arrayObservaciones
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType[]) this.results[3];
            }
        }

        public ComprobanteCAEAResponseType comprobanteCAEAResponse
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ComprobanteCAEAResponseType) this.results[2];
            }
        }

        public CodigoDescripcionType evento
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CodigoDescripcionType) this.results[5];
            }
        }

        public DateTime fechaProceso
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToDate(this.results[1]);
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

