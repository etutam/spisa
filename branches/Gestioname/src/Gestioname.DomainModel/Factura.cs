using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    public class Factura : EntityBase<Factura> 
    {

        

        #region Properties

        public virtual long NumeroFactura { get; set; }

        public virtual bool FueImpresa { get; set; }

        public virtual bool EsNotaDeCredito { get; set; }

        #endregion

        #region Methods
        
        public override Factura GetTestInstance()
        {
            return new Factura
                       {
                           NumeroFactura = 1234567891234567
                       };
        }


        void Imprimir()
        {
            
        }


        #endregion
    }
}
