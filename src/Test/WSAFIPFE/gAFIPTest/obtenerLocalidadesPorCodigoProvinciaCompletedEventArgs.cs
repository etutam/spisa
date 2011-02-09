using System.Runtime.CompilerServices;

namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class obtenerLocalidadesPorCodigoProvinciaCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal obtenerLocalidadesPorCodigoProvinciaCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public ArrayLocalidadesPorCodigoProvinciaResponse[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ArrayLocalidadesPorCodigoProvinciaResponse[]) this.results[0];
            }
        }
    }
}

