using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.Interfaces
{
    public interface IClientesDAO
    {
        #region Properties
        GestionameContext Context
        {
            get;
        }
        #endregion

        #region Methods
        void AddCliente(Cliente cliente);
        void DeleteCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);

        Cliente GetClienteById(int id);
        IEnumerable<Cliente> GetClientes();
        IEnumerable<Cliente> FindClientesByRazonSocial(string razonSocial);

        void AddTransaccion(Transaccion transaccion);
        void DeleteTransaccion(Transaccion transaccion);
        void UpdateTransaccion(Transaccion transaccion);

        TipoTransaccion GetTipoTransaccionByDescripcion(string descripcion);
        IEnumerable<TipoTransaccion> GetTiposTransacciones();

        void AddCuenta(Cuenta cuenta);
        void DeleteCuenta(Cuenta cuenta);
        void UpdateCuenta(Cuenta cuenta);

        Cuenta GetCuentaById(int id);
        IEnumerable<Cuenta> GetCuentas();


        #endregion
    }
}
