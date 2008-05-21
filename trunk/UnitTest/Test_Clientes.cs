using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SPISA.Libreria;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Test_Clientes
    /// </summary>
    [TestClass]
    public class Test_Clientes
    {
        public Test_Clientes()
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
        public void CargarClientes()
        {/*
           for (int i = 0; i < 9999; i++)
            {
                Cliente c = new Cliente();
                c.Codigo = i.ToString();
                c.CUIT = i.ToString();
                c.Domicilio = "Este es un Domicilio de Prueba";
                c.IVA = CondicionIVA.TraerCondicionIVAPorId(1);
                c.Localidad = "Capital Federal";
                c.Provincia = Provincia.TraerProvinciaPorId(1);
                c.RazonSocial = "Prueba " + i.ToString();
                c.Operatoria = Operatoria.TraerOperatoriaPorId(1);

                c.Guardar();
                

            }*/
        }
    }
}
