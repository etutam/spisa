using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.Library.Repositories
{
    public interface IRepository<T> where T :IEntity
    {
        T FindById(int Id);
        IList<T> GetAll();
        void Save(T item);
    }
}
