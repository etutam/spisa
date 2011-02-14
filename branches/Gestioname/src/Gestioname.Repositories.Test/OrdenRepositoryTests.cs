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
    class OrdenRepositoryTests: RepositoryTestCase<Orden,OrdenRepository>
    {
        public IArticuloRepository ArticuloRepository { get; set; }

        public IOrdenRepository OrdenRepository { get; set; }

        public IClienteRepository ClienteRepository { get; set; }


        protected override void BeforeSave(Orden orden)
        {
            ClienteRepository.Save(new Cliente().GetTestInstance());

            ArticuloRepository.Save(new Articulo().GetTestInstance());
            orden.Cliente = ClienteRepository.GetAll().First();
            orden.Items.Add(new OrdenItem(){Articulo = ArticuloRepository.GetAll().First()});
            
            //throw new Exception("falta almacenar items de la orden");
        }

        protected override void AfterSave(Orden entity)
        {
            ClienteRepository.Remove(ClienteRepository.GetAll().First());
        }

        [Test]
        public void SaveOrderWithItems()
        {
            Orden orden = new Orden().GetTestInstance();

            ArticuloRepository.Save(new Articulo().GetTestInstance());

            ClienteRepository.Save(new Cliente().GetTestInstance());

            orden.Cliente = ClienteRepository.GetAll().First();

            OrdenItem itemprueba = new OrdenItem().GetTestInstance();

            itemprueba.Articulo = ArticuloRepository.GetAll().First();

            orden.Items.Add(itemprueba);

            OrdenRepository.Save(orden);

            Orden resul = OrdenRepository.FindById(orden.Id);
            
            Assert.AreEqual(resul,orden);
        }
    }
}
