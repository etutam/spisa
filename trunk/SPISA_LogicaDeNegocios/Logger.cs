using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

using System.Collections.Generic;
namespace SPISA.Libreria
{
    public class Logger
    {
        public static void Append(string method, Object[] parameters, string returnedValue)
        {
            Logger.LogToFile(method, Logger.GenerateParameters(parameters), returnedValue);
        }

        private static void LogToFile(string method, string parameters, string returnedValue)
        {   
            AppSettingsReader reader = new AppSettingsReader();
            string directory = reader.GetValue("LogsDir", typeof(string)).ToString() ;
            string filename = reader.GetValue("LogFileName", typeof(string)).ToString();

            if (Convert.ToBoolean(reader.GetValue("LogActivities", typeof(bool))) == true)
            {
                
                FileStream objWriter;

                // Generate the line to append
                string lineToAppend = DateTime.Now.Year.ToString() +
                                      DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                      DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                      "|" +
                                      DateTime.Now.Hour.ToString().PadLeft(2, '0') +
                                      ":" +
                                      DateTime.Now.Minute.ToString().PadLeft(2, '0') +
                                      ":" +
                                      DateTime.Now.Second.ToString().PadLeft(2, '0') +
                                      "|" +
                                      method +
                                      "|" +
                                      parameters;

                lineToAppend += "|Returned Value: "+ returnedValue;
                                      
                // If the Log's Directory does not exists, create it
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // If the Log's File does not exists, create it
                if (!File.Exists(directory + "\\" + filename))
                {
                    objWriter = new FileStream(directory + "\\" + filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    objWriter.Close();
                }

                // Append new Line
                objWriter = File.Open(directory + "\\" + filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                string line = lineToAppend.Replace("\r\n", " ") + "\r\n";
                Encoding unicode = Encoding.ASCII;

                // Convert the string into a byte[].
                byte[] unicodeBytes = unicode.GetBytes(line);
                objWriter.Write(unicodeBytes, 0, unicodeBytes.Length);
                objWriter.Close();
            }




        }

        private static string GenerateParameters(object[] parameters)
        {

            string value = "";

            if (parameters!=null)
                for (int i = 0; (i < parameters.Length); i++)
                {
                    value += ((parameters[i] == null) ? "null" : parameters[i]) +
                             ((i % 2).Equals(0) ? "=" : "&");
                }

            return value;

        }


    }
}
