﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.f1AFIPTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough, DesignerCategory("code")]
    public class FECompTotXRequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FECompTotXRequestCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FERegXReqResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FERegXReqResponse) this.results[0];
            }
        }
    }
}

