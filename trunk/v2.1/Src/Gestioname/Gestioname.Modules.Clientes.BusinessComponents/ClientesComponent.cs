using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Gestioname.Infrastructure.Model;
using Gestioname.Modules.Clientes.Facade;
using Gestioname.Modules.Clientes.Interfaces;

using Gestioname.Framework.ObjectContextManager;

namespace Gestioname.Modules.Clientes.BusinessComponents
{
    public class ClientesComponent
    {
        public ClientesComponent()
        {
            //DO NOTHING
        }

        #region AddCliente
        public void AddCliente(Cliente cliente)
        {
            using (new UnitOfWorkScope(true)) /* "true" flag indicates that all changes
                                               * should be saved at the end of scope */
            {
                IClientesFacade facade = new ClientesFacade();
                facade.AddCliente(cliente);
            }
        }
        #endregion

    }
}
