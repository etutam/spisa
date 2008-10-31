using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using System.Data;
using System.Data.Common;

using System.Data.SqlClient;
using System.Xml;

using System.Globalization;
using System.Configuration;

namespace SPISA.Libreria
{
    public class Utils
    {
        public static DataSet ExecuteDataSet(string query)
        {
            DataSet ds = null;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetSqlStringCommand(query);

                ds = db.ExecuteDataSet(dbCommand);

                Logger.Append("Utils.ExecuteDataSet", null, ds.Tables[0].Rows.Count + " rows");
            }
            catch (Exception ex)
            {
                /*   AppSettingsReader appSettingsReader = new AppSettingsReader();
                   bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                   if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                   throw ex;*/
            }

            return ds;
        }
        public static DataSet GetTableColumns(string tableName)
        {
            string sqlCommand = Consts.GetTableColumns;

            DataSet ds = null;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "TableName", DbType.String, tableName);

                ds = db.ExecuteDataSet(dbCommand);

                Logger.Append(Consts.GetTableColumns, null, ds.Tables[0].Rows.Count + " rows");
            }
            catch (Exception ex)
            {
                throw ex;
                /*   AppSettingsReader appSettingsReader = new AppSettingsReader();
                   bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                   if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                   throw ex;*/
            }

            return ds;
        }
        public static DataSet GetDataSetFromXml(string xmlFile)
        {
            DataSet ds = new DataSet();

            ds.ReadXml(xmlFile);

            return ds;

        }

        public static string RemoveCharacterAndSpaces(char c, string s)
        {
            string _s = s;
            for (int i = 0; i < _s.Length; i++)
            {
                if (_s[i] == c)
                {
                    _s = _s.Remove(i, 1);
                    i--;
                }


            }

            return _s;
        }

        public static char GetDecimalSeparator()
        {
            return NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator[0];
        }
    }
}
