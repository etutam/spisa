using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace Gestioname.Framework.ObjectContextManager
{
    /// <summary>
    /// Abstract base class for all other ObjectContextManager classes. 
    /// </summary>
    public abstract class ObjectContextManager<T> where T : ObjectContext, new()
    {
        /// <summary>
        /// Returns a reference to an ObjectContext instance.
        /// </summary>
        public abstract T ObjectContext
        {
            get;
        }
    }
}
