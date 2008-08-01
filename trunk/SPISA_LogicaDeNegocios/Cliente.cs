//using System;
//using System.Collections.Generic;
//using System.Text;

//using Microsoft.Practices.EnterpriseLibrary.Data;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

//using System.Data;
//using System.Data.Common;

//using System.Configuration;

//namespace SPISA.Libreria
//{
//    public class Cliente
//    {
        
//        #region Constructores
//        public Cliente()
//        {

//        }
//        #endregion

//        #region Campos Privados
//        int _idCliente;
//        int _codigo; 
//        string _razonSocial;
//        string _domicilio;
//        string _localidad;
//        string _cuit;
//        Decimal _saldo;

//        IList<Descuento> _descuentos;

//        Provincia _provincia; 
//        CondicionIVA _iva;
//        Operatoria _operatoria;
//        CuentaCorriente _cuentaCorriente; 
//        DateTime _fechaAlta;
//        Transportista _transportista = null;
//        #endregion

//        #region Propiedades
//        public int Id
//        {
//            get { return _idCliente; }
//            set { _idCliente = value;  }
//        }
//        public int Codigo
//        {
//            get { return _codigo; }
//            set { _codigo = value; }
//        }
//        public string RazonSocial
//        {
//            get { return _razonSocial; }
//            set { _razonSocial = value; }
//        }
//        public string Domicilio
//        {
//            get { return _domicilio; }
//            set { _domicilio = value; } 
//        }
//        public string Localidad
//        {
//            get { return _localidad; }
//            set { _localidad = value; }
//        }
//        public Decimal Saldo
//        {
//            get { return _saldo; }
//            set { _saldo = value; }
//        }
//        public IList<Descuento> Descuentos
//        {
//            get { return _descuentos; }
//            set { _descuentos = value; }
//        }
//        public Provincia Provincia
//        {
//            get { return _provincia; }
//            set { _provincia = value; }
//        }

//        public CondicionIVA IVA
//        {
//            get {
//                return _iva;

//            }
//            set {
//                _iva = value;                
//            }
//        }
//        public string CUIT
//        {
//            get { return _cuit; }
//            set { _cuit = value; } 
//        }
//        public Operatoria Operatoria
//        {
//            get { return _operatoria; }
//            set { _operatoria = value; }
//        }

//        public CuentaCorriente CuentaCorriente
//        {
//            get
//            {
//                return _cuentaCorriente; 
//            }
//            set
//            {
//                _cuentaCorriente = value;
//            }
//        }
//        public Transportista Transportista
//        {
//            get
//            {
//                return _transportista;
//            }
//            set
//            {
//                _transportista = value; 
//            }
//        }
//        #endregion

//        #region Metodos Estaticos
//        public static int EstablecerTransportista(int IdCliente, int IdTransportista)
//        {
//            if (Transportista.TraerTransportistaPorId(IdTransportista)==null) throw new Exception("No Existe el transportista");
            
//            int _affectedRows = -1;

//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Clientes_EstablecerTransportista;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, IdCliente);
//            db.AddInParameter(dbCommand, "IdTransportista", DbType.Int32, IdTransportista);

//            using (DbConnection conn = db.CreateConnection())
//            {
//                conn.Open();

//                try
//                {
//                    //Actualizamos los datos del Cliente
//                    _affectedRows = db.ExecuteNonQuery(dbCommand);
//                }
//                catch (Exception ex)
//                {
//                    AppSettingsReader appSettingsReader = new AppSettingsReader();
//                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                    throw ex;
//                }
//            }

//            return _affectedRows;
//        }
           
//        public static int ObtenerNuevoNumeroDeCliente()
//        {
//            string sqlCommand = Consts.Clientes_ObtenerNuevoNumeroCliente;
//            int nuevoNumeroCliente = -1;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//                DataSet ds = db.ExecuteDataSet(dbCommand);

//                nuevoNumeroCliente = Convert.ToInt32(ds.Tables[0].Rows[0]["NumeroCliente"]);

//                Logger.Append(Consts.Clientes_ObtenerNuevoNumeroCliente, null, "NuevoNumeroCliente=" + nuevoNumeroCliente);
//            }
//            catch (Exception ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                throw ex;
//            }

//            return nuevoNumeroCliente;
//        }
//        public static DataTable TraerTodos()
//        {
//            DataSet ds = null; 
//            string sqlCommand = Consts.Clientes_TraerTodos;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
 
//                ds = db.ExecuteDataSet(dbCommand);

