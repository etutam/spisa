using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;

using System.Data.SqlClient;
using System.Transactions;
using System.Configuration;

using System.Xml;

namespace SPISA.Libreria
{

    public class Factura
    {
        public struct Totales
        {
            public string Total;
            public string SubTotal1;
            public string SubTotal2;
            public string IvaInscripto;
            public string DescuentoEspecial;

        }


        
        #region Campos Privados
        int _IdFactura = -1;
        long _NumeroFactura = -1;
        int _DescuentoEspecial = 0;
        NotaPedido _NotaPedido = null;
        Cliente _Cliente = null;
        DateTime _FechaEmision;
        string _Observaciones = "";
        Decimal _valorDolar = 1;
        bool _fueImpresa = false;
        bool _fueCancelada = false;
        bool _esNotaDeCredito = false;
        private bool _esCotizacion = false;


        IList<NotaPedido_Item> _ListaItems = new List<NotaPedido_Item>();

        #endregion

        #region Constructores
        public Factura()
        {
        }

        #endregion

        #region Propiedades
        public bool EsCotizacion
        {
            get { return _esCotizacion; }
            set { _esCotizacion = value; }
        }
        public int Id
        {
            get { return _IdFactura; }
            set { _IdFactura = value; }

        }
        public long NumeroFactura
        {
            get { return _NumeroFactura; }
            set { _NumeroFactura = value; }
        }
        public int DescuentoEspecial
        {
            get { return _DescuentoEspecial; }
            set { _DescuentoEspecial = value; }
        }
        public DateTime Fecha
        {
            get { return _FechaEmision; }
            set { _FechaEmision = value; }
        }
        public Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public NotaPedido NotaPedido
        {
            get { return _NotaPedido; }
            set { _NotaPedido = value; }
        }
        public IList<NotaPedido_Item> Items
        {
            get { return _ListaItems; }
            set { _ListaItems = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
        public decimal ValorDolar
        {
            get { return _valorDolar; }
            set { _valorDolar = value; }
        }
        public bool FueImpresa
        {
            get { return _fueImpresa; }
            set { _fueImpresa = value; }
        }
        public bool FueCancelada
        {
            get { return _fueCancelada; }
            set { _fueCancelada = value; }
        }
        public bool EsNotaDeCredito
        {
            get { return _esNotaDeCredito; }
            set { _esNotaDeCredito = value; }
        }

        //public Afip afip { get; set; }
        #endregion

        #region Metodos Estaticos

  /*      public static DataSet Buscar(SqlInt32 NumeroFactura, string RazonSocial, SqlDateTime FechaEmision, string Observaciones, SqlInt32 FueImpresa, SqlInt32 FueCancelada)
        {
            DataSet ds = null;
            string sqlCommand = Consts.Facturas_Buscar;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                /*db.AddInParameter(dbCommand, "RazonSocial", DbType.String, RazonSocial);
                db.AddInParameter(dbCommand, "FechaEmision", DbType.DateTime, FechaEmision);
                db.AddInParameter(dbCommand, "FechaEntrega", DbType.DateTime, FechaEntrega);
                db.AddInParameter(dbCommand, "Observaciones", DbType.String, Observaciones);
                
                ds = db.ExecuteDataSet(dbCommand);

                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

                Logger.Append(Consts.Facturas_Buscar, new Object[] { "NumeroFactura", NumeroFactura, "RazonSocial", RazonSocial, "FechaEmision", FechaEmision.ToString(), "Observaciones", Observaciones, "FueImpresa", FueImpresa, "FueCancelada", FueCancelada }, ds.Tables[0].Rows.Count + " rows");
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                throw ex;
            }

            return ds;
        }*/
        public static long ObtenerNuevoNumeroDeFactura()
        {
            string sqlCommand = Consts.Facturas_ObtenerNumeroNumeroDeFactura;
            Int64 nuevoNumeroFactura = -1;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                nuevoNumeroFactura = Convert.ToInt32(ds.Tables[0].Rows[0]["NumeroFactura"]);
                Logger.Append(Consts.Facturas_ObtenerNumeroNumeroDeFactura, null, "NuevoNumeroFactura=" + nuevoNumeroFactura.ToString());
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            return nuevoNumeroFactura;
        }



        public static DataSet TraerEntreFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            if ((FechaInicio == null) || (FechaFin == null) || (FechaInicio.Ticks > FechaFin.Ticks)) throw new Exception("(FechaInicio o FechaFin==null) o (FechaInicio.Ticks>FechaFin.Ticks)");

            string sqlCommand = Consts.Facturas_TraerTodas;
            DataSet ds = null;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                ds = db.ExecuteDataSet(dbCommand);

                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

                Logger.Append(Consts.Facturas_TraerTodas, new Object[] { "FechaInicio", FechaInicio.ToString(), "FechaFin", FechaFin.ToString() }, ds.Tables[0].Rows.Count + " rows");
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
        public static DataSet TraerTodas()
        {
            string sqlCommand = Consts.Facturas_TraerTodas;
            DataSet ds = null;
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                ds = db.ExecuteDataSet(dbCommand);

                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

                Logger.Append(Consts.Facturas_TraerTodas, null, ds.Tables[0].Rows.Count + " rows");
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

        public static void CargarDatosEnFactura(DataSet ds, ref Factura f)
        {
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];

                    f = new Factura();
                    f._IdFactura = (int)dr["IdFactura"];
                    f._FechaEmision = (DateTime)dr["Fecha"];
                    f._NumeroFactura = Convert.ToInt64(dr["NumeroFactura"]);
                    f._NotaPedido = NotaPedido.TraerNotaPedidoPorId((int)dr["IdNotaPedido"]);
                    f._Cliente = f._NotaPedido.Cliente;
                    f._Observaciones = dr["Observaciones"].ToString();
                    f._fueImpresa = Convert.ToBoolean(dr["FueImpresa"]);
                    f._fueCancelada = Convert.ToBoolean(dr["FueCancelada"]);
                    f._valorDolar = Convert.ToDecimal(dr["ValorDolar"].ToString());
                    f._esNotaDeCredito = Convert.ToBoolean(dr["EsNotaDeCredito"]);
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

                    f._ListaItems = items;
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
        public static Factura TraerFacturaPorID(int id)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Facturas_TraerFacturaPorID;
            Factura f = null;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "IdFactura", DbType.Int32, id);

            try
            {
                using (DataSet ds = db.ExecuteDataSet(dbCommand))
                {
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            CargarDatosEnFactura(ds, ref f);
                            Logger.Append(Consts.Facturas_TraerFacturaPorID, new Object[] { "IdFactura", id }, "IdFactura=" + f.Id.ToString());
                        }
                }


            }
            catch (Exception ex)
            {

                f = null;
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw ex;
            }

            return f;
        }

