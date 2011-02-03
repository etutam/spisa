
using System.Collections.Generic;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;
using NHibernate.Criterion;

namespace Gestioname.Repositories
{
    public class ClienteRepository : NHibernateRepository<Cliente> , IClienteRepository
    {
  
        public IEnumerable<Cliente> FindByRazonSocial(string razonsocial)
        {
            return
                HibernateTemplate.Execute(
                    session =>
                    session.CreateCriteria(typeof (Cliente))
                           .Add(Restrictions.Like("RazonSocial", razonsocial)))
                    .List<Cliente>();
        }
    }
}
