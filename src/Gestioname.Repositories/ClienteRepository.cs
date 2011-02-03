
using System.Collections.Generic;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;
using NHibernate.Criterion;

namespace Gestioname.Repositories
{
    public class ClienteRepository : NHibernateRepository<Cliente> , IClienteRepository
    {
  
        public Cliente FindByRazonSocial(string razonsocial)
        {
            return
                HibernateTemplate.Execute(
                    session =>
                    session.CreateCriteria(typeof (Cliente)).Add(
                        Restrictions.Eq("RazonSocial", razonsocial)).UniqueResult<Cliente>());
        }
    }
}
