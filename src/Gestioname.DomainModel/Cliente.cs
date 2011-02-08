
using System;
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    public class Cliente : EntityBase<Cliente>
    {
        //#region Campos Privados
        //   string _razonsocial;
        
        //#endregion


        #region Propiedades

           public virtual string RazonSocial
           {
               get; set;
           }
        #endregion



        public override Cliente GetTestInstance()
        {
            return new Cliente
                       {
                           RazonSocial = "Razon Social de Prueba"
                       };
        }
    }
}
