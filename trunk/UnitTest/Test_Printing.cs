using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Drawing;

using SPISA.Libreria;
namespace UnitTest
{
    /// <summary>
    /// Summary description for Test_Printing
    /// </summary>
    [TestClass]
    public class Test_Printing
    {
        public Test_Printing()
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
        public void Test_Imprimir()
        {
            /*Printing.ObjetoAImprimir _fecha = new Printing.ObjetoAImprimir();

            Printing.ObjetoAImprimir _cliente_RazonSocial = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir _cliente_Domicilio = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir _cliente_Localidad = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir _cliente_Provincia = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir _cliente_IVA = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir _cliente_CUIT = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir _cliente_CondicionVenta = new Printing.ObjetoAImprimir();


            _fecha.Texto = DateTime.Now.ToString() ;
            _fecha.X = 550;
            _fecha.Y = 100;

            _cliente_RazonSocial.Texto = "Suministros Petroleros e Industriales S.A.";
            _cliente_RazonSocial.X = 100;
            _cliente_RazonSocial.Y = 180;

            _cliente_Domicilio.Texto = "Jaramillo 2877 7 'B'";
            _cliente_Domicilio.X = 100;
            _cliente_Domicilio.Y = 195;

            _cliente_Localidad.Texto = "Capital Federal";
            _cliente_Localidad.X = 100;
            _cliente_Localidad.Y = 210;

            _cliente_Provincia.Texto = "Buenos Aires";
            _cliente_Provincia.X = 100;
            _cliente_Provincia.Y = 225;

            _cliente_IVA.Texto = "Responsable Inscripto";
            _cliente_IVA.X = 100;
            _cliente_IVA.Y = 265;

            _cliente_CUIT.Texto = "33-70829373-9";
            _cliente_CUIT.X = 450;
            _cliente_CUIT.Y = 265;
            
            
            Printing p = new Printing();

            p.Objetos.Add(_fecha);
            p.Objetos.Add(_cliente_RazonSocial);
            p.Objetos.Add(_cliente_Domicilio);
            p.Objetos.Add(_cliente_Localidad);
            p.Objetos.Add(_cliente_Provincia);
            
            p.Objetos.Add(_cliente_IVA);
            p.Objetos.Add(_cliente_CUIT);

            Factura f = Factura.TraerFacturaPorID(1);

            int y = 350;
            foreach (NotaPedido_Item item in f.Items)
            {
                Printing.ObjetoAImprimir cantidad = new Printing.ObjetoAImprimir();
                Printing.ObjetoAImprimir Descripcion = new Printing.ObjetoAImprimir();
                Printing.ObjetoAImprimir PrecioUnitario = new Printing.ObjetoAImprimir();
                Printing.ObjetoAImprimir PrecioFinal = new Printing.ObjetoAImprimir();

                cantidad.Texto = item.Cantidad.ToString();
                cantidad.X = 80 - (item.Cantidad.ToString().Length * 8);
                cantidad.Y = y;

                Descripcion.Texto = item.Articulo.Descripcion.ToString();
                Descripcion.X = 130;
                Descripcion.Y = y;

                PrecioUnitario.Texto = item.PrecioUnitario.ToString();
                PrecioUnitario.X = 640 - (item.PrecioUnitario.ToString().Length * 8);
                PrecioUnitario.Y = y;

                PrecioFinal.Texto = (item.Cantidad*item.PrecioUnitario).ToString();
                PrecioFinal.X = 750 - (item.Cantidad*item.PrecioUnitario).ToString().Length * 7.5F;
                PrecioFinal.Y = y;
                

                p.Objetos.Add(cantidad);
                p.Objetos.Add(Descripcion);
                p.Objetos.Add(PrecioUnitario);
                p.Objetos.Add(PrecioFinal);

                
                y += 18;

                
            }

            Printing.ObjetoAImprimir SubTotal = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir Iva = new Printing.ObjetoAImprimir();
            Printing.ObjetoAImprimir Total = new Printing.ObjetoAImprimir();


            SubTotal.Texto = "12343,34";
            SubTotal.X = 40;
            SubTotal.Y = 1000;


            Iva.Texto = "12343,34";
            Iva.X = 430;
            Iva.Y = 1000;

            Total.Texto = "12343,34";
            Total.X = 690;
            Total.Y = 1000;

            //Iva.Texto

            p.Objetos.Add(SubTotal);
            p.Objetos.Add(Iva);
            p.Objetos.Add(Total);
            p.Imprimir();*/
        }
    }
}
