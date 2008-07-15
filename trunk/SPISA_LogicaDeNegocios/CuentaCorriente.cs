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
    public class CuentaCorriente
    {
        
        public class Movimiento
        {
            #region Campos privados
            Factura _factura; 
            Decimal _monto;
            DateTime _fecha;
            string _tipoMovimiento;

            #endregion

            #region Constructores
            public Movimiento()
            {

            }
            public Movimiento(Factura f, DateTime fecha, Decimal monto)
            {
                this._factura = f;
                this._fecha = fecha;
                this._monto = monto;
            }
            #endregion

            #region Propiedades

            public string TipoMovimiento
            {
                get { return _tipoMovimiento; }
                set { _tipoMovimiento = value; } 
            }
            public Factura Factura
            {
                get
                {
                    return _factura;
                }
                set
                {
                    _factura = value;
                }
            }
            public Decimal Monto
            {
                get
                {
                    return _monto;
                }
                set
                {
                    _monto = value;
                }
            }

            public DateTime Fecha
            {
                get
                {
                    return _fecha;
                }
                set
                {
                    _fecha = value; 
                }
            }
            #endregion

        }

        #region Campos Privados

        int _idCuentaCorriente;
        IList<Movimiento> _movimientos;
        #endregion

        #region Constructores
        public CuentaCorriente()
        {
            _movimientos = new List<Movimiento>();

        }
        #endregion

        #region Propiedades

        public int Id
        {
            get
            {
                return _idCuentaCorriente;
            }
            set
            {
                _idCuentaCorriente = value;
            }
        }
        public IList<Movimiento> Movimientos
        {
            get
            {
                return _movimientos;
            }
            set
            {
                _movimientos = value;
            }
        }
        #endregion
       
        #region Metodos Estaticos

        //TODO: Falta terminar este metodo 
        public static CuentaCorriente TraerPorIdCliente(int idCliente, DbTransaction transaction)
        {
            if (idCliente <= 0) return null;
            
            string sqlCommand = Consts.CuentaCorriente_TraerPorIdCliente;
            CuentaCorriente _cc = null;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@IdCliente", DbType.Int32, idCliente);

                IDataReader dataReader;

                if (transaction != null)
                {
                    dataReader = db.ExecuteReader(dbCommand, transaction);
                }
                else
                {
                    dataReader = db.ExecuteReader(dbCommand);
                }
                
                if (dataReader.Read())
                {
                    _cc = new CuentaCorriente();
                    _cc._idCuentaCorriente = Convert.ToInt32(dataReader["IdCuentaCorriente"]);
                    dataReader.Close();
                }
                else
                {
                    dataReader.Close();
                    _cc = CrearCuentaCorriente(idCliente, transaction);
                }
            

                Logger.Append(Consts.CuentaCorriente_TraerPorIdCliente, new Object[] { "IdCliente", idCliente }, "IdCuentaCorriente=" + _cc.Id);
            }
            catch (Exception ex)
            {

                _cc = null;
                
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                
                throw (ex);
            }

            
            return _cc;
        }

        public static CuentaCorriente CrearCuentaCorriente(int idCliente, DbTransaction transaction)
        {
            if (idCliente <= 0) return null;

            string sqlCommand = Consts.CuentaCorriente_Agregar;
            object r = null;
            CuentaCorriente cc = null;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "IdCliente", DbType.Int32, idCliente);

                using (DbConnection conn = db.CreateConnection())
                {

                    conn.Open();

                    try
                    {
                        if (transaction != null)
                        {
                            r = db.ExecuteScalar(dbCommand, transaction);
                        }
                        else
                        {
                            r = db.ExecuteScalar(dbCommand);
                        }

                    }
                    catch (Exception ex)
                    {
                        ExceptionPolicy.HandleException(ex, "Global Policy");
                        throw ex;
                    }
                }

                cc = TraerPorIdCliente(idCliente, transaction);
                Logger.Append(Consts.CuentaCorriente_Agregar, new Object[] { "IdCliente", idCliente }, "IdCuentaCorriente=" + cc.Id);

                if (cc == null) throw new Exception("No se ha podido obtener la cuenta corriente del Cliente");
            }
            catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");

                throw ex;
            }

            return cc;
        }
        #endregion

        #region Metodos 

        /// <summary>
        /// Este método se encarga de Almacenar el Movimiento en la cuenta corriente del cliente
        /// y a su vez actualiza el campo saldo de la tabla Clientes
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int AlmacenarMovimiento(Movimiento m, DbTransaction ts)
        {
            if (m.Factura == null) throw new Exception("m.Factura==null");

            string sqlCommand = Consts.CuentaCorriente_AlmacenarMovimiento;
            object r = null;

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "IdCuentaCorriente", DbType.Int32, this._idCuentaCorriente);
                db.AddInParameter(dbCommand, "IdFactura", DbType.Int32, m.Factura.Id);
                db.AddInParameter(dbCommand, "Monto", DbType.Decimal, m.Monto);

                if (!m.Factura.EsNotaDeCredito) db.AddInParameter(dbCommand, "TipoOperacion", DbType.Int32, 1);
                else db.AddInParameter(dbCommand, "TipoOperacion", DbType.Int32, 2);

                using (DbConnection conn = db.CreateConnection())
                {
                    conn.Open();
                    r = db.ExecuteScalar(dbCommand, ts);
                }

                Logger.Append(Consts.CuentaCorriente_AlmacenarMovimiento, new Object[] { "IdFactura", m.Factura.Id, "Fecha", m.Fecha, "Monto", m.Monto, "TipoMovimiento", m.TipoMovimiento }, "No devuelve nada");

            }
           catch (Exception ex)
            {
                AppSettingsReader appSettingsReader = new AppSettingsReader();
                bool sendErrorsByMail = Convert.ToBoolean(appSettingsReader.GetValue("SendErrorsByMail", typeof(Boolean)));

                if (sendErrorsByMail) ExceptionPolicy.HandleException(ex, "Global Policy");
                throw (ex);
            }
            
            return Convert.ToInt32(r);
        
        }
        #endregion



    }


}
