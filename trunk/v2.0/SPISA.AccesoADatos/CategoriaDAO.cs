using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using SPISA.Libreria.Interfaces;
using SPISA.Entities;

namespace SPISA.AccesoADatos
{
    public class CategoriaDAO : ICategoriaDAO
    {

        #region ICategoriaDAO Members

        public IEnumerable<Categoria> TraerTodas()
        {
            throw new NotImplementedException();
        }

        public Categoria TraerCategoriaPorId(int idCategoria)
        {
            throw new NotImplementedException();
        }

        public Categoria TraerCategoriaPorDescripcion(string descripcion)
        {
            Categoria categoria = null;
            
            try
            {
                EntitiesContext entitiesContext = ContextFactory.CreateContext();

                var sql = " SELECT VALUE cat FROM Categorias as cat " +
                      " where cat.descripcion=@Descripcion";
                ObjectQuery<Categoria> query = entitiesContext.CreateQuery<Categoria>(sql, new ObjectParameter("descripcion", descripcion));

                categoria = query.First();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoria;
        }

        public int Almacenar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
