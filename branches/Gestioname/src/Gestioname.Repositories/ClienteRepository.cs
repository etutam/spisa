
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;

namespace Gestioname.Repositories
{
    public class ClienteRepository : NHibernateRepository<Cliente> , IClienteRepository
    {
  
        
    }
}
