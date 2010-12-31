using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace SPISA.Util
{
    public class MailSender
    {
        public static bool SendMailMessage(string SMTPServer, string fromAddress,
                                           string fromName, string toAddress, string toName, string msgSubject, string msgBody)
        {
            try
            {
                SmtpClient client = new SmtpClient(SMTPServer, 25);
                MailAddress from = new MailAddress(fromAddress, fromName);
                MailAddress to = new MailAddress(toAddress, toName);

                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("diego.falciola", "capn1984......");

                MailMessage message = new MailMessage(from, to);
                message.Subject = RemoveIllegalCharactersFromString(msgSubject);
                message.Body = msgBody;
                client.Send(message);
            }
            catch (System.Net.Mail.SmtpException smtpEx) 
            {
                
            }
            catch (Exception ex)
            {
                
            }
            return true;
        }

        private static string RemoveIllegalCharactersFromString(String str)
        {
            string newString=str;

            if (str.Contains("\r\n"))
            {
                newString = newString.Remove(str.IndexOf('\r'), 4);    
            }

            return newString;
        }
    }
}
