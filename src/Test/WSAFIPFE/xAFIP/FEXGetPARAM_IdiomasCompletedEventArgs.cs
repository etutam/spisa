﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.xAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FEXGetPARAM_IdiomasCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEXGetPARAM_IdiomasCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEXResponse_Idi Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEXResponse_Idi) this.results[0];
            }
        }
    }
}

