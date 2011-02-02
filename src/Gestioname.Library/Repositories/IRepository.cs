using System.Collections.Generic;

namespace Gestioname.Library.Repositories
{
    public interface IRepository<T> where T :IEntity<T>
    {
        T FindById(int id);
        IList<T> GetAll();
        void Save(T item);
    }
}
