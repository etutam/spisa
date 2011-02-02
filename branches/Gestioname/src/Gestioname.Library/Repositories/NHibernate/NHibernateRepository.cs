﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Spring.Data.NHibernate;

namespace Gestioname.Library.Repositories.NHibernate
{
    public class NHibernateRepository<T> : Spring.Data.NHibernate.Generic.Support.HibernateDaoSupport,  IRepository<T> where T: IEntity<T>
    {
        public virtual T FindById(int id)
        {
            return HibernateTemplate.Get<T>(id);
        }
        public virtual IList<T> GetAll()
        {
            return HibernateTemplate.LoadAll<T>();
        }

        public virtual void Save(T item)
        {
            HibernateTemplate.Save(item);
        }

        public virtual void Remove(T item)
        {
            HibernateTemplate.Delete(item);
        }

        public virtual void Clear()
        {
            HibernateTemplate.Clear();
        }
    }
}
