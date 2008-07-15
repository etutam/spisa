using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SPISA.Libreria;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Test_Facturas_Imprimir
    /// </summary>
    [TestClass]
    public class Test_Facturas
    {
        public Test_Facturas()
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
        public void CancelarFacturaNoImpresa()
        {/*
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

            np = NotaPedido.TraerNotaPedidoPorId(IdNotaPedido);

            if (np == null) Assert.Fail();

            Factura f = np.GenerarFactura();
            int IdFactura = f.Guardar();

            f = Factura.TraerFacturaPorID(IdFactura);

            if (f == null) Assert.Fail();

            f.Cancelar();

            f = Factura.TraerFacturaPorID(IdFactura);

            if (f != null) Assert.Fail();*/
        }

        [TestMethod]
        public void CancelarFacturaImpresa()
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
                item.Articulo = Articulo.TraerArticuloPorID(i+343);
                item.Cantidad = 10;
                item.Descuento = 20;
                item.PrecioUnitario = Convert.ToDecimal(22.22);

                np.Items.Add(item);
            }

            for (int i = 0; i < 5; i++)
            {
                NotaPedido_Item item = new NotaPedido_Item();
                item.Articulo = Articulo.TraerArticuloPorID(i + 372);
                item.Cantidad = 10;
                item.Descuento = 20;
                item.PrecioUnitario = Convert.ToDecimal(22.22);

                np.Items.Add(item);
            }
            for (int i = 0; i < 5; i++)
            {
                NotaPedido_Item item = new NotaPedido_Item();
                item.Articulo = Articulo.TraerArticuloPorID(i + 412);
                item.Cantidad = 10;
                item.Descuento = 20;
                item.PrecioUnitario = Convert.ToDecimal(22.22);

                np.Items.Add(item);
            }
            int IdNotaPedido = np.Guardar();

            np = NotaPedido.TraerNotaPedidoPorId(IdNotaPedido);

            if (np == null) Assert.Fail();

            Factura f = np.GenerarFactura();
            int IdFactura = f.Guardar();

            f = Factura.TraerFacturaPorID(IdFactura);

            if (f == null) Assert.Fail();

            decimal CantidadArticulosOriginal = Articulo.TraerArticuloPorID(1).Cantidad;
            
            f.AlmacenarImpresion(false);

            f.Cancelar();

            f = Factura.TraerFacturaPorID(IdFactura);

            if (Articulo.TraerArticuloPorID(1).Cantidad != CantidadArticulosOriginal) Assert.Fail();
        }
    }
}
