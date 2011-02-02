using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.Library
{
    public abstract class EntityBase<T> : IEntity<T>
    {
        public virtual int Id { get; set; }

        public abstract T GetTestInstance();
    }

}
