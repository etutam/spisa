using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows;

using System.Configuration;

namespace SPISA.Libreria
{
    public class Printing
    {

        public class ObjetoAImprimir
        {
            string _textToPrint;
            float _x;
            float _y;

            public ObjetoAImprimir(string texto, float x, float y)
            {
                this._textToPrint = texto;
                this._x = x;
                this._y = y;
            }
            public string Texto
            {
                get
                {
                    return _textToPrint;
                }
                set
                {
                    _textToPrint = value;
                }
            }

            public float X
            {
                get
                {
                    return _x;
                }
                set
                {
                    _x = value;
                }
            }

            public float Y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }
        }

        #region Campos Privados
        IList<ObjetoAImprimir> _objetosAImprimir;
        #endregion

        #region Constructores
        public Printing()
        {
            _objetosAImprimir = new List<ObjetoAImprimir>();
        }
        #endregion

        #region Metodos Publicos
        public bool Imprimir(short numeroCopias)
        {
            bool ret = true;

            AppSettingsReader reader = new AppSettingsReader();
            if (Convert.ToBoolean(reader.GetValue("ModoPrueba", typeof(string))) == true) return ret;

            try
            {
                System.Windows.Forms.PrintDialog pd = new System.Windows.Forms.PrintDialog();

                pd.PrinterSettings.Copies = numeroCopias;

                if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.Drawing.Printing.PrintDocument a = new System.Drawing.Printing.PrintDocument();
                    a.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);

                    a.PrinterSettings = pd.PrinterSettings;
                    a.Print();

                    Logger.Append("Imprimir", null, "");
                }
                else
                {
                    ret = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }


        #endregion

        #region Propiedades
        public IList<ObjetoAImprimir> Objetos
        {
            get { return _objetosAImprimir; }
            set { _objetosAImprimir = value; }
        }
        #endregion

        #region Eventos
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            foreach (ObjetoAImprimir o in _objetosAImprimir)
            {
                e.Graphics.DrawString(o.Texto, new Font("Courier New", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, new PointF(o.X, o.Y));
            }
        }
        #endregion


    }


}
