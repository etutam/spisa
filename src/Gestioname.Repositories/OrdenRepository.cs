using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.Library.Repositories.NHibernate;

namespace Gestioname.Repositories
{
    public class OrdenRepository:NHibernateRepository<Orden> ,IOrdenRepository
    {

        public virtual Orden CreateFromFactura(Factura factura)
        {
            Orden orden = new Orden().GetTestInstance();
            orden.Items = factura.Items;
            orden.Cliente = factura.Cliente;
            Save(orden);
            return FindById(orden.Id);
        }

    }
}
