using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using SPISA.Libreria;

namespace SPISA.Presentacion
{
    public partial class UcArticulo : BaseControl
    {
        Articulo _articulo = null;

        #region Constructores
        public UcArticulo()
        {
            InitializeComponent();
            BindearComponentes();

            Logger.Append(this.GetType().ToString(), null, "");
        }

        public UcArticulo(Articulo a)
        {
            InitializeComponent();
            CargarArticulo(a);
            BindearComponentes();

            Logger.Append("UcArticulo()", new Object[] { "IdArticulo", a.Id }, "");
        }
        #endregion

        #region Metodos
        private void BindearComponentes()
        {
            cbCategoria.DataSource = Categoria.TraerTodas();
            cbCategoria.DataBind();

            txtCodigo.DataSource = Articulo.TraerTodos();
            txtCodigo.DataBind();

            chtHistorialSalidas.DataSource = CargarHistorialDeSalidas(6);
        }


        /// <summary>
        /// Este mètodo mostrará en el gráfico un historial de salidas del artículo actual de N meses
        /// </summary>
        /// <param name="n">Se cargara un historial de salidas de N meses</param>
        /// <returns></returns>

        private DataTable CargarHistorialDeSalidas(int n)
        {
            
            DataTable mydata = new DataTable();
            mydata.Columns.Add("Meses", typeof(string));
            
            int numeroMesActual = DateTime.Now.Month;
            
            int x = (n-1)*-1;
            
            while (x != 1)
            {
                mydata.Columns.Add(ObtenerFecha(x).ToString("MMMM") + "  " + ObtenerFecha(x).ToString("yyyy"), typeof(int));

                x++; 
            }

            x=(n-1)*-1;

            DataRow myRow =  mydata.NewRow();

            int i = 1;
            while(x  != 1)
            {
                myRow[i] = Articulo.TraerCantidadSalidasPorArticuloPorFecha(_articulo.Id, ObtenerFecha(x));

                x++; i++;
            }

            mydata.Rows.Add(myRow);
            
            return mydata;
        }

        /// <summary>
        /// Éste método devuelve una instancia de objeto DateTime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public DateTime ObtenerFecha(int n)
        {
            return DateTime.Now.AddMonths(n);
        }

        private void CargarArticulo(Articulo a)
        {
            txtCodigo.Text = a.Codigo;
            txtCantidad.Value = a.Cantidad.ToString();
            cbCategoria.Text = a.Categoria.Descripcion; 
            txtPrecioUnitario.Value = Convert.ToDecimal(a.PrecioUnitario);
            txtDescripcion.Text = a.Descripcion;

            

            this._articulo = a; 
        }

        public void FocusCodigo()
        {
            txtCodigo.Focus();
        }
        public int Guardar()
        {
            int ret = -1;

            try
            {
                if (VerificarCampos())
                {
                    Articulo a;

                    if (_articulo != null)
                        a = _articulo;
                    else
                        a = new Articulo();

                    a.Codigo = txtCodigo.Text;
                    a.Categoria = Categoria.TraerCategoriaPorId(Convert.ToInt32(cbCategoria.Value));
                    a.Cantidad = Convert.ToDecimal(txtCantidad.Value);
                    a.Descripcion = txtDescripcion.Text;
                    a.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Value);

                    if (a.Id == -1)
                    {
                        ret = a.Guardar();
                    }
                    else
                    {
                        a.Actualizar();
                    }

                    BindearComponentes();
                    BorrarCampos(true);

                    txtCodigo.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret; 
        }

        // TODO: Implementar Este Metodo
        private bool VerificarCampos()
        {
            return true; 
        }
        #endregion

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Value != null)
            {
                Articulo a = Articulo.TraerArticuloPorID(Convert.ToInt32(txtCodigo.Value));
                CargarArticulo(a);
            }
            else
            {
                BorrarCampos(false);
                
            }
            
        }

        private void BorrarCampos(bool borrarCodigo)
        {
            
            txtCantidad.Value = 0;
            cbCategoria.Text = "";
            txtPrecioUnitario.Value = 0;
            txtDescripcion.Text = "";
            if (borrarCodigo) txtCodigo.Text = "";

            _articulo = null;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            chtHistorialSalidas.DataSource= CargarHistorialDeSalidas(Convert.ToInt32(txtMeses.Value));
        }

    }
}
