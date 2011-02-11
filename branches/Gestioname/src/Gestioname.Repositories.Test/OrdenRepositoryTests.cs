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

        public IOrdenRepository OrdenRepository { get; set; }

        public IClienteRepository ClienteRepository { get; set; }

        protected override void BeforeSave(Orden orden)
        {
            ClienteRepository.Save(new Cliente().GetTestInstance());

            orden.Cliente = ClienteRepository.GetAll().First();

            throw new Exception("falta almacenar items de la orden");
        }

        protected override void AfterSave(Orden entity)
        {
            ClienteRepository.Remove(ClienteRepository.GetAll().First());
        }

        [Test]
        public void SaveOrderWithItems()
        {
            Orden orden = new Orden().GetTestInstance();

            orden.Items.Add(new OrdenItem
                                {
                                    
                                });

            Assert.AreEqual(true, false);
        }
    }
}
