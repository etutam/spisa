using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Configuration;

using SPISA.Libreria;
using System.Globalization;

namespace MigrateTool
{
    class Program
    {
        private static void CargarClientes()
        {
            AppSettingsReader appSettingsReader = new AppSettingsReader();
            string ClientesDataBaseFile = Convert.ToString(appSettingsReader.GetValue("ClientesDataBaseFile", typeof(String)));

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ClientesDataBaseFile + ";");
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Clientes", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente c = Cliente.TraerClientePorRazonSocial(dr["Nombre"].ToString());

                if (c != null)
                {
                    c.Codigo = Convert.ToInt32(dr["Número"].ToString());
                    c.Domicilio = dr["Domicilio"].ToString();
                    c.Localidad = dr["Localidad"].ToString();
                    c.Provincia = Provincia.TraerProvinciaPorNombre(dr["Provincia"].ToString());
                    if (c.Provincia == null) c.Provincia = Provincia.TraerProvinciaPorId(1);

                    c.IVA = CondicionIVA.TraerCondicionIVAPorId(1);
                    c.CUIT = Utils.RemoveCharacterAndSpaces('-', dr["CUIT"].ToString());
                    c.Operatoria = Operatoria.TraerOperatoriaPorId(1);

                    c.Actualizar();
                }
            }

        }
        private static void CargarMateriales()
        {
            AppSettingsReader appSettingsReader = new AppSettingsReader();
            string MaterialesDataBaseFile = Convert.ToString(appSettingsReader.GetValue("MaterialesDataBaseFile", typeof(String)));

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + MaterialesDataBaseFile + ";");
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Materiales", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Articulo a = new Articulo();

                a.Codigo = dr["Código"].ToString();
                a.Descripcion = dr["Descripción"].ToString();
                a.Cantidad = Convert.ToDecimal((dr["Cantidad"].ToString()!="" ? dr["Cantidad"].ToString() : "0"));

                string decimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
                
                a.PrecioUnitario = Convert.ToDecimal(dr["Precio Unitario"].ToString().Replace('.',decimalSeparator[0]));

                if (a.Descripcion.Contains("rida")) a.Categoria = Categoria.TraerCategoriaPorDescripcion("Bridas");
                else if (a.Descripcion.Contains("rragos")) a.Categoria = Categoria.TraerCategoriaPorDescripcion("Espárragos");
                else if (a.Descripcion.Contains("lvula")) a.Categoria = Categoria.TraerCategoriaPorDescripcion("Válvulas");
                else  a.Categoria = Categoria.TraerCategoriaPorDescripcion("Accesorios");

                a.Guardar();

            }

        }
        static void Main(string[] args)
        {
            CargarClientes();
            
        }
    }
}
