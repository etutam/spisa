using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;

namespace Gestioname.Services
{
    public class FacturaServices: IFacturaServices
    {
        #region Properties
        public IFacturaRepository FacturaRepository { get; set; }
        #endregion

        #region Methods

        public void Save(Factura factura)
        {
           FacturaRepository.Save(factura);
        }

        public Factura FindByNumeroFactura(int numeroFactura)
        {
            return FacturaRepository.FindByNumeroFactura(numeroFactura);
        }
        #endregion
    }
}