//                Logger.Append(Consts.Clientes_TraerTodos, null, ds.Tables[0].Rows.Count + " rows");
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
//        private static void CargarDatosEnCliente(IDataReader dr, ref Cliente c)
//        {
//            if (c == null) c = new Cliente();

//            c._idCliente = Convert.ToInt32(dr["IdCliente"].ToString());
//            c._codigo = Convert.ToInt32(dr["Codigo"].ToString());
//            c._razonSocial = dr["RazonSocial"].ToString();
//            c._domicilio = dr["Domicilio"].ToString();
//            c._localidad = dr["Localidad"].ToString();
//            c._saldo = Convert.ToDecimal(dr["Saldo"].ToString());
//            c._descuentos = Descuento.TraerDescuentosPorIdCliente(c._idCliente);
//            c._provincia = Provincia.TraerProvinciaPorId(Convert.ToInt32(dr["IdProvincia"].ToString()));
//            c._iva = CondicionIVA.TraerCondicionIVAPorId(Convert.ToInt32(dr["IdCondicionIVA"].ToString()));
//            c._cuit = dr["CUIT"].ToString();
//            c._operatoria = Operatoria.TraerOperatoriaPorId(Convert.ToInt32(dr["IdOperatoria"].ToString()));
            
//            if (dr["IdTransportista"]!=DBNull.Value) 
//                c._transportista = Transportista.TraerTransportistaPorId(Convert.ToInt32(dr["IdTransportista"].ToString()));
//        }

//        public static Cliente TraerClientePorRazonSocial(string RazonSocial)
//        {
//            string sqlCommand = Consts.Clientes_TraerClientePorRazonSocial;
//            Cliente c = null;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "RazonSocial", DbType.String, RazonSocial);

//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    if (dr.Read())
//                    {
//                        CargarDatosEnCliente(dr, ref c);
//                        Logger.Append(Consts.Clientes_TraerClientePorRazonSocial, new Object[] { "RazonSocial", RazonSocial }, "IdCliente=" + c.Id.ToString());
//                    }
//                }
                
//            }
//            catch (Exception ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                ex.Data.Add("CodigoCliente", RazonSocial);
//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                c = null;


//                throw ex;
//            }

//            return c;

//        }
//        public static Cliente TraerClientePorCodigo(string codigo)
//        {
//            string sqlCommand = Consts.Clientes_TraerClientePorCodigo;
//            Cliente c = null;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "Codigo", DbType.String, codigo);

//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    if (dr.Read())
//                    {
//                        CargarDatosEnCliente(dr, ref c);
//                        Logger.Append(Consts.Clientes_TraerClientePorCodigo, new Object[] { "Codigo", codigo }, "IdCliente=" + c.Id.ToString());
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                ex.Data.Add("CodigoCliente", codigo);
//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                c = null;

                
//                throw ex;
//            }

//            return c;
//        }
//        public static Cliente TraerClientePorID(int IdCliente)
//        {
//            string sqlCommand = Consts.Clientes_TraerPorId; 
//            Cliente c = null;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, IdCliente);

//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    if (dr.Read())
//                    {
//                        CargarDatosEnCliente(dr, ref c);
//                        Logger.Append(Consts.Clientes_TraerPorId, new Object[] { "IdCliente", IdCliente }, "IdCliente=" + c.Id.ToString());
//                    }
//                }
                
//            }
//            catch (Exception ex)
//            {
//                c = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                ex.Data.Add("IdCliente", IdCliente);

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                throw ex;
                
//            }
//            return c;
//        }
//        public static DataTable Buscar(string Codigo, string Localidad, string RazonSocial, string CriterioSaldo, Decimal Saldo)
//        {
//            DataSet ds = null;
//            string sqlCommand = Consts.Clientes_Buscar;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//                db.AddInParameter(dbCommand, "Codigo", DbType.String, Codigo);
//                db.AddInParameter(dbCommand, "Localidad", DbType.String, Localidad);
//                db.AddInParameter(dbCommand, "RazonSocial", DbType.String, RazonSocial);
//                db.AddInParameter(dbCommand, "CriterioSaldo", DbType.String, CriterioSaldo);
//                db.AddInParameter(dbCommand, "Saldo", DbType.Decimal, Saldo);

//                ds = db.ExecuteDataSet(dbCommand);

//                Logger.Append(Consts.Clientes_Buscar, new Object[] {    "Codigo", Codigo,
//                                                                        "Localidad", Localidad,
//                                                                        "RazonSocial", RazonSocial,
//                                                                        "CriterioSaldo", CriterioSaldo,
//                                                                        "Saldo", Saldo.ToString()}, ds.Tables[0].Rows.Count + " rows");
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
//        #endregion

