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
    public partial class UcListadoArticulos : BaseControl
    {

        #region Constructores
        public UcListadoArticulos()
        {
            InitializeComponent();
            buscador.Inicializar();

            Logger.Append(this.GetType().ToString(), null, "");
        }
        #endregion

        #region Metodos Privados

        private void ModoEdicion(bool p)
        {
            if (p)
            {
                grListaArticulos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;

                chkIngresoMateriales.Enabled = false;
                btnBuscar.Enabled = false;
                btnBorrar.Enabled = false;
                btnMostrarTodos.Enabled = false;
            }
            else
            {
                if (grListaArticulos.Rows.Count > 0)
                {
                    AlmacenarCambios(chkModoEdicion);
                }

                grListaArticulos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Default;

                chkIngresoMateriales.Enabled = true;
                btnBuscar.Enabled = true;
                btnBorrar.Enabled = true;
                btnMostrarTodos.Enabled = true;
            }

            grListaArticulos.DataSource = dsListaArticulos;
            grListaArticulos.DataBind();
        }

        private void ModoIngresoDeMateriales(bool p)
        {
            if (p)
            {
                grListaArticulos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;

                chkModoEdicion.Enabled = false;
                btnBuscar.Enabled = false;
                btnBorrar.Enabled = false;
                btnMostrarTodos.Enabled = false;
            }

            else
            {
                if (grListaArticulos.Rows.Count > 0)
                {
                    AlmacenarCambios(chkIngresoMateriales);
                }

                grListaArticulos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Default;

                chkModoEdicion.Enabled = true;
                btnBuscar.Enabled = true;
                btnBorrar.Enabled = true;
                btnMostrarTodos.Enabled = true;
            }

            dsListaArticulos.Rows.Clear();

            grListaArticulos.DataSource = dsListaArticulos;
            grListaArticulos.DataBind();
        }
        private void AlmacenarCambios(Infragistics.Win.UltraWinEditors.UltraCheckEditor e)
        {
            for (int i = 0; i < dsListaArticulos.Rows.Count; i++)
            {
                if (dsListaArticulos.Rows[i]["Codigo"].ToString().Trim().Equals(""))
                {
                    dsListaArticulos.Rows.RemoveAt(i);
                    i--;
                }
            }

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in grListaArticulos.Rows)
            {
                Articulo a = Articulo.TraerArticuloPorCodigo(r.Cells["Codigo"].Text);

                if (a != null)
                {
                    if (e.Equals(chkModoEdicion))
                    {
                        a.Cantidad = Convert.ToInt32((r.Cells["Cantidad"].Text!="" ? r.Cells["Cantidad"].Text : "0"));
                        a.Descripcion = (r.Cells["Descripcion"].Text!="" ? r.Cells["Descripcion"].Text : "(Sin Descripción)");
                        a.PrecioUnitario = Convert.ToDecimal((r.Cells["Precio Unitario"].Text!="" ? r.Cells["Precio Unitario"].Text : "0"));

                        if (ucListaCategorias2.IsItemInList(r.Cells["Categoria"].Text))
                        {
                            a.Categoria = Categoria.TraerCategoriaPorDescripcion(r.Cells["Categoria"].Text);
                        }
                        else
                        {
                            a.Categoria = Categoria.TraerCategoriaPorDescripcion("Sin Categoria");
                        }

                        a.Actualizar();
                    }
                    if (e.Equals(chkIngresoMateriales))
                    {
                        a.Cantidad = a.Cantidad + Convert.ToInt32((r.Cells["Cantidad"].Text != "" ? r.Cells["Cantidad"].Text : "0"));
                        a.Descripcion = (r.Cells["Descripcion"].Text != "" ? r.Cells["Descripcion"].Text : "(Sin Descripción)");
                        a.PrecioUnitario = Convert.ToDecimal(r.Cells["Precio Unitario"].Text);
                        a.Categoria = Categoria.TraerCategoriaPorDescripcion((r.Cells["Categoria"].Text != "" ? r.Cells["Categoria"].Text : "Sin Categoria"));

                        a.Actualizar();
                    }
                }
                else
                {
                    if (r.Cells["Codigo"].Text.Trim() != "")
                    {
                        Articulo nuevoArticulo = new Articulo();

                        nuevoArticulo.Codigo = r.Cells["Codigo"].Text;
                        nuevoArticulo.Cantidad = Convert.ToInt32((r.Cells["Cantidad"].Text != "" ? r.Cells["Cantidad"].Text : "0"));
                        nuevoArticulo.Descripcion = (r.Cells["Descripcion"].Text != "" ? r.Cells["Descripcion"].Text : "(Sin Descripción)");
                       // r.Cells["Precio Unitario"].Text = r.Cells["Precio Unitario"].Text.Replace(".", ",");
                        nuevoArticulo.PrecioUnitario = Convert.ToDecimal(r.Cells["Precio Unitario"].Text.Replace(".", ","));
                        nuevoArticulo.Categoria = Categoria.TraerCategoriaPorDescripcion((r.Cells["Categoria"].Text != "" ? r.Cells["Categoria"].Text : "Sin Categoria"));

                        nuevoArticulo.Guardar();
                    }
                }


            }

            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DataBind();
        }
        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            BindearComponentes();
        }

        private void BindearComponentes()
        {
            ucListaCategorias.DataSource = Categoria.TraerTodas();
            ucListaCategorias.DataBind();

            ucListaCategorias2.DataSource = Categoria.TraerTodas();
            ucListaCategorias2.DataBind();

            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DataBind();
        }

        private void CargarArticulos(bool mostrarTodos, bool busquedaAvanzada)
        {
            DataTable dt = new DataTable();

            if (busquedaAvanzada)
            {
                DataSet ds = buscador.EjecutarBusqueda();
                if (ds!=null)
                    dt = ds.Tables[0];
            }
            else
            {
                if (mostrarTodos)
                {
                    dt = Articulo.TraerTodos();
                }
                else
                {
                    string criterioCodigo = (cbCriterioCodigo.Text != "" ? cbCriterioCodigo.Text : null);
                    string codigo = (txtCodigo.Text != "" ? txtCodigo.Text : null);
                    Int32 idCategoria = (Convert.ToInt32(ucListaCategorias.Value) != 0 ? Convert.ToInt32(ucListaCategorias.Value) : -1);
                    string criterioDescripcion = (cbCriterioDescripcion.Text != null ? cbCriterioDescripcion.Text : null);
                    string descripcion = (txtDescripcion.Text != "" ? txtDescripcion.Text : null);
                    string criterioPrecio = (cbCriterioPrecio.Text != "" ? cbCriterioPrecio.Text : null);
                    Decimal precio = (txtPrecio.Value != 0 ? txtPrecio.Value : -1);
                    string criterioCantidad = (cbCriterioCantidad.Text != "" ? cbCriterioCantidad.Text : null);
                    int cantidad = (Convert.ToInt32(txtCantidad.Value) != 0 ? Convert.ToInt32(txtCantidad.Value) : -1);

                    dt = Articulo.Buscar(criterioCodigo, codigo, idCategoria, criterioDescripcion, descripcion, criterioPrecio, precio, criterioCantidad, cantidad);
                }
            }

            CargarArticulos(dt);
        }

        private void CargarArticulos(DataTable dt)
        {
            dsListaArticulos.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                Infragistics.Win.UltraWinDataSource.UltraDataRow row = dsListaArticulos.Rows.Add();

                row["IdArticulo"] = dr["IdArticulo"].ToString();
                row["Cantidad"] = Convert.ToInt32(dr["Cantidad"]);
                row["Codigo"] = dr["Codigo"].ToString();
                row["Categoria"] = dr["Categoria"].ToString();
                row["Descripcion"] = dr["Descripcion"].ToString();
                row["Precio Unitario"] = Convert.ToDecimal(dr["PrecioUnitario"]);
            }

            grListaArticulos.DataSource = dsListaArticulos;
            grListaArticulos.DataBind();
        }

        #endregion

        #region Metodos Publicos
        public int ObtenerIdArticuloSeleccionado()
        {
            int i = -1;

            try
            {
                if (grListaArticulos.ActiveRow != null) i = Convert.ToInt32(grListaArticulos.ActiveRow.Cells["IdArticulo"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }

        #endregion

        #region Eventos
        private void grListaArticulos_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Column.ToString() == "Codigo")
            {
                if (ucListaArticulos.IsItemInList(e.Cell.Text))
                {
                    Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Row.Cells["Codigo"].Text);

                    if (chkModoEdicion.Checked) e.Cell.Row.Cells["Cantidad"].Value = a.Cantidad;
                    else e.Cell.Row.Cells["Cantidad"].Value = 0;

                    e.Cell.Row.Cells["Descripcion"].Value = a.Descripcion;
                    e.Cell.Row.Cells["Precio Unitario"].Value = a.PrecioUnitario;
                    e.Cell.Row.Cells["Categoria"].Value = a.Categoria.IdCategoria;

                }
                else
                {
                    e.Cell.Row.Cells["Cantidad"].Value = 0;
                    e.Cell.Row.Cells["Descripcion"].Value = "";
                    e.Cell.Row.Cells["Precio Unitario"].Value = 0;
                    e.Cell.Row.Cells["Categoria"].Value = "";
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarArticulos(true, false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarArticulos(false,false);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            ucListaCategorias.Text = "Seleccione una Categoría...";
            cbCriterioPrecio.Text = "";
            txtPrecio.Value = 0;
            cbCriterioCantidad.Text = "";
            txtCantidad.Value = 0;
        }

        private void chkModoEdicion_CheckedChanged(object sender, EventArgs e)
        {
            ModoEdicion(chkModoEdicion.Checked);
        }

        private void chkIngresoMateriales_CheckedChanged(object sender, EventArgs e)
        {
            ModoIngresoDeMateriales(chkIngresoMateriales.Checked);
        }

        #endregion

        private void UcListadoArticulos_Resize(object sender, EventArgs e)
        {
            this.gbOpciones.Location = new Point(0, this.Height - this.gbOpciones.Height-50);
            this.gbOpciones.Width = this.Width;



            this.grListaArticulos.Height = this.Height - gbBusqueda.Height - gbOpciones.Height - 50;
            this.grListaArticulos.Width = this.Width - 10;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (cbCriterioCodigo.Text == "")
            {
                cbCriterioCodigo.Text = "Comience Con"; 
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (cbCriterioDescripcion.Text == "")
            {
                cbCriterioDescripcion.Text = "Comience Con"; 
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            CargarArticulos(false, true); 
        }

    }
}
