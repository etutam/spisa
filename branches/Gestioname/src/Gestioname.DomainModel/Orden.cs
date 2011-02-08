using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;

namespace Gestioname.DomainModel
{
    public class Orden:EntityBase<Orden>
    {
        #region Properties

        public virtual Cliente Cliente { get; set; }

        public virtual DateTime FechaEmision { get; set; }

        public virtual DateTime FechaEntrega { get; set; }

        public virtual int Numero { get; set; }

        public virtual string Observaciones { get; set; }

        public virtual int DescuentoEspecial { get; set; }

        public virtual IList<Factura> Facturas { get; set; }

        public virtual IList<Remito> Remitos { get; set; }

        public virtual IList<OrdenItem> Items { get; set; }

        #endregion
    }
}
