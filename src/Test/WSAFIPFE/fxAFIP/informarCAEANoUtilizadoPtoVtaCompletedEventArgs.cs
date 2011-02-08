using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIP
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class informarCAEANoUtilizadoPtoVtaCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal informarCAEANoUtilizadoPtoVtaCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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

        public long CAEA
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToLong(this.results[1]);
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
                return Conversions.ToDate(this.results[3]);
            }
        }

        public short numeroPuntoVenta
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToShort(this.results[2]);
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

