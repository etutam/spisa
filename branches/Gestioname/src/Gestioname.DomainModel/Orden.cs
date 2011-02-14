using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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


        #region Constructors
        public Orden()
        {
            Facturas = new List<Factura>();

            Remitos = new List<Remito>();

            Items = new List<OrdenItem>();
        }
        #endregion
        #region Methods

        public override Orden GetTestInstance()
        {
            DateTime fecha = new DateTime(2010,2,3);
            return new Orden
                       {
                           DescuentoEspecial = 100,
                           FechaEmision = fecha,
                           FechaEntrega = DateTime.Today,
                           Numero = 1234
                       };
        }
        #endregion
    }
}
