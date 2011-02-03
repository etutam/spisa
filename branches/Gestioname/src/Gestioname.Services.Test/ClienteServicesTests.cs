using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;
using Gestioname.Repositories;
using NUnit.Framework;
using Rhino.Mocks;


namespace Gestioname.Services.Test
{
    [TestFixture]
    public class ClienteServicesTests
    {
        [Test]
        public void FindByRazonSocial()
        {
            IClienteRepository clienteRepository = MockRepository.GenerateMock<IClienteRepository>();
            string razonSocial = "Razon Social";
            IEnumerable<Cliente> clientes = new List<Cliente>();
                                                
            clienteRepository.Expect(x => x.FindByRazonSocial(razonSocial))
                .Return(clientes);
            

            ClienteServices clienteServices = new ClienteServices
                                                  {
                                                      ClienteRepository = clienteRepository
                                                  };

            var results = clienteServices.FindByRazonSocial(razonSocial);

            clienteRepository.VerifyAllExpectations();

            Assert.AreSame(clientes, results);
        }
    }
}