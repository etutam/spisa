using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SPISA.Entities;
using SPISA.Libreria;
namespace SPISA.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArticuloBO articulo = new ArticuloBO(Utilities.CreateFactoryInstance());

            //Articulos existente = articulo.TraerArticuloPorCodigo("Articulo1");
            Articulo nuevoArticulo = articulo.TraerArticuloPorCodigo("Articulo1");

        //    nuevoArticulo.CategoriasReference.Load();
            nuevoArticulo.Categorias = new CategoriaBO(Utilities.CreateFactoryInstance()).TraerCategoriaPorDescripcion("Bridas");
            nuevoArticulo.preciounitario = 1234;
           // nuevoArticulo.Categorias.Articulos.Clear();
            //articulo.Almacenar(existente);

            articulo.Almacenar(nuevoArticulo);


            //Articulos existente = articulo.TraerArticuloPorCodigo("Articulo1");
            Articulo nuevoArticulo2 = new Articulo();


            nuevoArticulo2.cantidad = 10;
            nuevoArticulo2.codigo = "testtsadfasdfesttest";
            nuevoArticulo2.descripcion = "test";
            nuevoArticulo2.preciounitario = 100;

            nuevoArticulo2.Categorias = new CategoriaBO(Utilities.CreateFactoryInstance()).TraerCategoriaPorDescripcion("Accesorios");
           // nuevoArticulo2.Categorias.Articulos.Clear();
            //articulo.Almacenar(existente);

            articulo.Almacenar(nuevoArticulo2);

            /// LO PROXIMO QUE HAY QUE HACER ES TRATAR DE SACAR EL ARTICULO EN LA CATEGORIA, PARA QUE NO SE AGREGUE SOLO AL OBJECTCONTEXT
            /// 
        }
    }
}
