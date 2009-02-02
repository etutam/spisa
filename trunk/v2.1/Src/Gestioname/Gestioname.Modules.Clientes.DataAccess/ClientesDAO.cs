using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Framework.BaseClasses;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.DataAccess
{
    public class ClientesDAO : BaseDataAccess<Cliente>, IClientesDAO
    {
        #region Constructors 
        public ClientesDAO()
        {
            // DO NOTHING
        }
        #endregion

        #region IClientesFacade Members

        #region Properties
        public GestionameContext Context
        { 
            get
            {
                return base.ObjectContext;
            }
        }
        #endregion

        #region CRUD Cliente

        #region AddCliente
        public void AddCliente(Cliente cliente)
        {
            try
            {
                Add("ClienteSet", cliente);
           }
            catch (Exception ex)
            {
                throw ex;                
            }
        }
        #endregion

        #region UpdateCliente
        public void UpdateCliente(Cliente cliente)
        {
            try
            {
                ObjectContext.AttachUpdated(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region DeleteCliente
        public void DeleteCliente(Cliente cliente)
        {
            try
            {
                ObjectContext.AttachUpdated(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region CRUD Cuenta
        #region AddCuenta
        public void AddCuenta(Cuenta cuenta)
        {
            try
            {
                ObjectContext.AddToCuentaSet(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region DeleteCuenta
        public void DeleteCuenta(Cuenta cuenta)
        {
            try
            {
                ObjectContext.AttachUpdated(cuenta);
                ObjectContext.DeleteObject(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region UpdateCuenta
        public void UpdateCuenta(Cuenta cuenta)
        {
            try
            {
                ObjectContext.AttachUpdated(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #endregion

        #region CRUD Transacciones
        #region AddTransaccion
        public void AddTransaccion(Transaccion transaccion)
        {
            try
            {
                ObjectContext.AddToTransaccionSet(transaccion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region DeleteTransaccion
        public void DeleteTransaccion(Transaccion transaccion)
        {

        }
        #endregion

        #region UpdateTransaccion
        public void UpdateTransaccion(Transaccion transaccion)
        {

        }
        #endregion
        #endregion

        #region Queries Cuentas
        #region GetCuentaById
        public Cuenta GetCuentaById(int idCuenta)
        {
            var q = from c in ObjectContext.CuentaSet
                    where c.IdCuenta == idCuenta
                    select c;

            return q.FirstOrDefault();
        }
        #endregion

        #region GetCuentas
        public IEnumerable<Cuenta> GetCuentas()
        {
            return ObjectContext.CuentaSet.ToList();
        }
        #endregion
        #endregion

        #region Queries Cliente

        #region GetClientes
        public IEnumerable<Cliente> GetClientes()
        {
            var q = from c in Context.ClienteSet
                    select c;
            return q.ToList();
        }
        #endregion
       
        #region GetClienteById
        public Cliente GetClienteById(int id)
        {
            var q = from c in Context.ClienteSet
                         where c.IdCliente == id
                         select c;

            return q.FirstOrDefault();
        }
        #endregion

        #region GetClientesByCodigo
        public Cliente GetClienteByCodigo(string codigo)
        {
            var q = from c in Context.ClienteSet
                    where c.Codigo.Equals(codigo)
                    select c;

            return q.FirstOrDefault();
        }
        #endregion

        #region FindClientesByRazonSocial
        public IEnumerable<Cliente> FindClientesByRazonSocial(string razonSocial)
        {
            var q = from c in Context.ClienteSet
                    where c.RazonSocial.Contains(razonSocial)
                    select c;

            List<Cliente> results = null;

            try
            {
                results = q.ToList();
            }
            catch
            {
                
            }

            return results;
        }
        #endregion
        #endregion

        #region Queries TiposTransacciones
        #region GetTipoTransaccionByDescripcion
        public TipoTransaccion GetTipoTransaccionByDescripcion(string descripcion)
        {
            var q = from c in Context.TipoTransaccionSet
                    where c.Descripcion.Equals(descripcion)
                    select c;

            return q.FirstOrDefault();
        }
        #endregion

        #region GetTiposTransacciones
        public IEnumerable<TipoTransaccion> GetTiposTransacciones()
        {
            IEnumerable<TipoTransaccion> tiposTransacciones = null;

            var q = from c in Context.TipoTransaccionSet
                    select c;

            tiposTransacciones = q.ToList();

            return tiposTransacciones;
        }
        #endregion
        #endregion

        #endregion
    }
}
