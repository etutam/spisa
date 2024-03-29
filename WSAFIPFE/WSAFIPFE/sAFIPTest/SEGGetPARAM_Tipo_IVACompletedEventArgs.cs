﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class SEGGetPARAM_Tipo_IVACompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGGetPARAM_Tipo_IVACompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGResponse_Tipo_IVA Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGResponse_Tipo_IVA) this.results[0];
            }
        }
    }
}

