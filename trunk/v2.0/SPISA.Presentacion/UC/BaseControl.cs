using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SPISA.Presentacion
{
    public partial class BaseControl : UserControl
    {
        private bool _refrescar = false;

        public BaseControl()
        {
            InitializeComponent();
        }

        public virtual bool RefrescarAutomaticamente
        {
            get
            {
                return _refrescar;
            }
            set
            {
                _refrescar = value;
            }
        }

        public virtual bool FueModificado
        {
            get
            {
                return false;
            }
            
        }

        public virtual void Refrescar()
        {
            
        }

        /// <summary>
        /// Este metodo solo sera ejecutado por algunos de los objetos heredados.
        /// </summary>
        /// <returns></returns>
        public virtual int ObtenerIdNotaPedido()
        {
            return -1;
        }

        public virtual void SetearFormularioNoModificable()
        {

        }

        public virtual void SetInitialFocus()
        {

        }

        public virtual int BeforeCloseCheck()
        {
            return 1;
        }
    }
}
