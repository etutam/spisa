﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.gAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class obtenerEspeciesCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal obtenerEspeciesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public ArrayEspeciesResponse[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ArrayEspeciesResponse[]) this.results[0];
            }
        }
    }
}

