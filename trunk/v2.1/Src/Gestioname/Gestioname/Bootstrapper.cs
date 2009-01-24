using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using Microsoft.Practices.Composite.UnityExtensions;
using Microsoft.Practices.Composite.Modularity;

using Gestioname.Modules.Clientes;

namespace Gestioname
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override 

        protected override void ConfigureContainer()
        {
            Container.RegisterType<IShellView, Shell>();
            base.ConfigureContainer();
        }

        protected override DependencyObject CreateShell()
        {
            ShellPresenter presenter = Container.Resolve<ShellPresenter>();
            IShellView view = presenter.View;
            view.ShowView();

            return view as DependencyObject;
        }

    }
}
