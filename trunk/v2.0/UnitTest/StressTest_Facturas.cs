using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SPISA.Libreria;
namespace UnitTest
{
    /// <summary>
    /// Summary description for StressTest_Facturas
    /// </summary>
    [TestClass]
    public class StressTest_Facturas
    {
        public StressTest_Facturas()
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

        [TestMethod]
        public void TestMethod1()
        {
            /*DateTime fecha = DateTime.Now.AddYears(-26);

            int x = 0;
            while (x != 9999)
            {
                Factura f = new Factura();
                
                Random r = new Random(10);

                f.Cliente = Cliente.TraerClientePorID(1);
                f.Fecha = fecha;
                
                f.Items.Add(new NotaPedido_Item(Articulo.TraerArticuloPorID(1), r.Next(10), r.NextDouble()));
                f.Items.Add(new NotaPedido_Item(Articulo.TraerArticuloPorID(2), r.Next(10), r.NextDouble()));
                f.Items.Add(new NotaPedido_Item(Articulo.TraerArticuloPorID(3), r.Next(10), r.NextDouble()));

                f.Observaciones = "Esto es una Prueba";
                f.ValorDolar = Convert.ToDecimal(3.05);

                f.Guardar();
                f.AlmacenarImpresion();

                fecha = fecha.AddDays(1);
                x++;
            }*/
        }
    }
}
