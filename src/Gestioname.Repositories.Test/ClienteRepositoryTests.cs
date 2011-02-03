using System.Collections.Generic;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;
using Gestioname.Library.Repositories.NHibernate;

namespace Gestioname.Repositories.Test
{
    [TestFixture]
    public class ClienteRepositoryTests : RepositoryTestCase<Cliente> 
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
            Cliente prueba = new Cliente().GetTestInstance();
            ClienteRepository.Save(prueba);
            Cliente prueba2 = new Cliente().GetTestInstance();
            prueba2.RazonSocial = prueba2.RazonSocial + "2";
            ClienteRepository.Save(prueba2);
            Cliente prueba3 = new Cliente().GetTestInstance();
            prueba3.RazonSocial = prueba3.RazonSocial + "3";
            ClienteRepository.Save(prueba3);
            Cliente cliResul = ClienteRepository.FindByRazonSocial(prueba2.RazonSocial);
            
            
            Assert.AreEqual(cliResul.RazonSocial,prueba2.RazonSocial);
            
            Assert.Null(cliResul.RazonSocial);
        }
    }
}
