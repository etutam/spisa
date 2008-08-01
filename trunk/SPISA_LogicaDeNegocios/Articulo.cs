//using System;
//using System.Collections.Generic;
//using System.Text;

//using Microsoft.Practices.EnterpriseLibrary.Data;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

//using System.Data;
//using System.Data.Common;
//using System.Data.SqlClient;
//using System.Data.SqlTypes;

using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.IO;
using System.Data.SqlClient;


using System.Configuration;

//using System.Text;
//using System.IO;
//using System.Data.SqlClient;


//using System.Configuration;

//using System.Transactions; 

//namespace SPISA.Libreria
//{
//    public enum Mensaje
//    {
//        ArticuloExistente = -1,
//        Error = -2
//    }

//    public class Articulo
//    {
//        #region Constructores
//        public Articulo()
//        {
//            _idArticulo = -1;
//        }
         
        
//        // Para setear los datos mas rapidamente
//        public Articulo(string codigo, string descripcion, int cantidad, Decimal precioUnitario, Categoria categoria)
//        {
//            this._codigo = codigo;
//            this._descripcion = descripcion;
//            this._cantidad = cantidad;
//            this._precioUnitario = precioUnitario;
//            this._categoria = categoria;
//        }
//        #endregion

//        #region Campos Privados
//        int _idArticulo;
//        Categoria _categoria;
//        string _codigo;
//        string _descripcion;
//        Decimal _cantidad;
//        Decimal _precioUnitario;

//        #endregion

//        #region Propiedades

//        public int Id
//        {
//            get { return _idArticulo; }
//            set { _idArticulo = value; } 
//        }
//        public Categoria Categoria
//        {
//            get { return _categoria; }
//            set { _categoria = value; } 
//        }
//        public string Codigo
//        {
//            get { return _codigo; }
//            set { _codigo = value; }
//        }
//        public string Descripcion
//        {
//            get { return _descripcion; }
//            set { _descripcion = value; }
//        }
//        public Decimal Cantidad
//        {
//            get { return _cantidad; }
//            set { _cantidad = value; }
//        }
//        public Decimal PrecioUnitario
//        {
//            get { return _precioUnitario; }
//            set { _precioUnitario = value; }
//        }
//        #endregion

//        #region Métodos Estáticos
//        public static DataTable TraerTodos()
//        {
//            DataSet ds = null;
//            string sqlCommand = Consts.Articulos_TraerTodos;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//                ds = db.ExecuteDataSet(dbCommand);

