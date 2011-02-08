
using System;
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    public class Cliente : EntityBase<Cliente>
    {
        


        #region Properties

           public virtual string RazonSocial
           {
               get; set;
           }
        #endregion


        #region Methods
        public override Cliente GetTestInstance()
        {
        return new Cliente
                    {
                        RazonSocial = "Razon Social de Prueba"
                    };
        }
        #endregion
    }
}
