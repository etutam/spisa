using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.BusinessComponents
{
    public class ClientesManager : IClientesFacade
    {

        #region Private Fields
        private GestionameContext context;
        #endregion


        #region Constructors 
        public ClientesManager()
        {
            context = new GestionameContext();
        }
        #endregion
        #region IClientesManager Members

        public void AddCliente(Cliente cliente)
        {
            
        }

        public void UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClienteByCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> FindClientesByRazonSocial()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
