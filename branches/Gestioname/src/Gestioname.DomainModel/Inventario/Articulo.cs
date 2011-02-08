using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;

namespace Gestioname.DomainModel.Inventario
{
    public class Articulo : EntityBase<Articulo>
    {
        #region Properties

        public virtual string Codigo { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual decimal PrecioUnitario { get; set; }

        //public Categoria Categoria { get; set; }

        //public Moneda Moneda { get; set; }

        #endregion
        #region Methods

        public override Articulo GetTestInstance()
        {
            return new Articulo
                       {
                           Cantidad = 999,
                           Codigo = "prueba",
                           PrecioUnitario = 99.99m
                       };
        }
        #endregion
        
    }
}
