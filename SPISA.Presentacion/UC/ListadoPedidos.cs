using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlTypes;

using SPISA.Libreria;
using System.Configuration;
namespace SPISA.Presentacion
{

    public partial class ListadoPedidos : BaseControl
    {

        #region Constructores
        public ListadoPedidos()
        {
            InitializeComponent();
            BindearComponentes();

            Logger.Append(this.GetType().ToString(), null, "");
        }
        #endregion

        #region Métodos Públicos
        public int ObtenerIdPedidoSeleccionado()
        {
            int i = -1;

            if (grListaNotasPedido.ActiveRow != null) i = Convert.ToInt32(grListaNotasPedido.ActiveRow.Cells["IdNotaPedido"].Value);

            return i;
        }
        #endregion

        #region Métodos Privados
        private void BindearComponentes()
        {
            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DataBind();

            ucListaClientes.DataSource = Cliente.TraerTodos();
            ucListaClientes.DataBind();


            AppSettingsReader reader = new AppSettingsReader();
            ucpNoModificables.Color = Color.FromName(reader.GetValue("ColorNoModificable", typeof(string)).ToString());
            
            SetearColores();
        }

        private void CargarPedidos(bool mostrarTodos, bool busquedaAvanzada)
        {
            DataSet ds;
            if (busquedaAvanzada)
            {
                ds = buscador.EjecutarBusqueda();
            }
            else
            {
                if (mostrarTodos)
                {
                    ds = NotaPedido.TraerTodas();

                }
                else
                {
                    string razonSocial = (ucListaClientes.Text != "" ? ucListaClientes.Text : null);
                    SqlDateTime fechaEmision = (dtFechaEmision.Text != "" ? Convert.ToDateTime(dtFechaEmision.Value) : SqlDateTime.Null);
                    SqlDateTime fechaEntrega = (dtFechaEntrega.Text != "" ? Convert.ToDateTime(dtFechaEntrega.Value) : SqlDateTime.Null);
                    string observaciones = (txtObservaciones.Text != "" ? txtObservaciones.Text : null);

                    ds = NotaPedido.Buscar(razonSocial, fechaEmision, fechaEntrega, observaciones);
                }
            }

            CargarDatosPedidos(ds);
        }

        private bool EsModificable(int idNotaPedido)
        {
            bool ret = true;

            Factura f = Factura.TraerFacturaPorIdNotaPedido(idNotaPedido);

            if (f != null)
            {
                if (f.FueImpresa) ret = false;
            }

            return ret;
        }

        private void CargarDatosPedidos(DataSet ds)
        {
            int n;
            dsListaNotaPedidos.Rows.Clear();

            Infragistics.Win.UltraWinDataSource.UltraDataRowsCollection childRows;

            if (ds != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    n = 0;
                    Infragistics.Win.UltraWinDataSource.UltraDataRow row = dsListaNotaPedidos.Rows.Add();
                    childRows = row.GetChildRows("Band 1");

                    Infragistics.Win.UltraWinDataSource.UltraDataBand childBand = row.Band.ChildBands[0];

                    row["IdNotaPedido"] = dr["IdNotaPedido"].ToString();
                    row["NumeroOrden"] = dr["NumeroOrden"].ToString();
                    row["RazonSocial"] = dr["RazonSocial"].ToString();
                    row["FechaEmision"] = dr["FechaEmision"].ToString();
                    row["FechaEntrega"] = dr["FechaEntrega"].ToString();
                    row["Observaciones"] = dr["Observaciones"].ToString();
                    row["Modificable"] = Convert.ToBoolean(dr["Modificable"]);

                    foreach (DataRow dr2 in dr.GetChildRows("Id"))
                    {
                        childRows.SetCount(n + 1);

                        childRows[n]["IdNotaPedido"] = dr2["IdNotaPedido"].ToString();
                        childRows[n]["Codigo"] = dr2["Codigo"].ToString();
                        childRows[n]["Descripción"] = dr2["Descripcion"].ToString();
                        childRows[n]["Cantidad"] = dr2["Cantidad"].ToString();
                        childRows[n]["Descuento"] = dr2["Descuento"].ToString();

                        n++;
                    }

                    SetearColores();
                }

                grListaNotasPedido.DataSource = dsListaNotaPedidos;
                grListaNotasPedido.DataBind();
            }
        }

        private void SetearColores()
        {
            
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow row in grListaNotasPedido.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Modificable"].Value)==false) row.Appearance.BackColor = ucpNoModificables.Color;
            }
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPedidos(false, false);
        }
        
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarPedidos(true, false);
        }

        private void ucListaArticulos_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            frmContainer frm = frmContainer.crearContainer(frmContainer.explorerBar);

            Articulo a = Articulo.TraerArticuloPorCodigo(ucListaArticulos.Value.ToString());

            if (frm.TabControl.Tabs.Exists("articulo_" + a.Id))
                frm.TabControl.Tabs["articulo_" + a.Id].Selected = true;
            else
            {
                UcArticulo ucArticulo = new UcArticulo(a);
                frm.TabControl.Tabs[frm.AgregarTab("articulo_" + a.Id, "Artículo #" + a.Codigo, "groupArticuloActual", ucArticulo)].Selected = true;
            }
        }

        #endregion

        private void ucpNoModificables_ColorChanged(object sender, EventArgs e)
        {
            SetearColores();
        }

        private void ListadoPedidos_Resize(object sender, EventArgs e)
        {
            this.gbOpciones.Location = new Point(0, this.Height - this.gbOpciones.Height - 50);
            this.gbOpciones.Width = this.Width;

            this.grListaNotasPedido.Height = this.Height - gbBusqueda.Height - gbOpciones.Height - 50;
            this.grListaNotasPedido.Width = this.Width - 10;
        }

        private void ListadoPedidos_Load(object sender, EventArgs e)
        {
            buscador.Inicializar();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            CargarPedidos(false, true);
        }





    }
}
