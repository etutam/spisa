using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Modules.Clientes.UI.Models;

namespace Gestioname.Modules.Clientes.UI.Views
{
    /// <summary>
    /// Interaction logic for ClientesView.xaml
    /// </summary>
    public partial class ClientesView : UserControl, IClientesView
    {
        public ClientesView()
        {
            InitializeComponent();
        }

        #region CRUD

        public void New()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
            
        }

        #endregion

        #region Presentation Model
        public void SetModel(IClientesPresentationModel model)
        {
            this.DataContext = model;
        }
        #endregion
    }
}
