using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;

namespace Gestioname.DomainModel.Inventario
{
    public class Almacen : EntityBase<Almacen>
    {
        public string Nombre { get; set; }

        public IList<Articulo> Articulos { get; set; }
        
       
    }
}
