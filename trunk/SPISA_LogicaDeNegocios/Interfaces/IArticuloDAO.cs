using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Entities;

namespace SPISA.Libreria.Interfaces
{
    public interface IArticuloDAO
    {
        IEnumerable<Articulo> TraerTodos();
        Articulo TraerArticuloPorId(int idArticulo);
        Articulo TraerArticuloPorCodigo(string codigo);
        int Almacenar(Articulo articulo);
    }
}
