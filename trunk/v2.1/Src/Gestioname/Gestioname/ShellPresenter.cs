using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname
{
    public class ShellPresenter
    {
        public ShellPresenter(IShellView view)
        {
            this.View = view;
        }

        public IShellView View
        {
            get;
            private set;
        }
    }
}
