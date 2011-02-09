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

        [Test]
        public void RunDefaultsTest()
        {
            base.RunDefaultUnitTests();
        }

        protected override void OnSetUp()
        {
            base.OnSetUp();

            ClienteRepository.Save(new Cliente().GetTestInstance());
        }

        protected override void OnTearDown()
        {
            ClienteRepository.Remove(ClienteRepository.GetAll().First());
        }

        protected override void BeforeSave(Orden orden)
        {
            orden.Cliente = ClienteRepository.GetAll().First();
        }

        [Test]
        public void TestVacio()
        {
        }
    }
}
