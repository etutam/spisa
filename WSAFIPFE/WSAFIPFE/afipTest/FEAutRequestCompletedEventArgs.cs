﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
    public class FEAutRequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FEAutRequestCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FEResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FEResponse) this.results[0];
            }
        }
    }
}

