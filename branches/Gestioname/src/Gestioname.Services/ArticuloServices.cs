using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Repositories;
using Gestioname.DomainModel.Services;

namespace Gestioname.Services
{
    public class ArticuloServices: IArticuloServices
    {
        public IArticuloRepository ArticuloRepository { get; set; }

        public void Save(Articulo articulo)
        {
            ArticuloRepository.Save(articulo);
        }

        public IEnumerable<Articulo> FindByCodigo(string codigo)
        {
            return ArticuloRepository.FindByCodigo(codigo);
        }
    }
}
