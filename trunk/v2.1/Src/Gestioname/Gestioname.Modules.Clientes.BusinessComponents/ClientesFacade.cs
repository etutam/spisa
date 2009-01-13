using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Framework.BaseClasses;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.BusinessComponents
{
    public class ClientesFacade : FacadeBase<Cliente>, IClientesFacade
    {
        #region Constructors 
        public ClientesFacade()
        {
            // DO NOTHING
        }
        #endregion

        #region IClientesFacade Members

        public GestionameContext Context
        { 
            get
            {
                return base.ObjectContext;
            }
        }

        #region CRUD Cliente

        public void CreateCliente(string codigo, string cuit, string razonSocial, string domicilio, string localidad, string provincia)
        {
            try
            {
                Cliente cliente = Cliente.CreateCliente(0, codigo, cuit, razonSocial, domicilio, localidad, provincia);
                Add("ClienteSet", cliente);
                SaveAllObjectChanges();
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }

        public void CreateTransaccion(Transaccion transaccion)
        {
            try
            {
                ObjectContext.AddToTransaccionSet(transaccion);
                SaveAllObjectChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCliente(Cliente cliente)
        {
            ObjectContext.AttachUpdated(cliente);
            SaveAllObjectChanges();
        }

        public void DeleteCliente(Cliente cliente)
        {
            ObjectContext.AttachUpdated(cliente);
        }

        #endregion


        #region Queries Cuentas
        public Cuenta GetCuentaById(int idCuenta)
        {
            var q = from c in ObjectContext.CuentaSet
                    where c.IdCuenta == idCuenta
                    select c;

            return q.FirstOrDefault();
        }
        public List<Cuenta> GetCuentas()
        {
            return ObjectContext.CuentaSet.ToList();
        }
        #endregion

        #region Queries Cliente
        public Cliente GetClienteById(int id)
        {
            var q = from c in Context.ClienteSet
                         where c.IdCliente == id
                         select c;

            return q.FirstOrDefault();
        }

        public Cliente GetClienteByCodigo(string codigo)
        {
            var q = from c in Context.ClienteSet
                    where c.Codigo.Equals(codigo)
                    select c;

            return q.FirstOrDefault();
        }

        public List<Cliente> FindClientesByRazonSocial(string razonSocial)
        {
            var q = from c in Context.ClienteSet
                    where c.RazonSocial.Contains(razonSocial)
                    select c;

            return q.ToList();
        }
        #endregion

        #region Queries TiposTransacciones 
        public TipoTransaccion GetTipoTransaccionByDescripcion(string descripcion)
        {

        }
        #endregion

        #endregion
    }
}
