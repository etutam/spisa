//using System;
//using System.Text;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//using SPISA.Libreria;

//namespace UnitTest
//{
//    /// <summary>
//    /// Summary description for Test_Articulo
//    /// </summary>
//    [TestClass]
//    public class Test_Articulo
//    {
//        public Test_Articulo()
//        {
            
//        }

//        #region Additional test attributes
//        //
//        // You can use the following additional attributes as you write your tests:
//        //
//        // Use ClassInitialize to run code before running the first test in the class
//        // [ClassInitialize()]
//        // public static void MyClassInitialize(TestContext testContext) { }
//        //
//        // Use ClassCleanup to run code after all tests in a class have run
//        // [ClassCleanup()]
//        // public static void MyClassCleanup() { }
//        //
//        // Use TestInitialize to run code before running each test 
//        // [TestInitialize()]
//        // public void MyTestInitialize() { }
//        //
//        // Use TestCleanup to run code after each test has run
//        // [TestCleanup()]
//        // public void MyTestCleanup() { }
//        //
//        #endregion

//        [TestMethod]
//        public void TestMethod_TraerArticuloPorCodigo()
//        {
            
//            ArticuloBO articulo = new ArticuloBO(Utilities.CreateFactoryInstance());
//            articulo.TraerArticuloPorCodigo("1");
            
//            //Articulo a = Articulo.TraerArticuloPorCodigo(null);
//        }

//        [TestMethod]
//        public void TestMethod_AgregarArticulos()
//        {/*
//            for (int i = 0; i < 9999; i++)
//            {
//                Random r = new Random();
//                Articulo a = new Articulo();

//                a.Cantidad = r.Next(3000);
//                a.Categoria = Categoria.TraerCategoriaPorId(2);
//                a.Codigo = i.ToString();
//                a.Descripcion = "Prueba " + i.ToString();
//                a.PrecioUnitario = r.NextDouble() * r.Next(300);

//                a.Guardar();
//            }*/
//        }

//        [TestMethod]
//        public void TestMethod_DecimalSeparator()
//        {
//            //Articulo a = Articulo.TraerArticuloPorID(4);
//        }
//    }
//}
