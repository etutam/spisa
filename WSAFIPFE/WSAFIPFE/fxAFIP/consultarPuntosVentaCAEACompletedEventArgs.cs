﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class consultarPuntosVentaCAEACompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarPuntosVentaCAEACompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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

        public PuntoVentaType[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (PuntoVentaType[]) this.results[0];
            }
        }
    }
}

