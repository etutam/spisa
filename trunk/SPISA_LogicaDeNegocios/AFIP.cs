using System;
using System.Collections.Generic;
using System.Text;

namespace SPISA.Libreria
{
    public class Afip
    {
        public virtual long Cae { get; set; }

        public virtual bool CaeValido { get; set; }

        public virtual List<string> Resultados { get; set; }

        public virtual List<string> Errores { get; set; }

        public virtual void Registrar(Factura datosFactura, Cliente datosCliente,Factura.Totales totales )
        {

            var f = new WSAFIPFE.Factura();
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
                    f.F1CabeceraPtoVta = 1;
                    f.F1CabeceraCbteTipo = 1;


                    f.f1Indice = 0;
                    f.F1DetalleConcepto = 1;
                    f.F1DetalleDocTipo = 80;
                    f.F1DetalleDocNro = datosCliente.CUIT;
                    f.F1DetalleCbteDesde = f.F1CompUltimoAutorizado(1,1) + 1;
                    f.F1DetalleCbteHasta = f.F1CompUltimoAutorizado(1,1) + 1;
                     Resultados.Add(f.F1CompUltimoAutorizado(1,1).ToString());
                    //Console.ReadLine();
                    f.F1DetalleCbteFch = datosFactura.Fecha.ToString("yyyMMdd");
                    f.F1DetalleImpTotal = Convert.ToDouble(totales.SubTotal2);
                    f.F1DetalleImpTotalConc = 0;
                    f.F1DetalleImpNeto = Convert.ToDouble(totales.SubTotal2);
                    f.F1DetalleImpOpEx = 0;
                    f.F1DetalleImpTrib = 0;
                    f.F1DetalleImpIva = Convert.ToDouble(totales.IvaInscripto);
                    //f.F1DetalleFchServDesde = "20101018";
                    //f.F1DetalleFchServHasta = "20101018";
                    //f.F1DetalleFchVtoPago = "20101018";
                    f.F1DetalleMonId = "PES";
                    f.F1DetalleMonCotiz = 1;


                    //f.F1DetalleTributoItemCantidad = 1;
                    //f.f1IndiceItem = 0;
                    //f.F1DetalleTributoId = 3;
                    //f.F1DetalleTributoDesc = "Impuesto Municipal Matanza";
                    //f.F1DetalleTributoBaseImp = 150;
                    //f.F1DetalleTributoAlic = 5.2;
                    //f.F1DetalleTributoImporte = 7.8;


                    //f.F1DetalleIvaItemCantidad = 2;
                    //f.f1IndiceItem = 0;
                    //f.F1DetalleIvaId = 5;
                    //f.F1DetalleIvaBaseImp = 100;
                    //f.F1DetalleIvaImporte = 21;


                    //f.f1IndiceItem = 1;
                    //f.F1DetalleIvaId = 4;
                    //f.F1DetalleIvaBaseImp = 50;
                    //f.F1DetalleIvaImporte = 5.25;




                    //f.F1DetalleCbtesAsocItemCantidad = 0;
                    //f.F1DetalleOpcionalItemCantidad = 0;


                    //f.ArchivoXMLRecibido = "c:\recibido.xml";
                    //f.ArchivoXMLEnviado = "c:\enviado.xml";


                    this.CaeValido = f.F1CAESolicitar();

                    Resultados.Add("resultado global AFIP: " + f.F1RespuestaResultado);
                    Resultados.Add("es reproceso? " + f.F1RespuestaReProceso);
                    Resultados.Add("registros procesados por AFIP: " + f.F1RespuestaCantidadReg.ToString());
                    Errores.Add("error genérico global:" + f.f1ErrorMsg1);

                    if (f.F1RespuestaCantidadReg > 0)
                    {
                        f.f1Indice = 0;
                        Resultados.Add("resultado detallado comprobante: " + f.F1RespuestaDetalleResultado);
                        Resultados.Add("cae comprobante: " + f.F1RespuestaDetalleCae);
                        Resultados.Add("número comprobante:" + f.F1RespuestaDetalleCbteDesdeS);
                        Errores.Add("error detallado comprobante: " + f.F1RespuestaDetalleObservacionMsg1);
                    }

                 
                }
                else
                {
                    Errores.Add("Error numero: "+ f.UltimoNumeroError + "  Error Mensaje:  " +f.UltimoMensajeError);
                    
                }
            }
        }
    }
}
