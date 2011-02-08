using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;
using NHibernate.Criterion;

namespace Gestioname.Repositories
{
    public class ArticuloRepository : NHibernateRepository<Articulo>, IArticuloRepository
    {
        public IEnumerable<Articulo> FindByCodigo(string codigo)
        {
         return
                HibernateTemplate.Execute(
                    session =>
                    session.CreateCriteria(typeof(Articulo)).Add(Restrictions.Like("Codigo", codigo))).List
                    <Articulo>();
        }

    }
}
