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
    public partial class DetallesCliente : BaseControl
    {
        #region Campos
        Cliente _cliente;
        #endregion

        #region Delegates
        public delegate void ClienteSeleccionadoEventHandler(object sender, EventArgs e);
        public event ClienteSeleccionadoEventHandler ClienteSeleccionado;
        #endregion

        #region Constructor
        public DetallesCliente()
        {
            InitializeComponent();
        }

        #endregion

        #region Propiedades

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
        }

        public string CodigoCliente
        {
            get
            {
                return ucListaClientes.SelectedRow.Cells["Codigo"].Value.ToString(); 
            }
        }
        public string RazonSocial
        {
            get { return ucListaClientes.Text; }                
        }
        public string DomicilioComercial
        {
            get { return txtDomicilioComercial.Text; }
        }
        public string Localidad
        {
            get { return txtLocalidad.Text; }
        }
        public Provincia Provincia
        {
            get { return Provincia.TraerProvinciaPorId(Convert.ToInt32(ucListaProvincias.SelectedRow.Cells["IdProvincia"].Text)); }
        }
        public CondicionIVA CondicionIVA
        {
            get { return CondicionIVA.TraerCondicionIVAPorId(Convert.ToInt32(ucListaCondicionesIVA.SelectedRow.Cells["IdCondicionIVA"].Text)); }
        }
        public string CUIT
        {
            get {

                return txtCUIT.Text.Replace("-", "");
                
                
            }
        }
        public Operatoria Operatoria
        {
            get { return Operatoria.TraerOperatoriaPorId(Convert.ToInt32(ucListaOperatorias.SelectedRow.Cells["IdOperatoria"].Text)); }
        }

        #endregion

        #region Eventos
        private void ucListaClientes_Enter(object sender, EventArgs e)
        {
            ucListaClientes.Textbox.SelectAll();
        }

        public void SetFocus()
        {
            ucListaClientes.Focus();
        }
        private void ucListaClientes_TextChanged(object sender, EventArgs e)
        {
            if (ucListaClientes.IsItemInList())
            {
                string codigoCliente = ucListaClientes.SelectedRow.Cells["Codigo"].Value.ToString();
                Cliente c = Cliente.TraerClientePorCodigo(codigoCliente);
                this.CargarCliente(c);
                this._cliente = c;
                
            }
            else
            {
                this._cliente = null;
                BorrarCamposDetallesCliente();
            }

            if (ClienteSeleccionado!=null) ClienteSeleccionado(this, e);

        }
        private void ucListaClientes_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (_cliente != null)
                frmPrincipal.EditarCliente(_cliente.Id);
        }
        #endregion

        #region Métodos Públicos
        public void CargarCliente(Cliente c)
        {
            ucListaClientes.Text = c.RazonSocial;
            txtDomicilioComercial.Text = c.Domicilio;
            txtLocalidad.Text = c.Localidad;
            
            ucListaProvincias.Text = c.Provincia.Nombre;
            ucListaCondicionesIVA.Text = c.IVA.Condicion;
            ucListaOperatorias.Text = c.Operatoria.Tipo;
            txtCUIT.Text = c.CUIT;
            txtCUIT.Tag = c.CUIT;
            txtSaldo.Value = c.Saldo;

            if (c.Saldo < 0)
            {
                txtSaldo.Appearance.ForeColor = Color.Red;
            }
            else
            {
                txtSaldo.Appearance.ForeColor = Color.Black;
            }



            this._cliente = c; 

        }

        public void ActualizarDescuentos()
        {
            if (_cliente!=null)
                _cliente.Descuentos = Descuento.TraerDescuentosPorIdCliente(_cliente.Id);
        }

        private void BorrarCamposDetallesCliente()
        {
            txtDomicilioComercial.Text = "";
            txtLocalidad.Text = "";
            
            ucListaCondicionesIVA.Text = "";
            ucListaOperatorias.Text = "";
            ucListaProvincias.Text = "";
            txtCUIT.Text = "";
            

            txtSaldo.Appearance.ForeColor = Color.Black;
            txtSaldo.Value = 0;

        }

        public void BindearComponentes()
        {
            ucListaClientes.DataSource = Cliente.TraerTodos();
            ucListaClientes.DataBind();
            ucListaClientes.DisplayLayout.Bands[0].Columns[0].Hidden = true;

            ucListaProvincias.DataSource = Provincia.TraerTodas();
            ucListaProvincias.DataBind();
            ucListaProvincias.DisplayLayout.Bands[0].Columns[0].Hidden = true;

            ucListaCondicionesIVA.DataSource = CondicionIVA.TraerTodas();
            ucListaCondicionesIVA.DataBind();

            ucListaCondicionesIVA.DisplayLayout.Bands[0].Columns[0].Hidden = true;
            ucListaCondicionesIVA.DisplayLayout.Bands[0].Columns[1].Width = 200;
            

            ucListaOperatorias.DataSource = Operatoria.TraerTodas();
            ucListaOperatorias.DataBind();
            ucListaOperatorias.DisplayLayout.Bands[0].Columns[0].Hidden = true;
            ucListaOperatorias.DisplayLayout.Bands[0].Columns[1].Width = 200;

            
        }

        public override void SetearFormularioNoModificable()
        {
            ucListaClientes.ReadOnly = true;
        }

        public void SetearFormularioModificable()
        {
            txtDomicilioComercial.ReadOnly = false;
            txtLocalidad.ReadOnly = false;
            ucListaProvincias.ReadOnly = false;
            ucListaCondicionesIVA.ReadOnly = false;
            txtCUIT.ReadOnly = false;
            ucListaOperatorias.ReadOnly = false;
            txtSaldo.ReadOnly = false;
        }

        public void EstablecerError()
        {
            errorProvider.SetError(ucListaClientes, "Seleccione un cliente de la lista...");
        }
        public void QuitarError()
        {
            errorProvider.Clear();
        }

        #endregion

       

    
    }
}
