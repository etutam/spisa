using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Framework.BaseClasses;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.Interfaces
{
    public interface ICuentasFacade
    {
        void AddCuenta(Cuenta cuenta);
        void UpdateCuenta();
        void DeleteCuenta();

        void AddTransaccion();
        void UpdateTransaccion();
        void DeleteTransaccion();

    }
}
