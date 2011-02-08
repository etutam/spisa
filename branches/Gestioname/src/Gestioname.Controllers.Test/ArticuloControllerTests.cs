using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace Gestioname.Controllers.Test
{
    [TestFixture]
    class ArticuloControllerTests
    {
        [Test]
        public void FindByCodigo()
        {
            IArticuloServices articuloServices = MockRepository.GenerateMock<IArticuloServices>();
            string codigo = "prueba";
            IEnumerable<Articulo> articulos = new List<Articulo>();

            articuloServices.Expect(x => x.FindByCodigo(codigo)).Return(articulos);

            ArticuloController articuloController = new ArticuloController
                                                        {
                                                            ArticuloSerices = articuloServices
                                                        };

            var result = articuloController.FindByCodigo(codigo);

            articuloServices.VerifyAllExpectations();

            Assert.AreEqual(articulos,result);

        }
    }
}


