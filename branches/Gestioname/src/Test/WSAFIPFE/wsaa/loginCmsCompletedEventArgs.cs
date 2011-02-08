﻿using System.Runtime.CompilerServices;

namespace WSAFIPFE.wsaa
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
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

