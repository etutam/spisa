using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;

namespace Gestioname.Modules.Clientes
{
    public class ClientesModule : IModule
    {

        #region Private Fields
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        #endregion

        #region Constructors
        public ClientesModule(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _container = container;
        }
        #endregion

        #region Members

        public void Initialize()
        {
            RegisterViewsAndServices();   
        }

        protected void RegisterViewsAndServices()
        {

        }

        #endregion
    }
}
