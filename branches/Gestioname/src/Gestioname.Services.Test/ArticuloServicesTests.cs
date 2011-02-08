using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;
using Rhino.Mocks;

namespace Gestioname.Services.Test
{
    [TestFixture]
    class ArticuloServicesTests
    {
        [Test]
        public void  FindByCodigo()
        {
            IArticuloRepository articuloRepository = MockRepository.GenerateMock<IArticuloRepository>();
            string codigo = "prueba";
            IEnumerable<Articulo> articulo = new List<Articulo>();

            articuloRepository.Expect(x => x.FindByCodigo(codigo)).Return(articulo);

            ArticuloServices articuloServices = new ArticuloServices {ArticuloRepository = articuloRepository};
            
            var resul=articuloServices.FindByCodigo(codigo);

            articuloRepository.VerifyAllExpectations();
            
            Assert.AreEqual(articulo,resul);
        }
    }
}
