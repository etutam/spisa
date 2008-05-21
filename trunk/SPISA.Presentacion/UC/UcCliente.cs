using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using SPISA.Libreria;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinGrid;

namespace SPISA.Presentacion
{
    public partial class UcCliente : BaseControl
    {
        #region Campos Privados
        Cliente _cliente;
        #endregion

        #region Constructores
        public UcCliente()
        {
            InitializeComponent();
            BindearComponentes();

            Logger.Append(this.GetType().ToString(), null, "");
        }
        public UcCliente(Cliente c)
        {
            InitializeComponent();
            BindearComponentes();
            CargarCliente(c);

            Logger.Append(this.GetType().ToString(), new Object[] { "IdCliente", c.Id }, "");
        }

        private void CargarCliente(Cliente c)
        {
            detallesCliente.CargarCliente(c);
            try
            {
                IList<Descuento> descuentos = Descuento.TraerDescuentosPorIdCliente(c.Id);

                foreach (Descuento d in descuentos)
                {
                    UltraDataRow dr = dsListaDescuentos.Rows.Add();
                    dr["IdCategoria"] = d.Categoria.IdCategoria;
                    dr["Categoria"] = d.Categoria.Descripcion;
                    dr["Descuento"] = d.Porcentaje;
                }

                this._cliente = c;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
        #endregion

        #region Metodos Privados

        private void BindearComponentes()
        {
            detallesCliente.BindearComponentes();

            ucListaCategorias.DataSource = Categoria.TraerTodas();
            ugDescuentos.DataSource = dsListaDescuentos;

        }

        #endregion

        #region Metodos Publicos
        public Cliente Guardar()
        {
            Cliente c = null;

            if (detallesCliente.Cliente != null)
                c = detallesCliente.Cliente;
            else
                c = new Cliente();


            c.RazonSocial = detallesCliente.RazonSocial;
            c.Domicilio = detallesCliente.DomicilioComercial;
            c.Provincia = detallesCliente.Provincia;
            c.IVA = detallesCliente.CondicionIVA;
            c.CUIT = detallesCliente.CUIT;
            c.Operatoria = detallesCliente.Operatoria;

            c.Descuentos.Clear();
            foreach (UltraGridRow dr in ugDescuentos.Rows)
            {
                Descuento d = new Descuento();
                d.Categoria = Categoria.TraerCategoriaPorId(Convert.ToInt32(dr.Cells["IdCategoria"].Text));
                d.Porcentaje = Convert.ToInt32(dr.Cells["Descuento"].Text);
                c.Descuentos.Add(d);
            }

            if (c.Id == -1)
                c.Guardar();
            else
                c.Actualizar();


            return c;
        }
        #endregion
        #region Eventos
        private void ugDescuentos_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
        {
            bool encontro = false;
            foreach (UltraGridRow dr in ugDescuentos.Rows)
            {
                if (dr != e.Cell.Row)
                {
                    if (dr.Cells["Categoria"].Text == e.Cell.Text)
                        encontro = true;
                }
            }

            if (encontro == true)
            {
                MessageBox.Show("Esa categoría ya existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        #endregion

        private void ugDescuentos_AfterCellUpdate(object sender, CellEventArgs e)
        {
            Categoria c = Categoria.TraerCategoriaPorDescripcion(e.Cell.Row.Cells["Categoria"].Text);

            e.Cell.Row.Cells[0].Value = c.IdCategoria;
        }

    }
}
