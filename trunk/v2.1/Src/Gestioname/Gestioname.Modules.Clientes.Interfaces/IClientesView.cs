
namespace Gestioname.Modules.Clientes.Interfaces
{
    public interface IClientesView
    {
        #region CRUD

        /// <summary>
        /// Permite crear un nuevo Cliente. Para almacenar los cambios se debe invocar al metodo SaveChanges
        /// </summary>
        void New();

        /// <summary>
        /// Almacena los cambios realizados sobre los datos del cliente
        /// </summary>
        void SaveChanges();

        #endregion

        #region Presentation Model

        void SetModel(IClientesPresentationModel model);

        #endregion
    }
}