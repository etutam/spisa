using System;
using System.Collections.Generic;
using System.Text;

namespace SPISA.Libreria
{
    public class NotaPedido_Item
    {

        #region Constructores
        public NotaPedido_Item()
        {
            
        }
        #endregion

        #region Campos Privados

        Articulo _Articulo = null;
        Decimal _cantidad = -1;
        Decimal _precioUnitario = -1; 
        Decimal _descuento = -1;

        #endregion

        #region Propiedades
        public Articulo Articulo
        {
            get { return _Articulo; }
            set { _Articulo = value; }
        }

        public Decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Decimal PrecioUnitario
        {
            get
            {
                return _precioUnitario;
            }
            set
            {
                _precioUnitario = value;
            }
        }
        public Decimal Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        #endregion
    }
}