//        #region Métodos Públicos
//        public int Actualizar()
//        {
//            if (string.IsNullOrEmpty(this._razonSocial) || (this._provincia == null) || (this._iva == null) || (this._operatoria == null)) throw new NullReferenceException("No se pudo almacenar el Cliente debido a que algunas de las variables son nulas o vacias");

//            int _affectedRows = -1;

//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Clientes_ActualizarCliente;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, this._idCliente);
//            db.AddInParameter(dbCommand, "RazonSocial", DbType.String, this._razonSocial);
//            db.AddInParameter(dbCommand, "Domicilio", DbType.String, this._domicilio);
//            db.AddInParameter(dbCommand, "Localidad", DbType.String, this._localidad);
//            db.AddInParameter(dbCommand, "IdProvincia", DbType.Int32, this._provincia.Id);
//            db.AddInParameter(dbCommand, "IdCondicionIVA", DbType.Int32, this._iva.Id);
//            db.AddInParameter(dbCommand, "CUIT", DbType.String, this._cuit);
//            db.AddInParameter(dbCommand, "IdOperatoria", DbType.Int32, this._operatoria.Id);

//            using (DbConnection conn = db.CreateConnection())
//            {
//                conn.Open();
//                DbTransaction ts = conn.BeginTransaction();

//                try
//                {
//                    //Actualizamos los datos del Cliente
//                    _affectedRows =  db.ExecuteNonQuery(dbCommand,ts);

//                    //Actualizamos los Descuentos para este cliente
//                    Descuento.ActualizarDescuentos(this._idCliente, this._descuentos, ts);
//                    ts.Commit();

//                    Logger.Append(Consts.Clientes_ActualizarCliente, new Object[] {     "IdCliente", this._idCliente,
//                                                                                        "RazonSocial", this._razonSocial,
//                                                                                        "Domicilio", this._domicilio,
//                                                                                        "Localidad", this._localidad,
//                                                                                        "IdProvincia", this._provincia.Id,
//                                                                                        "IdCondicionIVA", this._iva.Id,
//                                                                                        "CUIT", this._cuit,
//                                                                                        "IdOperatoria", this._operatoria.Id}, _affectedRows + " rows afectadas");
//                }
//                catch (Exception ex)
//                {
//                    ts.Rollback();
//                    AppSettingsReader appSettingsReader = new AppSettingsReader();
//                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                    throw ex;
//                }
//            }
//            return _idCliente;
//        }
//        public int Guardar()
//        {
//            if (this._codigo == -1 || string.IsNullOrEmpty(this._razonSocial) || (this._provincia == null) || (this._iva == null) || (this._operatoria == null)) throw new NullReferenceException("No se pudo almacenar el Cliente debido a que algunas de las variables son nulas o vacias");

//            object r = null;
//            int _idCliente = -1;
            
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Clientes_GuardarCliente;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            

//            db.AddInParameter(dbCommand, "Codigo", DbType.Int32, this._codigo);
//            db.AddInParameter(dbCommand, "RazonSocial", DbType.String, this._razonSocial);
//            db.AddInParameter(dbCommand, "Domicilio", DbType.String, this._domicilio);
//            db.AddInParameter(dbCommand, "Localidad", DbType.String, this._localidad);
//            db.AddInParameter(dbCommand, "IdProvincia", DbType.Int32, this._provincia.Id);
//            db.AddInParameter(dbCommand, "IdCondicionIVA", DbType.Int32, this._iva.Id);
//            db.AddInParameter(dbCommand, "CUIT", DbType.String, this._cuit );
//            db.AddInParameter(dbCommand, "IdOperatoria", DbType.Int32, this._operatoria.Id);

//            using (DbConnection conn = db.CreateConnection())
//            {
//                conn.Open();
//                try
//                {
//                    r = db.ExecuteScalar(dbCommand);

//                    _idCliente = Convert.ToInt32(r);

//                    Logger.Append(Consts.Clientes_GuardarCliente, new Object[] {    "Codigo", this._codigo,
//                                                                                    "RazonSocial", this._razonSocial,
//                                                                                    "Domicilio", this._domicilio,
//                                                                                    "Localidad", this._localidad,
//                                                                                    "IdProvincia", this._provincia.Id,
//                                                                                    "IdCondicionIVA", this._iva.Id,
//                                                                                    "CUIT", this._cuit,
//                                                                                     "IdOperatoria", this._operatoria.Id}, "IdCliente=" + _idCliente);
               
