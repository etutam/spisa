﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEParamGetPtosVentaCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEParamGetPtosVentaCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEPtoVentaResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEPtoVentaResponse) this.results[0];
            }
        }
    }
}

