using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using System.Data;
using System.Data.Common;

using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Transactions;

using System.Configuration;
namespace SPISA.Libreria
{
    public class NotaPedido
    {
        #region Campos Privados
        int _IdNotaPedido = -1;

        Cliente _Cliente = null;
        long _NumeroOrden = -1;
        DateTime _FechaEmision;
        DateTime _FechaEntrega;
        IList<NotaPedido_Item> _Items = null;

        int _descuentoEspecial = 0;
        string _Observaciones = "";

        bool _fueFacturado = false;
        #endregion

        #region Constructores
        public NotaPedido()
        {

        }
        #endregion

        #region Propiedades
        public int IdNotaPedido
        {
            get { return _IdNotaPedido; }
            set { _IdNotaPedido = value; }
        }

        public Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public int DescuentoEspecial
        {
            get { return _descuentoEspecial; }
            set { _descuentoEspecial = value; }
        }

        public DateTime FechaEmision
        {
            get { return _FechaEmision; }
            set { _FechaEmision = value; }
        }

        public DateTime FechaEntrega
        {
            get { return _FechaEntrega; }
            set { _FechaEntrega = value; }
        }
        public long NumeroOrden
        {
            get { return _NumeroOrden; }
            set { _NumeroOrden = value; }
        }
        public IList<NotaPedido_Item> Items
        {
            get { if (_Items == null) _Items = new List<NotaPedido_Item>(); return _Items; }
            set { _Items = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }

        /// <summary>
        /// Esta propiedad permite saber si se ha generado la factura 
        /// correspondiente a esta nota de pedido
        /// </summary>
        public bool FueFacturado
        {
            get
            {
                return _fueFacturado;
            }
        }
        #endregion

        #region Metodos Estaticos

        public static DataSet Buscar(string RazonSocial, SqlDateTime FechaEmision, SqlDateTime FechaEntrega, string Observaciones)
        {
            DataSet ds = null;
            string sqlCommand = Consts.NotaPedido_Buscar;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "RazonSocial", DbType.String, RazonSocial);
                db.AddInParameter(dbCommand, "FechaEmision", DbType.DateTime, FechaEmision);
                db.AddInParameter(dbCommand, "FechaEntrega", DbType.DateTime, FechaEntrega);
                db.AddInParameter(dbCommand, "Observaciones", DbType.String, Observaciones);

                ds = db.ExecuteDataSet(dbCommand);

                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

                Logger.Append(Consts.NotaPedido_Buscar, new Object[]{   "RazonSocial", RazonSocial, 
                                                                        "FechaEmision", FechaEmision,
                                                                        "FechaEntrega", FechaEntrega,
                                                                        "Observaciones", Observaciones}, ds.Tables[0].Rows.Count + " rows");
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                throw ex;
            }

            return ds;
        }
        /// <summary>
        /// Obtiene el Ultimo Numero de Orden almacenado en la base de datos
        /// </summary>
        /// <returns>Integer con el MAX(NumeroOrden) de la tabla NotaPedidos</returns>
        public static int ObtenerUltimoNumeroDeOrden()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.NotaPedido_ObtenerUltimoNumeroDeOrden;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            object oNumeroOrden = db.ExecuteScalar(dbCommand);

            Logger.Append(Consts.NotaPedido_ObtenerUltimoNumeroDeOrden, null, "NumeroNumeroOrden=" + oNumeroOrden.ToString());

