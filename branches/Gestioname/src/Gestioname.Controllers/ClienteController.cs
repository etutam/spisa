using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Controllers;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;

namespace Gestioname.Controllers
{
    public class ClienteController: IClienteControllers
    {

        #region Properties
        public IClienteServices ClienteServices
        {
            get;
            set;
        }
        #endregion

        #region Methods
        public void Save(Cliente cliente)
        {
            ClienteServices.Save(cliente);
        }

        public IEnumerable<Cliente> FindByRazonSocial(string razonSocial)
        {
            return ClienteServices.FindByRazonSocial(razonSocial);
        }
        #endregion
    }
}
