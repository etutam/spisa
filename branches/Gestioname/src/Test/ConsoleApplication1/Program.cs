

using System;

namespace AfipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WSAFIPFE.Factura f = new WSAFIPFE.Factura();

            if (f.iniciar(WSAFIPFE.Factura.modoFiscal.Test, "33708293739", @"c:\pirulo.pfx", ""))
            {
                if (f.ObtenerTicketAcceso())
                {
                    DateTime ahora = DateTime.Now;
                    //f.bDireccionServicio = WSAFIPFE
                    f.FECabeceraCantReg = 1;
                    f.FECabeceraPresta_serv = 1;
                    f.indice = 0;
                    f.FEDetalleFecha_vence_pago = "20120101";
                    f.FEDetalleFecha_serv_desde = "20120101";
                    f.FEDetalleFecha_serv_hasta = "20120101";
                    f.FEDetalleFecha_vence_pago = ahora.ToString("yyyyMMdd");
                    f.FEDetalleImp_neto = 100;
                    f.FEDetalleImp_total = 120;

                    f.FEDetalleFecha_cbte = ahora.ToString("yyyyMMdd");
                    f.FEDetalleNro_doc = "33708293739";
                    f.FEDetalleTipo_doc = WSAFIPFE.Factura.TipoDocumento.CUIT;

                    var result = f.Registrar(1, WSAFIPFE.Factura.TipoComprobante.FacturaA, "1");

                    }
                else
                {
                    Console.WriteLine("Error numero: {0}; Mensaje {1}", f.UltimoNumeroError, f.UltimoMensajeError);
                    Console.ReadLine();
                }
            }
        }
    }
}
