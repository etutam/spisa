using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Data;
using System.Xml;

using System.Configuration;

namespace SPISA.Libreria
{
    public class Cotizacion
    {
        #region Campos Privados
        Decimal valorDolarCompra = 1;
        Decimal valorDolarVenta = 1;
        #endregion

        #region Propiedades
        public Decimal DolarCompra
        {
            get { return valorDolarCompra; }
        }
        public Decimal DolarVenta
        {
            get { return valorDolarVenta; }
        }
        #endregion

        #region Constructores
        public Cotizacion()
        {
            ScanUrl("http://www.midolar.com.ar/dolar.xml");
        }
        #endregion

        #region Metodos Publicos
        public void ScanUrl(object str)
        {
            string s = str.ToString();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(s);
            request.Method = "GET";
            IAsyncResult asyncresult = request.BeginGetResponse(new AsyncCallback(EndScan), request);
        }
        public void EndScan(IAsyncResult result)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream stream = null;
            StreamReader streamReader = null;

            try
            {
                request = (HttpWebRequest)result.AsyncState;
                response = (HttpWebResponse)request.EndGetResponse(result);
                stream = response.GetResponseStream();
                streamReader = new StreamReader(stream);
                string feedData = streamReader.ReadToEnd();
                response.Close();
                stream.Close();
                streamReader.Close();

                DataSet ds = GetDataSetFromStream(feedData);
                GetDolarFromDataSet(ds);

                Logger.Append("Obtencion Valor Dolar", null, "ValorDolarCompra=" + valorDolarCompra.ToString() + "ValorDolarVenta=" + valorDolarVenta.ToString());
            }


            catch (Exception ex)
            {
                
            }

        }
        #endregion

        #region Metodos Privados
        private void GetDolarFromDataSet(DataSet ds)
        {
            AppSettingsReader reader = new AppSettingsReader();
            valorDolarCompra = Convert.ToDecimal(ds.Tables[0].Rows[0]["VALORCOMPRA"].ToString().Replace(',', Utils.GetDecimalSeparator()));
            valorDolarVenta = Convert.ToDecimal(ds.Tables[0].Rows[0]["VALORVENTA"].ToString().Replace(',', Utils.GetDecimalSeparator())) + Convert.ToDecimal(reader.GetValue("CantidadCentesimosAlDolar", typeof(decimal))) / 100;
        }
        private DataSet GetDataSetFromStream(string feedData)
        {
            DataSet ds = new DataSet();
            XmlTextReader xmlRdr = new XmlTextReader(new StringReader(feedData));
            ds.ReadXml(xmlRdr);

            return ds;
        }
        #endregion
    }
}
