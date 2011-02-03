using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.DomainModel.Controllers
{
    public interface IClienteController
    {

        void Save(Cliente cliente);

        IEnumerable<Cliente> FindByRazonSocial(string razonSocial);
    }
}
