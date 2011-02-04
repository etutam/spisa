using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.DomainModel.Controllers
{
    public interface IFacturaController
    {
        void Save(Factura factura);
        Factura FindByNumeroFractura(Int32 numeroaFactura);

    }
}
