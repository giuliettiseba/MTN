using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTN_RestAPI.Models;

namespace MTN_Administration
{
    public partial class AMB_Tecnicos : UserControl
    {
        private APIHelper aPIHelper;

        public AMB_Tecnicos()
        {

            if (!this.DesignMode)
            {

                InitializeComponent();

                aPIHelper = new APIHelper();

                RefreshTable();
            }
        }

        internal APIHelper GetAPIHelper()
        {
            return aPIHelper;
        }

        public void RefreshTable()
        {
            tablaTecnicos.Rows.Clear();
            tablaTecnicos.Refresh();
            AddItemsTablaTecnicos(aPIHelper.GetTecnicos());
        }

        private void AddItemsTablaTecnicos(List<Tecnico> listaTecnicos)
        {
            foreach (Tecnico tecnico in listaTecnicos)
            {
                tablaTecnicos.Rows.Add();
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["id"].Value = tecnico.id;
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["apellido"].Value = tecnico.apellido;
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["nombre"].Value = tecnico.nombre;
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["legajo"].Value = tecnico.legajo;
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["direccion"].Value = tecnico.direccion;
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["localidad"].Value = aPIHelper.GetNombreLocalidad(tecnico.id_localidad);
                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["provincia"].Value =
                    aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(tecnico.id_localidad));



                tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["tipo_empleado"].Value = aPIHelper.GetTipoEmpleado(tecnico.id_tipo_empleado);
            }
        }

        private void FiltroTodosTecnicos_Click(object sender, EventArgs e)
        {
            sliderFiltroTecnicos.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroTecnicos.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;


        }

        private void FiltroSupervisores_Click(object sender, EventArgs e)
        {
            sliderFiltroTecnicos.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroTecnicos.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;


        }

        private void FiltroLideres_Click(object sender, EventArgs e)
        {
            sliderFiltroTecnicos.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroTecnicos.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

        }

        private void FiltroAnalistas_Click(object sender, EventArgs e)
        {
            sliderFiltroTecnicos.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroTecnicos.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
        }

        private void ButtonAgregarTecnico_Click(object sender, EventArgs e)
        {
            alta_Tecnico1.AgregarNuevo();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;
            Tecnico tecnico = aPIHelper.GetTecnico(id_tecnico);
            alta_Tecnico1.Cargar(tecnico);
        }

        private void TablaTecnicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditar_Click(sender, e);
        }

        private void BotonEliminarTecnico_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;
            aPIHelper.RemoveTecnico(id_tecnico);
            RefreshTable();
        }
    }
}
