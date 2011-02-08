using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;

namespace Gestioname.DomainModel.Controllers
{
    public interface IArticuloController
    {
        void Save(Articulo articulo);

        IEnumerable<Articulo> FindByCodigo(string codigo);
    }
}
