

using System;

namespace AfipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WSAFIPFE.Factura f = new WSAFIPFE.Factura();
            f.ProxyUserName = "";


            if (f.iniciar(WSAFIPFE.Factura.modoFiscal.Test, "33708293739", @"c:\pirulo.pfx", ""))
            {
                if (f.f1ObtenerTicketAcceso())
                {
                    //DateTime ahora = DateTime.Now;
                    ////f.bDireccionServicio = WSAFIPf
                    //f.fCabeceraCantReg = 1;
                    //f.fCabeceraPresta_serv = 1;
                    //f.indice = 0;
                    //f.fDetallefcha_vence_pago = "20120101";
                    //f.fDetallefcha_serv_desde = "20120101";
                    //f.fDetallefcha_serv_hasta = "20120101";
                    //f.fDetallefcha_vence_pago = ahora.ToString("yyyyMMdd");
                    //f.fDetalleImp_neto = 100;
                    //f.fDetalleImp_total = 120;

                    //f.fDetallefcha_cbte = ahora.ToString("yyyyMMdd");
                    //f.fDetalleNro_doc = "33708293739";
                    //f.fDetalleTipo_doc = WSAFIPf.Factura.TipoDocumento.CUIT;

                    //var result = f.Registrar(1, WSAFIPf.Factura.TipoComprobante.FacturaA, "1");

                    //Console.WriteLine("Cae:  "+f.fRespuestaDetalleCae);
                    //Console.WriteLine("Respuesta:  " + f.fRespuestaResultado);
                    //Console.ReadLine();

                    f.F1CabeceraCantReg = 1;
                    f.F1CabeceraPtoVta = 4;
                    f.F1CabeceraCbteTipo = 1;


                    f.f1Indice = 0;
                    f.F1DetalleConcepto = 1;
                    f.F1DetalleDocTipo = 80;
                    f.F1DetalleDocNro = "33708293749";
                    f.F1DetalleCbteDesde = 1;
                    f.F1DetalleCbteHasta = 1;
                    f.F1DetalleCbteFch = DateTime.Now.ToString("yyyyMMdd");
                    f.F1DetalleImpTotal = 184.05;
                    f.F1DetalleImpTotalConc = 0;
                    f.F1DetalleImpNeto = 150;
                    f.F1DetalleImpOpEx = 0;
                    f.F1DetalleImpTrib = 7.8;
                    f.F1DetalleImpIva = 26.25;
                    //f.F1DetalleFchServDesde = "20101018";
                    //f.F1DetalleFchServHasta = "20101018";
                    //f.F1DetalleFchVtoPago = "20101018";
                    f.F1DetalleMonId = "PES";
                    f.F1DetalleMonCotiz = 1;


                    f.F1DetalleTributoItemCantidad = 1;
                    f.f1IndiceItem = 0;
                    f.F1DetalleTributoId = 3;
                    f.F1DetalleTributoDesc = "Impuesto Municipal Matanza";
                    f.F1DetalleTributoBaseImp = 150;
                    f.F1DetalleTributoAlic = 5.2;
                    f.F1DetalleTributoImporte = 7.8;


                    f.F1DetalleIvaItemCantidad = 2;
                    f.f1IndiceItem = 0;
                    f.F1DetalleIvaId = 5;
                    f.F1DetalleIvaBaseImp = 100;
                    f.F1DetalleIvaImporte = 21;


                    f.f1IndiceItem = 1;
                    f.F1DetalleIvaId = 4;
                    f.F1DetalleIvaBaseImp = 50;
                    f.F1DetalleIvaImporte = 5.25;




                    f.F1DetalleCbtesAsocItemCantidad = 0;
                    f.F1DetalleOpcionalItemCantidad = 0;


                    f.ArchivoXMLRecibido = "c:\recibido.xml";
                    //f.ArchivoXMLEnviado = "c:\enviado.xml";


                    bool lResultado = f.F1CAESolicitar();
      
                    if(lResultado )
                    {
                        Console.WriteLine("resultado método: verdadero");
                    }
                    else
                    {
                        Console.WriteLine("resultado método: falso");
                    }
                    Console.WriteLine("resultado global AFIP: " + f.F1RespuestaResultado);
                    Console.WriteLine("es reproceso? " + f.F1RespuestaReProceso);
                    Console.WriteLine("registros procesados por AFIP: " + f.F1RespuestaCantidadReg.ToString());
                Console.WriteLine("error genérico global:" + f.f1ErrorMsg1);
      
                if(f.F1RespuestaCantidadReg > 0 )
                {
                    f.f1Indice = 0;
                    Console.WriteLine("resultado detallado comprobante: " + f.F1RespuestaDetalleResultado);
                    Console.WriteLine("cae comprobante: " + f.F1RespuestaDetalleCae);
                    Console.WriteLine("número comprobante:" + f.F1RespuestaDetalleCbteDesdeS);
                    Console.WriteLine("error detallado comprobante: " + f.F1RespuestaDetalleObservacionMsg1);
                }

                    Console.ReadLine();
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
