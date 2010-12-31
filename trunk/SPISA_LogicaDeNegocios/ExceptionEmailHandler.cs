using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;

using System.Collections.Specialized;

using SPISA.Util;
using System.Collections;

namespace SPISA.Libreria
{
    [ConfigurationElementType(typeof(CustomHandlerData))]
    public class ExceptionEmailHandler : IExceptionHandler
    {

        public ExceptionEmailHandler(NameValueCollection ignore)
        {

        }

        #region IExceptionHandler Members


        /// <summary>
        /// Este método se encargará de enviar por mail todos los datos de la excepción
        /// que se ha generado. Las Direcciones de mail se obtienen del Web.Config
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="handlingInstanceId"></param>
        /// <returns></returns>
        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(DictionaryEntry de in exception.Data){

                sb.Append(de.Key.ToString() + ": " + de.Value+"\n");
            }

            sb.Append(exception.ToString());

            MailSender.SendMailMessage("smtp.gmail.com", "diego.falciola@gmail.com", "Diego A. Falciola", "diego.falciola@gmail.com", "Diego", exception.Message,  sb.ToString());

            Logger.Append("ERROR", null, exception.Message);
            return null;
        }

        #endregion
    }
}
