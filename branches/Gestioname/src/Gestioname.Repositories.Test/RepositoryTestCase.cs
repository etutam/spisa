using System;
using Gestioname.Library;
using Gestioname.Library.Repositories.NHibernate;
using NUnit.Framework;
using Spring.Testing.NUnit;

namespace Gestioname.Repositories.Test
{
    public class RepositoryTestCase<T> : AbstractTransactionalDbProviderSpringContextTests where T : IEntity<T>, new()
    {
        protected override string[] ConfigLocations
        {
            get { return new [] { "assembly://Gestioname.Repositories/Gestioname.Repositories/repositories.xml" }; }
        }

        public NHibernateRepository<T> Repository { get; set; }

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

            RunDefaultUnitTests();
        }

        public void RunDefaultUnitTests()
        {
            T entityToSave = new T().GetTestInstance();
            
            Repository.Save(entityToSave);

            T savedEntity = Repository.FindById(entityToSave.Id);

            Assert.AreEqual(entityToSave, savedEntity);
        }
    }
}