        public static Factura TraerFacturaPorIdNotaPedido(int idNotaPedido)
        {
            if (idNotaPedido == -1)
                return null;

            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Facturas_TraerFacturaPorIdNotaPedido;
            Factura f = null;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "IdNotaPedido", DbType.Int32, idNotaPedido);

            try
            {
                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
                {
                    if (dataReader.Read())
                    {
                        f = new Factura();
                        f._IdFactura = (int)dataReader["IdFactura"];
                        f._FechaEmision = (DateTime)dataReader["Fecha"];
                        f._NumeroFactura = Convert.ToInt64(dataReader["NumeroFactura"]);
                        f._NotaPedido = NotaPedido.TraerNotaPedidoPorId(idNotaPedido);
                        f._Observaciones = dataReader["Observaciones"].ToString();

                        f._Cliente = f._NotaPedido.Cliente;
                        f._ListaItems = f._NotaPedido.Items;
                        f._fueImpresa = Convert.ToBoolean(dataReader["FueImpresa"]);
                        f._fueCancelada = Convert.ToBoolean(dataReader["FueCancelada"]);
                        f._valorDolar = Convert.ToDecimal(dataReader["ValorDolar"]);
                        f._esNotaDeCredito = Convert.ToBoolean(dataReader["EsNotaDeCredito"]);

                        Logger.Append(Consts.Facturas_TraerFacturaPorIdNotaPedido, new Object[] { "IdNotaPedido", idNotaPedido }, "IdFactura=" + f.Id.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                f = null;

                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw (ex);
            }

            return f;
        }

        #endregion

        #region Metodos Publicos

        //public void Registrar (Factura factura,Cliente detallesCliente,Totales totales)
        //{
        //    afip.Registrar(factura, detallesCliente,
        //        totales);
        //}

        /// <summary>
        /// El metodo deberá:
        /// - Almacenar el Movimiento en la cuenta corriente del cliente
        /// - Se considera que, a partir de la Impresion de la factura, los materiales son considerados como "Debitados" de la base de datos,
        /// y deben darse de baja en la misma.
        /// </summary>
        public void AlmacenarImpresion(bool EsNotaDeCredito)
        {
            if (this.FueCancelada) throw new Exception("La factura ha sido cancelada y no puede imprimirse");

            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Facturas_AlmacenarImpresion;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCmdOC, "IdFactura", DbType.Int32, this._IdFactura);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction ts = conn.BeginTransaction();

                try
                {
                    if (!this._fueImpresa)
                    {
                        db.ExecuteNonQuery(dbCmdOC, ts);

                        // Almacenamos el Movimiento
                        CuentaCorriente.TraerPorIdCliente(this._Cliente.Id).AlmacenarMovimiento(new CuentaCorriente.Movimiento(this, this._FechaEmision, this.CalcularTotal()), ts);

                        foreach (NotaPedido_Item item in this.Items)
                        {
                            // Restamos el Stock
                            Articulo.ModificarCantidad(item.Articulo.Id, item.Cantidad, (!this.EsNotaDeCredito ? 1 : 2)); // 1: Debe - 2: Haber
                        }
                    }
                    ts.Commit();
                    Logger.Append(Consts.Facturas_AlmacenarImpresion, new Object[] { "EsNotaDeCredito", EsNotaDeCredito }, "No devuelve nada");

                }
                catch (Exception ex)
                {
                    AppSettingsReader appSettingsReader = new AppSettingsReader();
                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                    ts.Rollback();
                    throw ex;
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        public void Actualizar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Facturas_ActualizarFactura;

            DbCommand dbCmdOC = db.GetStoredProcCommand(sqlCommand);


            db.AddInParameter(dbCmdOC, "IdFactura", DbType.Int32, this._IdFactura);
            db.AddInParameter(dbCmdOC, "IdCliente", DbType.Int32, (this._Cliente.Id != null ? this._Cliente.Id : -1));
            db.AddInParameter(dbCmdOC, "Fecha", DbType.DateTime, this._FechaEmision);
            db.AddInParameter(dbCmdOC, "Observaciones", DbType.String, (this._Observaciones != null ? this._Observaciones : ""));
            db.AddInParameter(dbCmdOC, "DescuentoEspecial", DbType.Int32, this._DescuentoEspecial);
            db.AddInParameter(dbCmdOC, "ValorDolar", DbType.Decimal, (this._valorDolar != -1 ? this._valorDolar : -1));
            db.AddInParameter(dbCmdOC, "EsNotaDeCredito", DbType.Boolean, this._esNotaDeCredito);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction ts = conn.BeginTransaction();

                try
                {
                    db.ExecuteNonQuery(dbCmdOC, ts);
                    NotaPedido.ActualizarItems(this.NotaPedido.IdNotaPedido, this._ListaItems, ts);

                    ts.Commit();
                    Logger.Append(Consts.Facturas_ActualizarFactura, new Object[] { "IdFactura", this._IdFactura,
                                                                                    "IdCliente", this._Cliente.Id,
                                                                                    "Fecha", this._FechaEmision,
                                                                                    "Observaciones", this._Observaciones,
                                                                                    "DescuentoEspecial", this._DescuentoEspecial,
                                                                                    "ValorDolar", this._valorDolar,
                                                                                    "EsNotaDeCredito", this._esNotaDeCredito}, "No devuelve nada");
                }
                catch (Exception ex)
                {
                    AppSettingsReader appSettingsReader = new AppSettingsReader();
                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                    ts.Rollback();
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Facturas_GuardarFactura realiza las siguientes operaciones
        /// 1. Guarda la factura en la base de datos
        /// 2. Actualiza IdFactura de OrdenesDeCompra
        /// 
        /// 
        /// PROBLEMA: Mi viejo pide que se puedan generar facturas que no provengan de una nota de pedido
        /// En tal caso, cuando guardamos, debemos preguntar 
        /// - Si tiene nota de pedido, no se guardan en la tabla Factura_Items los items
        /// - Si no tiene nota de pedido, se almacenan en esa tabla los items
        /// - Probablemente, las facturas generadas sin pedidos nunca tenga pedidos, entonces en 2 lugares van a quedar
        ///   items, en NotaPedido_Items y en Factura_Items. Esto esta bien??
        /// 
        /// SOLUCION: Si la factura que vamos a guardar no posee una nota de pedido, entonces la generamos automaticamente y la guardamos
        /// tambien automaticamente de esta manera, se conserva un unico lugar para los items 
        /// 
        /// La función Guardar tambien Actualiza la cuenta corriente del cliente 

        /// </summary>
        /// <returns></returns>
        public int Guardar()
        {
            if (this._Cliente == null) throw new Exception("Cliente es nulo");

            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Facturas_GuardarFactura;

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
                        np.Guardar(ts,false);
                        this._NotaPedido = np;
                    }
                    else
                    {
                        NotaPedido.ActualizarItems(this.NotaPedido.IdNotaPedido, this._ListaItems, ts);
                    }

                    db.AddInParameter(dbCommand, "Fecha", DbType.DateTime, this._FechaEmision);
                    db.AddInParameter(dbCommand, "IdNotaPedido", DbType.Int32, this._NotaPedido.IdNotaPedido);
                    db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, (this._Cliente != null ? this._Cliente.Id : -1));
                    db.AddInParameter(dbCommand, "NumeroFactura", DbType.Int64, this._NumeroFactura);
                    db.AddInParameter(dbCommand, "Observaciones", DbType.String, (this._Observaciones != null ? this._Observaciones : ""));
                    db.AddInParameter(dbCommand, "DescuentoEspecial", DbType.Int32, this._DescuentoEspecial);
                    db.AddInParameter(dbCommand, "ValorDolar", DbType.Decimal, (this._valorDolar != 0 ? this._valorDolar : 0));
                    db.AddInParameter(dbCommand, "EsNotaDeCredito", DbType.Boolean, this._esNotaDeCredito);
                    db.AddInParameter(dbCommand, "EsCotizacion", DbType.Boolean, this._esCotizacion);

                    _IdFactura = Convert.ToInt32(db.ExecuteScalar(dbCommand, ts));


                    Logger.Append(Consts.Facturas_GuardarFactura, new Object[]{   "FechaEmision", this._FechaEmision.ToString(),
                                                                        "IdNotaPedido", this._NotaPedido.IdNotaPedido.ToString(),
                                                                        "IdCliente", this._Cliente.Id.ToString(),
                                                                        "NumeroFactura", this._NumeroFactura.ToString(),
                                                                        "Observaciones", this._Observaciones,
                                                                        "DescuentoEspecial", this._DescuentoEspecial.ToString(),
                                                                        "ValorDolar", this._valorDolar.ToString(),
                                                                        "EsNotaDeCredito", this._esNotaDeCredito.ToString()}, _IdFactura.ToString());
                    ts.Commit();
                }
                catch (Exception ex)
                {
                    //AppSettingsReader appSettingsReader = new AppSettingsReader();
                   // bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                    //if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                    ts.Rollback();
                    throw ex;
                }
            }
            return _IdFactura;
        }

