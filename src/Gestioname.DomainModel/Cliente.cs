
using Gestioname.Library;


namespace Gestioname.DomainModel
{
    public class Cliente : EntityBase
    {
        #region Campos Privados
           string _razonsocial;
        
        #endregion


        #region Propiedades

        public string RazonSocial
        {
            get { return _razonsocial; }
            set { _razonsocial = value; }
        }
        #endregion

    }
}
