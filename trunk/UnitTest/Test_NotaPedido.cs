using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SPISA.Libreria;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Test_NotaPedido
    /// </summary>
    [TestClass]
    public class Test_NotaPedido
    {
        public Test_NotaPedido()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        /*[TestMethod]
        public void TestMethod_AgregarPedido()
        {
            NotaPedido np = new NotaPedido();
            np.Cliente = Cliente.TraerClientePorID(1);
            np.DescuentoEspecial = 10;
            np.FechaEmision = DateTime.Now;
            np.FechaEntrega = DateTime.Now;

            np.Observaciones = "This is a Test";

            for (int i = 0; i < 5; i++)
            {
                NotaPedido_Item item = new NotaPedido_Item();
                item.Articulo = Articulo.TraerArticuloPorID(1);
                item.Cantidad = 10;
                item.Descuento = 20;
                item.PrecioUnitario = Convert.ToDecimal(22.22);

                np.Items.Add(item);
            }

            int IdNotaPedido = np.Guardar();
        }
        [TestMethod]
        public void TestMethod_AgregarPedidosyFactura()
        {/*
            for (int i = 0; i < 1000000; i++)
            {
                Random r = new Random();

                NotaPedido np = new NotaPedido();
                np.Cliente = Cliente.TraerClientePorID(r.Next(1,7000));
                np.FechaEmision = DateTime.Now;
                np.FechaEntrega = DateTime.Now.Add(new TimeSpan(1,0,0,0));
                np.Observaciones = "This is a test";

                

                for (int j = 0; j < r.Next(1, 10); j++)
                {
                    NotaPedido_Item item = new NotaPedido_Item();
                    item.Articulo = Articulo.TraerArticuloPorID(r.Next(1,7000));
                    item.Cantidad = r.Next(100);
                    item.Descuento = r.Next(100);
                    item.PrecioUnitario = item.Articulo.PrecioUnitario;

                    np.Items.Add(item);


                }

                np.Guardar();
            }
        }*/
    }
}
