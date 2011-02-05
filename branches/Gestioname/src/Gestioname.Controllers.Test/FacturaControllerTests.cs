using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace Gestioname.Controllers.Test
{
    [TestFixture]

    class FacturaControllerTests
    {
        [Test]
        public void FindByNumeroFactura()
        {
            IFacturaServices facturaServices = MockRepository.GenerateMock<IFacturaServices>();

            long numeroFactura = 1234567891234567;

            Factura factura = new Factura();

            facturaServices.Expect(x => x.FindByNumeroFactura(numeroFactura)).Return(factura);

            FacturaController FacturaController = new FacturaController {FacturaServices = facturaServices};

            var result = FacturaController.FindByNumeroFactura(numeroFactura);

            facturaServices.VerifyAllExpectations();

            // No nos olvidemos los Asserts
            Assert.IsNotNull(result);
            Assert.AreSame(factura, result);
        }
    }
}
