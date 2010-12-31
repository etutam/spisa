using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Libreria.Interfaces;
using SPISA.Entities;

namespace SPISA.Libreria
{
    public class ArticuloBO : BaseBO
    {
        private IArticuloDAO _dao;

        public ArticuloBO(IDaoFactory factory) : base(factory)
        {
            _dao = base.Factory.CreateArticuloDAO();
        }

        public Articulo TraerArticuloPorCodigo(string codigo)
        {
            return _dao.TraerArticuloPorCodigo(codigo);
        }

        public int Almacenar(Articulo articulo)
        {
            return _dao.Almacenar(articulo);
        }
        
    }
}
