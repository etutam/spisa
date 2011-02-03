using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.DomainModel.Services
{
    public interface IClienteServices
    {
        void Save(Cliente cliente);

        IEnumerable<Cliente> FindByRazonSocial(string razonSocial);
    }
}
