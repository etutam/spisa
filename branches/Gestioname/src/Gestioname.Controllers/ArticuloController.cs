using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Controllers;
using Gestioname.DomainModel.Inventario;
using Gestioname.DomainModel.Services;

namespace Gestioname.Controllers
{
    public class ArticuloController:IArticuloController
    {
        public IArticuloServices ArticuloServices { get; set; }

        public void Save(Articulo articulo)
        {
            ArticuloServices.Save(articulo);
        }

        public IEnumerable<Articulo> FindByCodigo(string codigo)
        {
            return ArticuloServices.FindByCodigo(codigo);
        }
    }
}
