using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Entities;
namespace SPISA.Libreria.Interfaces
{
    public interface ICategoriaDAO
    {
        IEnumerable<Categoria> TraerTodas();
        Categoria TraerCategoriaPorId(int idCategoria);
        Categoria TraerCategoriaPorDescripcion(string descripcion);
        int Almacenar(Categoria categoria);
    }
}
