using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;

namespace Gestioname.Repositories
{
    class TransportistaRepository: NHibernateRepository<Transportista>, ITransportistaRepository
    {
    }
}
