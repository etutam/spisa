using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Framework.ObjectContextManager;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Infrastructure
{
    public sealed class UnitOfWorkScope : ObjectContextScope<GestionameContext>
    {
        public UnitOfWorkScope()
            : base()
        { }

        public UnitOfWorkScope(bool saveAllChangesAtEndOfScope) 
            : base(saveAllChangesAtEndOfScope)
        {

        }
    }
}
