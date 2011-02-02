using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;

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
    }
}
