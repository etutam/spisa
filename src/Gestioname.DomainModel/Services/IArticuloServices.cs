using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;

namespace Gestioname.DomainModel.Services
{
    public interface IArticuloServices
    {
        void Save(Articulo articulo);

        IEnumerable<Articulo> FindByCodigo(string codigo);

    }
}
