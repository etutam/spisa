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

        public void AddCliente(Cliente cliente)
        {
            try
            {
                Add("ClienteSet", cliente);
                SaveAllObjectChanges();
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
                
            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateCliente(Cliente cliente)
        {
            ObjectContext.AttachUpdated(cliente);
            SaveAllObjectChanges();
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new NotImplementedException();
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

        #endregion
    }
}
