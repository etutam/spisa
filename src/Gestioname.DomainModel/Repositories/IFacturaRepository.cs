using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library.Repositories;

namespace Gestioname.DomainModel.Repositories
{
    public interface IFacturaRepository : IRepository<Factura>
    {
        Factura FindByNumeroFactura(long numeroFactura);

        
    }
}
