using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;

namespace Gestioname.DomainModel.Inventario
{
    public class Articulo : EntityBase
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public Categoria Categoria { get; set; }

        //public Moneda Moneda { get; set; }
    }
}
