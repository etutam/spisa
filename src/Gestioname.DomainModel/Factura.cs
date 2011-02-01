using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    class Factura : EntityBase 
    {

#region Datos Privados
        
        Int32 _NumeroFactura = -1;

#endregion  

#region Propiedades
        
        public Int32 NumeroFactura 
        {
            get { return _NumeroFactura; }
            set { _NumeroFactura = value; }
        }

#endregion

    }
}
