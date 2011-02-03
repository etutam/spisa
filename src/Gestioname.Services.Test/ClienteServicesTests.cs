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
        public IClienteServices ClienteServices { get; set; }

        [Test]
        public void FindByRazonSocial_OneResult()
        {
            
        }
    }

}
