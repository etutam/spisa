﻿namespace WSAFIPFE.f1AFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FECAEAConsultarCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FECAEAConsultarCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FECAEAGetResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FECAEAGetResponse) this.results[0];
            }
        }
    }
}

