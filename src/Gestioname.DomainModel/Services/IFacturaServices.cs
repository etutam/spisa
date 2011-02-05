using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.DomainModel.Services
{
    public interface IFacturaServices
    {
        void Save(Factura factura);

        Factura FindByNumeroFactura(long numeroFactura);
    }
}
