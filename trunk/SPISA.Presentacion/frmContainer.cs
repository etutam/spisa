// Hacer que todos los objetos (factura, listados, etc) se puedan comunicar de una forma efectiva
// El problema lo encontre cuando queria actualizar la lista de pedidos, dp de almacenar un pedido 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinExplorerBar;

namespace SPISA.Presentacion
{
    public partial class frmContainer : Form
    {
        #region Campos Estaticos
        static frmContainer frm=null;
        public static UltraExplorerBar explorerBar = null;
        #endregion

        #region Constructores
        private frmContainer()
        {
            InitializeComponent();
        }

        #endregion

        #region Singleton
        public static frmContainer crearContainer(UltraExplorerBar e)
        {
            if (frm == null) frm = new frmContainer();
            explorerBar = e;

            return frm;
        }

        #endregion

        #region Metodos

        public void ModificarTabSeleccionado(string Name)
        {
            UltraTab tabSeleccionado = TabControl.SelectedTab;

            tabSeleccionado.Text = Name;
        }


        public void ModificarTabSeleccionado(string Name, string Key, string Tag, bool Selected)
        {
            UltraTab tabSeleccionado = TabControl.SelectedTab;

            tabSeleccionado.Text = Name;
            tabSeleccionado.Key = Key;
            tabSeleccionado.Tag = Tag;
            tabSeleccionado.Selected = Selected;

            TabControl_SelectedTabChanged(null, null);
        }
        
        /// <summary>
        /// Retorna el Tab que el usuario tiene seleccionado actualmente
        /// </summary>
        /// <returns></returns>
        public UltraTab ObtenerTabVisualizado()
        {
            return TabControl.SelectedTab;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Text"></param>
        /// <param name="optionalTag"></param>
        /// <param name="optionalControl">Control que queremos agregar al TabPage</param>
        /// <returns></returns>
        public int AgregarTab(string Key, string Text, string optionalTag, Control optionalControl)
        {
            UltraTab tab = TabControl.Tabs.Add();

            if (Key != "") tab.Key = Key;
            
            tab.Text = Text;
            tab.Tag = optionalTag;

            if (optionalControl != null)
            {
                
                tab.TabPage.Controls.Add(optionalControl);
                ResizeTabControls();
            }

            tab.Selected = true;
            return tab.Index;
        }

        public BaseControl TraerUserControlVisible()
        {
            return (BaseControl)TabControl.SelectedTab.TabPage.Controls[0];
        }
        private void ResizeTabControls()
        {
            foreach (UltraTab tab in TabControl.Tabs)
            {
                tab.TabPage.Controls[0].Width = this.Width;
                tab.TabPage.Controls[0].Height = this.Height;
            }
        }
        #endregion


        #region Eventos

        private void TabControl_ActiveTabChanged(object sender, ActiveTabChangedEventArgs e)
        {

            IList<string> grupos = new List<string>();
            grupos.Add("groupFavoritos");
            grupos.Add("groupGestion");

            if (e.Tab != null)
            {

                if (e.Tab.Tag != null)
                {
                    string[] groups = e.Tab.Tag.ToString().Split(',');

                    foreach (string str in groups)
                        grupos.Add(str);

                    ExplorerBarController.FillExplorerBar(grupos, explorerBar);

                    BaseControl bc = (BaseControl) e.Tab.TabPage.Controls[0];
                    bc.Refrescar();
                }
            }
           
        }


        private void TabControl_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
        {
            if (TabControl.SelectedTab != null)
            {
                IList<string> grupos = new List<string>();
                grupos.Add("groupFavoritos");
                grupos.Add("groupGestion");


                string[] groups = TabControl.SelectedTab.Tag.ToString().Split(',');

                foreach(string str in groups)
                    grupos.Add(str);

                ExplorerBarController.FillExplorerBar(grupos, explorerBar);

                BaseControl bc = (BaseControl)TabControl.SelectedTab.TabPage.Controls[0];
                bc.Refrescar();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeTabControls();
        }

        private void frmContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TabControl.SelectedTab != null)
            {

                BaseControl bc = (BaseControl)TabControl.SelectedTab.TabPage.Controls[0];

                int check = bc.BeforeCloseCheck();

                if (check == 1 || check == 2)
                {
                    if (e.CloseReason != CloseReason.MdiFormClosing)
                    {
                        if (TabControl.Tabs.Count > 1)
                        {
                            TabControl.Tabs.RemoveAt(TabControl.SelectedTab.Index);
                            e.Cancel = true;
                        }
                        else
                        {
                            frm.Dispose();
                            frm = null;
                            IList<string> grupos = new List<string>();
                            grupos.Add("groupFavoritos");
                            grupos.Add("groupGestion");
                            ExplorerBarController.FillExplorerBar(grupos, explorerBar);
                        }
                    }
                }
                else if (check == 3)
                {
                    e.Cancel = true;
                }
            }
            
        }
        

        #endregion

    


    }
}