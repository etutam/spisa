using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.Library
{
    public interface IEntity<T>
    {
        int Id { get; }

        T GetTestInstance();
    }
}
