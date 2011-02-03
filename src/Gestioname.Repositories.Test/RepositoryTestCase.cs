using System;
using Gestioname.Library;
using Gestioname.Library.Repositories;
using Gestioname.Library.Repositories.NHibernate;
using NUnit.Framework;
using Spring.Data.NHibernate.Generic;
using Spring.Testing.NUnit;

namespace Gestioname.Repositories.Test
{
    public class RepositoryTestCase<TEntity, TRepository> : AbstractTransactionalDbProviderSpringContextTests where TEntity : IEntity<TEntity>, new()
                                                                                                              where TRepository: IRepository<TEntity>, new()
    {
        protected override string[] ConfigLocations
        {
            get { return new [] { "assembly://Gestioname.Repositories/Gestioname.Repositories/repositories.xml" }; }
        }

        public HibernateTemplate HibernateTemplate { get; set; }

        public IRepository<TEntity> Repository { get; set; }

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

            Repository = (TRepository)applicationContext.GetObject(typeof (TRepository).Name);
            
            Repository.HibernateTemplate = HibernateTemplate;

            RunDefaultUnitTests();
        }

        public void RunDefaultUnitTests()
        {
            SaveTest();

            GetAllTest();
        }

        private void SaveTest()
        {
            TEntity entityToSave = new TEntity().GetTestInstance();

            Repository.Save(entityToSave);

            TEntity savedEntity = Repository.FindById(entityToSave.Id);

            Assert.AreEqual(entityToSave, savedEntity);

            Repository.Remove(savedEntity);
            
        }

        private void GetAllTest()
        {
            TEntity entityToSave1 = new TEntity().GetTestInstance();
            TEntity entityToSave2 = new TEntity().GetTestInstance();
            TEntity entityToSave3 = new TEntity().GetTestInstance();

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
