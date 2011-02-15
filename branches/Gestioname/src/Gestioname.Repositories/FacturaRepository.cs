
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;
using Gestioname.DomainModel;
using NHibernate.Criterion;

namespace Gestioname.Repositories
{
    public class FacturaRepository:NHibernateRepository<Factura>,IFacturaRepository
    {
        public Factura FindByNumeroFactura(long numeroFactura)
        {
            return
                HibernateTemplate.Execute(
                    session =>
                    session.CreateCriteria(typeof (Factura)).Add(Restrictions.Eq("NumeroFactura", numeroFactura)).UniqueResult<Factura>());
        }

       
    }
}
