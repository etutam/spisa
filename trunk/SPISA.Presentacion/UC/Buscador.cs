using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;

using SPISA.Libreria;
namespace SPISA.Presentacion
{
    public partial class Buscador : BaseControl
    {
        #region Campos Privados
        private string _tableName = "";
        private UltraGrid _grid;
        private DataTable _tableColumns; 

        #endregion

        #region Constructores
        public Buscador()
        {
            InitializeComponent();
        }
        #endregion 

        #region Propiedades

        public string Table
        {
            get
            {
                return _tableName;
            }
            set
            {
                _tableName = value;
            }
        }
        #endregion 

        #region Metodos Publicos
        public void Inicializar()
        {
            DataSet ds = Utils.GetTableColumns(_tableName);

            if (ds != null)
            {
                CambiarColumnasForaneas(ds);

                ddCampos.DataSource = ds.Tables[0];
                ddCampos.DataBind();

                this._tableColumns = ds.Tables[0];
            }
        }

        public DataSet EjecutarBusqueda()
        {
            if (!Validar())
            {
                MessageBox.Show("Error en la consulta. Revise e intente nuevamente.", "Error en la consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string query = "";

            string columnsToSelect = "";
            string joins = "";
            string whereClause = "";

            foreach (UltraGridRow gr in ddCampos.Rows)
            {
                if (gr.Cells["TablaABuscar"].Text == "")
                {
                    columnsToSelect += _tableName + "." + gr.Cells["Columna"].Text + ",";
                }
                else
                {
                    string _tableToJoinWith = gr.Cells["TablaABuscar"].Text;
                    string _columnToGetDataFrom = gr.Cells["Columna"].Text;
                    string _joinByColumn = gr.Cells["ColumnaABuscar"].Text;
                    string _queryPersonalizada = gr.Cells["QueryPersonalizada"].Text;
                    string _nombreColumna = gr.Cells["NombreColumna"].Text;
                    bool _columnaPersonalizada = Convert.ToBoolean(gr.Cells["ColumnaPersonalizada"].Text);

                    if (gr.Cells["QueryPersonalizada"].Text == "")
                    {
                        columnsToSelect += _tableToJoinWith + "." + _columnToGetDataFrom + (_nombreColumna!=""?" as " + _nombreColumna : "") + ",";
                        joins += " INNER JOIN " + _tableToJoinWith + " " + _tableToJoinWith + " on " + _tableToJoinWith + "." + _joinByColumn + "=" + _tableName + "." + _joinByColumn;
                    }
                    else
                    {
                        columnsToSelect += (_columnaPersonalizada ? _joinByColumn : _tableToJoinWith + "." + _columnToGetDataFrom + (_nombreColumna!=""?" as " + _nombreColumna : "") ) + ",";
                        joins += " " + _queryPersonalizada;
                    }
                }
            }

            columnsToSelect = columnsToSelect.Remove(columnsToSelect.Length - 1);


            foreach (UltraGridRow r in grBuscador.Rows)
            {
                string andOr = r.Cells["And/Or"].Text;
                
                UltraGridRow selectedField = ddCampos.SelectedRow;
                string criteria = r.Cells["Criterio"].Text;
                bool not = Convert.ToBoolean(r.Cells["Negado"].Text);
                string value = r.Cells["Valor"].Text;
                bool active = Convert.ToBoolean(r.Cells["Activo"].Text);

                if (r.Index == 0) andOr = "";

                if (r.Cells["TablaABuscar"].Text == "")
                {
                    whereClause += andOr + " " +_tableName + "." + r.Cells["Campo"].Text + " " + criteria + " '" + value + "' ";
                }
                else
                {
                    if (r.Cells["ColumnaPersonalizada"].Text != "1")
                    {
                        whereClause += andOr + " " +    r.Cells["TablaABuscar"].Text + "." + r.Cells["ColumnaABuscar"].Text + " in (select " + r.Cells["ColumnaABuscar"].Text + " FROM " + r.Cells["TablaABuscar"].Text + " WHERE " + r.Cells["Columna"].Text + " " + criteria + " '" + value + "') " ;
                    }
                }
            }
           
            query = "SELECT " + columnsToSelect + " FROM " + _tableName + " " + joins + " WHERE " + whereClause;

            return Utils.ExecuteDataSet(query);
        }

        private bool Validar()
        {
            bool validacion = true;

            foreach (UltraGridRow r in grBuscador.Rows)
            {
                if (validacion != false)
                {
                    if (r.Cells["And/Or"].Text != "AND" && r.Cells["And/Or"].Text != "OR")
                    {
                        if (r.Index!=0)
                            validacion = false;
                    }

                    bool fieldFound = false;
                    foreach (UltraGridRow gr in ddCampos.Rows)
                    {
                        if (gr.Cells["Columna"].Text == r.Cells["Campo"].Text) fieldFound = true;
                    }

                    if (!fieldFound)
                    {
                        validacion = false;
                    }

                    bool criteriaFound = false;
                    foreach (UltraGridRow gr in ddCriterios.Rows)
                    {
                        if (gr.Cells["Criterio"].Text == r.Cells["Criterio"].Text) criteriaFound = true;
                    }

                    if (!criteriaFound)
                    {
                        validacion = false;
                    }

                    if (r.Cells["Valor"].Text == "")
                    {
                        validacion = false;
                    }
                }
            }

            return validacion;
        }
        #endregion

        #region Metodos Privados
        private void Buscador_Resize(object sender, EventArgs e)
        {
            grBuscador.Width = this.Width;
            grBuscador.Height = this.Height;
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            
                        
        }

        private void CambiarColumnasForaneas(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["ColumnaABuscar"] != DBNull.Value)
                {
                    string swap = dr["ColumnaABuscar"].ToString();
                    dr["ColumnaABuscar"] = dr["Columna"];
                    dr["Columna"] = swap;
                }
            }
        }

