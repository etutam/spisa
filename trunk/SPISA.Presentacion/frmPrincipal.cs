using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO; 
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinTabControl;
using SPISA.Libreria;

using System.Xml;

using System.Threading;
using System.Security.Permissions;
using System.Configuration;

namespace SPISA.Presentacion
{
    

    public partial class frmPrincipal : Form
    {
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        //public class TestMessageFilter : IMessageFilter
        //{
        //    public bool PreFilterMessage(ref Message m)
        //    {
        //        bool ret = false;
        //        if (m.Msg == 522)
        //        {
        //            ret = true;
        //        }

        //        return ret;

        //    }
        //}

        public static String valorDolar = "";


        //System.Threading.Timer dollarTimer;

        public frmPrincipal()
        {
            //Application.AddMessageFilter(new TestMessageFilter());
            
            CultureInfo Cultura = new CultureInfo("es-AR",true);
            Cultura.NumberFormat.CurrencyDecimalSeparator = ",";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-AR");


            InitializeComponent();

            string[] grupos = { "groupFavoritos", "groupGestion" };
            ExplorerBarController.FillExplorerBar(grupos,explorerBar);

            status.Panels[1].Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Logger.Append("============================= EL SISTEMA HA SIDO INICIADO ============================= ", null, null);

            //CheckForIllegalCrossThreadCalls = false;
            //dollarTimer = new System.Threading.Timer(new TimerCallback(TraerCotizacion), status,2000, 60000);

            //ExplorerBarController.e = this.explorerBar;
            //status.Panels["pMessages"].Width = this.Size.Width - this.explorerBar.Width - status.Panels["pDolar"].Width;

            valorDolar = ConfigurationManager.AppSettings["ValorDolar"];
            valorDolar=valorDolar.Replace(".", ",");
            status.Panels[0].Text = "Dolar: " + valorDolar;

        }


        //public void TraerCotizacion(object value)
        //{
        //    Infragistics.Win.UltraWinStatusBar.UltraStatusBar bar = (Infragistics.Win.UltraWinStatusBar.UltraStatusBar)value;
        //    bar.Panels["pDolar"].Text = "Dolar: " + valorDolar.DolarVenta;

        //    Logger.Append("El dolar ha sido actualizado a $" + valorDolar.DolarVenta.ToString(), null, null);
        //}


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Articulo.test();
        }

        private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                // Manejo de Pedidos
                case "itemListadoPedidos":
                    VisualizarListadoDePedidos();
                    break;
                case "itemListadoFacturas":
                    VisualizarListadoFacturas();
                    break;
                case "itemListadoArticulos":
                    VisualizarListadoArticulos();
                    break;
                case "itemListadoClientes":
                    VisualizarListadoClientes();
                    break;
                case "itemAgregarPedido":
                    AgregarPedido();
                    break;
                case "itemFavoritoAgregarPedido":
                    AgregarPedido();
                    break;
                case "itemEditarPedido":
                    EditarPedido();
                    break;
                case "itemAlmacenarPedido":
                    AlmacenarPedido();
                    break;
                case "itemFacturarPedido":
                    GenerarFactura();
                    break;
                case "itemVisualizarFactura":
                    VisualizarFactura();
                    break;
                case "itemAlmacenarFactura":
                    AlmacenarFactura();
                    break;
                case "itemAgregarFactura":
                    AgregarFactura();
                    break; 
                case "itemFavoritoAgregarFactura":
                    AgregarFactura();
                    break;
                case "itemEditarFactura":
                    EditarFactura();
                    break; 
                case "itemImprimirFactura":
                    ImprimirFactura();
                    break;
                case "itemImprimirCopiaFactura":
                    ImprimirCopiaFactura();
                    break;
                case "itemCancelarFactura":
                    CancelarFactura();
                    break;
                case "itemImprimirRemito":
                    ImprimirRemito();
                    break;
                case "itemAgregarArticulo":
                    AgregarArticulo();
                    break;
                case "itemAlmacenarArticulo":
                    AlmacenarArticulo();
                    break;
                case "itemEditarArticulo":
                    EditarArticulo();
                    break;
                case "itemFavoritoAgregarRemito":
                    AgregarRemito();
                    break;
                case "itemAlmacenarRemito":
                    AlmacenarRemito();
                    break;
                case "itemGenerarRemito":
                    GenerarRemito();
                    break;
                case "itemVisualizarNotaDePedido":
                    VisualizarNotaDePedido();
                    break;
                case "itemVisualizarRemito":
                    VisualizarRemito();
                    break;
                case "itemEditarCliente":
                    EditarCliente();
                    break;
                case "itemAlmacenarCliente":
                    AlmacenarCliente();
                    break;
                case "itemImprimir":
                    Imprimir();
                    break;
                case "itemAlmacenarCotizacion":
                     
