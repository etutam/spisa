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
        public IClienteRepository ClienteRepository
        {
            get;
            set;
        }

        public void Guardar(Cliente cliente)
        {
            ClienteRepository.Save(cliente);
        }
    }
    
}
