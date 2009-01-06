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

        public void UpdateCliente(Cliente cliente)
        {
            ObjectContext.AttachUpdated(cliente);
            SaveAllObjectChanges();
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClienteById(int id)
        {
            var q = from c in Context.ClienteSet
                         where c.IdCliente == id
                         select c;

            var client = q.First();
            return client;
        }

        public Cliente GetClienteByCodigo(string codigo)
        {
            var q = from c in Context.ClienteSet
                    where c.Codigo.Equals(codigo)
                    select c;

            var client = q.First();
            return client;
        }

        public List<Cliente> FindClientesByRazonSocial(string razonSocial)
        {
            var q = from c in Context.ClienteSet
                    where c.RazonSocial.Contains(razonSocial)
                    select c;

            var client = q.ToList();
            return client;
        }

        #endregion

       
    }
}
