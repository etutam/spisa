using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;

namespace Gestioname.Modules.Clientes.UI
{
    public class ClientesModule : IModule{

        private readonly IRegionManager _regionManager;

        #region IModule Members

        public void Initialize()
        {
            
        }

        #endregion
    }
}
