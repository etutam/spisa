using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.Library;

namespace Gestioname.DomainModel
{
    public class Transportista: EntityBase<Transportista>
    {

        #region Properties

        public virtual string NombreTransportista { get; set; }

        public virtual string Domicilio { get; set; }

        #endregion
    }
}
