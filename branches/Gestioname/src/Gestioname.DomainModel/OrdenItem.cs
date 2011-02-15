using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.Library;

namespace Gestioname.DomainModel
{
    public class OrdenItem: EntityBase<OrdenItem>
    {
        #region Constructors
        public OrdenItem()
        {
            
        }
        
        public OrdenItem(Articulo articulo, int cantidad, decimal descuento, Orden orden)
        {
            Articulo = articulo;
            Cantidad = cantidad;
            Descuento = descuento;
            Orden = orden;
        }
        #endregion

        #region Properties
        public virtual Articulo Articulo { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual Decimal Descuento { get; set; }

        public virtual Orden Orden { get;set; }
        #endregion

        public override OrdenItem GetTestInstance()
        {
            return new OrdenItem { Cantidad = 100, Descuento = 20};

        }

    }
}
