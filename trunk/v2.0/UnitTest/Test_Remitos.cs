using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SPISA.Libreria;
using System.Data;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Test_Remitos
    /// </summary>
    [TestClass]
    public class Test_Remitos
    {
        public Test_Remitos()
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
        /*
        [TestMethod]
        public void TraerTodos()
        {
            DataSet ds = Remito.TraerTodos();

            Assert.AreEqual(true, ds.Tables.Count > 0);
               
        }

        [TestMethod]
        public void TraerPorId()
        {
            Remito r = Remito.TraerRemitoPorID(1);

            if (r == null) Assert.Fail();
        }
        
        [TestMethod]
        public void TraerPorIdNotaPedido()
        {
            Remito r = Remito.TraerRemitoPorIdNotaPedido(1);

            if (r == null) Assert.Fail();
        }

        [TestMethod]
        public void GuardarRemito()
        {
            Remito r = new Remito();
            r.Cliente = Cliente.TraerClientePorID(1);
            r.Fecha = DateTime.Now;
            r.NumeroRemito = "1234";
            r.Observaciones = "This is a Test";
            r.Peso = 10;
            r.Bultos = 20;
            r.Valor = 10;

            for (int i = 0; i < 5; i++)
            {
                NotaPedido_Item item = new NotaPedido_Item();
                item.Articulo = Articulo.TraerArticuloPorID(1);
                item.Cantidad = 10;
                item.Descuento = 20;
                item.PrecioUnitario = Convert.ToDecimal(22.22);

                r.Items.Add(item);
            }

            r.Guardar();
           
        }*/
    }
}
