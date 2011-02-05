using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;
using Rhino.Mocks;
using NUnit.Framework;

namespace Gestioname.Services.Test
{
    [TestFixture]
    public class FacturaServicesTests
    {
      [Test]
      public void FindByNumeroFactura()
      {

          IFacturaRepository facturaRepository = MockRepository.GenerateMock<IFacturaRepository>();
          
          long numeroFactura = 1234567891234567;

          Factura factura = new Factura();

          facturaRepository.Expect(x => x.FindByNumeroFactura(numeroFactura)).Return(factura);
          
          FacturaServices facturaServices = new FacturaServices
                                                {
                                                    FacturaRepository = facturaRepository
                                                };
          var result = facturaServices.FindByNumeroFactura(numeroFactura);

          facturaRepository.VerifyAllExpectations();

          Assert.IsNotNull(result);
          Assert.AreSame(factura, result);

      }

    }
}
