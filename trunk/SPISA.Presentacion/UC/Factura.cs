using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using SPISA.Libreria;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinExplorerBar;

using System.Configuration;

namespace SPISA.Presentacion
{
    public partial class UcFactura : BaseControl
    {

        public enum ResultadoVerificar
        {
            
            StockSuperado,
            NoCliente,
            NoExistenItemsCargados
        }

        

        #region Campos Privados
        Factura _factura = null;
        bool _modificable = true;

        private bool _refrescar = false;
        private bool _fueModificada = false; 
        private static bool printingCalled = false;
        #endregion

        #region Constructores
        public UcFactura()
        {

            frmPrincipal.valorDolar = frmPrincipal.valorDolar.Replace(".", ",");
            Decimal valorDolar = Convert.ToDecimal(frmPrincipal.valorDolar);
            StringBuilder sb = new StringBuilder();
            long numeroFactura = Factura.ObtenerNuevoNumeroDeFactura();

            InitializeComponent();
            detallesCliente.ClienteSeleccionado += new SPISA.Presentacion.DetallesCliente.ClienteSeleccionadoEventHandler(detallesCliente_ClienteSeleccionado);
            MostrarFilasVacias();
            BindearComponentes();

            txtValorDolar.Value = valorDolar;
            txtNumeroPedido.Text = "(Sin Asignar)";
            dtFechaEmision.Value = DateTime.Now;

            for (int i = 0; i < 12 - (numeroFactura.ToString().Length); i++)
            {
                sb.Append("0");
            }
            txtNumeroFactura.Text = sb.ToString() + numeroFactura.ToString();
            txtNumeroFactura.Tag = sb.ToString() + numeroFactura.ToString();
                
            _factura = null;

            Logger.Append(this.GetType().ToString(), null, "");
            _fueModificada = true;

        }

        public UcFactura(SPISA.Libreria.Factura factura)
        {


            InitializeComponent();
            detallesCliente.ClienteSeleccionado += new SPISA.Presentacion.DetallesCliente.ClienteSeleccionadoEventHandler(detallesCliente_ClienteSeleccionado);
            BindearComponentes();
            CargarFactura(factura);

            Logger.Append(this.GetType().ToString(), new Object[] { "IdFactura", factura.Id }, "");

            if (factura.Id == -1) _fueModificada = true; 
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
        public Factura Factura
        {
            get { return this._factura; }
        }

        #endregion

        #region Eventos
        private void EventoSetearFueModificada(object sender, EventArgs e)
        {
            SetearFueModificada();
        }

        private void detallesCliente_ClienteSeleccionado_1(object sender, EventArgs e)
        {
            ActualizarDescuentos();
            SetearFueModificada();
        }

        private void chkNotaDeCredito_CheckedChanged(object sender, EventArgs e)
        {
            SetearColores();
            SetearFueModificada();
        }

        private void ugArticulos_AfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Codigo")
            {
                if (e.Cell.Text == "") e.Cell.Value = "0";
            }
        }

