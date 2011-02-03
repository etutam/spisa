using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library.Repositories;

namespace Gestioname.DomainModel.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente FindByRazonSocial(string razonsocial);
    }
}
