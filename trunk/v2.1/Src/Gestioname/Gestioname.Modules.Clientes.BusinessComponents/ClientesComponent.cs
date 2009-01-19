using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Gestioname.Infrastructure.Model;
using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Modules.Clientes.DataAccess;

using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using Gestioname.Framework.ObjectContextManager;

namespace Gestioname.Modules.Clientes.BusinessComponents
{
    public class ClientesComponent : IClientesComponent
    {
        public ClientesComponent()
        {
            //DO NOTHING
        }

        #region CRUD Cliente
        #region AddCliente
        public void AddCliente(Cliente cliente)
        {
            try
            {
                using (new UnitOfWorkScope(true)) /* "true" flag indicates that all changes
                                               * should be saved at the end of scope */
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.AddCliente(cliente);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
            #endregion

        #region UpdateCliente
        public void UpdateCliente(Cliente cliente)
        {
            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.UpdateCliente(cliente);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
        #endregion

        #region DeleteCliente
        public void DeleteCliente(Cliente cliente)
        {
            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.DeleteCliente(cliente);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
        #endregion
        #endregion

        #region CRUD Cuenta

        #region AddCuenta
        void AddCuenta(Cuenta cuenta)
        {
            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.AddCuenta(cuenta);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

            
        }
        #endregion

        #region DeleteCuenta
        void DeleteCuenta(Cuenta cuenta)
        {
            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.DeleteCuenta(cuenta);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }
        #endregion

        #region UpdateCuenta

        public void UpdateCuenta(Cuenta cuenta)
        {
            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    clientesDao.UpdateCuenta(cuenta);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }
        #endregion

        #endregion

        #region CRUD Transaccion
        #region AddTransaccion
        public void AddTransaccion(Transaccion transaccion)
        {
            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();

                    var qActualBalance = from c in clientesDao.Context.TransaccionSet
                                         where c.IdTransaccion == (from q in clientesDao.Context.TransaccionSet
                                                                   select q.IdTransaccion).Max()
                                         select c;
                    string actualBalance = (qActualBalance.Count() == 0 ? "0" : qActualBalance.FirstOrDefault().Balance);

                    transaccion.Balance = Convert.ToString(Convert.ToDouble(actualBalance) + Convert.ToDouble(transaccion.Monto));
                    clientesDao.AddTransaccion(transaccion);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
        #endregion
        #endregion

        #region Queries Cliente
        #region GetClienteById
        public Cliente GetClienteById(int id)
        {
            Cliente cliente = null;

            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    cliente = clientesDao.GetClienteById(id);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }


            return cliente;
        }
        #endregion

        #region GetClienteByCodigo
        public Cliente GetClienteByCodigo(string codigo)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
            return new Cliente();
        }
        #endregion

        #region FindClientesByRazonSocial
        public IEnumerable<Cliente> FindClientesByRazonSocial(string razonSocial)
        {
            IEnumerable<Cliente> qry = null;

            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    qry = clientesDao.FindClientesByRazonSocial(razonSocial);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

            return qry;
        }
        #endregion
        #endregion

        #region Queries Transaccion
        #region GetTipoTransaccionByDescripcion
        public TipoTransaccion GetTipoTransaccionByDescripcion(string descripcion)
        {
            TipoTransaccion tipoTransaccion = null;

            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    tipoTransaccion = clientesDao.GetTipoTransaccionByDescripcion(descripcion);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

            
            return new TipoTransaccion();
        }
        #endregion
        #endregion

        #region Queries Cuentas
        public Cuenta GetCuentaById(int id)
        {
            Cuenta cuenta = null;

            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    cuenta = clientesDao.GetCuentaById(id);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

            return cuenta;
        }
        public IEnumerable<Cuenta> GetCuentas()
        {
            IEnumerable<Cuenta> qry = null;

            try
            {
                using (new UnitOfWorkScope(true))
                {
                    IClientesDAO clientesDao = new ClientesDAO();
                    qry = clientesDao.GetCuentas();
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }


            return qry;
        }
        #endregion

        #region Exceptions Management
        public void ProcessException(Exception exception)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
