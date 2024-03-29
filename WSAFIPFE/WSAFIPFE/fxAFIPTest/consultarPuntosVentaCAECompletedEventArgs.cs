﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.fxAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class consultarPuntosVentaCAECompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarPuntosVentaCAECompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
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

