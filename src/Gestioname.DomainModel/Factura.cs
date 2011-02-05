using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    public class Factura : EntityBase<Factura> 
    {

        

        #region Propiedades

        public virtual long NumeroFactura { get; set; }

        #endregion

        public override Factura GetTestInstance()
        {
            return new Factura
                       {
                           NumeroFactura = 1234567891234567
                       };
        }
    }
}
