using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;

namespace Gestioname.Infrastructure.Exceptions 
{
    public class AppMessageExceptionHandler : IExceptionHandler
    {

        #region IExceptionHandler Members

        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            DialogResult result = this.ShowThreadExceptionDialog(exception);

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();

            return exception;
        }

        #endregion

        // Creates the error message and displays it.
        private DialogResult ShowThreadExceptionDialog(Exception e)
        {
            string errorMsg = e.Message + Environment.NewLine + Environment.NewLine;

            return MessageBox.Show(errorMsg, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
