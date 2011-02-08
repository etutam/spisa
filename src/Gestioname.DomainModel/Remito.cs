using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;

namespace Gestioname.DomainModel
{
    public class Remito: EntityBase<Remito>
    {
        #region Properties

        public virtual int NumeroRemito { get; set; }

        public virtual Orden Orden { get; set; }

        public virtual DateTime Fecha { get; set; }

        public virtual string Observaciones { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Decimal Peso { get; set; }

        public virtual Decimal Valor { get; set; }

        public virtual int Bultos { get; set; }

        public virtual Transportista Transportista { get; set; }

        public virtual IList<OrdenItems> ListaItems { get; set; }

        
        #endregion



    }
}