//                }
//                catch (Exception ex)
//                {
//                    AppSettingsReader appSettingsReader = new AppSettingsReader();
//                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                    throw ex;
//                }
//            }
//            return _idCliente;
//        }
//        #endregion
//    }
//    public class Operatoria
//    {
//        #region Constructores
//        private Operatoria(){ }
//        #endregion

//        #region Campos Privados
//        int _idOperatoria;
//        string _operatoria;
//        #endregion

//        #region Propiedades
//        public int Id
//        {
//            get { return this._idOperatoria; }
//            set { this._idOperatoria = value; }
//        }
//        public string Tipo
//        {
//            get { return this._operatoria; }
//            set { this._operatoria = value; }
//        }
//        #endregion

//        #region Métodos Estáticos 
//        public static DataTable TraerTodas()
//        {
//            DataSet ds = null;
//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                string sqlCommand = Consts.Operatorias_TraerTodas;
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
//        public static void CargarDatosEnOperatoria(IDataReader dr, ref Operatoria o)
//        {
//            if (o == null) o = new Operatoria();
//            o._idOperatoria = Convert.ToInt32(dr["IdOperatoria"].ToString());
//            o._operatoria = dr["Operatoria"].ToString();
//        }
//        public static Operatoria TraerOperatoriaPorOperatoria(string Operatoria)
//        {
//            try
//            {
//                if (String.IsNullOrEmpty(Operatoria)) throw new ArgumentNullException("Operatoria esta nulo o vacio");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            Operatoria o = null;
//            string sqlCommand = Consts.Operatorias_TraerPorOperatoria;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "Operatoria", DbType.String, Operatoria);

//                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
//                {
//                    if (dataReader.Read())
//                    {
//                        CargarDatosEnOperatoria(dataReader, ref o);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                o = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");

//                throw e;
//            }

//            return o;

//        }
//        public static Operatoria TraerOperatoriaPorId(int IdOperatoria)
//        {
//            try
//            {
//                if (IdOperatoria <= 0) throw new ArgumentNullException("IdOperatoria es <= 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            Operatoria o = null;
//            string sqlCommand = Consts.Operatorias_TraerPorId;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "IdOperatoria", DbType.Int32, IdOperatoria);

//                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
//                {
//                    if (dataReader.Read())
//                    {
//                        CargarDatosEnOperatoria(dataReader, ref o);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                o = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");

//                throw e;
//            }

//            return o;

//        }
//        #endregion
//    }
//    public class CondicionIVA
//    {
//        #region Constructores
//        private CondicionIVA() { }
//        #endregion
        
//        #region Campos Privados
//        int _idCondicionIVA;
//        string _condicionIVA;
//        #endregion

//        #region Propiedades
//        public int Id
//        {
//            get { return this._idCondicionIVA; }
//            set { this._idCondicionIVA = value; }

//        }

//        public string Condicion
//        {
//            get { return this._condicionIVA; }
//            set { this._condicionIVA = value; }
//        }


//        #endregion

//        #region Métodos Estáticos
//        public static DataTable TraerTodas()
//        {
//            DataSet ds = null;
//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                string sqlCommand = Consts.CondicionesIVA_TraerTodas;
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
//        private static void CargarDatosEnCondicionIVA(IDataReader dr, ref CondicionIVA ci)
//        {
//            if (ci == null) ci = new CondicionIVA();
//            ci._idCondicionIVA = Convert.ToInt32(dr["IdCondicionIVA"].ToString());
//            ci._condicionIVA = dr["CondicionIVA"].ToString();
//        }

//        public static CondicionIVA TraerCondicionIVAPorCondicionIVA(string CondicionIVA)
//        {
//            try
//            {
//                if (String.IsNullOrEmpty(CondicionIVA)) throw new ArgumentNullException("CondicionIVA es nulo o esta vacio");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            CondicionIVA ci = null;
//            string sqlCommand = Consts.CondicionesIVA_TraerPorCondicionIVA;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "CondicionIVA", DbType.String, CondicionIVA);

//                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
//                {
//                    if (dataReader.Read())
//                    {
//                        CargarDatosEnCondicionIVA(dataReader, ref ci);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                ci = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");

//                throw e;
//            }

//            return ci;

//        }
//        public static CondicionIVA TraerCondicionIVAPorId(int IdCondicionIVA)
//        {