        /// <summary>
        /// Éste método se encargará de cancelar la factura generada. 
        /// 
        /// Existen 2 tipos de cancelaciones: 
        /// 
        /// - Si la factura no fue impresa, la misma se cancela y se elimina de la base de datos, 
        ///   y se deben revertir todos los pasos del a impresion (Borrar el Movimiento de la Cuenta corriente, 
        ///   Devolver la Cantidad de Items, borrar los movimientos en la base de datos.
        /// - Si la factura fue impresa, la misma no podra eliminarse de la base de datos, sin embargo
        ///   tambien se reestableceran los datos anteriormente mencionados.
        /// </summary>
        /// <returns></returns>

        public int Cancelar()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = Consts.Facturas_CancelarFactura;

            int result = 0;

            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "IdFactura", DbType.Int32, this._IdFactura);

            using (DbConnection conn = db.CreateConnection())
            {

                conn.Open();

                try
                {
                    db.ExecuteNonQuery(dbCommand);
                    Logger.Append(Consts.Facturas_CancelarFactura, new Object[] { "IdFactura", this._IdFactura }, "No Devuelve Nada");

                }
                catch (Exception ex)
                {
                    AppSettingsReader appSettingsReader = new AppSettingsReader();
                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                    MessageBox.Show("ERROR AL CANCELAR FACTURA");
                    throw ex;
                }
            }
            return result;
        }


        public static DataSet Buscar(string razonSocial, SqlDateTime fechaDesde,SqlDateTime fechaHasta, string observaciones,SqlInt32 numeroFactura)
        {
            DataSet ds = null;
            string sqlCommand = Consts.Facturas_Buscar ;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                
                db.AddInParameter(dbCommand, "FechaDesde", DbType.DateTime,(fechaDesde.IsNull?SqlDateTime.MinValue:fechaDesde.Value));
                
                
                //db.AddInParameter(dbCommand,"FechaDesde",DbType.DateTime,fechaDesde.Value);
               
                db.AddInParameter(dbCommand, "FechaHasta", DbType.DateTime,(fechaHasta.IsNull?SqlDateTime.MinValue:fechaHasta.Value));
                
                
                //db.AddInParameter(dbCommand, "FechaHasta", DbType.DateTime, fechaHasta.Value);
                db.AddInParameter(dbCommand,"RazonSocial",DbType.String,razonSocial);
                db.AddInParameter(dbCommand,"NumeroFactura",DbType.Int32,numeroFactura);
                db.AddInParameter(dbCommand,"Observaciones",DbType.String,observaciones);
                ds= db.ExecuteDataSet(dbCommand);
                DataRelation rel = new DataRelation("Id", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(rel);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Produjo una excepción al ejecutar la busqueda \n"+ ex.Message);
            }


            return ds;
        }


        public Decimal CalcularTotal()
        {
            Decimal d_SubTotal = 0;

            foreach (NotaPedido_Item item in this._ListaItems)
            {
                Decimal precioUnitario = item.PrecioUnitario;

                Decimal precioFinalSinDescuento = item.Cantidad * item.PrecioUnitario;
                Decimal precioFinalConDescuento = precioFinalSinDescuento - (precioFinalSinDescuento * (item.Descuento > 0 ? (item.Descuento / 100) : 0));

                d_SubTotal += precioFinalConDescuento * this._valorDolar;
            }


            switch (this._Cliente.IVA.Condicion)
            {
                case "Responsable Inscripto":
                    d_SubTotal *= Convert.ToDecimal(1.21);
                    break;
                case "Responsable No Inscripto":
                    d_SubTotal *= Convert.ToDecimal(1.105);
                    break;
                case "Exento":
                    d_SubTotal += ((d_SubTotal * Convert.ToDecimal(0.21)) + (d_SubTotal * Convert.ToDecimal(1.105)));
                    break;
            }


            if (this.NotaPedido.DescuentoEspecial != 0) d_SubTotal = d_SubTotal - (Convert.ToDecimal(d_SubTotal) * Convert.ToDecimal(this.NotaPedido.DescuentoEspecial)) / 100;

            return d_SubTotal;
        }


        public NotaPedido GenerarNotaDePedido()
        {
            NotaPedido np = new NotaPedido();

            np.Cliente = this._Cliente;
            np.FechaEmision = this._FechaEmision;
            np.FechaEntrega = this._FechaEmision;
            np.Items = this._ListaItems;

            return np;

        }
        #endregion
    }
}
