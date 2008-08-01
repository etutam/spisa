using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPISA.Libreria.Interfaces
{
    public interface IDaoFactory
    {
        IArticuloDAO CreateArticuloDAO();
        ICategoriaDAO CreateCategoriaDAO();
    }
}
