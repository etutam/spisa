using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Controllers;
using Gestioname.DomainModel.Services;

namespace Gestioname.Controllers
{
    public class FacturaController: IFacturaController
    {
        public IFacturaServices FacturaServices { get; set; }

        public void Save(Factura factura)
        {
           FacturaServices.Save(factura);
        }

        public Factura FindByNumeroFactura(long numeroaFactura)
        {
            return FacturaServices.FindByNumeroFactura(numeroaFactura);
        }
    }
}
