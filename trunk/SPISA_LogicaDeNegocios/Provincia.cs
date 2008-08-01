//using System;
//using System.Collections.Generic;
//using System.Text;

//using Microsoft.Practices.EnterpriseLibrary.Data;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

//using System.Data;
//using System.Data.Common;
//using System.Data.SqlClient;

//using System.Configuration;


//namespace SPISA.Libreria
//{
//    public class Provincia
//    {
//        #region Constructores
//        public Provincia()
//        {

//        }
//        #endregion

//        #region Campos Privados
//        int _idProvincia;
//        string _nombre; 
//        #endregion

//        #region Propiedades
//        public int Id
//        {
//            get { return this._idProvincia; }
//            set { this._idProvincia = value; }
//        }

//        public string Nombre
//        {
//            get { return this._nombre; }
//            set { this._nombre = value; }
//        }
//        #endregion

//        #region Métodos Estáticos
//        public static DataTable TraerTodas()
//        {
//            DataSet ds = null;
//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                string sqlCommand = Consts.Provincias_TraerTodas;
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//                ds = db.ExecuteDataSet(dbCommand);
//            }
//            catch (Exception ex)
//            {

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                throw ex;
//            }

//            return ds.Tables[0];

//        }

//        public static void CargarDatosEnProvincia(IDataReader dr, ref Provincia p)
//        {
//            if (p == null) p = new Provincia();

//            p._idProvincia = Convert.ToInt32(dr["IdProvincia"].ToString());
//            p._nombre = dr["Provincia"].ToString();
//        }

//        public static Provincia TraerProvinciaPorId(int IdProvincia)
//        {
//            try
//            {
//                if (IdProvincia <= 0) throw new ArgumentException("IdProvincia es menor o igual a 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            Provincia p = null;
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Provincias_TraerPorId;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            db.AddInParameter(dbCommand, "IdProvincia", DbType.Int32, IdProvincia);

//            try
//            {
//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    if (dr.Read())
//                    {
//                        CargarDatosEnProvincia(dr, ref p);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                p = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

//                throw ex;

//            }

//            return p;
//        }

//        public static Provincia TraerProvinciaPorNombre(string Nombre)
//        {
//            try
//            {
//                if (String.IsNullOrEmpty(Nombre)) throw new ArgumentException("Nombre es nulo o esta vacio");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            Provincia p = null;
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Provincias_TraerPorNombre;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            db.AddInParameter(dbCommand, "Nombre", DbType.String, Nombre);

//            try
//            {
//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    if (dr.Read())
//                    {
//                        CargarDatosEnProvincia(dr, ref p);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                p = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

//                throw ex;

//            }

//            return p;
//        }
//        #endregion
//    }
//}
