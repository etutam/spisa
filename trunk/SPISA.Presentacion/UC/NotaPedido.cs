using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using Infragistics.Win.UltraWinGrid;

using SPISA.Libreria;

namespace SPISA.Presentacion
{
    public partial class UcNotaPedido : BaseControl
    {
        #region Campos Privados
        NotaPedido _notaPedido = null;

        private bool _refrescar = false;
        private bool _fueModificada = false; 
        #endregion

        #region Constructores
        public UcNotaPedido()
        {
            InitializeComponent();
            BindearComponentes();
            MostrarFilasVacias();

            txtNumeroPedido.Text = "(Sin Asignar)";
            
            dtFechaEmision.Value = DateTime.Now;
            dtFechaEntrega.Value = DateTime.Now;

            _fueModificada = true;

            Logger.Append(this.GetType().ToString(), null, "");
        }

        public UcNotaPedido(SPISA.Libreria.NotaPedido np)
        {
            InitializeComponent();
            BindearComponentes();
            CargarNotaDePedido(np);

            Logger.Append(this.GetType().ToString(), new Object[] { "IdNotaPedido", np.IdNotaPedido.ToString() }, "");
        }
        #endregion

        #region Propiedades
        public override bool  RefrescarAutomaticamente
        {
	          get 
	        { 
		         return this._refrescar;
	        }
	          set 
	        { 
		        this._refrescar = value;
	        }
        }

        public NotaPedido NotaPedido
        {
            get
            {
                return _notaPedido;
            }
            set
            {
                _notaPedido = value;
            }
        }
        
        #endregion

        #region Eventos
        private void EventoSetearFueModificada(object sender, EventArgs e)
        {
            SetearFueModificada();
        }
        private void frmNotaPedido_Load(object sender, EventArgs e)
        {}

        private void ugArticulos_Enter(object sender, EventArgs e)
        {
            if (ugArticulos.Rows.Count > 0)
            {
                ugArticulos.ActiveCell = ugArticulos.Rows[0].Cells[0];
                ugArticulos.PerformAction(UltraGridAction.ToggleCellSel, false, false);
                ugArticulos.PerformAction(UltraGridAction.EnterEditMode, false, false);

            }
        }

        private void ucpStockCritico_ColorChanged(object sender, EventArgs e)
        {
            SetearColores();
        }

        private void ugArticulos_BeforeRowsDeleted(object sender, Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs e)
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in e.Rows)
            {
                r.Cells[0].Value = "0";
                r.Cells[1].Value = 0;
                r.Cells[2].Value = "";
                r.Cells[3].Value = 0;
            }
            e.Cancel = true;

