using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.Interfaces
{
    public interface IClientesComponent
    {

          
        #region Methods

        #region Clientes
        /// <summary>
        /// Agrega un cliente a la base de datos
        /// </summary>
        /// <param name="cliente">Cliente a agregar</param>
        void AddCliente(Cliente cliente);
        /// <summary>
        /// Actualiza un cliente existente en la base de datos
        /// </summary>
        /// <param name="cliente">Cliente a actualizar</param>
        void UpdateCliente(Cliente cliente);
        /// <summary>
        /// Elimina un cliente de la base de datos
        /// </summary>
        /// <param name="cliente">Cliente a eliminar</param>
        void DeleteCliente(Cliente cliente);
        /// <summary>
        /// Obtiene un Cliente de la base de datos por Id
        /// </summary>
        /// <param name="id">Id del cliente a obtener de la base de datos</param>
        /// <returns></returns>
        Cliente GetClienteById(int id);
        /// <summary>
        /// Obtiene un Cliente de la base de datos por codigo
        /// </summary>
        /// <param name="codigo">Codigo del cliente a obtener de la base de datos</param>
        /// <returns>Instancia de Cliente</returns>
        Cliente GetClienteByCodigo(string codigo);
        /// <summary>
        /// Obtiene un listado de clientes por razon social
        /// </summary>
        /// <returns>Listado de Instancias de Clientes</returns>
        IEnumerable<Cliente> FindClientesByRazonSocial(string razonSocial);
        #endregion 

        #region Cuentas
        Cuenta GetCuentaById(int idCuenta);
        IEnumerable<Cuenta> GetCuentas();
        #endregion

        #region Transacciones
        void AddTransaccion(Transaccion transaccion);
        #endregion

        #region Queries TiposTransacciones
        TipoTransaccion GetTipoTransaccionByDescripcion(string descripcion);
        #endregion

        #endregion
    }
}
