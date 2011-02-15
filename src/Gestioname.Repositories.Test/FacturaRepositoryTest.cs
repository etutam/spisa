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

        protected override void BeforeSave(Factura entity)
        {
            // Setup
            ArticuloRepository.Save(new Articulo().GetTestInstance());
            ClienteRepository.Save(new Cliente().GetTestInstance());

            // Creacion de Orden
            Orden orden = new Orden().GetTestInstance();

            orden.Cliente = ClienteRepository.GetAll().First();
            orden.Items.Add(new OrdenItem(ArticuloRepository.GetAll().First(), 10, 1, orden));

            OrdenRepository.Save(orden);

            entity.Orden = OrdenRepository.GetAll().First();
        }

        protected override void AfterSave(Factura entity)
        {
            OrdenRepository.Remove(OrdenRepository.GetAll().First());

            ArticuloRepository.Remove(ArticuloRepository.GetAll().First());
        }

        [Test]
        public void FindByNumeroFactura()
        {
            Factura facturaprueba = new Factura().GetTestInstance();

            ClienteRepository.Save(new Cliente().GetTestInstance());

            ArticuloRepository.Save(new Articulo().GetTestInstance());

            facturaprueba.Cliente = ClienteRepository.GetAll().First();

            Articulo productoprueba = ArticuloRepository.GetAll().First();

            Orden orden = new Orden().GetTestInstance();

            orden.Cliente = ClienteRepository.GetAll().First();
            orden.Items.Add(new OrdenItem(productoprueba, 10, 1, orden));

            OrdenRepository.Save(orden);
            facturaprueba.Orden = OrdenRepository.GetAll().First();

            FacturaRepository.Save(facturaprueba);
            
            Factura resultado = FacturaRepository.FindByNumeroFactura(facturaprueba.NumeroFactura);

            Assert.NotNull(resultado);

            Assert.AreEqual(facturaprueba.NumeroFactura,resultado.NumeroFactura);
        }

        [Test]
        public void NoDataSaved()
        {
            throw new Exception("Keeps going to setup for each test :(");
        }
        
       

    }
}
