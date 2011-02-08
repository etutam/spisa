using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;
using Gestioname.Library.Repositories.NHibernate;

namespace Gestioname.Repositories.Test
{
    [TestFixture]
    public class ClienteRepositoryTests : RepositoryTestCase<Cliente, ClienteRepository> 
    {
        public IClienteRepository ClienteRepository { get; set; }
        
        [Test]
        public void RunDefaultTests()
        {
            base.RunDefaultUnitTests();
        }

        //Intento de Adri 1
        [Test]
        public void GetbyRazonSocialTest()
        {
            Cliente cliente1 = new Cliente().GetTestInstance();
            ClienteRepository.Save(cliente1);
            Cliente cliente2 = new Cliente().GetTestInstance();
            cliente2.RazonSocial = cliente2.RazonSocial + "2";
            ClienteRepository.Save(cliente2);
            Cliente cliente3 = new Cliente().GetTestInstance();
            cliente3.RazonSocial = cliente3.RazonSocial + "3";
            ClienteRepository.Save(cliente3);

            IList<Cliente> results = ClienteRepository.FindByRazonSocial(cliente2.RazonSocial) as List<Cliente>;
            
            Assert.NotNull(results);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(results.First().RazonSocial, cliente2.RazonSocial);
        }

    }
}
