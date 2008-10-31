using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using System.Data.Common;

using System.Data.SqlClient;
using System.Transactions;
using System.Configuration;

namespace SPISA.Libreria
{
    public class Categoria
    {
        #region Campos Privados
        int _idCategoria;
        string _descripcion;
        int _descuento;
        #endregion

        #region Propiedades
        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        #endregion

        #region Constructores
        public Categoria()
        {
            this._idCategoria = -1;
        }
        #endregion

        #region Metodos Estáticos
        public static DataTable TraerTodas()
        {
            DataTable dt = null;
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                string sqlCommand = Consts.Categorias_TraerTodas;
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                dt = db.ExecuteDataSet(dbCommand).Tables[0];

                Logger.Append(Consts.Categorias_TraerTodas, null, dt.Rows.Count + " rows");
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }
            return dt;
        }
        private static void CargarDatosEnCategoria(IDataReader dr, ref Categoria c)
        {
            try
            {
                if (c == null) c = new Categoria();
                c._idCategoria = Convert.ToInt32(dr["IdCategoria"]);
                c._descripcion = dr["Descripcion"].ToString();
                c._descuento = Convert.ToInt32(dr["Descuento"]);
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }
        }
        public static Categoria TraerCategoriaPorId(int idCategoria)
        {
            try
            {
                if (idCategoria <= 0) throw new Exception("IdCategoria es <= 0");
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            Categoria c = null;
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Categorias_TraerPorId;


            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "IdCategoria", DbType.Int32, idCategoria);

            try
            {
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    if (dr.Read())
                    {
                        CargarDatosEnCategoria(dr, ref c);
                    }
                }
                Logger.Append(Consts.Categorias_TraerPorId, new Object[] { "IdCategoria", idCategoria }, "IdCategoria=" + c.IdCategoria.ToString());

            }
            catch (Exception ex)
            {
                c = null;
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            return c;
        }
        public static Categoria TraerCategoriaPorDescripcion(string Descripcion)
        {
            try
            {
                if (String.IsNullOrEmpty(Descripcion)) throw new Exception("Descripcion es nulo o vacio");
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            Categoria c = null;
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Categorias_TraerPorDescripcion;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "Descripcion", DbType.String, Descripcion);

            try
            {
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    if (dr.Read())
                    {
                        CargarDatosEnCategoria(dr, ref c);
                    }
                }

                Logger.Append(Consts.Categorias_TraerPorDescripcion, new Object[] { "Descripcion", Descripcion }, "IdCategoria=" + c.IdCategoria.ToString());
            }
            catch (Exception ex)
            {
                c = null;
                ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            return c;
        }
        #endregion

        #region Métodos Publicos

        /// <summary>
        /// Almacena la Categoria en la Base de Datos
        /// </summary>
        /// <returns>El id de la categoria almacenada</returns>
        public int Guardar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Categorias_GuardarCategoria;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            object r = null;

            db.AddInParameter(dbCommand, "Descripcion", DbType.String, this._descripcion);
            db.AddInParameter(dbCommand, "Descuento", DbType.Int32, this._descuento);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                try
                {
                    r = db.ExecuteScalar(dbCommand);
                }
                catch (Exception ex)
                {
                    AppSettingsReader appSettingsReader = new AppSettingsReader();
                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                    throw ex;
                }

            }
            return Convert.ToInt32(r);
        }
        public void Actualizar()
        {
            if (this._idCategoria <= 0) throw new Exception("No se puede actualizar una categoría por que IdCategoria <= 0");

            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Categorias_ActualizarCategoria;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            object r = null;
            db.AddInParameter(dbCommand, "IdCategoria", DbType.Int32, this._idCategoria);
            db.AddInParameter(dbCommand, "Descripcion", DbType.String, this._descripcion);
            db.AddInParameter(dbCommand, "Descuento", DbType.Int32, this._descuento);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                try
                {
                    r = db.ExecuteScalar(dbCommand);
                }
                catch (Exception ex)
                {
                    AppSettingsReader appSettingsReader = new AppSettingsReader();
                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                    throw ex;
                }
            }
        }
        #endregion
    }
}