        private void ugArticulos_BeforeRowsDeleted(object sender, Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs e)
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in e.Rows)
            {
                r.Cells[0].Value = "0";
                r.Cells[1].Value = 0;
                r.Cells[2].Value = "";
                r.Cells[3].Value = 0;
                r.Cells[4].Value = 0;
                r.Cells[5].Value = 0;
            }
            e.Cancel = true;
            SetearFueModificada();
        }

        void detallesCliente_ClienteSeleccionado(object sender, EventArgs e)
        {

        }

        private void ugArticulos_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
        
            Decimal valorDolar = Convert.ToDecimal(txtValorDolar.Value);


            if (e.Cell.Column.ToString() == "Codigo")
            {
                if (ucListaArticulos.IsItemInList(e.Cell.Text))
                {
                    Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Row.Cells["Codigo"].Text);

                    e.Cell.Row.Cells["Cantidad"].Value = a.Cantidad;
                    e.Cell.Row.Cells["Descuento"].Value = ObtenerDescuento(a);
                    e.Cell.Row.Cells["Descripcion"].Value = a.Descripcion;
                    e.Cell.Row.Cells["PrecioUnitario"].Value = a.PrecioUnitario * valorDolar;
                    e.Cell.Row.Cells["Tag"].Value = a.PrecioUnitario;
                }
                else
                {
                    e.Cell.Row.Cells["Cantidad"].Value = 0;
                    e.Cell.Row.Cells["Descripcion"].Value = "";
                    e.Cell.Row.Cells["Descuento"].Value = 0;
                    e.Cell.Row.Cells["PrecioUnitario"].Value = 0;
                    e.Cell.Row.Cells["PrecioFinal"].Value = 0;
                }

                e.Cell.Row.Cells["StockCritico"].SetValue(false, false);
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
            }

            CalcularTotalesUnitarios(e);
            CalcularTotales();
            SetearFueModificada();
        }

        private void txtDescuentoEspecial_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void txtValorDolar_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalesUnitarios(null);
            CalcularTotales();

            SetearFueModificada();
        }

        private void ucListaArticulos_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (e.Button.Key == "bEditar")
            {
                frmContainer frm = frmContainer.crearContainer(frmContainer.explorerBar);

                if (ucListaArticulos.Value != null)
                {
                    Articulo a = Articulo.TraerArticuloPorCodigo(ucListaArticulos.Value.ToString());

                    if (frm.TabControl.Tabs.Exists("articulo_" + a.Id))
                        frm.TabControl.Tabs["articulo_" + a.Id].Selected = true;
                    else
                    {
                        UcArticulo ucArticulo = new UcArticulo(a);
                        frm.TabControl.Tabs[frm.AgregarTab("articulo_" + a.Id, "Artículo #" + a.Codigo, "groupArticuloActual", ucArticulo)].Selected = true;
                    }
                }
            }
        }
        private void ugArticulos_AfterRowsDeleted(object sender, EventArgs e)
        {
            CalcularTotalesUnitarios(null);
            CalcularTotales();
        }


        #endregion

        #region Métodos
        private void SetearFueModificada()
        {
            frmContainer frm = frmContainer.crearContainer(frmContainer.explorerBar);


            if (!this._fueModificada && (frm.ObtenerTabVisualizado() != null && frm.ObtenerTabVisualizado().Key.ToString().Contains("factura")))
            {
                this._fueModificada = true;

                if (this.Factura != null)
                {

                    frm.ModificarTabSeleccionado("Factura \"" + this.Factura.Cliente.RazonSocial + "\" [*]");
                }
                else
                {
                    this._fueModificada = false;
                }
            }

        }

        private void ActualizarDescuentos()
        {

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in ugArticulos.Rows)
            {
                if (ucListaArticulos.IsItemInList(r.Cells["Codigo"].Text))
                {
                    Decimal descuento = ObtenerDescuento(Articulo.TraerArticuloPorCodigo(r.Cells["Codigo"].Text));
                    r.Cells["Descuento"].Value = descuento;
                }
            }

            CalcularTotalesUnitarios(null);
            CalcularTotales();
            
        }

        /// <summary>
        /// Carga la factura 
        /// </summary>
        /// <param name="factura"></param>
        private void CargarFactura(SPISA.Libreria.Factura factura)
        {
            StringBuilder sb = new StringBuilder();
            long _numeroFactura = (factura.NumeroFactura != -1 ? factura.NumeroFactura : Factura.ObtenerNuevoNumeroDeFactura());

            _factura = factura;

            txtNumeroPedido.Text = factura.NotaPedido.NumeroOrden.ToString();

            for (int i = 0; i < 12 - (_numeroFactura.ToString().Length); i++)
            {
                sb.Append("0");
            }
            txtNumeroFactura.Text = sb.ToString() + _numeroFactura.ToString();
            txtNumeroFactura.Tag = sb.ToString() + _numeroFactura.ToString();

            txtObservaciones.Text = factura.Observaciones;
            chkNotaDeCredito.Checked = factura.EsNotaDeCredito;

            dtFechaEmision.Text = factura.Fecha.ToString();
            detallesCliente.CargarCliente(factura.Cliente);

            Decimal valorDolar = _factura.ValorDolar;

            // LISTADO DE ARTICULOS
            dsListaArticulos.Rows.Clear();
            MostrarFilasVacias();

            int j = 0;
            foreach (NotaPedido_Item item in factura.NotaPedido.Items)
            {
                Infragistics.Win.UltraWinDataSource.UltraDataRow dr = dsListaArticulos.Rows[j];
                dr["Codigo"] = item.Articulo.Codigo;
                dr["Cantidad"] = item.Cantidad;
                dr["Descripcion"] = item.Articulo.Descripcion;

                Decimal descuento = 0;

                if (item.Descuento != -1)
                {
                    descuento = item.Descuento;
                }
                else
                {
                    descuento = ObtenerDescuento(item.Articulo);
                }

                dr["Descuento"] = descuento;




                if (factura.NotaPedido != null)
                {
                    dr["PrecioUnitario"] = item.PrecioUnitario - (item.PrecioUnitario * (descuento > 0 ? (descuento / 100) : 0)); ;// * valorDolar;
                    dr["Tag"] = item.PrecioUnitario;
                }


                Decimal precioFinalSinDescuento = Convert.ToDecimal(dr["PrecioUnitario"]) * item.Cantidad;
                Decimal precioFinalConDescuento = precioFinalSinDescuento - (precioFinalSinDescuento * (descuento > 0 ? (descuento / 100) : 0));

                dr["PrecioFinal"] = precioFinalConDescuento;

                if (item.Cantidad > item.Articulo.Cantidad) dr["StockCritico"] = true;
                else dr["StockCritico"] = false;

                j++;
            }

            ugArticulos.DataBind();

            txtDescuentoEspecial.Value = factura.NotaPedido.DescuentoEspecial;
            txtValorDolar.Value = valorDolar;

            CalcularTotalesUnitarios(null);
            CalcularTotales();
            SetearColores();
        }

        private void SetearColores()
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in ugArticulos.Rows)
            {
                if (!chkNotaDeCredito.Checked && Convert.ToBoolean((r.Cells["StockCritico"].Value != DBNull.Value ? r.Cells["StockCritico"].Value : false)) == true)
                {
                    r.Cells["Cantidad"].Appearance.BackColor = ucpStockCritico.Color;
                }
                else
                {
                    r.Cells["Cantidad"].Appearance.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Obtiene el descuento del cliente para un determinado articulo
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private Decimal ObtenerDescuento(Articulo a)
        {
            detallesCliente.ActualizarDescuentos();

            Decimal descuento = 0;
            if (detallesCliente.Cliente != null)
            {
                foreach (Descuento d in detallesCliente.Cliente.Descuentos)
                {
                    if (d.Categoria.IdCategoria == a.Categoria.IdCategoria)
                    {
                        descuento = d.Porcentaje;
                    }
                }
            }
            return descuento;
        }

        /// <summary>
        /// Éste método se encarga de calcular los Precios Finales para cada uno de los items cargados
        /// </summary>
        /// <param name="e"></param>
        private void CalcularTotalesUnitarios(CellEventArgs e)
        {
            Decimal valorDolar = Convert.ToDecimal(txtValorDolar.Value);

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in ugArticulos.Rows)
            {
                if (e != null)
                {
                    if (r.Index == e.Cell.Row.Index)
                    {
                        if (ucListaArticulos.IsItemInList(e.Cell.Row.Cells["Codigo"].Text))
                        {
                            Articulo a = Articulo.TraerArticuloPorCodigo(e.Cell.Row.Cells["Codigo"].Text);

                            string trimDescuento = e.Cell.Row.Cells["Descuento"].Text.Replace('_', ' ').Trim();

                            Decimal descuento = Convert.ToDecimal(trimDescuento != "" ? trimDescuento : "0");

                            Decimal cantidad = Convert.ToDecimal((e.Cell.Row.Cells["Cantidad"].Text.Replace('_', ' ').Trim() != "" ? e.Cell.Row.Cells["Cantidad"].Text.Replace('_', ' ').Trim() : "0"));

                            //Decimal precioUnitario = Convert.ToDecimal(e.Cell.Row.Cells["PrecioUnitario"].Text);
                            Decimal precioUnitario = 0;
                            if (r.Cells["Tag"].Value.ToString() != "")
                            {
                                precioUnitario = Convert.ToDecimal(r.Cells["Tag"].Value.ToString());
                            }
                            else
                            {
                                precioUnitario = a.PrecioUnitario;
                            }

                            precioUnitario *= valorDolar;

                            precioUnitario = precioUnitario - (precioUnitario * (descuento > 0 ? (descuento / 100) : 0));

                            Decimal precioFinal = cantidad * precioUnitario;

                            e.Cell.Row.Cells["PrecioUnitario"].Value = precioUnitario.ToString();
                            e.Cell.Row.Cells["PrecioFinal"].Value = precioFinal.ToString();
                        }
                    }

                }
                else
                {
                    if (ucListaArticulos.IsItemInList(r.Cells["Codigo"].Text))
                    {
                        Articulo a = Articulo.TraerArticuloPorCodigo(r.Cells["Codigo"].Text);
                        Decimal descuento = Convert.ToDecimal(r.Cells["Descuento"].Text);

                        Decimal cantidad = Convert.ToDecimal((r.Cells["Cantidad"].Text != "" ? r.Cells["Cantidad"].Text : "0"));

                        Decimal precioUnitario = 0;

                        if (r.Cells["Tag"].Value.ToString() != "")
                        {
                            precioUnitario = Convert.ToDecimal(r.Cells["Tag"].Value.ToString());
                        }
                        else
                        {
                            precioUnitario = a.PrecioUnitario;
                        }

                        precioUnitario *= valorDolar;

                        precioUnitario = precioUnitario - (precioUnitario * (descuento > 0 ? (descuento / 100) : 0));

                        r.Cells["PrecioUnitario"].Value = precioUnitario;

                        Decimal precioFinal = cantidad * precioUnitario;

                        r.Cells["PrecioFinal"].Value = precioFinal.ToString();
                    }
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
        private void BindearComponentes()
        {
            detallesCliente.BindearComponentes();

            ugArticulos.DataSource = dsListaArticulos;
            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DisplayMember = "Codigo";

            txtNumeroPedido.Text = (NotaPedido.ObtenerUltimoNumeroDeOrden() + 1).ToString();

            AppSettingsReader reader = new AppSettingsReader();
            ucpStockCritico.Color = Color.FromName(reader.GetValue("Facturas_ColorStockCritico", typeof(string)).ToString());
        }

        /// <summary>
        /// Llena los campos dentro de Totales con la informacion correspondiente
        /// </summary>
        private void CalcularTotales()
        {
            Decimal d_SubTotal1 = 0;
            Decimal d_Descuento = 0;
            Decimal d_SubTotal2 = 0;

            Decimal d_DescuentoEspecial = Convert.ToDecimal((txtDescuentoEspecial.Value != 0 ? txtDescuentoEspecial.Value : 0));
            Decimal d_ValorDolar = Convert.ToDecimal(txtValorDolar.Value);
            Decimal d_txtIva21 = Convert.ToDecimal(txtIva21.Value);
            Decimal d_txtIva105 = Convert.ToDecimal(txtIva105.Value);
            Decimal d_txtTotal;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow r in ugArticulos.Rows)
            {
                d_SubTotal1 += Convert.ToDecimal((r.Cells["PrecioFinal"].Value.ToString() != "" ? r.Cells["PrecioFinal"].Value.ToString() : "0"));
            }

            d_Descuento = d_SubTotal1 * d_DescuentoEspecial / 100;
            d_SubTotal2 = d_SubTotal1 - d_Descuento;

            if (detallesCliente.Cliente != null)
            {
                switch (detallesCliente.Cliente.IVA.Condicion)
                {

                    case "Responsable Inscripto":
                        d_txtIva21 = d_SubTotal2 * Convert.ToDecimal(0.21);
                        txtIva21.Text = d_txtIva21.ToString();
                        break;
                    case "Responsable No Inscripto":
                        d_txtIva105 = d_SubTotal2 * Convert.ToDecimal(0.105);
                        txtIva105.Text = d_txtIva105.ToString();
                        break;
                    case "Exento":
                        d_txtIva21 = d_SubTotal2 * Convert.ToDecimal(0.21);
                        d_txtIva105 = d_SubTotal2 * Convert.ToDecimal(0.105);

                        txtIva21.Text = d_txtIva21.ToString();
                        txtIva105.Text = d_txtIva105.ToString();
                        break;
                }
            }
            else
            {
                txtIva21.Value = 0;
                txtIva105.Value = 0;
            }


            d_txtTotal = (d_SubTotal2 + d_txtIva21 + d_txtIva105);

            //Asignamos los valores calculados

            txtSubTotal.Value = d_SubTotal1;
            txtDescuentoAplicado.Value = d_Descuento;
            txtSubTotal2.Value = d_SubTotal2;
            txtTotal.Value = Convert.ToDecimal(d_txtTotal);
        }

        /// <summary>
        /// Busca la posicion del objeto en el xml
        /// </summary>
        /// <param name="Objeto">El nombre del objeto a buscar en el xml</param>
        /// <returns>Posicion absoluta del objeto a imprimir </returns>
        private PointF ObtenerPosicionDeImpresionDeObjeto(string Objeto)
        {
            PointF posicion = new PointF(-1, -1);

            try
            {
                DataSet ds = Utils.GetDataSetFromXml("Resources/FacturaObjectsToPrint.xml");

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

                pos = ObtenerPosicionDeImpresionDeObjeto("ColumnaPrecioUnitario");
                string precioUnitario = dr.Cells["PrecioUnitario"].Text;
                _objetos.Add(new Printing.ObjetoAImprimir(precioUnitario, pos.X - (precioUnitario.Length * 8), y));

                pos = ObtenerPosicionDeImpresionDeObjeto("ColumnaPrecioFinal");
                string precioFinal = dr.Cells["PrecioFinal"].Text;
                _objetos.Add(new Printing.ObjetoAImprimir(precioFinal, pos.X - (precioFinal.Length * 8), y));


                y += ObtenerPosicionDeImpresionDeObjeto("EspacioEntreItems").Y;
            }


            pos = ObtenerPosicionDeImpresionDeObjeto("SubTotal1");
            _objetos.Add(new Printing.ObjetoAImprimir(Decimal.Round(txtSubTotal.Value, 2).ToString(), pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("DescuentoEspecial");
            _objetos.Add(new Printing.ObjetoAImprimir(Decimal.Round(txtDescuentoAplicado.Value, 2).ToString(), pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("SubTotal2");
            _objetos.Add(new Printing.ObjetoAImprimir(Decimal.Round(txtSubTotal2.Value, 2).ToString(), pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("IvaInscripto");
            _objetos.Add(new Printing.ObjetoAImprimir(Decimal.Round(txtIva21.Value, 2).ToString(), pos.X, pos.Y));
            pos = ObtenerPosicionDeImpresionDeObjeto("Total");
            _objetos.Add(new Printing.ObjetoAImprimir(Decimal.Round(txtTotal.Value, 2).ToString(), pos.X, pos.Y));

            return _objetos;
        }


       public void ImprimirCotizacion()
       {
           IList<ResultadoVerificar> resultadoVerificar = VerificarCampos();
           

           bool imprimir = true;
               foreach (ResultadoVerificar verificar in resultadoVerificar)
               {
                   if (verificar == ResultadoVerificar.NoExistenItemsCargados)
                   {
                       imprimir = false;
                       errorProvider.SetError(ugArticulos, "Deberá agregar al menos un item a la lista...");
                   }
                   if(verificar == ResultadoVerificar.NoCliente)
                   {
                       imprimir = false;
                       detallesCliente.EstablecerError();
                   }
                   if (verificar == ResultadoVerificar.StockSuperado)
                   {
                       DialogResult dr = MessageBox.Show("Se supero el stock de un articulo, Desea continuar con la Impresio",
                                                         "Stock Critico", MessageBoxButtons.YesNo);
                       if(dr == DialogResult.No) imprimir = false;
                   }
               }
               if (imprimir == true)
               {
                   try
                   {
                       Printing p = new Printing();
                       p.Objetos = CargarObjetosAImprimir();

                       AppSettingsReader settings = new AppSettingsReader();
                       p.Imprimir(1);
                   }
                   catch (Exception ex)
                   {
                       throw ex;
                   }

               }

       }

        public void ImprimirCopia()
        {
            if (_factura != null)
            {
                try
                {
                    Printing p = new Printing();
                    p.Objetos = CargarObjetosAImprimir();

                    AppSettingsReader settings = new AppSettingsReader();
                    p.Imprimir((short)(settings.GetValue("NumeroDeCopiasFactura", typeof(short))));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Id de la factura impresa</returns>
        public int Imprimir()
        {
            int ret = 0;
            printingCalled = true;

            IList<ResultadoVerificar> resultadoVerificar = VerificarCampos();
            int check = BeforeCloseCheck();
            if (resultadoVerificar.Count == 0 || (resultadoVerificar[0]== ResultadoVerificar.StockSuperado && chkNotaDeCredito!= null))
            {
                if (check == 1)
                {
                    if (_factura != null)
                    {
                        try
                        {
                            Printing p = new Printing();
                            p.Objetos = CargarObjetosAImprimir();
                            
                            _factura.Registrar(_factura,new Cliente{CUIT = detallesCliente.CUIT},new Factura.Totales{Total = txtTotal.Text,IvaInscripto = txtIva21.Text,SubTotal1 = txtSubTotal.Text,SubTotal2 = txtSubTotal2.Text} );

                            
                            AppSettingsReader settings = new AppSettingsReader();
                            if (p.Imprimir((short)(settings.GetValue("NumeroDeCopiasFactura", typeof(short)))))
                            {
                                _factura.AlmacenarImpresion(_factura.EsNotaDeCredito);
                                ret = _factura.Id;
                            }
                            else ret = 0;


                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                else if (check == 2)
                {
                    MessageBox.Show("Es necesario almacenar la factura para poder imprimirla.",
                                    "Error al Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ret = 0;
                }
            }
            else
            {
                foreach (ResultadoVerificar verificar in resultadoVerificar)
                {

                    if (verificar == ResultadoVerificar.StockSuperado)
                    {
                        if (verificar == ResultadoVerificar.NoExistenItemsCargados)
                            errorProvider.SetError(ugArticulos, "Deberá agregar al menos un item a la lista...");

                        if (verificar == ResultadoVerificar.NoCliente)
                            detallesCliente.EstablecerError();

                        if (verificar == ResultadoVerificar.StockSuperado)
                        {
                            AppSettingsReader reader = new AppSettingsReader();
                            int option = (int) reader.GetValue("StockCritico", typeof (int));

                            switch (option)
                            {
                                case 1:
                                    DialogResult dr =
                                        MessageBox.Show(
                                            "Existen uno o mas items cuya cantidad supera la que existe en stock. ¿Desea Continuar?",
                                            "Stock Crítico", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);

                                    break;
                                case 2:
                                    MessageBox.Show(
                                        "Existen uno o mas items cuya cantidad supera la que existe en stock. No puede continuar",
                                        "Stock Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    break;
                            }
                        }
                    }
                }

            }
              
            

            return ret;
        }
        

        /// <summary>
        /// Si la factura proviene de una nota de pedido, la factura podra guardarse una sola vez. Para volver a generarla, habra una opcion
        /// "volver a generar factura". 
        /// En caso que la factura no provenga de una nota de pedido, entonces podra ser almacenada tantas veces como se quiera, 
        /// mientras la misma no sea impresa. 
        /// </summary>
        /// <returns></returns>
        public Factura Guardar()
        {
            Factura f = null;
            IList<ResultadoVerificar> resultadoVerificar = VerificarCampos();
            if (resultadoVerificar.Count == 0 || (resultadoVerificar[0] == ResultadoVerificar.StockSuperado && chkNotaDeCredito != null))
            {
                try
                {


                    errorProvider.Clear();
                    detallesCliente.QuitarError();

                    string codigoCliente = detallesCliente.CodigoCliente;

                    IList<NotaPedido_Item> items = new List<NotaPedido_Item>();

                    if (_factura != null)
                    {
                        f = _factura;
                    }
                    else
                    {
                        f = new Factura();
                    }

                    f.Fecha = Convert.ToDateTime(dtFechaEmision.Value);
                    f.Cliente = Cliente.TraerClientePorCodigo(codigoCliente);
                    f.NumeroFactura = Convert.ToInt64(Utils.RemoveCharacterAndSpaces('-', txtNumeroFactura.Text));
                    f.Observaciones = txtObservaciones.Text;
                    f.ValorDolar = Convert.ToDecimal(txtValorDolar.Value);
                    f.DescuentoEspecial = (int) txtDescuentoEspecial.Value;
                    f.EsNotaDeCredito = chkNotaDeCredito.Checked;
                    f.EsCotizacion = checkBox1.Checked;
                    if (f.Items != null) f.Items.Clear();

                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in ugArticulos.Rows)
                    {
                        Articulo a = Articulo.TraerArticuloPorCodigo(dr.Cells["Codigo"].Value.ToString());

                        if (a != null)
                        {
                            //guardamos a que precio fue tomado el articulo en el momento 
                            NotaPedido_Item item = new NotaPedido_Item();

                            item.Articulo = a;
                            item.Cantidad = Convert.ToDecimal(dr.Cells["Cantidad"].Text);
                            item.PrecioUnitario = Convert.ToDecimal(dr.Cells["Tag"].Text);
                            item.Descuento = Convert.ToInt32(dr.Cells["Descuento"].Text);

                            items.Add(item);
                        }
                    }

                    f.Items = items;

                    if (f.Id != -1)
                    {
                        f.Actualizar();
                    }
                    else
                    {
                        int idFactura = f.Guardar();
                        f = Factura.TraerFacturaPorID(idFactura);
                    }

                    if (_factura == null) _factura = f;
                    this._fueModificada = false;



                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                foreach (ResultadoVerificar verificar in resultadoVerificar)
                {

                    
                    
                        if (verificar == ResultadoVerificar.NoExistenItemsCargados)
                        {
                            errorProvider.SetError(ugArticulos, "Deberá agregar al menos un item a la lista...");
                        }

                        if (verificar == ResultadoVerificar.NoCliente)
                        {
                            detallesCliente.EstablecerError();
                        }

                        if (verificar == ResultadoVerificar.StockSuperado)
                        {
                            AppSettingsReader reader = new AppSettingsReader();
                            int option = (int)reader.GetValue("StockCritico", typeof(int));

                            switch (option)
                            {
                                case 1:
                                    DialogResult dr =
                                        MessageBox.Show(
                                            "Existen uno o mas items cuya cantidad supera la que existe en stock. ¿Desea Continuar?",
                                            "Stock Crítico", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);

                                    break;
                                case 2:
                                    MessageBox.Show(
                                        "Existen uno o mas items cuya cantidad supera la que existe en stock. No puede continuar",
                                        "Stock Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    break;
                            }
                        }
                    
                }
            }

            return f;

        }

        /// <summary>
        /// Cancela la factura actual
        /// </summary>
        public void Cancelar()
        {
            _factura.Cancelar();
        }

        private IList<ResultadoVerificar> VerificarCampos()
        {
            IList<ResultadoVerificar> listaErrores = new List<ResultadoVerificar>();
            //Verificamos que se haya seleccionado algun cliente
            if (detallesCliente.Cliente == null)
            listaErrores.Add(ResultadoVerificar.NoCliente);
            
            bool existenItemsCargados = false;
            foreach (UltraGridRow dr in ugArticulos.Rows)
            {
                Articulo a = Articulo.TraerArticuloPorCodigo(dr.Cells["Codigo"].Value.ToString());


                if (a != null)
                {
                    existenItemsCargados = true;
                    if (Convert.ToBoolean(dr.Cells["StockCritico"].Value)|| a.Cantidad==0)
                    {
                        listaErrores.Add(ResultadoVerificar.StockSuperado);
                        break;
                    }
                }
            }
            if (!existenItemsCargados)
                listaErrores.Add(ResultadoVerificar.NoExistenItemsCargados);


            return listaErrores;
        



            //IList<ResultadoVerificar> ListaErrores = new List<ResultadoVerificar>();

            //ResultadoVerificar resultadoVerificar = ResultadoVerificar.Ok;


            ////Verificamos que se haya seleccionado algun cliente
            //if (detallesCliente.Cliente == null)
            //{
            //    detallesCliente.EstablecerError();
            //    ok = false;

            //}

            //bool existenItemsCargados = false;
            //foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in ugArticulos.Rows)
            //{
            //    Articulo a = Articulo.TraerArticuloPorCodigo(dr.Cells["Codigo"].Value.ToString());

            //    if (Convert.ToBoolean((dr.Cells["StockCritico"].Value != DBNull.Value ? dr.Cells["StockCritico"].Value : false)) == true)
            //        stockCritico = (true && (!chkNotaDeCredito.Checked));

            //    if (a != null)
            //    {
            //        existenItemsCargados = true;
            //    }
            //}

            //if (!existenItemsCargados)
            //{
            //    errorProvider.SetError(ugArticulos, "Deberá agregar al menos un item a la lista...");
            //    ok = false;
            //}


            //if (ok)
            //    if (stockCritico)
            //        resultadoVerificar = ResultadoVerificar.StockSuperado;
            ///*{
            //    if (printingCalled)
            //    {
            //        //MessageBox.Show("Existen uno o mas items cuya cantidad supera la que existe en stock. No puede continuar", "Stock Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
            //        ok = false;
            //    }
            //    else
            //    {
                        
            //        AppSettingsReader reader = new AppSettingsReader();
            //        int option = (int)reader.GetValue("StockCritico", typeof(int));

            //        switch (option)
            //        {
            //            case 1:
            //                DialogResult dr = MessageBox.Show("Existen uno o mas items cuya cantidad supera la que existe en stock. ¿Desea Continuar?", "Stock Crítico", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //                if (dr == DialogResult.No) ok = false;
            //                break;
            //            case 2:
            //                MessageBox.Show("Existen uno o mas items cuya cantidad supera la que existe en stock. No puede continuar", "Stock Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                ok = false;
            //                break;
            //        }
            //    }
            //}*/
            //return resultadoVerificar;
            
            
            //return ok;
        }

        #endregion

        #region Metodos Sobreescritos
        public override void Refrescar()
        {
            if (!_modificable) return;

            ugArticulos.DataSource = dsListaArticulos;
            ucListaArticulos.DataSource = Articulo.TraerTodos();
            ucListaArticulos.DisplayMember = "Codigo";

            if (this._factura != null && this._refrescar)
            {
                int _idFactura = this._factura.Id;
                Factura f = Factura.TraerFacturaPorID(_idFactura);
                
                this._factura = f;
                CargarFactura(f);
                
                this._refrescar = false;
            }
        }
        public override int ObtenerIdNotaPedido()
        {
            return this._factura.NotaPedido.IdNotaPedido;
        }
        public override void SetearFormularioNoModificable()
        {
            // Detalles Generales
            dtFechaEmision.ReadOnly = true;
            txtDescuentoEspecial.ReadOnly = true;
            txtDescuentoEspecial.Increment = 0;

            txtValorDolar.ReadOnly = true;


            detallesCliente.SetearFormularioNoModificable();
            dsListaArticulos.ReadOnly = true;


            _modificable = false;
        }
        public override void SetInitialFocus()
        {
            detallesCliente.SetFocus();
        }
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

        #endregion      

        private void txtNumeroFactura_Leave(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.txtValorDolar.Value = 1;
                this.detallesCliente.RazonSocial = "COTIZACION";
                IList<string> grupos = new List<string>();
                grupos.Add("groupFavoritos");
                grupos.Add("groupGestion");
                grupos.Add("groupCotizacion");
                ExplorerBarController.FillExplorerBar(grupos, ExplorerBarController.e);
                this.chkNotaDeCredito.Visible = false;

                
            }
            else
            {
                this.chkNotaDeCredito.Visible = true;
                frmPrincipal.valorDolar = frmPrincipal.valorDolar.Replace(".", ",");
                this.txtValorDolar.Value = Convert.ToDecimal(frmPrincipal.valorDolar);
                this.detallesCliente.RazonSocial = "Seleccione un Cliente de la Lista... ";
                IList<string> grupos = new List<string>();
                grupos.Add("groupFavoritos");
                grupos.Add("groupGestion");
                grupos.Add("groupFacturaActual");
                ExplorerBarController.FillExplorerBar(grupos, ExplorerBarController.e);

            }
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

       
    }
}
        

