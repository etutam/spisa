using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.Interfaces
{
    public interface IClientesPresentationModel
    {
        /// <summary>
        /// Listado de Clientes
        /// </summary>
        IEnumerable<Cliente> Clientes
        {
            get;
        }
        /// <summary>
        /// Vista
        /// </summary>
        IClientesView View
        {
            get; set;
        }

    }
}
