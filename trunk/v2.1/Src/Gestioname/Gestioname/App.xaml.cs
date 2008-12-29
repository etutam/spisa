using System;
using System.Windows;

using Microsoft.Practices.Composite.UnityExtensions;

namespace Gestioname
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

#if (DEBUG)
            RunInDebugMode();
#else       
            RunInReleaseMode();
#endif
        }

        private void RunInDebugMode()
        {
            UnityBootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }

        private void RunInReleaseMode()
        {

        }
    }
}
