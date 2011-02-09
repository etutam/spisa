﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.bAFIP
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class BFEAuthorizeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal BFEAuthorizeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public BFEResponseAuthorize Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (BFEResponseAuthorize) this.results[0];
            }
        }
    }
}
