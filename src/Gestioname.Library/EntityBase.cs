using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.Library
{
    public abstract class EntityBase<T> : IEntity<T> where T : IEntity<T>, new()
    {
        public virtual int Id { get; set; }

        public virtual T GetTestInstance()
        {
            return new T();
        }
    }

}
