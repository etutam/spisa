using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;
using Rhino.Mocks;

namespace Gestioname.Repositories.Test
{
        [TestFixture]
        class ArticuloRepositoryTests: RepositoryTestCase<Articulo,ArticuloRepository>
        {
        public IArticuloRepository ArticuloRepository { get; set; }
      
        [Test]
        public void FindByCodigo()
        {
            Articulo articulo1 = new Articulo().GetTestInstance();

            ArticuloRepository.Save(articulo1);

            var resul = ArticuloRepository.FindByCodigo(articulo1.Codigo) as List<Articulo>;

            Assert.NotNull(resul);
            Assert.AreEqual(articulo1, resul.First());
            
        }



    }
}
