using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;

namespace Gestioname.Repositories.Test
{   
    [TestFixture]
    class FacturaRepositoryTest: RepositoryTestCase<Factura,FacturaRepository>
    {

        public IFacturaRepository FacturaRepository { get; set; }

        public IOrdenRepository OrdenRepository { get; set; }

        public IClienteRepository ClienteRepository { get; set; }

        public IArticuloRepository ArticuloRepository { get; set; }

        [Test]
        public void FindByNumeroFactura()
        {
            Factura facturaprueba = new Factura().GetTestInstance();

            ClienteRepository.Save(new Cliente().GetTestInstance());

            ArticuloRepository.Save(new Articulo().GetTestInstance());

            facturaprueba.Cliente = ClienteRepository.GetAll().First();

            Articulo productoprueba = ArticuloRepository.GetAll().First();

            facturaprueba.Items.Add(new OrdenItem() { Articulo = productoprueba});

            facturaprueba.Orden = OrdenRepository.CreateFromFactura(facturaprueba);



            FacturaRepository.Save(facturaprueba);
            
            Factura resultado = FacturaRepository.FindByNumeroFactura(facturaprueba.NumeroFactura);

            Assert.NotNull(resultado);

            Assert.AreEqual(facturaprueba.NumeroFactura,resultado.NumeroFactura);

            FacturaRepository.Remove(facturaprueba);
        }

        
       

    }
}
