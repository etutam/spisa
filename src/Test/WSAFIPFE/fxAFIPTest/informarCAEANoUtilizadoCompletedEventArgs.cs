using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIPTest
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class informarCAEANoUtilizadoCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal informarCAEANoUtilizadoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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
                return (CodigoDescripcionType) this.results[4];
            }
        }

        public DateTime fechaProceso
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToDate(this.results[2]);
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