                    AlmacenarCotizacion();
                    break;
            }
        }

        
      


        #region Otros
 

        private void AlmacenarCotizacion()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            UcFactura ucFactura = (UcFactura)frm.TraerUserControlVisible();

            ucFactura.Guardar();
            
        }

        private void Imprimir()
       {
           frmContainer frm = frmContainer.crearContainer(this.explorerBar);
           UcFactura ucFactura= (UcFactura)frm.TraerUserControlVisible();
           ucFactura.ImprimirCotizacion();
           
       }

        private void ImprimirRemito()
        {
            try
            {
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);
                UcRemito ucRemito = (UcRemito)frm.TraerUserControlVisible();
                ucRemito.Imprimir();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ImprimirCopiaFactura()
        {
            try
            {
                DialogResult result = MessageBox.Show("Se imprimirá la factura. ¿Desea continuar?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    frmContainer frm = frmContainer.crearContainer(this.explorerBar);
                    UcFactura ucFactura = (UcFactura)frm.TraerUserControlVisible();

                    ucFactura.ImprimirCopia();
                }
                else
                {
                    MessageBox.Show("La impresión la factura ha sido cancelada.", "Error al Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar imprimir la Factura. Consulte el Log para mas detalles.", "Error al Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImprimirFactura()
        {
            try
            {
                
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);
                UcFactura ucFactura = (UcFactura)frm.TraerUserControlVisible();
                
                int idFactura = ucFactura.Imprimir();
                Factura _factura = Factura.TraerFacturaPorID(idFactura);

                if (_factura != null)
                {
                    frm.ModificarTabSeleccionado("Factura \""  + _factura.Cliente.RazonSocial.ToString() + "\"", "factura_" + _factura.Id.ToString(), "groupFacturaActualAlmacenadaImpresa", true);
                    ucFactura.SetearFormularioNoModificable();

                    int existeFacturaORemito = DeterminarExistenciaDeFacturaORemito(_factura.NotaPedido.IdNotaPedido);

                    string[] options = new string[] { 
                                            "groupPedidoActualAlmacenadoSinFacturaSinRemito",
                                            "groupPedidoActualAlmacenadoSinFacturaConRemito",
                                            "groupPedidoActualAlmacenadoConFacturaSinRemito",
                                            "groupPedidoActualAlmacenadoConFacturaConRemito"
                    
                                        };

                    if (frm.TabControl.Tabs.Exists("pedido_" + _factura.NotaPedido.IdNotaPedido))
                    {
                        frm.TabControl.Tabs["pedido_" + _factura.NotaPedido.IdNotaPedido].Tag = options[existeFacturaORemito];

                        BaseControl bc = (BaseControl)frm.TabControl.Tabs["pedido_" + _factura.NotaPedido.IdNotaPedido].TabPage.Controls[0];
                        bc.SetearFormularioNoModificable();
                    }


                    Remito r = Remito.TraerRemitoPorIdNotaPedido(_factura.NotaPedido.IdNotaPedido);

                    if (r != null)
                    {
                        if (frm.TabControl.Tabs.Exists("remito_" + r.Id))
                        {
                            BaseControl bc = (BaseControl)frm.TabControl.Tabs["remito_" + r.Id].TabPage.Controls[0];
                            bc.SetearFormularioNoModificable();

                            frm.TabControl.Tabs["remito_" + r.Id].Tag = "groupRemitoActualNoModificable";
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar imprimir la Factura. Consulte el Log para mas detalles.", "Error al Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarFactura()
        {
            try
            {
                string[] grupos = { "groupFavoritos", "groupGestion" };
                
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);
                UcFactura ucFactura = (UcFactura)frm.TraerUserControlVisible();
                Factura f = ucFactura.Factura;

                ucFactura.Cancelar();

                
                /* cambios desde aqui */
                int existeFacturaORemito = DeterminarExistenciaDeFacturaORemito(f.NotaPedido.IdNotaPedido);

                string[] options = new string[] { 
                                                "groupPedidoActualAlmacenadoSinFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoSinFacturaConRemito",
                                                "groupPedidoActualAlmacenadoConFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoConFacturaConRemito"
                        
                                            };

                if (frm.TabControl.Tabs.Exists("pedido_" + f.NotaPedido.IdNotaPedido))
                {
                    frm.TabControl.Tabs["pedido_" + f.NotaPedido.IdNotaPedido].Tag = options[existeFacturaORemito];

                }

                frm.TabControl.Tabs.Remove(frm.TabControl.SelectedTab);
                /*cambios hasta aqui */
                if (frm.TabControl.Tabs.Count == 0)
                {
                    frm.Close();
                    ExplorerBarController.FillExplorerBar(grupos, explorerBar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cancelar la Factura. Consulte el Log para mas detalles.", "Error al Cancelar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DeterminarExistenciaDeFacturaORemito(int IdNotaPedido)
        {
            int existeRemito = 1;
            int existeFactura = 2;

            int ret = 0;

            Factura f = Factura.TraerFacturaPorIdNotaPedido(IdNotaPedido);
            Remito r = Remito.TraerRemitoPorIdNotaPedido(IdNotaPedido);

            if (f != null)
            {   
                ret = ret | existeFactura;
            }
            if (r != null)
            {
                ret = ret | existeRemito;
            }
            return ret;
        }
        #endregion

        #region Editar
        private void EditarFactura()
        {
            UcFactura ucFactura;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            if (frm != null)
            {
                UcListadoFacturas lf = (UcListadoFacturas)frm.TraerUserControlVisible();
                int idFactura = lf.ObtenerIdFacturaSeleccionado();

                if (idFactura != -1)
                {
                    if (frm.TabControl.Tabs.Exists("factura_" + idFactura))
                    {
                        frm.TabControl.Tabs["factura_" + idFactura].Selected = true;
                    }
                    else
                    {
                        Factura f = Factura.TraerFacturaPorID(idFactura);
                        ucFactura = new UcFactura(f);

                        if (f.FueCancelada)
                        {
                            frm.TabControl.Tabs[frm.AgregarTab("factura_" + f.Id.ToString(), "Factura \"" + f.Cliente.RazonSocial + "\"", "", ucFactura)].Selected = true;
                            ucFactura.SetearFormularioNoModificable();
                        }
                        else if (f.FueImpresa)
                        {
                            frm.TabControl.Tabs[frm.AgregarTab("factura_" + f.Id.ToString(), "Factura \"" + f.Cliente.RazonSocial + "\"", "groupFacturaActualAlmacenadaImpresa", ucFactura)].Selected = true;
                            ucFactura.SetearFormularioNoModificable();
                        }
                        else
                        {
                            frm.TabControl.Tabs[frm.AgregarTab("factura_" + f.Id.ToString(), "Factura \"" + f.Cliente.RazonSocial + "\"", "groupFacturaActualAlmacenada", ucFactura)].Selected = true;
                        }

                        ucFactura.SetInitialFocus();
                    }
                }

            }
        }
        private void EditarArticulo()
        {
            UcArticulo ucArticulo;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            UcListadoArticulos la = (UcListadoArticulos)frm.TraerUserControlVisible();
            int idArticulo = la.ObtenerIdArticuloSeleccionado();

            if (idArticulo != -1)
            {
                if (frm.TabControl.Tabs.Exists("articulo_" + idArticulo))
                    frm.TabControl.Tabs["articulo_" + idArticulo].Selected = true;
                else
                {
                    Articulo a = Articulo.TraerArticuloPorID(idArticulo);
                    ucArticulo = new UcArticulo(a);

                    frm.TabControl.Tabs[frm.AgregarTab("articulo_" + a.Id, "Artículo #" + a.Codigo, "groupArticuloActual", ucArticulo)].Selected = true;
                }
            }
        }
        private void EditarPedido()
        {
            UcNotaPedido ucNp;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            string[] options = new string[] { 
                                                "groupPedidoActualAlmacenadoSinFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoSinFacturaConRemito",
                                                "groupPedidoActualAlmacenadoConFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoConFacturaConRemito"
                        
                                            };

            if (frm != null)
            {

                ListadoPedidos lp = (ListadoPedidos)frm.TraerUserControlVisible();
                int idNotaPedido = lp.ObtenerIdPedidoSeleccionado();

                if (idNotaPedido != -1)
                {
                    if (frm.TabControl.Tabs.Exists("pedido_" + idNotaPedido))
                    {
                        frm.TabControl.Tabs["pedido_" + idNotaPedido].Selected = true;
                    }
                    else
                    {
                        NotaPedido np = NotaPedido.TraerNotaPedidoPorId(idNotaPedido);
                        ucNp = new UcNotaPedido(np);

                        int existeFacturaORemito = DeterminarExistenciaDeFacturaORemito(np.IdNotaPedido);
                        frm.TabControl.Tabs[frm.AgregarTab("pedido_" + np.IdNotaPedido, "Pedido \"" + np.Cliente.RazonSocial + "\"", options[existeFacturaORemito], ucNp)].Selected = true;

                        ucNp.SetInitialFocus();

                        Factura f = Factura.TraerFacturaPorIdNotaPedido(np.IdNotaPedido);
                        if (f!=null)
                            if (f.FueImpresa)
                            {
                                ucNp.SetearFormularioNoModificable();
                            }
                    }
                }
            }
        }
        private void EditarCliente()
        {
            UcCliente ucCliente;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            if (frm != null)
            {
                ListadoClientes lc = (ListadoClientes)frm.TraerUserControlVisible();
                int idCliente = lc.ObtenerIdClienteSeleccionado();

                if (idCliente != -1)
                {
                    if (frm.TabControl.Tabs.Exists("cliente_" + idCliente))
                    {
                        frm.TabControl.Tabs["cliente_" + idCliente].Selected = true;
                    }
                    else
                    {
                        Cliente c = Cliente.TraerClientePorID(idCliente);
                        ucCliente = new UcCliente(c);
                        frm.TabControl.Tabs[frm.AgregarTab("cliente_" + idCliente, "Cliente #" + c.Codigo, "groupClienteActual", ucCliente)].Selected = true;
                    }
                }
            }
        }
        public static void EditarCliente(int idCliente)
        {
            UcCliente ucCliente;
            frmContainer frm = frmContainer.crearContainer(ExplorerBarController.e);

            if (frm != null)
            {
                if (idCliente != -1)
                {
                    if (frm.TabControl.Tabs.Exists("cliente_" + idCliente))
                    {
                        frm.TabControl.Tabs["cliente_" + idCliente].Selected = true;
                    }
                    else
                    {
                        Cliente c = Cliente.TraerClientePorID(idCliente);
                        ucCliente = new UcCliente(c);
                        frm.TabControl.Tabs[frm.AgregarTab("cliente_" + idCliente, "Cliente #" + c.Codigo, "groupClienteActual", ucCliente)].Selected = true;
                    }
                }
            }
        }


        #endregion

        #region Generar

        private void GenerarRemito()
        {
            try
            {
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);

                UcNotaPedido ucNP = (UcNotaPedido)frm.TraerUserControlVisible();
                NotaPedido np = ucNP.NotaPedido;

                if (frm.TabControl.Tabs.Exists("remito_" + np.IdNotaPedido))
                {
                    frm.TabControl.Tabs["remito_" + np.IdNotaPedido].Selected = true;
                }
                else
                {
                    int check = ucNP.BeforeCloseCheck();
                    if (check == 1)
                    {
                        ucNP.Guardar();
                        frm.ModificarTabSeleccionado("Pedido \"" + np.Cliente.RazonSocial + "\"");
                    }
                    if (check != 3)
                    {

                        Remito r = np.GenerarRemito();
                        Factura f = Factura.TraerFacturaPorIdNotaPedido(np.IdNotaPedido);

                        if (r != null)
                        {
                            UcRemito ucRemito = new UcRemito(r);
                            frm.TabControl.Tabs[frm.AgregarTab("remito_" + np.IdNotaPedido, "Nuevo Remito *", "groupRemitoActual", ucRemito)].Selected = true;

                            if (f != null && f.FueImpresa)
                            {
                                ucRemito.SetearFormularioNoModificable();
                            }

                            ucRemito.SetInitialFocus();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GenerarFactura()
        {
            try
            {
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);

                if (frm != null)
                {
                    UcNotaPedido ucNP = (UcNotaPedido)frm.TraerUserControlVisible();
                    NotaPedido np = ucNP.NotaPedido;

                    
                    //verificamos que ya no se haya hecho click en "facturar"
                    if (frm.TabControl.Tabs.Exists("factura_" + np.IdNotaPedido))
                    {
                        frm.TabControl.Tabs["factura_" + np.IdNotaPedido].Selected = true;
                    }
                    else
                    {
                        int check = ucNP.BeforeCloseCheck();
                        if (check == 1)
                        {
                            ucNP.Guardar();
                            frm.ModificarTabSeleccionado("Pedido \"" + np.Cliente.RazonSocial + "\"");
                        }
                        if (check != 3)
                        {
                            frmPrincipal.valorDolar = frmPrincipal.valorDolar.Replace(".", ",");

                            Decimal valorDolar = Convert.ToDecimal(frmPrincipal.valorDolar);
                            Factura f = ucNP.NotaPedido.GenerarFactura();

                            f.ValorDolar = valorDolar;

                            if (f != null)
                            {
                                UcFactura ucFactura = new UcFactura(f);
                                frm.TabControl.Tabs[frm.AgregarTab("factura_" + np.IdNotaPedido, "Nueva Factura *", "groupFacturaActual", ucFactura)].Selected = true;
                                ucFactura.SetInitialFocus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Agregar
        private void AgregarRemito()
        {
            UcRemito ucRemito;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            frm.MdiParent = this;

            ucRemito = new UcRemito();
            frm.AgregarTab("", "Nuevo Remito *", "groupRemitoActual", ucRemito);

            if (frm.Visible == false) frm.Show();
            ucRemito.SetInitialFocus();

        }
        private void AgregarArticulo()
        {
            UcArticulo ucArticulo;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            ucArticulo = new UcArticulo();
            frm.AgregarTab("", "Nuevo Articulo *", "groupArticuloActual", ucArticulo);

            ucArticulo.FocusCodigo();
        }
        private void AgregarPedido()
        {
            

            UcNotaPedido ucNp;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            frm.MdiParent = this;

            ucNp = new UcNotaPedido();
            frm.AgregarTab("", "Nuevo Pedido *", "groupPedidoActualNoAlmacenado", ucNp);

            if (frm.Visible == false) frm.Show();
            ucNp.SetInitialFocus();
        }

        private void AgregarFactura()
        {
            UcFactura ucFactura;
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            frm.MdiParent = this;

            ucFactura = new UcFactura();
            frm.AgregarTab("", "Nueva Factura *", "groupFacturaActual", ucFactura);
            if (frm.Visible == false) frm.Show();

            ucFactura.SetInitialFocus();

        }
        #endregion

        #region Almacenar
        private void AlmacenarPedido()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            UcNotaPedido ucNP = (UcNotaPedido)frm.TraerUserControlVisible();
            NotaPedido np = ucNP.Guardar();

            string[] options = new string[] { 
                                                "groupPedidoActualAlmacenadoSinFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoSinFacturaConRemito",
                                                "groupPedidoActualAlmacenadoConFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoConFacturaConRemito"
                        
                                            };

            if (np != null)
            {
                int existeFacturaORemito = DeterminarExistenciaDeFacturaORemito(np.IdNotaPedido);
                frmContainer _container = frmContainer.crearContainer(frmContainer.explorerBar);
                _container.ModificarTabSeleccionado("Pedido \"" + np.Cliente.RazonSocial + "\"", "pedido_" + np.IdNotaPedido, options[existeFacturaORemito], true);



                Remito r = Remito.TraerRemitoPorIdNotaPedido(np.IdNotaPedido);
                Factura f = Factura.TraerFacturaPorIdNotaPedido(np.IdNotaPedido);

                if (r != null)
                {
                    if (frm.TabControl.Tabs.Exists("remito_" + r.Id))
                    {
                        frm.TabControl.Tabs["remito_" + r.Id].Text = "Remito \"" + r.Cliente.RazonSocial + "\"";

                        BaseControl bc = (BaseControl)frm.TabControl.Tabs["remito_" + r.Id].TabPage.Controls[0];
                        bc.RefrescarAutomaticamente = true;
                    }
                }

                if (f != null)
                {
                    if (frm.TabControl.Tabs.Exists("factura_" + f.Id))
                    {
                        frm.TabControl.Tabs["factura_" + f.Id].Text = "Factura \"" + f.Cliente.RazonSocial + "\"";

                        BaseControl bc = (BaseControl)frm.TabControl.Tabs["factura_" + f.Id].TabPage.Controls[0];
                        bc.RefrescarAutomaticamente = true;
                    }
                }

            }
        }
        private void AlmacenarArticulo()
        {
            try
            {
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);

                UcArticulo ucArticulo = (UcArticulo)frm.TraerUserControlVisible();
                ucArticulo.Guardar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void AlmacenarRemito()
        {
            try
            {
                frmContainer frm = frmContainer.crearContainer(this.explorerBar);

                UcRemito ucRemito = (UcRemito)frm.TraerUserControlVisible();
                Remito r = ucRemito.Guardar();

                string[] options = new string[] { 
                                                "groupPedidoActualAlmacenadoSinFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoSinFacturaConRemito",
                                                "groupPedidoActualAlmacenadoConFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoConFacturaConRemito"
                        
                                            };


                if (r != null)
                {
                    if (frm.TabControl.Tabs.Exists("pedido_" + r.NotaPedido.IdNotaPedido))
                    {
                        int existeFacturaORemito = DeterminarExistenciaDeFacturaORemito(r.NotaPedido.IdNotaPedido);
                        frm.TabControl.Tabs["pedido_" + r.NotaPedido.IdNotaPedido].Tag = options[existeFacturaORemito];
                        frm.TabControl.Tabs["pedido_" + r.NotaPedido.IdNotaPedido].Text = "Pedido \"" + r.Cliente.RazonSocial + "\"";

                        BaseControl bc = (BaseControl)frm.TabControl.Tabs["pedido_" + r.NotaPedido.IdNotaPedido].TabPage.Controls[0];
                        bc.RefrescarAutomaticamente = true;
                    }

                    Factura f = Factura.TraerFacturaPorIdNotaPedido(r.NotaPedido.IdNotaPedido);
                    if (f != null)
                    {
                        if (frm.TabControl.Tabs.Exists("factura_" + f.Id))
                        {
                            BaseControl bc = (BaseControl)frm.TabControl.Tabs["factura_" + f.Id].TabPage.Controls[0];
                            bc.RefrescarAutomaticamente = true;
                        }
                    }

                    frm.ModificarTabSeleccionado("Remito \"" + r.Cliente.RazonSocial + "\"", "remito_" + r.Id.ToString(), "groupRemitoActualAlmacenado", true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AlmacenarFactura()
        {
            try
            {

                frmContainer frm = frmContainer.crearContainer(this.explorerBar);
                UcFactura ucFactura = (UcFactura)frm.TraerUserControlVisible();

                Factura f = ucFactura.Guardar();

                string[] options = new string[] { 
                                                "groupPedidoActualAlmacenadoSinFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoSinFacturaConRemito",
                                                "groupPedidoActualAlmacenadoConFacturaSinRemito",
                                                "groupPedidoActualAlmacenadoConFacturaConRemito"
                        
                                            };
                if (f != null)
                {
                    if (frm.TabControl.Tabs.Exists("pedido_" + f.NotaPedido.IdNotaPedido))
                    {
                        int existeFacturaORemito = DeterminarExistenciaDeFacturaORemito(f.NotaPedido.IdNotaPedido);
                        frm.TabControl.Tabs["pedido_" + f.NotaPedido.IdNotaPedido].Tag = options[existeFacturaORemito];
                        frm.TabControl.Tabs["pedido_" + f.NotaPedido.IdNotaPedido].Text = "Pedido \"" + f.Cliente.RazonSocial + "\"";

                        BaseControl bc = (BaseControl)frm.TabControl.Tabs["pedido_" + f.NotaPedido.IdNotaPedido].TabPage.Controls[0];
                        bc.RefrescarAutomaticamente = true;
                    }

                    Remito r = Remito.TraerRemitoPorIdNotaPedido(f.NotaPedido.IdNotaPedido);
                    
                    if (r != null)
                    {
                        if (frm.TabControl.Tabs.Exists("remito_" + r.Id))
                        {
                            frm.TabControl.Tabs["remito_" + r.Id].Text = "Remito \"" + r.Cliente.RazonSocial + "\"";

                            BaseControl bc = (BaseControl)frm.TabControl.Tabs["remito_" + r.Id].TabPage.Controls[0];
                            bc.RefrescarAutomaticamente = true;
                        }
                    }

                    if (f.FueImpresa)
                        frm.ModificarTabSeleccionado("Factura \"" + f.Cliente.RazonSocial + "\"", "factura_" + f.Id.ToString(), "groupFacturaActualAlmacenadaImpresa", true);
                    else
                        frm.ModificarTabSeleccionado("Factura \"" + f.Cliente.RazonSocial + "\"", "factura_" + f.Id.ToString(), "groupFacturaActualAlmacenada", true);

                    StatusBarController.ShowMessage(status, "pMessages", "La factura ha sido almacenada con éxito");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error");
            }

        }
        private void AlmacenarCliente()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            UcCliente ucCliente = (UcCliente)frm.TraerUserControlVisible();

            Cliente f = ucCliente.Guardar();
        }
        #endregion

        #region Visualizar Formularios
        private void VisualizarFactura()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);

            if (frm != null)
            {
                UcNotaPedido ucNP = (UcNotaPedido)frm.TraerUserControlVisible();
                Factura f = Factura.TraerFacturaPorIdNotaPedido(ucNP.NotaPedido.IdNotaPedido);
                UcFactura ucFactura = new UcFactura(f);

                if (frm.TabControl.Tabs.Exists("factura_" + f.Id))
                {
                    frm.TabControl.Tabs["factura_" + f.Id].Selected = true;
                }
                else
                {
                    if (f.FueCancelada)
                    {
                        frm.TabControl.Tabs[frm.AgregarTab("factura_" + f.Id.ToString(), "Factura \"" + f.Cliente.RazonSocial + "\"", "", ucFactura)].Selected = true;
                        ucFactura.SetearFormularioNoModificable();
                    }
                    else if (f.FueImpresa)
                    {
                        frm.TabControl.Tabs[frm.AgregarTab("factura_" + f.Id.ToString(), "Factura \"" + f.Cliente.RazonSocial + "\"", "groupFacturaActualAlmacenadaImpresa", ucFactura)].Selected = true;
                        ucFactura.SetearFormularioNoModificable();
                    }
                    else
                    {
                        frm.TabControl.Tabs[frm.AgregarTab("factura_" + f.Id.ToString(), "Factura \"" + f.Cliente.RazonSocial + "\"", "groupFacturaActualAlmacenada", ucFactura)].Selected = true;
                    }
                }
            }
        }
        private void VisualizarRemito()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            UcNotaPedido ucNP = (UcNotaPedido)frm.TraerUserControlVisible();
            Remito r = Remito.TraerRemitoPorIdNotaPedido(ucNP.ObtenerIdNotaPedido());
            UcRemito ucRemito = new UcRemito(r);

            if (frm.TabControl.Tabs.Exists("remito_" + r.Id))
            {
                frm.TabControl.Tabs["remito_" + r.Id].Selected = true;
            }
            else
            {
                frm.TabControl.Tabs[frm.AgregarTab("remito_" + r.Id.ToString(), "Remito \"" + r.Cliente.RazonSocial + "\"", "groupRemitoActualAlmacenado, groupDatosCliente", ucRemito)].Selected = true;
            }

        }
        private void VisualizarNotaDePedido()
        {

            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            BaseControl bc = (BaseControl)frm.TraerUserControlVisible();

            frm.MdiParent = this;

            NotaPedido np = NotaPedido.TraerNotaPedidoPorId(bc.ObtenerIdNotaPedido());

            UcNotaPedido ucNp = new UcNotaPedido(np);

            if (frm.TabControl.Tabs.Exists("pedido_" + np.IdNotaPedido))
            {
                frm.TabControl.Tabs["pedido_" + np.IdNotaPedido].Selected = true;
            }
            else
            {
                Factura f = Factura.TraerFacturaPorIdNotaPedido(np.IdNotaPedido);
                Remito r = Remito.TraerRemitoPorIdNotaPedido(np.IdNotaPedido);

                if (f == null && r != null)
                {
                    frm.TabControl.Tabs[frm.AgregarTab("pedido_" + np.IdNotaPedido, "Pedido \"" + np.Cliente.RazonSocial + "\"", "groupPedidoActualAlmacenadoSinFacturaConRemito", ucNp)].Selected = true;
                }
                else if (f != null && r == null)
                {
                    if (f.FueImpresa)
                    {
                        frm.TabControl.Tabs[frm.AgregarTab("pedido_" + np.IdNotaPedido, "Pedido \"" + np.Cliente.RazonSocial + "\"", "groupPedidoActualAlmacenadoConFacturaSinRemito", ucNp)].Selected = true;
                        ucNp.SetearFormularioNoModificable();
                    }
                    else
                    {
                        frm.TabControl.Tabs[frm.AgregarTab("pedido_" + np.IdNotaPedido, "Pedido \"" + np.Cliente.RazonSocial + "\"", "groupPedidoActualAlmacenadoConFacturaSinRemito", ucNp)].Selected = true;
                    }
                }
                else // ambos sean != null
                {
                        if (f.FueImpresa)
                        {
                            ucNp.SetearFormularioNoModificable();
                            frm.TabControl.Tabs[frm.AgregarTab("pedido_" + np.IdNotaPedido, "Pedido #" + np.NumeroOrden, "groupPedidoActualAlmacenadoConFacturaConRemito", ucNp)].Selected = true;
                        }
                        else
                        {
                            frm.TabControl.Tabs[frm.AgregarTab("pedido_" + np.IdNotaPedido, "Pedido #" + np.NumeroOrden, "groupPedidoActualAlmacenadoConFacturaConRemito", ucNp)].Selected = true;
                        }
                }
            }

        }
        #endregion

        #region Visualizar Listados
        private void VisualizarListadoArticulos()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            frm.MdiParent = this;

            if (frm.TabControl.Tabs.Exists("groupManejoDeArticulos"))
            {
                frm.TabControl.Tabs["groupManejoDeArticulos"].Selected = true;
            }
            else
            {
                UcListadoArticulos la = new UcListadoArticulos();

                frm.TabControl.Tabs[frm.AgregarTab("groupManejoDeArticulos", "Listado de Articulos", "groupManejoDeArticulos", la)].Selected = true;

            }
            frm.Show();
        }
        private void VisualizarListadoFacturas()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            frm.MdiParent = this;

            if (frm.TabControl.Tabs.Exists("groupManejoDeFacturas"))
            {
                frm.TabControl.Tabs["groupManejoDeFacturas"].Selected = true;
            }
            else
            {
                UcListadoFacturas lf = new UcListadoFacturas();

                frm.TabControl.Tabs[frm.AgregarTab("groupManejoDeFacturas", "Listado de Facturas", "groupManejoDeFacturas", lf)].Selected = true;

            }
            frm.Show();
        }
        private void VisualizarListadoDePedidos()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            ListadoPedidos lp = null;

            frm.MdiParent = this;
            if (frm.TabControl.Tabs.Exists("groupManejoDePedidos"))
            {
                frm.TabControl.Tabs["groupManejoDePedidos"].Selected = true;
            }
            else
            {
                lp = new ListadoPedidos();
                frm.TabControl.Tabs[frm.AgregarTab("groupManejoDePedidos", "Listado de Pedidos", "groupManejoDePedidos", lp)].Selected = true;
            }
            frm.Show();
        }
        private void VisualizarListadoClientes()
        {
            frmContainer frm = frmContainer.crearContainer(this.explorerBar);
            ListadoClientes lc = null;

            frm.MdiParent = this;
            if (frm.TabControl.Tabs.Exists("groupManejoDeClientes"))
            {
                frm.TabControl.Tabs["groupManejoDeClientes"].Selected = true;
            }
            else
            {
                lc = new ListadoClientes();
                frm.TabControl.Tabs[frm.AgregarTab("groupManejoDeClientes", "Listado de Clientes", "groupManejoDeClientes", lc)].Selected = true;
            }
            frm.Show();
        }
        #endregion

        /// <summary>
        /// El unico objetivo de esta funcion es proveer un lugar central para mostrarle mensajes al usuario
        /// </summary>
        public static void MostrarInformacionAlUsuario(string titulo, string mensaje)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            int size = this.Size.Width - this.explorerBar.Width - status.Panels["pDolar"].Width;
            status.Panels["pMessages"].Width = (size >= 0 ? size : 0);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Append("============================= EL USUARIO HA CERRADO EL SISTEMA =============================", null, null);
        }


        private void setEditarValorDolar(bool state)
        {
            if (state)
            {
                status.Panels[0].Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer;
                status.Panels[0].Control = txtDolar;
                txtDolar.Visible = true;
                txtDolar.Text = valorDolar;
                txtDolar.Focus();
            }
            else
            {
                status.Panels[0].Text = "Dolar: " + txtDolar.Text;
                status.Panels[0].Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Button;
                valorDolar = txtDolar.Text;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("ValorDolar");
                config.AppSettings.Settings.Add("ValorDolar", valorDolar);
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void status_ButtonClick_1(object sender, Infragistics.Win.UltraWinStatusBar.PanelEventArgs e)
        {
            setEditarValorDolar(true);
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            setEditarValorDolar(false);
        }

        private void txtDolar_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            setEditarValorDolar(false);
        }
    }
}