using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Gestioname.Infrastructure.Model;
using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Modules.Clientes.BusinessComponents;

namespace Getioname.Modules.Clientes.UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ClientesTest
    {
        public ClientesTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
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
        public void AddClienteTest()
        {
            IClientesFacade facade = new ClientesFacade();

            if (facade.FindClientesByRazonSocial("empresa test") == null)
            {

                Cliente cliente = new Cliente();
                cliente.Codigo = "abcde";
                cliente.CUIT = "1929394";
                cliente.Domicilio = "domicilio";
                cliente.Localidad = "capital";
                cliente.Provincia = "buenos aires";
                cliente.RazonSocial = "empresa test";

                facade.AddCliente(cliente);
            }
        }

        [TestMethod]
        public void AddCuentaTest()
        {
            for (int i = 0; i < 10; i++)
            {
                IClientesFacade facade = new ClientesFacade();
                Cliente c = facade.GetClienteById(1);

                if (c != null)
                {
                    if (c.Cuentas.Count == 0)
                    {
                        Cuenta cuenta = new Cuenta();
                        cuenta.Balance = "0";

                        c.Cuentas.Add(cuenta);

                        //facade.Context.Detach(c);
                        facade.UpdateCliente(c);
                    }
                }
            }
        }

        [TestMethod]
        public void AddTransaccionTest()
        {
            IClientesFacade facade = new ClientesFacade();
            Cliente c = facade.GetClienteById(1);

            if (c != null)
            {
                Cuenta cuenta = facade.GetCuentaById(5);
                Transaccion transaccion = Transaccion.CreateTransaccion(facade.GetTipoTransaccionByDescripcion("Cuenta Corriente"), DateTime.Now, "100");
                facade.CreateTransaccion(transaccion);
            }
        }
        //[TestMethod]
        //public void UpdateClienteTest()
        //{
        //    IClientesFacade facade = new ClientesFacade();
        //    Cliente c = facade.GetClienteById(1);

        //    if (c != null)
        //    {
        //        c.Domicilio = "nuevo domicilio";
        //        c.RazonSocial = "nueva razon social";

        //        facade.Context.Detach(c);
       //        facade.UpdateCliente(c);
        //    }
        //}
    }
}
