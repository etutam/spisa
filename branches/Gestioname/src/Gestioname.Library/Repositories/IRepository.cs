using System.Collections.Generic;
using Spring.Data.NHibernate.Generic;

namespace Gestioname.Library.Repositories
{
    public interface IRepository<T> where T :IEntity<T>
    {
        T FindById(int id);
        IList<T> GetAll();
        void Save(T item);
        void Remove(T item);
        void Clear();

        HibernateTemplate HibernateTemplate { get; set; }
    }
}
