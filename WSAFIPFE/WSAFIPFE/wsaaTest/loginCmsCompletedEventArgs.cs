﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.wsaaTest
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053"), DebuggerStepThrough]
    public class loginCmsCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal loginCmsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return Conversions.ToString(this.results[0]);
            }
        }
    }
}

