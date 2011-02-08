using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel.Inventario;
using Gestioname.Library;

namespace Gestioname.DomainModel
{
    public class OrdenItem: EntityBase<OrdenItem>
    {
        public virtual Articulo Articulo { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual Decimal Descuento { get; set; }


    }
}
