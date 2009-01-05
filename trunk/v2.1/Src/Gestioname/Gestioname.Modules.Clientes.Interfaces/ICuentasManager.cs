using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.Modules.Clientes.Interfaces
{
    public interface ICuentasFacade
    {
        void AddCuenta();
        void UpdateCuenta();
        void DeleteCuenta();

        void AddTransaccion();
        void UpdateTransaccion();
        void DeleteTransaccion();

    }
}
