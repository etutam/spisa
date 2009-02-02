using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;

using Gestioname.Modules.Clientes.BusinessComponents;
using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Modules.Clientes.Models;
using Gestioname.Modules.Clientes.Views;
using Gestioname.Infrastructure;

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
            // Register Types
            _container.RegisterType<IClientesView, ClientesView>();
            _container.RegisterType<IClientesPresentationModel, ClientesPresentationModel>();
            _container.RegisterType<IClientesComponent, ClientesComponent>();

            // Register Views
            _regionManager.RegisterViewWithRegion(RegionNames.MainRegion,
                                                  () => _container.Resolve<IClientesPresentationModel>().View);
        }

        #endregion
    }
}
