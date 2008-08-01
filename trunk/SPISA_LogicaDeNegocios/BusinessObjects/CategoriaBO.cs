using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Libreria.Interfaces;
using SPISA.Entities;

namespace SPISA.Libreria
{
    public class CategoriaBO : BaseBO
    {
        private ICategoriaDAO _dao;

        public CategoriaBO(IDaoFactory factory)
            : base(factory)
        {
            _dao = base.Factory.CreateCategoriaDAO();
        }

        public Categoria TraerCategoriaPorDescripcion(string descripcion)
        {
           return _dao.TraerCategoriaPorDescripcion(descripcion);
        }
    }
}