        private void grBuscador_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            
            if (e.Cell.Column.ToString() == "Campo")
            {
                string tipoDeDato="";
                string sqlQuery;
                /* Cargamos el listado de Criterios */
                
                sqlQuery = "SELECT Criterio FROM Buscador_Criterios WHERE TipoDeDato='" + (tipoDeDato == "varchar" ? tipoDeDato : "other") + "'";
                ddCriterios.DataSource = Utils.ExecuteDataSet(sqlQuery);
                ddCriterios.DataBind();
                
                e.Cell.Row.Cells["Criterio"].ValueList = ddCriterios;

                /* Cargamos el listado de posibles valores si los hay */
                if (ddCampos.SelectedRow != null)
                {
                    if (ddCampos.SelectedRow.Cells["TablaABuscar"].Text != "")
                    {
                        tipoDeDato = ddCampos.SelectedRow.Cells["TipoDeDatoRelacion"].Text;
                        sqlQuery = "SELECT " + ddCampos.SelectedRow.Cells["Columna"].Text +
                                    " FROM " + ddCampos.SelectedRow.Cells["TablaABuscar"].Text;

                        ddValores.DataSource = Utils.ExecuteDataSet(sqlQuery);
                        ddValores.DataBind();

                        e.Cell.Row.Cells["TablaABuscar"].Value = ddCampos.SelectedRow.Cells["TablaABuscar"].Text;
                        e.Cell.Row.Cells["ColumnaABuscar"].Value = ddCampos.SelectedRow.Cells["ColumnaABuscar"].Text;
                        e.Cell.Row.Cells["Columna"].Value = ddCampos.SelectedRow.Cells["Columna"].Text;
                        e.Cell.Row.Cells["QueryPersonalizada"].Value = ddCampos.SelectedRow.Cells["QueryPersonalizada"].Text;
                        e.Cell.Row.Cells["ColumnaPersonalizada"].Value = ddCampos.SelectedRow.Cells["ColumnaPersonalizada"].Text;
                        e.Cell.Row.Cells["Valor"].ValueList = ddValores;
                    }
                    else
                    {
                        e.Cell.Row.Cells["TablaABuscar"].Value = "";
                        e.Cell.Row.Cells["ColumnaABuscar"].Value = "";
                        e.Cell.Row.Cells["Columna"].Value = "";
                        e.Cell.Row.Cells["QueryPersonalizada"].Value = "";
                        e.Cell.Row.Cells["ColumnaPersonalizada"].Value = "";

                        tipoDeDato = ddCampos.SelectedRow.Cells["TipoDeDato"].Text;
                        e.Cell.Row.Cells["Valor"].ValueList = null;
                    }
                }

                /* Cambiamos el tipo de control visible en el campo Valor */

                if (tipoDeDato == "datetime")
                {
                    e.Cell.Row.Cells["Valor"].EditorControl = igDateTime;
                }
                else if (tipoDeDato == "int")
                {
                    e.Cell.Row.Cells["Valor"].EditorControl = igInteger;
                }
                else if (tipoDeDato == "decimal")
                {
                    e.Cell.Row.Cells["Valor"].EditorControl = igDecimal;
                }
                else if (tipoDeDato == "bit")
                {
                    e.Cell.Row.Cells["Valor"].EditorControl = igBit;
                }
                else
                {
                    e.Cell.Row.Cells["Valor"].EditorControl = null;
                }
            }
        }
        #endregion

    }
}
