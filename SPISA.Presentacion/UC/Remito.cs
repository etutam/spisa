using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using SPISA.Libreria;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;
namespace SPISA.Presentacion
{
    public partial class UcRemito : BaseControl
    {

        #region Campos Privados
        private Remito _remito;

        private bool _refrescar = false;
        private bool _fueModificado = false;
        #endregion

        #region Constructores
        public UcRemito()
        {
            InitializeComponent();
            BindearComponentes();
            MostrarFilasVacias();

            txtNumeroPedido.Text = "(Sin Asignar)";

            this.dtFechaEmision.Value = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            int numeroRemito = Remito.ObtenerNuevoNumeroDeRemito();

            for (int i = 0; i < 12 - (numeroRemito.ToString().Length); i++)
            {
                sb.Append("0");
            }
            txtNumeroRemito.Text = sb.ToString() + numeroRemito.ToString();
            txtNumeroRemito.Tag = sb.ToString() + numeroRemito.ToString();

            Logger.Append(this.GetType().ToString(), null, "");

            _fueModificado = true;
        }
        
        public UcRemito(Remito r)
        {
            InitializeComponent();
            BindearComponentes();
            CargarRemito(r);

            Logger.Append(this.GetType().ToString(), new Object[] { "IdRemito", r.Id }, "");
            if (r.Id == -1) _fueModificado = true; 
        }
        #endregion

        #region Propiedades
        public override bool RefrescarAutomaticamente
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

        #endregion

        #region Metodos Privados
        private void SetearFueModificado()
        {
            frmContainer frm = frmContainer.crearContainer(frmContainer.explorerBar);


            if (!this._fueModificado && (frm.ObtenerTabVisualizado() != null && frm.ObtenerTabVisualizado().Key.ToString().Contains("remito")))
            {
                this._fueModificado = true;

                if (this._remito != null)
                {

                    frm.ModificarTabSeleccionado("Remito \"" + detallesCliente.Cliente.RazonSocial + "\" [*]");
                }
                else
                {
                    this._fueModificado = false;
                }
            }

        }