            SetearFueModificada();
        }

        private void ugArticulos_AfterCellUpdate(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Codigo")
            {
                if (e.Cell.Text == "") e.Cell.Value = "0";
            }
        }

        private void ugArticulos_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {

            if (e.Cell.Column.ToString() == "Codigo")
            {
                if (ucListaArticulos.IsItemInList(e.Cell.Text))
                {
                    Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Text);
                    if (a != null)
                    {
                        e.Cell.Row.Cells[1].Value = a.Cantidad;
                        e.Cell.Row.Cells[2].Value = a.Descripcion;
                        e.Cell.Row.Cells[3].Value = a.PrecioUnitario;
                    }

                    ucListaArticulos.ButtonsRight[0].Visible = true;

                }
                else
                {
                    e.Cell.Row.Cells[1].Value = 0;
                    e.Cell.Row.Cells[2].Value = "";
                    e.Cell.Row.Cells[3].Value = 0;
                    ucListaArticulos.ButtonsRight[0].Visible = false;
                }
                SetearFueModificada();
            }

            if (e.Cell.Column.Key.Equals("Cantidad"))
            {
                Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Row.Cells[0].Text);
                string cellText = Utils.RemoveCharacterAndSpaces('_', e.Cell.Text);
                
                if (a!=null)
                {
                    if(cellText!="")
                        if (Convert.ToInt32(cellText) > a.Cantidad)
                        {
                            e.Cell.Appearance.BackColor = ucpStockCritico.Color;
                            e.Cell.Row.Cells["StockCritico"].SetValue(true, false);
                        }
                        else
                        {
                            e.Cell.Appearance.BackColor = Color.White;
                            e.Cell.Row.Cells["StockCritico"].SetValue(false, false);
                        }
                }
                SetearFueModificada();
            }
        }
      

        #endregion

        #region Metodos
        private void SetearFueModificada()
        {
            frmContainer frm = frmContainer.crearContainer(frmContainer.explorerBar);


            if (!this._fueModificada && (frm.ObtenerTabVisualizado() != null && frm.ObtenerTabVisualizado().Key.ToString().Contains("pedido")))
            {
                this._fueModificada = true;

                if (this._notaPedido != null)
                {

                    frm.ModificarTabSeleccionado("Pedido \"" + this._notaPedido.Cliente.RazonSocial + "\" [*]");
                }
                else
                {
                    this._fueModificada = false;
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="np"></param>
        private void CargarNotaDePedido(NotaPedido np)
        {
            _notaPedido = np; 

            // DATOS GENERALES
            txtNumeroPedido.Text = np.NumeroOrden.ToString();

            dtFechaEmision.Value = np.FechaEmision;
            dtFechaEntrega.Value = np.FechaEntrega;
            txtDescuentoEspecial.Text = np.DescuentoEspecial.ToString();
            txtObservaciones.Text = np.Observaciones; 

            // DETALLES DEL CLIENTE
            detallesCliente.CargarCliente(np.Cliente);

            // LISTADO DE ARTICULOS
            dsListaArticulos.Rows.Clear();
            MostrarFilasVacias();

            int i = 0;
            foreach (NotaPedido_Item item in np.Items)
            {

                Infragistics.Win.UltraWinDataSource.UltraDataRow dr = dsListaArticulos.Rows[i];
                dr["Codigo"] = item.Articulo.Codigo;
                dr["Cantidad"] = item.Cantidad;
                dr["Descripcion"] = item.Articulo.Descripcion;
                dr["PrecioUnitario"] = item.PrecioUnitario;

                if (item.Cantidad > item.Articulo.Cantidad) dr["StockCritico"] = true;
                else dr["StockCritico"] = false;

                i++;
            }

            ugArticulos.DataBind();
            SetearColores();
        }

        private void SetearColores()
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in ugArticulos.Rows)
            {
                if (Convert.ToBoolean((r.Cells["StockCritico"].Value!=DBNull.Value ? r.Cells["StockCritico"].Value : false)) == true)
                {
                    r.Cells["Cantidad"].Appearance.BackColor = ucpStockCritico.Color;
                }
            }
        }

        /// <summary>
        /// Este metodo se encarga de capturar del app.config la cantidad de filas a mostrar
        /// y crearlas en el listado
        /// </summary>
        private void MostrarFilasVacias()
        {
            AppSettingsReader appSettingsReader = new AppSettingsReader();
            int cantidadFilas = Convert.ToInt32(appSettingsReader.GetValue("CantidadDeItems", typeof(Int32)));

            for (int i = 0; i < cantidadFilas; i++) dsListaArticulos.Rows.Add();
        }
        /// <summary>
        /// Enlaza los controles a un source de datos
        /// </summary>
        public void BindearComponentes()
        {
            ugArticulos.DataSource = dsListaArticulos;
            dsListaArticulos.Rows.Add();

            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DisplayMember = "Codigo";

            txtNumeroPedido.Text = (NotaPedido.ObtenerUltimoNumeroDeOrden()+1).ToString();
            detallesCliente.BindearComponentes();

            AppSettingsReader reader = new AppSettingsReader();
            ucpStockCritico.Color = Color.FromName(reader.GetValue("Pedidos_ColorStockCritico", typeof(string)).ToString());
        }
        
        /// <summary>
        /// Almacena la nota de pedido en la base de datos
        /// </summary>
        /// <returns>Una instancia de la nota de pedido almacenada</returns>
        public NotaPedido Guardar()
        {
            NotaPedido ret = null;

            try
            {
                //verificamos que la nota de pedido no exista en la base de datos
                if (VerificarCampos())
                {
                    errorProvider.Clear();
                    detallesCliente.QuitarError();

                    NotaPedido np;
                    string codigoCliente = detallesCliente.CodigoCliente; 

                    IList<NotaPedido_Item> items = new List<NotaPedido_Item>();
                    IList<NotaPedido_Item> backupItems = new List<NotaPedido_Item>();



                    if (_notaPedido != null)
                    {
                        np = _notaPedido;
                    }
                    else
                    {
                        np = new NotaPedido();
                        np.FechaEmision = Convert.ToDateTime(dtFechaEmision.Value);
                    }


                    //realizamos backup de los elementos que estaban cargados, para mantener la configuracion seteada
                    //en otros formularios
                    foreach (NotaPedido_Item item in np.Items)  
                        backupItems.Add(item);

                    np.FechaEntrega = Convert.ToDateTime(dtFechaEntrega.Value);
                    np.Cliente = Cliente.TraerClientePorCodigo(codigoCliente);
                    np.DescuentoEspecial = Convert.ToInt32(txtDescuentoEspecial.Text);
                    np.Observaciones = txtObservaciones.Text; 

                    if (np.Items != null) np.Items.Clear();

                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in ugArticulos.Rows)
                    {

                        Articulo a = Articulo.TraerArticuloPorCodigo(dr.Cells["Codigo"].Value.ToString());
                        
                        if (a != null)
                        {
                            NotaPedido_Item item = new NotaPedido_Item();

                            foreach (NotaPedido_Item backupItem in backupItems)
                            {
                                if (backupItem.Articulo.Id == a.Id)
                                {
                                    item.Descuento = backupItem.Descuento;
                                }
                            }

                            item.Articulo = a;
                            item.Cantidad = Convert.ToDecimal(dr.Cells["Cantidad"].Text);
                            item.PrecioUnitario = Convert.ToDecimal(dr.Cells["PrecioUnitario"].Text);

                            items.Add(item);
                        }
                    }

                    np.Items = items;

                    if (np.IdNotaPedido == -1)
                    {
                        
                        int IdNotaPedido = np.Guardar();

                        ret = NotaPedido.TraerNotaPedidoPorId(IdNotaPedido);
                    }
                    else
                    {
                        np.Actualizar();

                        ret = np;
                    }

                    _notaPedido = np;

                    _fueModificada = false;
                }
            }
            catch (Exception ex)
            {
                ret = null;
                throw ex;
            }

            return ret; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>False si hubo error</returns>
        private bool VerificarCampos()
        {
            errorProvider.Clear();
            detallesCliente.QuitarError();

            bool ok = true;
            bool stockCritico = false;
            //Verificamos que se haya seleccionado algun cliente
            if (detallesCliente.Cliente == null)
            {
                detallesCliente.EstablecerError();
                ok = false;
                
            }


            bool existenItemsCargados = false;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in ugArticulos.Rows)
            {
                Articulo a = Articulo.TraerArticuloPorCodigo(dr.Cells["Codigo"].Value.ToString());

                if (Convert.ToBoolean((dr.Cells["StockCritico"].Value != DBNull.Value ? dr.Cells["StockCritico"].Value : false)) == true) stockCritico = true;

                if (a != null)
                {
                    existenItemsCargados = true;
                }
            }

            if (!existenItemsCargados)
            {
                errorProvider.SetError(ugArticulos, "Deberá agregar al menos un item a la lista...");
                ok = false;
            }

            if (ok)
                if (stockCritico)
                {
                    AppSettingsReader reader = new AppSettingsReader();
                    int option = (int)reader.GetValue("StockCritico", typeof(int));

                    switch (option)
                    {
                        case 1:
                            DialogResult dr = MessageBox.Show("Existen uno o mas items cuya cantidad supera la que existe en stock. ¿Desea Continuar?", "Stock Crítico", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.No) ok = false;
                            break;
                        case 2:
                            MessageBox.Show("Existen uno o mas items cuya cantidad supera la que existe en stock. No puede continuar", "Stock Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ok = false;
                            break;
                    }
                }

            return ok; 
        }
        
        #endregion

        #region Metodos Sobreescritos
        public override int BeforeCloseCheck()
        {
            int ret = 1;

            if (this._fueModificada)
            {
                DialogResult res = MessageBox.Show("¿Desea guardar los cambios?", "Cambios Realizados", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res.ToString() == "Yes")
                {
                    if (this.Guardar() == null)
                        ret = 3;

                }
                else if (res.ToString() == "No") ret = 2;
                else if (res.ToString() == "Cancel") ret = 3;

            }
            return ret;
        }


        public override void SetInitialFocus()
        {
            detallesCliente.SetFocus();
        }

        public override void Refrescar()
        {
            ugArticulos.DataSource = dsListaArticulos;
            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DisplayMember = "Codigo";

            if (this._notaPedido != null && this._refrescar)
            {
                int _idNotaPedido = this._notaPedido.IdNotaPedido;
                NotaPedido np = NotaPedido.TraerNotaPedidoPorId(_idNotaPedido);

                this._notaPedido = np;
                CargarNotaDePedido(np);

                this._refrescar = false;
            }
        }
        public override int ObtenerIdNotaPedido()
        {
            return this._notaPedido.IdNotaPedido;
        }
        public override void SetearFormularioNoModificable()
        {
            dtFechaEmision.ReadOnly = true;
            dtFechaEntrega.ReadOnly = true;
            txtDescuentoEspecial.ReadOnly = true;
            txtDescuentoEspecial.Increment = 0;

            detallesCliente.SetearFormularioNoModificable();
            dsListaArticulos.ReadOnly = true;
        }
        #endregion
    }
}
