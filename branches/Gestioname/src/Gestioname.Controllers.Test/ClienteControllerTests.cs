using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace Gestioname.Controllers.Test
{
    public class ClienteControllerTests
    {
        [Test]
        public void FindByRazonSocial()
        {
            IClienteServices clienteServices = MockRepository.GenerateMock<IClienteServices>();
            string razonSocial = "RazonSocial";
            IEnumerable<Cliente> clientes = new List<Cliente>();

            clienteServices.Expect(x => x.FindByRazonSocial(razonSocial))
                .Return(clientes);

            ClienteController clienteController= new ClienteController
                                  {
                                      ClienteServices = clienteServices
                                  };
            var results = clienteController.FindByRazonSocial(razonSocial);
            Assert.AreSame(clientes, results);

            clienteServices.VerifyAllExpectations();
        }
    }
}