        private void SetearColores()
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in ugArticulos.Rows)
            {
                if (Convert.ToBoolean((r.Cells["StockCritico"].Value != DBNull.Value ? r.Cells["StockCritico"].Value : false)) == true)
                {
                    r.Cells["Cantidad"].Appearance.BackColor = ucpStockCritico.Color;
                }
            }
        }

        private void CargarRemito(Remito r)
        {
            StringBuilder sb = new StringBuilder();
            _remito = r;

            if (_remito == null || (_remito != null ? _remito.Id <= 0 : true))
            {
                int numeroRemito = Remito.ObtenerNuevoNumeroDeRemito();

                for (int i = 0; i < 12 - (numeroRemito.ToString().Length); i++)
                {
                    sb.Append("0");
                }
                txtNumeroRemito.Text = sb.ToString() + numeroRemito.ToString();
                txtNumeroRemito.Tag = sb.ToString() + numeroRemito.ToString();
            }
            else
            {
                int numeroRemito = r.NumeroRemito;

                for (int i = 0; i < 12 - (numeroRemito.ToString().Length); i++)
                {
                    sb.Append("0");
                }
                txtNumeroRemito.Text = sb.ToString() + numeroRemito.ToString();
                txtNumeroRemito.Tag = sb.ToString() + numeroRemito.ToString();
            }


            txtNumeroPedido.Text = r.NotaPedido.NumeroOrden.ToString();
            txtObservaciones.Text = r.Observaciones;

            dtFechaEmision.Value = r.Fecha;
            detallesCliente.CargarCliente(r.Cliente);

            dsListaArticulos.Rows.Clear();
            MostrarFilasVacias();

            int j = 0;
            foreach (NotaPedido_Item item in r.NotaPedido.Items)
            {
                Infragistics.Win.UltraWinDataSource.UltraDataRow dr = dsListaArticulos.Rows[j];
                dr["Codigo"] = item.Articulo.Codigo;
                dr["Cantidad"] = item.Cantidad;
                dr["Descripcion"] = item.Articulo.Descripcion;

                j++;
            }

            txtPeso.Value = r.Peso;
            txtBultos.Value = r.Bultos;
            txtValor.Value = r.Valor;

            SetearColores();
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
        private void BindearComponentes()
        {
            detallesCliente.BindearComponentes();

            ugArticulos.DataSource = dsListaArticulos;
            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DisplayMember = "Codigo";

            ucListaTransportistas.DataSource = Transportista.TraerTodos();
            ucListaTransportistas.DisplayMember = "Transportista";
            ucListaTransportistas.ValueMember = "IdTransportista";

            AppSettingsReader reader = new AppSettingsReader();
            ucpStockCritico.Color = Color.FromName(reader.GetValue("Remitos_ColorStockCritico", typeof(string)).ToString());

            
        }

        private bool VerificarCampos()
        {
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

        #region Metodos Publicos

        public Remito Guardar()
        {
            int ret = -1;
            Remito r = null;

            try
            {
                if (VerificarCampos())
                {

                    errorProvider.Clear();
                    detallesCliente.QuitarError();

                    string codigoCliente = detallesCliente.CodigoCliente;

                    IList<NotaPedido_Item> items = new List<NotaPedido_Item>();
                    IList<NotaPedido_Item> backupItems = new List<NotaPedido_Item>();

                    if (_remito != null)
                    {
                        r = _remito;
                    }
                    else
                    {
                        r = new Remito();
                    }

                    r.NumeroRemito = Convert.ToInt32(txtNumeroRemito.Tag.ToString());
                    r.Fecha = Convert.ToDateTime(dtFechaEmision.Value);
                    r.Cliente = Cliente.TraerClientePorCodigo(codigoCliente);
                    r.Observaciones = txtObservaciones.Text;

                    r.Peso = Convert.ToDecimal(txtPeso.Value);
                    r.Valor = Convert.ToDecimal(txtValor.Value);
                    r.Bultos = (int)txtBultos.Value;

                    if (ucListaTransportistas.IsItemInList(ucListaTransportistas.Text))
                        r.Transportista = Transportista.TraerTransportistaPorId((int)ucListaTransportistas.Value);

                    foreach (NotaPedido_Item item in r.Items)
                        backupItems.Add(item);

                    if (r.Items != null) r.Items.Clear();

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
                            item.PrecioUnitario = a.PrecioUnitario;
                            

                            items.Add(item);
                        }
                    }

                    r.Items = items;

                    if (r.Id != -1)
                    {
                        r.Actualizar();
                    }
                    else
                    {
                        ret = r.Guardar();
                        r = Remito.TraerRemitoPorID(ret);

                        _remito = r;
                    }

                    this._fueModificado = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return r;
        }

        private PointF ObtenerPosicionDeImpresionDeObjeto(string Objeto)
        {
            PointF posicion = new PointF(-1, -1);

            try
            {
                DataSet ds = Utils.GetDataSetFromXml("Resources/RemitoObjectsToPrint.xml");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr[2].ToString() == Objeto)
                    {
                        posicion = new PointF((float)Convert.ToDecimal(dr[0]), (float)Convert.ToDecimal(dr[1]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return posicion;
        }
        private IList<Printing.ObjetoAImprimir> CargarObjetosAImprimir()
        {
            IList<Printing.ObjetoAImprimir> _objetos = new List<Printing.ObjetoAImprimir>();

            PointF pos = new PointF(-1, -1);

            pos = ObtenerPosicionDeImpresionDeObjeto("Fecha");
            // SE CAMBIA FORMATO DE FECHA PARA IMPRIMIR ASI EL CONTADOR NO ROMPE LAS PELOTAS:)
            string fecha = Convert.ToDateTime(dtFechaEmision.Value).ToString("dd/MM/yyyy");
            fecha = fecha.Replace("-", "/");
            _objetos.Add(new Printing.ObjetoAImprimir(fecha, pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("RazonSocialCliente");
            _objetos.Add(new Printing.ObjetoAImprimir(detallesCliente.Cliente.RazonSocial, pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("DomicilioCliente");
            _objetos.Add(new Printing.ObjetoAImprimir(detallesCliente.Cliente.Domicilio, pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("LocalidadCliente");
            _objetos.Add(new Printing.ObjetoAImprimir(detallesCliente.Cliente.Localidad, pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("ProvinciaCliente");
            _objetos.Add(new Printing.ObjetoAImprimir(detallesCliente.Cliente.Provincia.Nombre, pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("IVACliente");
            _objetos.Add(new Printing.ObjetoAImprimir(detallesCliente.Cliente.IVA.Condicion, pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("CUITCliente");
            _objetos.Add(new Printing.ObjetoAImprimir(detallesCliente.Cliente.CUIT, pos.X, pos.Y));

            float y = ObtenerPosicionDeImpresionDeObjeto("InicioItems").Y;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in ugArticulos.Rows)
            {
                pos = ObtenerPosicionDeImpresionDeObjeto("ColumnaCantidad");
                string cantidad = dr.Cells["Cantidad"].Text;
                _objetos.Add(new Printing.ObjetoAImprimir(cantidad, pos.X - (cantidad.Length * 8), y));

                pos = ObtenerPosicionDeImpresionDeObjeto("ColumnaDescripcion");
                _objetos.Add(new Printing.ObjetoAImprimir(dr.Cells["Descripcion"].Text, pos.X, y));

                y += ObtenerPosicionDeImpresionDeObjeto("EspacioEntreItems").Y;
            }

            if (chkDatosTransportista.Checked)
            {
                pos = ObtenerPosicionDeImpresionDeObjeto("Transportista");
                _objetos.Add(new Printing.ObjetoAImprimir(ucListaTransportistas.Text, pos.X, pos.Y));
                pos = ObtenerPosicionDeImpresionDeObjeto("DomicilioTransportista");
                _objetos.Add(new Printing.ObjetoAImprimir(txtDomicilioTransportista.Text, pos.X, pos.Y));
                pos = ObtenerPosicionDeImpresionDeObjeto("Peso");

                StateEditorButton c = (StateEditorButton)(txtPeso.ButtonsRight[0]);
                _objetos.Add(new Printing.ObjetoAImprimir("Peso: " + (c.Checked ? "_____" : txtPeso.Value + " kg."), pos.X, pos.Y));

                pos = ObtenerPosicionDeImpresionDeObjeto("Valor");
                c = (StateEditorButton)(txtValor.ButtonsRight[0]);
                _objetos.Add(new Printing.ObjetoAImprimir("Valor: $" + (c.Checked ? "_____"  : txtValor.Value.ToString()), pos.X, pos.Y));
                
                pos = ObtenerPosicionDeImpresionDeObjeto("Bulto");
                c = (StateEditorButton)(txtBultos.ButtonsRight[0]);
                _objetos.Add(new Printing.ObjetoAImprimir("Bultos: " + (c.Checked ? "_____" : txtBultos.Value), pos.X, pos.Y));
            }
            return _objetos;
        }
        public void Imprimir()
        {
            if (_remito != null)
            {
                try
                {
                    IList<Printing.ObjetoAImprimir> _objetos = new List<Printing.ObjetoAImprimir>();

                    _objetos = CargarObjetosAImprimir();

                    Printing p = new Printing();
                    p.Objetos = _objetos;

                    AppSettingsReader settings = new AppSettingsReader();
                    short numeroCopias = (short)(settings.GetValue("NumeroDeCopiasRemito", typeof(short)));

                    p.Imprimir(numeroCopias);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region Eventos
        private void EventoSeleccionarCliente(object sender, EventArgs e)
        {
            if (detallesCliente.Cliente != null)
            {
                if (detallesCliente.Cliente.Transportista != null)
                {
                    ucListaTransportistas.Text = detallesCliente.Cliente.Transportista.NombreTransportista;
                    ucListaTransportistas.Value = detallesCliente.Cliente.Transportista.Id;
                    txtDomicilioTransportista.Text = detallesCliente.Cliente.Transportista.Domicilio;

                    chkDatosTransportista.Checked = true;
                }
                else
                {
                    ucListaTransportistas.Text = "";
                    ucListaTransportistas.Value = null;
                    txtDomicilioTransportista.Text = "";

                    chkDatosTransportista.Checked = false;
                }
            }
            SetearFueModificado();

            detallesCliente.Focus();
        }


        private void btnPredeterminar_Click(object sender, EventArgs e)
        {
            if (ucListaTransportistas.Value != null && detallesCliente.Cliente != null)
                Cliente.EstablecerTransportista(detallesCliente.Cliente.Id, (int)ucListaTransportistas.Value);
        }

        private void ugArticulos_Enter(object sender, EventArgs e)
        {
            if (ugArticulos.Rows.Count > 0)
            {
                ugArticulos.ActiveCell = ugArticulos.Rows[0].Cells[0];
                ugArticulos.PerformAction(UltraGridAction.ToggleCellSel, false, false);
                ugArticulos.PerformAction(UltraGridAction.EnterEditMode, false, false);

            }
        }
        private void ucListaTransportistas_Enter(object sender, EventArgs e)
        {
            ucListaTransportistas.Textbox.SelectAll();
        }
        private void txtPeso_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            StateEditorButton s = (StateEditorButton)e.Button;
            txtPeso.ReadOnly = s.Checked;
        }
        private void txtBultos_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            StateEditorButton s = (StateEditorButton)e.Button;
            txtBultos.ReadOnly = s.Checked;
        }
        private void txtValor_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            StateEditorButton s = (StateEditorButton)e.Button;
            txtValor.ReadOnly = s.Checked;
        }
        private void chkDatosTransportista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDatosTransportista.Checked) ucListaTransportistas.Focus();
        }
        private void ucListaTransportistas_TextChanged(object sender, EventArgs e)
        {
            if (ucListaTransportistas.IsItemInList(ucListaTransportistas.Text))
            {
                txtDomicilioTransportista.Text = Transportista.TraerTransportistaPorId((int)ucListaTransportistas.Value).Domicilio;
            }
            else
            {
                txtDomicilioTransportista.Text = "";
            }
            SetearFueModificado();
        }
        private void ucpStockCritico_ColorChanged(object sender, EventArgs e)
        {
            SetearColores();
        }
        private void ugArticulos_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Column.ToString() == "Codigo")
            {
                if (ucListaArticulos.IsItemInList(e.Cell.Text))
                {
                    Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Row.Cells["Codigo"].Text);

                    e.Cell.Row.Cells["Cantidad"].Value = a.Cantidad;
                    e.Cell.Row.Cells["Descripcion"].Value = a.Descripcion;
                }
                else
                {
                    e.Cell.Row.Cells["Cantidad"].Value = 0;
                    e.Cell.Row.Cells["Descripcion"].Value = "";
                }
                SetearFueModificado();
            }

            if (e.Cell.Column.Key.Equals("Cantidad"))
            {
                Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Row.Cells[0].Text);
                string cellText = Utils.RemoveCharacterAndSpaces('_', e.Cell.Text);

                if (a != null)
                {
                    if (cellText != "")
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
                SetearFueModificado();
            }
        }
        private void EventoSetearFueModificado(object sender, EventArgs e)
        {
            SetearFueModificado();
        }

        #endregion

        #region Metodos Sobreescritos

        public override int BeforeCloseCheck()
        {
            int ret = 1;

            if (this._fueModificado)
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

            if (this._remito != null & this._refrescar)
            {
                int _idRemito = this._remito.Id;
                Remito r = Remito.TraerRemitoPorID(_idRemito);

                this._remito = r;
                CargarRemito(r);

                this._refrescar = false;
            }
        }
        public override int ObtenerIdNotaPedido()
        {
            return this._remito.NotaPedido.IdNotaPedido;    
        }
        public override void SetearFormularioNoModificable()
        {
            dtFechaEmision.ReadOnly = true;
            detallesCliente.SetearFormularioNoModificable();
            dsListaArticulos.ReadOnly = true;
        }
        #endregion
    }
}
