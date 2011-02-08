using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;
using Gestioname.Library.Repositories;

namespace Gestioname.DomainModel.Repositories
{
    public interface IArticuloRepository: IRepository<Articulo>
    {
        IEnumerable<Articulo> FindByCodigo(string codigo);

        


    }
}
