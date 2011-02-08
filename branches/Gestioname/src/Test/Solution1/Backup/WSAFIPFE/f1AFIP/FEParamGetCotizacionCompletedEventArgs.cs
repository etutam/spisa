﻿namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class FEParamGetCotizacionCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEParamGetCotizacionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FECotizacionResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FECotizacionResponse) this.results[0];
            }
        }
    }
}

