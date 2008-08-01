using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Libreria.Interfaces;

namespace SPISA.AccesoADatos
{
    public class DaoFactory : IDaoFactory
    {
        #region IDaoFactory Members

        public IArticuloDAO CreateArticuloDAO()
        {
            return new ArticuloDAO();
        }

        public ICategoriaDAO CreateCategoriaDAO()
        {
            return new CategoriaDAO();
        }

        #endregion


    }
}
