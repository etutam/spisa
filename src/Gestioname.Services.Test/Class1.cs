using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using Gestioname.Repositories;
using NUnit.Framework;

namespace Gestioname.Services.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Lala()
        {
            ClienteServices clienteServices = new ClienteServices();

            Cliente cliente = new Cliente();

            clienteServices.ClienteRepository = new ClienteRepository();

            clienteServices.Guardar(cliente);
        }
    }

    public class ClienteRepositoryFake : IClienteRepository
    {
        public Cliente FindById(int Id)
        {
            return new Cliente();
        }

        public IList<Cliente> GetAll()
        {
            return new List<Cliente>();
        }

        public void Save(Cliente item)
        {
            //
        }
    }
}
