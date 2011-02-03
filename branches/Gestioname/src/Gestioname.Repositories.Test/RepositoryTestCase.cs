using System;
using Gestioname.Library;
using Gestioname.Library.Repositories.NHibernate;
using NUnit.Framework;
using Spring.Data.NHibernate.Generic;
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
            SaveTest();

            GetAllTest();
        }

        private void SaveTest()
        {
            T entityToSave = new T().GetTestInstance();

            Repository.Save(entityToSave);

            T savedEntity = Repository.FindById(entityToSave.Id);

            Assert.AreEqual(entityToSave, savedEntity);

            Repository.Remove(savedEntity);
            
        }

        private void GetAllTest()
        {
            T entityToSave1 = new T().GetTestInstance();
            T entityToSave2 = new T().GetTestInstance();
            T entityToSave3 = new T().GetTestInstance();

            Repository.Save(entityToSave1);
            Repository.Save(entityToSave2);
            Repository.Save(entityToSave3);

            var all = Repository.GetAll();

            Assert.AreEqual(3, all.Count);

            Repository.Remove(entityToSave1);
            Repository.Remove(entityToSave2);
            Repository.Remove(entityToSave3);
        }
    }
}
