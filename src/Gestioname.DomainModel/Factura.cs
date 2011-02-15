using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    public class Factura : EntityBase<Factura>, IHasItems
    {

        

        #region Properties

        public virtual long NumeroFactura { get; set; }

        public virtual bool FueImpresa { get; set; }

        public virtual bool EsNotaDeCredito { get; set; }

        public virtual DateTime Fecha { get; set; }

        public virtual Decimal ValorDolar { get; set; }

        public virtual string Observaciones { get; set; }

        public virtual bool EsCotizacion { get; set; }

        public virtual Orden Orden { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual List<OrdenItem> Items { get; set; }

        #endregion

        #region Methods
        
        public override Factura GetTestInstance()
        {
            return new Factura
                       {
                           NumeroFactura = 1234567891234567,
                           Fecha = DateTime.Now,
                           FueImpresa = false,
                           EsCotizacion = false,
                           EsNotaDeCredito = false,
                           ValorDolar = 4.06m
                       };
        }


        void Imprimir()
        {
            
        }


        #endregion

        
    }
}
