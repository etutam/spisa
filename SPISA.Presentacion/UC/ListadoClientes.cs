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
    public partial class ListadoClientes : BaseControl
    {
        public ListadoClientes()
        {
            InitializeComponent();
            buscador.Inicializar();

            Logger.Append(this.GetType().ToString(), null, "");
        }

        public int ObtenerIdClienteSeleccionado()
        {
            int i = -1;

            try
            {
                if (grListaClientes.ActiveRow != null) i = Convert.ToInt32(grListaClientes.ActiveRow.Cells["IdCliente"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            BindearComponentes();
        }

        private void BindearComponentes()
        {
            ucListaClientes.DataSource = Cliente.TraerTodos();
            ucListaClientes.DataBind();

            ucListadoCondicionesIVA.DataSource = CondicionIVA.TraerTodas();
            ucListadoCondicionesIVA.DataBind();

            ucListadoOperatorias.DataSource = Operatoria.TraerTodas();
            ucListadoOperatorias.DataBind();

            ucListadoProvincias.DataSource = Provincia.TraerTodas();
            ucListadoProvincias.DataBind();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarClientes(false, false);
        }

        private void chkModoEdicion_CheckedChanged(object sender, EventArgs e)
        {
            ModoEdicion(chkModoEdicion.Checked);
        }

        private void ModoEdicion(bool p)
        {
            if (p)
            {
                grListaClientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;

                btnBuscar.Enabled = false;
                btnBorrar.Enabled = false;
                btnMostrarTodos.Enabled = false;
            }
            else
            {
                if (grListaClientes.Rows.Count > 0)
                {
                    AlmacenarCambios(chkModoEdicion);
                }

                grListaClientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Default;

                btnBuscar.Enabled = true;
                btnBorrar.Enabled = true;
                btnMostrarTodos.Enabled = true;

                dsListadoClientes.Rows.Clear();
            }

            ucListaClientes.DataSource = Cliente.TraerTodos();
            ucListaClientes.DataBind();
        }

        private void AlmacenarCambios(Infragistics.Win.UltraWinEditors.UltraCheckEditor chkModoEdicion)
        {
            bool existe = false;

            for (int i = 0; i < dsListadoClientes.Rows.Count; i++)
            {
                if (dsListadoClientes.Rows[i]["RazonSocial"].ToString().Trim().Equals(""))
                {
                    dsListadoClientes.Rows.RemoveAt(i);
                    i--;
                }
            }

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in grListaClientes.Rows)
            {
                existe = false;

                Cliente c = Cliente.TraerClientePorRazonSocial(r.Cells["RazonSocial"].Text);

                if (c == null)
                {
                    c = new Cliente();
                }
                else
                {
                    existe = true;
                }
                if (r.Cells["RazonSocial"].Text.Trim() != "")
                {
                    c.RazonSocial = r.Cells["RazonSocial"].Text;
                    c.Codigo = Convert.ToInt32(r.Cells["Codigo"].Text);
                    c.Domicilio = r.Cells["Domicilio"].Text;
                    c.Localidad = r.Cells["Localidad"].Text;

                    if (ucListadoProvincias.IsItemInList(r.Cells["Provincia"].Text))
                        c.Provincia = Provincia.TraerProvinciaPorNombre(r.Cells["Provincia"].Text);
                    else
                        c.Provincia = Provincia.TraerProvinciaPorNombre("Buenos Aires");

                    if (ucListadoCondicionesIVA.IsItemInList(r.Cells["CondicionIVA"].Text))
                        c.IVA = CondicionIVA.TraerCondicionIVAPorCondicionIVA(r.Cells["CondicionIVA"].Text);
                    else
                        c.IVA = CondicionIVA.TraerCondicionIVAPorCondicionIVA("Responsable Inscripto");

                    if (ucListadoOperatorias.IsItemInList(r.Cells["Operatoria"].Text))
                        c.Operatoria = Operatoria.TraerOperatoriaPorOperatoria(r.Cells["Operatoria"].Text);
                    else
                        c.Operatoria = Operatoria.TraerOperatoriaPorOperatoria("Contado");

                    c.CUIT = r.Cells["CUIT"].Text;
                    c.Saldo = Convert.ToDecimal(r.Cells["Saldo"].Value.ToString() != "" ? r.Cells["Saldo"].Value.ToString() : "0");

                    if (existe) c.Actualizar();
                    else c.Guardar();
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarClientes(true, false);
        }

        private void CargarClientes(bool mostrarTodos, bool busquedaAvanzada)
        {
            DataTable dt = null;

            if (busquedaAvanzada)
            {
                DataSet ds = buscador.EjecutarBusqueda();
                if (ds != null) dt = ds.Tables[0];
            }
            else
            {
                if (mostrarTodos)
                {
                    dt = Cliente.TraerTodos();
                }
                else
                {
                    string codigo = (txtCodigo.Text != "" ? txtCodigo.Text : null);
                    string localidad = (txtLocalidad.Text != "" ? txtLocalidad.Text : null);
                    string razonSocial = (txtRazonSocial.Text != "" ? txtRazonSocial.Text : null);
                    string criterioSaldo = (cbCriterioSaldo.Text != "" ? cbCriterioSaldo.Text : null);
                    decimal saldo = txtSaldo.Value;


                    dt = Cliente.Buscar(codigo, localidad, razonSocial, criterioSaldo, saldo);
                }
            }
            CargarClientes(dt);
        }

        private void CargarClientes(DataTable dt)
        {
            dsListadoClientes.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                Infragistics.Win.UltraWinDataSource.UltraDataRow row = dsListadoClientes.Rows.Add();

                row["IdCliente"] = Convert.ToInt32(dr["IdCliente"]);
                row["RazonSocial"] = dr["RazonSocial"].ToString();
                row["Codigo"] = dr["Codigo"].ToString();
                row["Domicilio"] = dr["Domicilio"].ToString();
                row["Localidad"] = dr["Localidad"].ToString();
                row["Provincia"] = dr["Provincia"].ToString();
                row["CondicionIVA"] = dr["CondicionIVA"].ToString();
                row["CUIT"] = dr["CUIT"].ToString();
                row["Operatoria"] = dr["Operatoria"].ToString();
                row["Saldo"] = Convert.ToDecimal(dr["Saldo"]);
            }

            grListaClientes.DataSource = dsListadoClientes;
            grListaClientes.DataBind();
        }

        private void grListaClientes_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Column.ToString() == "RazonSocial")
            {
                if (ucListaClientes.IsItemInList(e.Cell.Text))
                {
                    Cliente c = Cliente.TraerClientePorRazonSocial(e.Cell.Text);

                    e.Cell.Row.Cells["IdCliente"].Value = c.Id;
                    e.Cell.Row.Cells["Codigo"].Value = c.Codigo;
                    e.Cell.Row.Cells["Domicilio"].Value = c.Domicilio;
                    e.Cell.Row.Cells["Localidad"].Value = c.Localidad;
                    e.Cell.Row.Cells["Provincia"].Value = c.Provincia.Id;
                    e.Cell.Row.Cells["CondicionIVA"].Value = c.IVA.Id;
                    e.Cell.Row.Cells["CUIT"].Value = c.CUIT;
                    e.Cell.Row.Cells["Operatoria"].Value = c.Operatoria.Id;
                    e.Cell.Row.Cells["Saldo"].Value = c.Saldo;
                }
                else
                {
                    e.Cell.Row.Cells["IdCliente"].Value = 0;
                    e.Cell.Row.Cells["Codigo"].Value = Cliente.ObtenerNuevoNumeroDeCliente();
                    e.Cell.Row.Cells["Domicilio"].Value = "";
                    e.Cell.Row.Cells["Localidad"].Value = "";
                    e.Cell.Row.Cells["Provincia"].Value = "";
                    e.Cell.Row.Cells["CondicionIVA"].Value = "";
                    e.Cell.Row.Cells["CUIT"].Value = "";
                    e.Cell.Row.Cells["Operatoria"].Value = "";
                    e.Cell.Row.Cells["Saldo"].Value = "";
                }
            }
        }

        private void ListadoClientes_Resize(object sender, EventArgs e)
        {
            this.gbOpciones.Location = new Point(0, this.Height - this.gbOpciones.Height - 50);
            this.gbOpciones.Width = this.Width;

            this.grListaClientes.Height = this.Height - gbBusqueda.Height  - 50;
            this.grListaClientes.Width = this.Width - 10;

            this.tcBusqueda.Width = this.Width;
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            CargarClientes(false, true);
        }


    }
}
