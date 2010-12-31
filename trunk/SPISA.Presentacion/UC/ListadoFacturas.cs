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
    public partial class UcListadoFacturas : BaseControl
    {
        public  UcListadoFacturas()
        {
            InitializeComponent();
            buscador.Inicializar();

            Logger.Append(this.GetType().ToString(), null, "");
        }

        public int ObtenerIdFacturaSeleccionado()
        {
            int i = -1;

            try
            {
                if (grListaFacturas.ActiveRow != null) i = Convert.ToInt32(grListaFacturas.ActiveRow.Cells["IdFactura"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return i;
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarFacturas(true, false);
        }

        private void CargarFacturas(bool mostrarTodos, bool busquedaAvanzada)
        {
            DataSet ds = null;

            if (busquedaAvanzada)
            {
                ds = buscador.EjecutarBusqueda();
            }
            else
            {
                if (mostrarTodos)
                {
                    ds = Factura.TraerTodas();
                }
                else
                {

                }
            }
            CargarDatosFacturas(ds);
        }

        private void CargarDatosFacturas(DataSet ds)
        {

            int n;
            dsListaFacturas.Rows.Clear();

            Infragistics.Win.UltraWinDataSource.UltraDataRowsCollection childRows;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                n = 0;
                Infragistics.Win.UltraWinDataSource.UltraDataRow row = dsListaFacturas.Rows.Add();
                childRows = row.GetChildRows("Band 1");

                Infragistics.Win.UltraWinDataSource.UltraDataBand childBand = row.Band.ChildBands[0];

                row["IdNotaPedido"] = dr["IdNotaPedido"].ToString();
                row["IdFactura"] = dr["IdFactura"].ToString();
                row["NumeroFactura"] = dr["NumeroFactura"].ToString();
                row["RazonSocial"] = dr["RazonSocial"].ToString();
                row["Observaciones"] = dr["Observaciones"].ToString();
                row["ValorDolar"] = dr["ValorDolar"].ToString();
                row["Fecha"] = Convert.ToDateTime(dr["Fecha"]);
                row["FueImpresa"] = Convert.ToBoolean(dr["FueImpresa"]);
                row["FueCancelada"] = Convert.ToBoolean(dr["FueCancelada"]);

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

              //  SetearColores();
            }

            grListaFacturas.DataSource = dsListaFacturas;
            grListaFacturas.DataBind();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarFacturas(false, false);
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            CargarFacturas(false, true);
        }


    }
}