//            try
//            {
//                if (IdCondicionIVA <= 0) throw new ArgumentNullException("IdCondicionIVA es <= 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            CondicionIVA ci = null;
//            string sqlCommand = Consts.CondicionesIVA_TraerPorId;
            
//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "IdCondicionIVA", DbType.Int32, IdCondicionIVA);
            
//                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
//                {
//                    if (dataReader.Read())
//                    {
//                        CargarDatosEnCondicionIVA(dataReader, ref ci);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                ci = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");

//                throw e;
//            }

//            return ci;

//        }
//        #endregion
//    }
//    public class Descuento
//    {
//        #region Campos Privados
//        Categoria _categoria;
//        int _porcentaje;
//        #endregion

//        #region Propiedades
        
//        public Categoria Categoria
//        {
//            get { return _categoria; }
//            set { _categoria = value; }
//        }
//        public int   Porcentaje
//        {
//            get { return _porcentaje; }
//            set { _porcentaje = value; }
//        }


//        #endregion

//        #region Métodos Estáticos
//        public static IList<Descuento> TraerDescuentosPorIdCliente(int IdCliente)
//        {
//            try
//            {
//                if (IdCliente <= 0) throw new ArgumentNullException("IdCliente es <= 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return null;
//            }

//            IList<Descuento> descuentos = null;
//            string sqlCommand = Consts.Descuentos_TraerPorIdCliente;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, IdCliente);

//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    descuentos = new List<Descuento>();

//                    while (dr.Read())
//                    {
//                        Descuento d = new Descuento();
//                        d.Categoria = Categoria.TraerCategoriaPorId(Convert.ToInt32(dr["IdCategoria"].ToString()));
//                        d.Porcentaje = Convert.ToInt32(dr["Descuento"]);

//                        descuentos.Add(d);
//                    }
                    
//                }
//            }
//            catch (Exception e)
//            {
//                descuentos = null;

//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");

//                throw e;
//            }

//            return descuentos;
//        }
//        public static int AgregarDescuento(int IdCliente, Descuento Descuento, DbTransaction ts)
//        {
//            Database db = DatabaseFactory.CreateDatabase();
//            string sqlCommand = Consts.Descuentos_AgregarDescuento;

//            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

//            int ret = -1; 
//            using (DbConnection conn = db.CreateConnection())
//            {
//                conn.Open();

//                try
//                {
//                    db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, IdCliente);
//                    db.AddInParameter(dbCommand, "IdCategoria", DbType.Int32, Descuento.Categoria.IdCategoria);
//                    db.AddInParameter(dbCommand, "Descuento", DbType.Int32, Descuento.Porcentaje);

//                    if (ts != null)
//                        ret = db.ExecuteNonQuery(dbCommand, ts);
//                    else
//                        ret = db.ExecuteNonQuery(dbCommand);
//                }
//                catch (Exception ex)
//                {
//                    AppSettingsReader appSettingsReader = new AppSettingsReader();
//                    bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                    if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                    throw ex;
//                }
//            }

//            return ret; 
//        }
//        public static int ActualizarDescuentos(int IdCliente, IList<Descuento> Descuentos, DbTransaction ts)
//        {
//            int ret = -1; 
//            try
//            {
//                //Eliminamos los descuentos existentes (si es que hay)
//                Descuento.EliminarPorIdCliente(IdCliente, ts);

                
//                foreach (Descuento d in Descuentos)
//                {
//                    ret = Descuento.AgregarDescuento(IdCliente, d, ts);
//                }
//            }
//            catch (Exception ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                throw ex;

//            }

//            return ret;

            
//        }
//        public static int EliminarPorIdCliente(int IdCliente, DbTransaction ts)
//        {
//            int _affectedRows = -1; 
//            try
//            {
//                if (IdCliente <= 0) throw new ArgumentNullException("IdCliente es <= 0");
//            }
//            catch (ArgumentException ex)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
//                return -1;
//            }

//            string sqlCommand = Consts.Descuentos_EliminarPorIdCliente;

//            try
//            {
//                Database db = DatabaseFactory.CreateDatabase();
//                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
//                db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, IdCliente);

//                using (IDataReader dr = db.ExecuteReader(dbCommand))
//                {
//                    _affectedRows = db.ExecuteNonQuery(dbCommand, ts);
//                }
//            }
//            catch (Exception e)
//            {
//                AppSettingsReader appSettingsReader = new AppSettingsReader();
//                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

//                if (sendErrorsByMail) ExceptionPolicy.HandleException(e, "Global Policy");

//                throw e;
//            }
//            return _affectedRows;

//        }
//        #endregion
//    }
//}
