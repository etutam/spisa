using System;
using Gestioname.Library;
using Gestioname.Library.Repositories.NHibernate;
using NUnit.Framework;
using Spring.Testing.NUnit;

namespace Gestioname.Repositories.Test
{
    public class RepositoryTestCase<T> : AbstractTransactionalDbProviderSpringContextTests where T : IEntity, new()
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

            //Repository = new NHibernateRepository<T>();

            RunDefaultUnitTests();
        }

        public void RunDefaultUnitTests()
        {
            T entityToSave = new T();
            
            Repository.Save(entityToSave);

            T savedEntity = Repository.FindById(entityToSave.Id);

            Assert.AreEqual(entityToSave, savedEntity);
        }
    }
}
