namespace WSAFIPFE.afipTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class FERecuperaLastCMPRequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal FERecuperaLastCMPRequestCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public FERecuperaLastCMPResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (FERecuperaLastCMPResponse) this.results[0];
            }
        }
    }
}

