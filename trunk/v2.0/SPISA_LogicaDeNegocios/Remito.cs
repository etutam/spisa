using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using System.Data;
using System.Data.Common;

using System.Data.SqlClient;
using System.Transactions;
using System.Configuration;


namespace SPISA.Libreria
{
    public class Remito
    {
        #region Campos Privados
        int _IdRemito = -1;        
        int _NumeroRemito = -1;        
        string _Observaciones = "";        
        int _Bultos = 0;

        Cliente _Cliente = null; 
        IList<NotaPedido_Item> _ListaItems = new List<NotaPedido_Item>();
        NotaPedido _NotaPedido = null;
        Transportista _Transportista = null;
        DateTime _Fecha;
        Decimal _Peso = 0;
        Decimal _Valor = 0;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return _IdRemito; }
            set { _IdRemito = value; }
        }
        public NotaPedido NotaPedido
        {
            get { return _NotaPedido; }
            set { _NotaPedido = value; }
        }
        public int NumeroRemito
        {
            get { return _NumeroRemito; }
            set { _NumeroRemito = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
        public Transportista Transportista
        {
            get { return _Transportista; }
            set { _Transportista = value; }
        }
        public Decimal Peso
        {
            get { return _Peso; }
            set { _Peso = value; }
        }
        public int Bultos
        {
            get { return _Bultos; }
            set { _Bultos = value; }
        }
        public Decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        public IList<NotaPedido_Item> Items
        {
            get { return _ListaItems; }
            set { _ListaItems = value; }
        }
        #endregion 

        #region Constructores
        public Remito()
        {

        }
        #endregion

        #region Métodos Estáticos
        public static int ObtenerNuevoNumeroDeRemito()
        {
            string sqlCommand = Consts.Remitos_ObtenerNuevoNumeroDeRemito;
            int nuevoNumeroRemito = -1;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                nuevoNumeroRemito = Convert.ToInt32(ds.Tables[0].Rows[0]["NumeroRemito"]);

                Logger.Append(Consts.Remitos_ObtenerNuevoNumeroDeRemito, null, "NuevoNumeroRemito=" + nuevoNumeroRemito.ToString());
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            return nuevoNumeroRemito;
        }
        public static DataSet TraerTodos()
        {
            string sqlCommand = Consts.Remitos_TraerTodos;
            DataSet ds = null;
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                ds = db.ExecuteDataSet(dbCommand);

                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

                Logger.Append(Consts.Remitos_TraerTodos, null, ds.Tables[0].Rows.Count + " rows");
            }
            catch (Exception ex)
            {
                ds = null;

                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }
            return ds; 
        }

        public static Remito TraerRemitoPorID(int IdRemito)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Remitos_TraerRemitoPorID;
            Remito r = null;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "IdRemito", DbType.Int32, IdRemito);

            try
            {
                using (DataSet ds = db.ExecuteDataSet(dbCommand))
                {
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            CargarDatosEnRemito(ds, ref r);
                            Logger.Append(Consts.Remitos_TraerRemitoPorID, new Object[] { "IdRemito", IdRemito }, "IdRemito=" + IdRemito.ToString());
                        }
                }
            }
            catch (Exception e)
            {

                r = null;
                throw (e);
            }

            return r; 
        }

        public static Remito TraerRemitoPorIdNotaPedido(int IdNotaPedido)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Remitos_TraerRemitoPorIdNotaPedido;
            Remito r = null;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "IdNotaPedido", DbType.Int32, IdNotaPedido);

            try
            {
                using (DataSet ds = db.ExecuteDataSet(dbCommand))
                {
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            CargarDatosEnRemito(ds, ref r);
                            Logger.Append(Consts.Remitos_TraerRemitoPorIdNotaPedido, new Object[] { "IdNotaPedido", IdNotaPedido }, "IdRemito=" + r.Id.ToString());
                        }
                }


            }
            catch (Exception e)
            {

                r = null;
                throw (e);
            }

            return r;
        } 

        private static void CargarDatosEnRemito(DataSet ds, ref Remito r)
        {
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];

                    r = new Remito();

                    r._IdRemito = Convert.ToInt32(dr["IdRemito"]);
                    r._NumeroRemito = Convert.ToInt32(dr["NumeroRemito"]);
                    r._Fecha = Convert.ToDateTime(dr["Fecha"]);
                    r._NotaPedido = NotaPedido.TraerNotaPedidoPorId(Convert.ToInt32(dr["IdNotaPedido"]));
                    r._Cliente = r._NotaPedido.Cliente;
                    r._Observaciones = Convert.ToString(dr["Observaciones"]);
                    r._Transportista = Transportista.TraerTransportistaPorId(Convert.ToInt32(dr["IdTransportista"]));
                    r._Peso = Convert.ToDecimal(dr["Peso"]);
                    r._Bultos = Convert.ToInt32(dr["Bultos"]);
                    r._Valor = Convert.ToDecimal(dr["Valor"]);
                }
                else { throw new Exception("ds.Tables[0].Rows.Count==0"); }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    IList<NotaPedido_Item> items = new List<NotaPedido_Item>();

                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        NotaPedido_Item item = new NotaPedido_Item();

                        item.Articulo = Articulo.TraerArticuloPorID(Convert.ToInt32(dr["IdArticulo"]));
                        item.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                        item.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
                        item.Descuento = Convert.ToDecimal(dr["Descuento"]);
                        items.Add(item);
                    }

                    r._ListaItems = items;
                }
                else { throw new Exception("ds.Tables[1].Rows.Count==0"); }
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }
        }
        #endregion

        #region Métodos Públicos

        public void Actualizar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Remitos_ActualizarRemito;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCmdOC, "IdRemito", DbType.Int32, this._IdRemito);
            db.AddInParameter(dbCmdOC, "Fecha", DbType.DateTime, this._Fecha);
            db.AddInParameter(dbCmdOC, "Observaciones", DbType.String, (this._Observaciones != null ? this._Observaciones : ""));
            db.AddInParameter(dbCmdOC, "IdTransportista", DbType.Int32, (this._Transportista != null ? this.Transportista.Id : -1));
            db.AddInParameter(dbCmdOC, "Peso", DbType.Decimal, (this._Peso != 0 ? this._Peso : 0));
            db.AddInParameter(dbCmdOC, "Bultos", DbType.Int32, (this._Bultos != 0 ? this._Bultos : 0));
            db.AddInParameter(dbCmdOC, "Valor", DbType.Decimal, (this._Valor != 0 ? this._Valor : 0));

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction ts = conn.BeginTransaction();

                try
                {
                    int affectedRows = db.ExecuteNonQuery(dbCmdOC, ts);
                    NotaPedido.ActualizarItems(this.NotaPedido.IdNotaPedido, this._ListaItems, ts);

                    ts.Commit();

                    Logger.Append(Consts.Remitos_ActualizarRemito, new Object[]{"IdRemito", this._IdRemito,
                                                                                "Fecha", this._Fecha,
                                                                                "Observaciones", this._Observaciones,
                                                                                "IdTransportista", (this._Transportista!=null?this._Transportista.Id:-1),
                                                                                "Peso", this._Peso,
                                                                                "Bultos", this._Bultos,
                                                                                "Valor", this._Valor}, affectedRows.ToString() + " rows afectadas");
                }
                catch (Exception ex)
                {
                    ExceptionPolicy.HandleException(ex, "Global Policy");
                    ts.Rollback();
                }
            }
            
        }

        public int Guardar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Remitos_GuardarRemito; 
            
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            
            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction ts = conn.BeginTransaction();

                try
                {
                    if (this._NotaPedido == null)
                    {
                        NotaPedido np = GenerarNotaDePedido();
                        np.Guardar();
                        this._NotaPedido = np;
                    }
                    else
                    {
                        NotaPedido.ActualizarItems(this.NotaPedido.IdNotaPedido, this._ListaItems, ts);
                    }

                    db.AddInParameter(dbCommand, "IdNotaPedido", DbType.Int32, (this._NotaPedido != null ? this._NotaPedido.IdNotaPedido : -1));
                    db.AddInParameter(dbCommand, "NumeroRemito", DbType.Int32, (this._NumeroRemito != -1 ? this._NumeroRemito : -1));
                    db.AddInParameter(dbCommand, "Fecha", DbType.DateTime, this._Fecha);
                    db.AddInParameter(dbCommand, "Observaciones", DbType.String, (this._Observaciones != null ? this._Observaciones : ""));
                    db.AddInParameter(dbCommand, "IdTransportista", DbType.Int32, (this._Transportista!= null ? this.Transportista.Id : -1));
                    db.AddInParameter(dbCommand, "Peso", DbType.Decimal, (this._Peso != 0 ? this._Peso : 0));
                    db.AddInParameter(dbCommand, "Bultos", DbType.Int32, (this._Bultos != 0 ? this._Bultos : 0));
                    db.AddInParameter(dbCommand, "Valor", DbType.Decimal, (this._Valor != 0 ? this._Valor : 0));


                    _IdRemito = Convert.ToInt32(db.ExecuteScalar(dbCommand, ts));
                    ts.Commit();

                    Logger.Append(Consts.Remitos_GuardarRemito, new Object[]{"IdNotaPedido", this._NotaPedido.IdNotaPedido,
                                                                                "NumeroRemito", this._NumeroRemito,
                                                                                "Fecha", this._Fecha,
                                                                                "Observaciones", this._Observaciones,
                                                                                "IdTransportista", (this._Transportista!=null?this._Transportista.Id:-1),
                                                                                "Peso", this._Peso,
                                                                                "Bultos", this._Bultos,
                                                                                "Valor", this._Valor}, "IdRemito=" + _IdRemito.ToString());

                }
                catch (Exception ex)
                {
                    ts.Rollback();
                    ExceptionPolicy.HandleException(ex, "Global Policy");
                    throw ex;
                }
            }
            return _IdRemito;
        }
        public NotaPedido GenerarNotaDePedido()
        {
            NotaPedido np = new NotaPedido();

            np.Cliente = this._Cliente;
            np.FechaEmision = this._Fecha;
            np.FechaEntrega = this._Fecha;
            np.Items = this._ListaItems;

            return np;

        }
        #endregion
    }

    public class Transportista
    {
        #region Campos Privados
        int _IdTransportista;
        string _Transportista;
        string _Domicilio;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return _IdTransportista; }
            set { _IdTransportista = value; }
        }
        public string NombreTransportista
        {
            get { return _Transportista; }
            set { _Transportista = value; }
        }
        public string Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = value; }
        }
        #endregion

        #region Constructores
        public Transportista() { }
        #endregion

        #region Metodos Estáticos
        public static DataTable TraerTodos()
        {
            DataSet ds = null;
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                string sqlCommand = Consts.Transportistas_TraerTodos;
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                ds = db.ExecuteDataSet(dbCommand);
            }
            catch (Exception ex)
            {

                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            return ds.Tables[0];

        }

        public static void CargarDatosEnTransportista(IDataReader dr, ref Transportista t)
        {
            if (t == null) t = new Transportista();

            t._IdTransportista = Convert.ToInt32(dr["IdTransportista"].ToString());
            t._Transportista = dr["Transportista"].ToString();
            t._Domicilio = dr["Domicilio"].ToString();
        }

        public static Transportista TraerTransportistaPorId(int IdTransportista)
        {
            Transportista t = null;
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Transportistas_TraerPorId;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "IdTransportista", DbType.Int32, IdTransportista);

            try
            {
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    if (dr.Read())
                    {
                        CargarDatosEnTransportista(dr, ref t);
                    }
                }
            }
            catch (Exception ex)
            {
                t = null;

                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                throw ex;

            }

            return t;
        }
        #endregion

    }
}