            return Convert.ToInt32(oNumeroOrden);
        }
        /// <summary>
        /// Devuelve todas las notas de pedido almacenadas en la Base de Datos
        /// </summary>
        /// <returns>DataSet con los datos de la tabla NotaPedidos</returns>
        public static DataSet TraerTodas()
        {
            DataSet ds = null;
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                string sqlCommand = Consts.NotaPedido_TraerTodas;

                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                ds = db.ExecuteDataSet(dbCommand);

                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

                Logger.Append(Consts.NotaPedido_TraerTodas, null, ds.Tables[0].Rows.Count + " rows");
            }
            catch (Exception ex)
            {

                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Obtiene una Instancia de Nota de Pedido através de un Id suministrado
        /// </summary>
        /// <param name="id">IdNotaPedido de la Base de Datos, tabla NotaPedidos</param>
        /// <returns>Instancia de Nota de Pedido</returns>
        public static NotaPedido TraerNotaPedidoPorId(int id)
        {
            NotaPedido np = null;
            IList<NotaPedido_Item> items;

            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.NotaPedido_TraerPorId;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@IdNotaPedido", DbType.Int32, id);

            try
            {
                using (DataSet ds = db.ExecuteDataSet(dbCommand))
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];

                        np = new NotaPedido();

                        np._IdNotaPedido = Convert.ToInt32(dr["IdNotaPedido"]);
                        np._Cliente = Cliente.TraerClientePorID(Convert.ToInt32(dr["IdCliente"]));
                        np._FechaEmision = Convert.ToDateTime(dr["FechaEmision"]);
                        np._FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"]);
                        np._NumeroOrden = Convert.ToInt32(dr["NumeroOrden"]);
                        np._fueFacturado = Convert.ToBoolean(dr["Facturado"]);
                        np._Observaciones = dr["Observaciones"].ToString();
                        np._descuentoEspecial = Convert.ToInt32(dr["DescuentoEspecial"]);

                        Logger.Append(Consts.NotaPedido_TraerPorId, new Object[] { "IdNotaPedido", id }, "IdNotaPedido=" + np.IdNotaPedido.ToString());
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        items = new List<NotaPedido_Item>();
                        foreach (DataRow dr in ds.Tables[1].Rows)
                        {
                            NotaPedido_Item item = new NotaPedido_Item();

                            item.Articulo = Articulo.TraerArticuloPorID(Convert.ToInt32(dr["IdArticulo"]));
                            item.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                            item.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
                            item.Descuento = Convert.ToInt32(dr["Descuento"]);
                            items.Add(item);
                        }

                        np._Items = items;
                    }

                }

            }
            catch (Exception ex)
            {
                np = null;

                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                throw ex;
            }


            return np;
        }
        #endregion

        public static void ActualizarItems(int IdNotaPedido, IList<NotaPedido_Item> Items, DbTransaction ts)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.NotaPedido_Items_BorrarPorIdNotaPedido;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();

                try
                {

                    List<NotaPedido_Item> backupItems = new List<NotaPedido_Item>();

                    foreach (NotaPedido_Item item in Items)
                        backupItems.Add(item);

                    //borramos los items de la nota de pedido
                    dbCmdOC.Parameters.Clear();
                    dbCmdOC = db.GetStoredProcCommand(sqlCommand);

                    db.AddInParameter(dbCmdOC, "IdNotaPedido", DbType.Int32, IdNotaPedido);
                    int affectedRows = db.ExecuteNonQuery(dbCmdOC, ts);

                    Logger.Append(Consts.NotaPedido_Items_BorrarPorIdNotaPedido, new Object[] { "IdNotaPedido", IdNotaPedido }, affectedRows.ToString() + " rows afectadas");

                    /*Agrego los Items de la Orden a la Base de Datos*/
                    sqlCommand = Consts.NotaPedido_Items_AgregarItem;

                    dbCmdOC.Parameters.Clear();
                    dbCmdOC = db.GetStoredProcCommand(sqlCommand);

                    db.AddInParameter(dbCmdOC, "IdNotaPedido", DbType.Int32, IdNotaPedido);
                    db.AddInParameter(dbCmdOC, "IdArticulo", DbType.Int32, null);
                    db.AddInParameter(dbCmdOC, "Cantidad", DbType.Int32, null);
                    db.AddInParameter(dbCmdOC, "PrecioUnitario", DbType.Double, null);
                    db.AddInParameter(dbCmdOC, "Descuento", DbType.Int32, null);

                    foreach (NotaPedido_Item item in Items)
                    {
                        bool encontroBackup = false;
                        foreach (NotaPedido_Item backupItem in backupItems)
                        {
                            if (backupItem.Articulo.Id == item.Articulo.Id)
                            {
                                dbCmdOC.Parameters[1].Value = item.Articulo.Id;
                                dbCmdOC.Parameters[2].Value = item.Cantidad;
                                dbCmdOC.Parameters[3].Value = item.PrecioUnitario;
                                dbCmdOC.Parameters[4].Value = backupItem.Descuento;
                                encontroBackup = true;

                            }
                        }

                        if (!encontroBackup)
                        {
                            dbCmdOC.Parameters[1].Value = item.Articulo.Id;
                            dbCmdOC.Parameters[2].Value = item.Cantidad;
                            dbCmdOC.Parameters[3].Value = item.PrecioUnitario;
                            dbCmdOC.Parameters[4].Value = item.Descuento;
                        }

                        encontroBackup = false;
                        affectedRows = db.ExecuteNonQuery(dbCmdOC, ts);

                        Logger.Append(Consts.NotaPedido_Items_AgregarItem, new Object[] {   "IdNotaPedido", IdNotaPedido,
                                                                                            "IdArticulo", item.Articulo.Id,
                                                                                            "Cantidad", item.Cantidad,
                                                                                            "PrecioUnitario", item.PrecioUnitario,
                                                                                            "Descuento", item.Descuento}, affectedRows.ToString() + " rows afectadas");
                    }



                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #region Metodos Publicos

        public void Actualizar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.NotaPedido_Actualizar;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCmdOC, "IdNotaPedido", DbType.Int32, _IdNotaPedido);
            db.AddInParameter(dbCmdOC, "IdCliente", DbType.Int32, _Cliente.Id);
            db.AddInParameter(dbCmdOC, "FechaEntrega", DbType.DateTime, _FechaEntrega);
            db.AddInParameter(dbCmdOC, "DescuentoEspecial", DbType.Int32, this._descuentoEspecial);
            db.AddInParameter(dbCmdOC, "Observaciones", DbType.String, this._Observaciones);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction ts = conn.BeginTransaction();
                try
                {
                    //Actualizo los datos generales de la nota de pedido
                    int affectedRows = db.ExecuteNonQuery(dbCmdOC, ts);

                    ActualizarItems(this.IdNotaPedido, this._Items, ts);

                    ts.Commit();
                    Logger.Append(Consts.NotaPedido_Actualizar, new Object[] {  "IdNotaPedido", _IdNotaPedido,
                                                                                "IdCliente", _Cliente.Id,
                                                                                "FechaEntrega", _FechaEntrega,
                                                                                "DescuentoEspecial", _descuentoEspecial,
                                                                                "Observaciones", _Observaciones}, affectedRows.ToString() + " rows afectadas");
                }
                catch (Exception ex)
                {

                    ts.Rollback();
                    throw ex;
                }

                conn.Close();
            }

        }
        /// <summary>
        /// Almacena la Nota de Pedido en la Base de Datos
        /// 
        /// 1. Almcenar los datos generales de la Nota de Pedido 
        /// 2. Almacenar los items que componen la nota de pedido
        /// 3. En caso de error, se deshacen todos los cambios 
        /// 
        /// </summary>
        /// <returns>Id de la Nota de Pedido</returns>
        public int Guardar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.NotaPedido_Guardar;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);

            /*Parametros para OC */
            db.AddInParameter(dbCmdOC, "IdCliente", DbType.Int32, _Cliente.Id);
            db.AddInParameter(dbCmdOC, "FechaEmision", DbType.DateTime, _FechaEmision);
            db.AddInParameter(dbCmdOC, "FechaEntrega", DbType.DateTime, _FechaEntrega);
            db.AddInParameter(dbCmdOC, "DescuentoEspecial", DbType.Int32, this._descuentoEspecial);
            db.AddInParameter(dbCmdOC, "Observaciones", DbType.String, this._Observaciones);


            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction ts = conn.BeginTransaction();
                try
                {
                    //Agrego la orden a la Base de Datos
                    DataSet ds = db.ExecuteDataSet(dbCmdOC, ts);

                    _IdNotaPedido = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    ActualizarItems(this.IdNotaPedido, this._Items, ts);
                    ts.Commit();

                    Logger.Append(Consts.NotaPedido_Guardar, new Object[] {     "IdCliente",_Cliente.Id,
                                                                                "FechaEmision", _FechaEmision,
                                                                                "FechaEntrega", _FechaEntrega,
                                                                                "DescuentoEspecial", _descuentoEspecial,
                                                                                "Observaciones", _Observaciones}, "IdNotaPedido=" + _IdNotaPedido.ToString());
                }
                catch (Exception ex)
                {

                    ts.Rollback();
                    throw (ex);
                }

                conn.Close();
            }
            return _IdNotaPedido;
        }

        /// <summary>
        /// Elimina la Nota de Pedido de la Base da Datos
        /// 
        /// El Stored Procedure encargado realiza las siguientes acciones
        /// 
        /// 1. Elimina los datos generales de la Nota de Pedido
        /// 2. Elimina los items que componen la nota de pedido 
        /// </summary>
        public void Eliminar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.NotaPedido_Borrar;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCmdOC, "IdNotaPedido", DbType.Int32, _IdNotaPedido);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                try
                {
                    db.ExecuteNonQuery(dbCmdOC);
                }
                catch (Exception ex)
                {

                }
            }
        }

        /// <summary>
        /// Genera una nueva instancia de Factura, cuyos datos provienen de esta Nota de Pedido
        /// </summary>
        /// <returns>Una instancia de Factura</returns>
        public Factura GenerarFactura()
        {
            Factura f = null;
            /*if (_fueFacturado == false)
            {*/
            f = new Factura();

            f.Cliente = _Cliente;
            f.NotaPedido = this;

            foreach (NotaPedido_Item item in _Items)
            {
                f.Items.Add(item);
            }

            f.Fecha = DateTime.Now;
            //}

            return f;

        }

        public Remito GenerarRemito()
        {
            Remito r = new Remito();

            r.NotaPedido = this;
            r.Cliente = _Cliente;
            r.Items = _Items;
            r.Fecha = DateTime.Now;

            return r;
        }
        #endregion


    }
}