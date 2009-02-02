﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Gestioname.Infrastructure.Model;
using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Modules.Clientes.BusinessComponents;

namespace Gestioname.Modules.Clientes.Models
{
    public class ClientesPresentationModel : IClientesPresentationModel
    {

        #region Private Fields
        /// <summary>
        /// Acceso a los metodos de negocio
        /// </summary>
        private IClientesComponent _clientesComponent;
        #endregion

        #region Constructors
        public ClientesPresentationModel(IClientesView view, IClientesComponent clientesComponent)
        {
            View = view;
            _clientesComponent = clientesComponent;
      
            InitializeComponents();
        }
        #endregion

        private void InitializeComponents()
        {
            Clientes = _clientesComponent.GetClientes();
        }

        #region IClientesPresentationModel Members

        public IEnumerable<Cliente> Clientes
        {
            get;
            private set;
        }

        public String Test
        {
            get
            {
                return "Hola Mundo";
            }
        }

        public IClientesView View
        {
            get; set;
        }    

        #endregion
    }
}
