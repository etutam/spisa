using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using SPISA.Libreria.Interfaces;
using SPISA.Entities;

namespace SPISA.AccesoADatos
{
    public class ArticuloDAO : IArticuloDAO
    {

        #region IArticuloDAO Members

        public Articulo TraerArticuloPorCodigo(string codigo)
        {
            Articulo articulo = null;

            try
            {
                EntitiesContext entitiesContext = ContextFactory.CreateContext();

                var sql = " SELECT VALUE art FROM Articulos as art " +
                      " where art.codigo=@Codigo";
                ObjectQuery<Articulo> query = entitiesContext.CreateQuery<Articulo>(sql, new ObjectParameter("codigo", codigo));

                if (query.Count() > 0) articulo = query.First();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return articulo;
        }

        public IEnumerable<Articulo> TraerTodos()
        {
            IEnumerable<Articulo> articulos = null;

            try
            {
                using (EntitiesContext entitiesContext = new EntitiesContext())
                {
                    articulos = entitiesContext.Articulos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return articulos;
        }

        public Articulo TraerArticuloPorId(int idArticulo)
        {
            Articulo articulo = null;

            try
            {
                EntitiesContext entitiesContext = ContextFactory.CreateContext();
                
                var sql = " SELECT VALUE art FROM Articulos as art " +
                          " where art.id=@Id";
                ObjectQuery<Articulo> query = entitiesContext.CreateQuery<Articulo>(sql, new ObjectParameter("id", idArticulo));

                if (query.Count() > 0) articulo = query.First();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return articulo;
        }

        public int Almacenar(Articulo articulo)
        {
            int idArticulo = 0;
            Articulo nuevoArticulo = null;

            EntitiesContext entitiesContext = ContextFactory.CreateContext();
            try
            {
                entitiesContext.Attach(articulo);

                //ObjectQuery<Articulo> exists = entitiesContext.CreateQuery<Articulo>(
                //    "SELECT VALUE art FROM Articulos AS art WHERE art.codigo=@codigo and art.idArticulo!=0", new ObjectParameter("codigo", articulo.codigo));

              
                //if (exists.Count() > 0)
                //{
                //    int test = exists.First().idArticulo;
                //    articulo.idArticulo = test;

                //    entitiesContext.Detach(exists.First());
                //    entitiesContext.Attach(articulo);
                    
                //    //nuevoArticulo = exists.First();

                //    //nuevoArticulo.cantidad = articulo.cantidad;
                //    //nuevoArticulo.Categorias = articulo.Categorias;
                //    //nuevoArticulo.descripcion = articulo.descripcion;
                //    //nuevoArticulo.preciounitario = articulo.preciounitario;

                //    //entitiesContext.Refresh(RefreshMode.ClientWins, nuevoArticulo);
                    
                //}
                //else
                //{
                //    nuevoArticulo = articulo;
                //    entitiesContext.AddObject("Articulos", nuevoArticulo);
                //}
                
                entitiesContext.SaveChanges();
            }
            catch (Exception ex)
            {
                ObjectStateEntry state = entitiesContext.ObjectStateManager.GetObjectStateEntry(articulo.EntityKey);

                if (state.State == System.Data.EntityState.Modified)
                    entitiesContext.Refresh(RefreshMode.ClientWins, articulo);
                entitiesContext.SaveChanges();

                //throw ex;
            }

            return idArticulo;
        }

        #endregion

 
    }
}
