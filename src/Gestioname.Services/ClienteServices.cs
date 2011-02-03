using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;

namespace Gestioname.Services
{
    public class ClienteServices : IClienteServices
    {
        #region Properties
        public IClienteRepository ClienteRepository
        {
            get;
            set;
        }
        #endregion

        #region Methods
        public void Save(Cliente cliente)
        {
            ClienteRepository.Save(cliente);
        }

        public IEnumerable<Cliente> FindByRazonSocial(string razonSocial)
        {
            return ClienteRepository.FindByRazonSocial(razonSocial);
        }
        #endregion
    }
    
}
