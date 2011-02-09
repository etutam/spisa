﻿namespace WSAFIPFE.sAFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class SEGGetPARAM_MONCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal SEGGetPARAM_MONCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public SEGResponse_Mon Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (SEGResponse_Mon) this.results[0];
            }
        }
    }
}

