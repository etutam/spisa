using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Framework.BaseClasses;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.Facade
{
    public class ClientesFacade : FacadeBase<Cliente>, IClientesComponent
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

        public void AddTransaccion(Transaccion transaccion)
        {
            try
            {
                // Calculamos el balance
                var qActualBalance = from c in ObjectContext.TransaccionSet
                                    where c.IdTransaccion == (from q in ObjectContext.TransaccionSet
                                                              select q.IdTransaccion).Max()
                                    select c;
                string actualBalance = (qActualBalance.Count() == 0 ? "0" : qActualBalance.FirstOrDefault().Balance);

                transaccion.Balance = Convert.ToString(Convert.ToDouble(actualBalance) + Convert.ToDouble(transaccion.Monto));

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
            var q = from c in Context.TipoTransaccionSet
                    where c.Descripcion.Equals(descripcion)
                    select c;

            return q.FirstOrDefault();
        }
        #endregion

        #endregion
    }
}