//                Logger.Append(Consts.Articulos_TraerTodos, null, ds.Tables[0].Rows.Count + " rows");
//            }
//            catch (Exception ex)
//            {
                
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                throw ex;
//            }

            return ds.Tables[0];
        }

        private static void CargarDatosEnArticulo(IDataReader dataReader, ref Articulo a)
        {
            try
            {
                if (a == null) a = new Articulo();

//        public static void test(){
//            using (SPISA.Entities.EntitiesModel entitiesModel = new SPISA.Entities.EntitiesModel())
//            {
//                SPISA.Entities.Articulo _articulo = (from art
//                                                     in entitiesModel.Articulos
//                                                     select art).First();
                                     
//            }


//        }
//        private static void CargarDatosEnArticulo(IDataReader dataReader, ref Articulo a)
//        {
//            try
//            {
//                if (a == null) a = new Articulo();
            

//                a._idArticulo = Convert.ToInt32(dataReader["idArticulo"]);
//                a._codigo = Convert.ToString(dataReader["codigo"]);
//                a._categoria = Categoria.TraerCategoriaPorId(Convert.ToInt32(dataReader["IdCategoria"]));
//                a._descripcion = Convert.ToString(dataReader["descripcion"]);
//                a._cantidad = Convert.ToDecimal(dataReader["cantidad"]);
//                a.PrecioUnitario = Convert.ToDecimal(dataReader["PrecioUnitario"]);
//                //a._precioUnitario = Convert.ToDecimal(dataReader["preciounitario"]);
//            }
//            catch (Exception ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//            }
//        }
//        public static Articulo TraerArticuloPorCodigo(string codigo )
//        {
//            try
//            {
//                if (string.IsNullOrEmpty(codigo)) throw new ArgumentNullException("codigo es null o esta vacío");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }
            

//            Articulo a = null; 
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Articulos_TraerArticuloPorCodigo;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            db.AddInParameter(dbCommand, "Codigo", DbType.String, codigo);
//            try
//            {
//                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
//                {
//                    if (dataReader.Read())
//                    {
//                        CargarDatosEnArticulo(dataReader,ref a);
//                        Logger.Append(Consts.Articulos_TraerTodos, new Object[] { "Codigo", codigo }, "IdArticulo=" + a.Id.ToString());
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                a = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");
                
//                throw e;
//            }

//            return a;

//        }
//        public static DataTable Buscar(string criterioCodigo, string codigo, int idCategoria,string criterioDescripcion, string descripcion, string criterioPrecio, decimal precio, string criterioCantidad, int cantidad)
//        {
            
//            DataSet ds = null;
//            string sqlCommand = Consts.Articulos_Buscar;

//            try
//            {   
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//                db.AddInParameter(dbCommand, "CriterioCodigo", DbType.String, criterioCodigo);
//                db.AddInParameter(dbCommand, "Codigo", DbType.String, codigo);
//                db.AddInParameter(dbCommand, "CriterioDescripcion", DbType.String, criterioDescripcion);
//                db.AddInParameter(dbCommand, "Descripcion", DbType.String, descripcion);
//                db.AddInParameter(dbCommand, "IdCategoria", DbType.Int32, (idCategoria!=-1 ? idCategoria : SqlInt32.Null));
//                db.AddInParameter(dbCommand, "CriterioPrecio", DbType.String, criterioPrecio);
//                db.AddInParameter(dbCommand, "Precio", DbType.Decimal, (precio != -1 ? precio : SqlDecimal.Null));
//                db.AddInParameter(dbCommand, "CriterioCantidad", DbType.String, criterioCantidad);
//                db.AddInParameter(dbCommand, "Cantidad", DbType.Int32, (cantidad!= -1 ? cantidad : SqlInt32.Null));


//                ds = db.ExecuteDataSet(dbCommand);

//                Logger.Append(Consts.Articulos_Buscar, new Object[] {   "Codigo", codigo,
//                                                                        "Descripcion", descripcion,
//                                                                        "IdCategoria", idCategoria.ToString(),
//                                                                        "CriterioPrecio", criterioPrecio,
//                                                                        "Precio", precio.ToString(),
//                                                                        "CriterioCantidad", criterioCantidad,
//                                                                        "Cantidad", cantidad.ToString()}, ds.Tables[0].Rows.Count + " rows");
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
//        public static DataTable TraerArticulosPorDescripcion(string descripcion)
//        {
//            try
//            {
//                if (string.IsNullOrEmpty(descripcion)) throw new ArgumentException("Descripcion esta nulo o vacio");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            DataSet ds = null;
//            string sqlCommand = Consts.Articulos_TraerArticulosPorDescripcion;
            
//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                
//                ds = db.ExecuteDataSet(dbCommand);

//                Logger.Append(Consts.Articulos_TraerArticulosPorDescripcion, new Object[] { "Descripcion", descripcion }, ds.Tables[0].Rows.Count + " rows");
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
//        public static Articulo TraerArticuloPorID(int IdArticulo)
//        {
//            try
//            {
//                if (IdArticulo <= 0) throw new ArgumentException("IdArticulo es menor o igual a 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            Articulo a = null;
//            string sqlCommand = Consts.Articulos_TraerArticuloPorID;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "IdArticulo", DbType.Int32, IdArticulo);

//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    if (dr.Read())
//                    {
//                        CargarDatosEnArticulo(dr, ref a);
//                        Logger.Append(Consts.Articulos_TraerArticuloPorID, new Object[] { "IdArticulo", IdArticulo }, "IdArticulo=" + a.Id.ToString());
//                    }
//                }

                
//            }
//            catch (Exception ex)
//            {
//                a = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

//                throw ex;
                 
//            }

            return a;
        }
        /// <summary>
        /// Se encarga de sustraer de la tabla de Articulo, una cantidad "Cantidad" del artìculo "IdArticulo"
        /// Generalmente, este mètodo va a ser invocado desde el mètodo "AlmacenarImpresión" 
        /// </summary>
        /// <param name="IdArticulo"></param>
        /// <param name="Cantidad"></param>
        /// <param name="TipoOperacion"> 1- Resta
        ///                              2- Suma</param>
        /// <returns></returns>
        public static int ModificarCantidad(int IdArticulo, Decimal Cantidad, int TipoOperacion, DbTransaction transaction)
        {
            try
            {
                if (IdArticulo <= 0) throw new ArgumentException("IdArticulo es menor o igual a 0");
                if (Cantidad <= 0) throw new ArgumentException("Cantidad es menor o igual a 0");
            }
            catch (ArgumentException ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                return -1;
            }
//                return -1;
//            }

//            AppSettingsReader reader = new AppSettingsReader();
//            bool controlStock = Convert.ToBoolean(reader.GetValue("ControlStock", typeof(Boolean)));

//            if (controlStock)
//            {
                
//                Database db = DatabaseFactory.CreateDatabase();
//                string sqlCommand = Consts.Articulos_ModificarCantidad;
                
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                object r = null;

//                db.AddInParameter(dbCommand, "IdArticulo", DbType.Int32, IdArticulo);
//                db.AddInParameter(dbCommand, "Cantidad", DbType.Int32, Cantidad);
//                db.AddInParameter(dbCommand, "TipoOperacion", DbType.Int32, TipoOperacion);


//                using (DbConnection conn = db.CreateConnection())
//                {
//                    conn.Open();
//                    r = db.ExecuteScalar(dbCommand, transaction);

//                    Logger.Append(Consts.Articulos_ModificarCantidad, new Object[] { "IdArticulo", IdArticulo, "Cantidad", Cantidad, "TipoOperacion", TipoOperacion }, r.ToString() + " rows");
                    r = db.ExecuteScalar(dbCommand, transaction);

//                return Convert.ToInt32(r);
//            }
//            else return -1;
            
//        }
//        public static Decimal TraerCantidadSalidasPorArticuloPorFecha(int IdArticulo, DateTime Fecha)
//        {
//            try
//            {
//                if (IdArticulo <= 0) throw new ArgumentException("IdArticulo es menor o igual a 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return -1;
//            }
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Articulos_CantidadSalidasPorArticuloPorMes;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            db.AddInParameter(dbCommand, "IdArticulo", DbType.Int32, IdArticulo);
//            db.AddInParameter(dbCommand, "Fecha", DbType.DateTime, Fecha);


//            Decimal cantidad;
//            try
//            {
//                object o = db.ExecuteScalar(dbCommand); 
//                cantidad = (o.ToString()!=""?Convert.ToDecimal(o):0);

//                Logger.Append(Consts.Articulos_CantidadSalidasPorArticuloPorMes, new Object[] { "IdArticulo", IdArticulo, "Fecha", Fecha.ToString() }, "Cantidad Salida:" + cantidad.ToString());
//            }
//            catch (Exception ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                throw ex;

//            }
//            return cantidad;
//        }
//        #endregion

//        #region Metodos Publicos

//        public void Actualizar()
//        {
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Articulos_Actualizar;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//            int rowsAffected=-1;

//            db.AddInParameter(dbCommand, "IdArticulo", DbType.Int32, this._idArticulo);
//            db.AddInParameter(dbCommand, "IdCategoria", DbType.Int32, this._categoria.IdCategoria);
//            db.AddInParameter(dbCommand, "Codigo", DbType.String, this._codigo);
//            db.AddInParameter(dbCommand, "Descripcion", DbType.String, this._descripcion);
//            db.AddInParameter(dbCommand, "Cantidad", DbType.Decimal, this._cantidad);
//            db.AddInParameter(dbCommand, "PrecioUnitario", DbType.Decimal, this._precioUnitario);


//            using (DbConnection conn = db.CreateConnection())
//            {
//                conn.Open();
                
//                try
//                {
//                    rowsAffected =  db.ExecuteNonQuery(dbCommand);

//                    Logger.Append(Consts.Articulos_Actualizar, new Object[]{  "IdArticulo", this._idArticulo, 
//                                                                            "IdCategoria", this._categoria.IdCategoria,
//                                                                            "Codigo", this._codigo,
//                                                                            "Descripcion", this._descripcion,
//                                                                            "Cantidad", this._cantidad,
//                                                                            "PrecioUnitario", this._precioUnitario}, "Filas Afectadas: " + rowsAffected.ToString());
//                }
//                catch (Exception ex)
//                {
//                    AppSettingsReader appSettingsReader = new AppSettingsReader();
//                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                    throw ex;
//                }
//            }
//        }
//        public int Guardar()
//        {  
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Articulos_GuardarArticulo;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//            object r = null;

//            db.AddInParameter(dbCommand, "IdCategoria", DbType.Int32, (this._categoria!=null? this._categoria.IdCategoria:-1));
//            db.AddInParameter(dbCommand, "Codigo", DbType.String, this._codigo);
//            db.AddInParameter(dbCommand, "Descripcion", DbType.String, this._descripcion);
//            db.AddInParameter(dbCommand, "Cantidad", DbType.Decimal, this._cantidad);
//            db.AddInParameter(dbCommand, "PrecioUnitario", DbType.Decimal, this._precioUnitario);


//            using (DbConnection conn = db.CreateConnection())
//            {
//                conn.Open();
//                try
//                {
//                    r = db.ExecuteScalar(dbCommand);

//                    _idArticulo = Convert.ToInt32(r);

//                    Logger.Append(Consts.Articulos_GuardarArticulo, new Object[] {  "IdCategoria", this._categoria.IdCategoria, 
//                                                                                    "Codigo", this._codigo,
//                                                                                    "Descripcion", this._descripcion,
//                                                                                    "Cantidad", this._cantidad,
//                                                                                    "PrecioUnitario", this._precioUnitario }, "IdArticulo=" + _idArticulo);
//                }
//                catch (Exception ex)
//                {
//                    AppSettingsReader appSettingsReader = new AppSettingsReader();
//                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                    throw ex; 
//                }
//            }
//            return _idArticulo;
//        }
//        #endregion
//    }
//}
