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
    public partial class ABM_Tecnicos : UserControl
    {
        private APIHelper aPIHelper;
        private List<Tecnico> listaTecnicos;

        public ABM_Tecnicos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTable(0);
        }

        /// <summary>
        /// Se utiliza sobrecarga de metodo para refrescar la tabla de empleados 
        /// </summary>
        /// <returns></returns>
        public void RefreshTable()
        {
            tablaTecnicos.Rows.Clear();
            tablaTecnicos.Refresh();
            listaTecnicos = aPIHelper.GetTecnicosHelper().GetTecnicos();
        }

        public void RefreshTable(string s)
        {
            RefreshTable();
            foreach (Tecnico tecnico in listaTecnicos)
            {
                if (tecnico.Nombre.ToUpper().Contains(s.ToUpper()) || tecnico.Apellido.ToUpper().Contains(s.ToUpper()))
                {
                    AddItem(tecnico);
                }
            }
        }

        public void RefreshTable(int i)
        {
            RefreshTable();
            foreach (Tecnico tecnico in listaTecnicos)
            {
                if (i == 0)
                {
                    AddItem(tecnico);
                }
                else if (i == tecnico.Id_tipo_empleado)
                    AddItem(tecnico);
            }
        }


        private void AddItem(Tecnico tecnico)
        {

            tablaTecnicos.Rows.Add();
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["id"].Value = tecnico.Id;
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["apellido"].Value = tecnico.Apellido;
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["nombre"].Value = tecnico.Nombre;
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["legajo"].Value = tecnico.Legajo;
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["direccion"].Value = tecnico.Direccion;
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["localidad"].Value = aPIHelper.GetNombreLocalidad(tecnico.Id_localidad);
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["provincia"].Value = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(tecnico.Id_localidad));
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["tipo_empleado"].Value = aPIHelper.GetTipoEmpleado(tecnico.Id_tipo_empleado);
        }


        private void MoverSlider(object sender)
        {
            sliderFiltroTecnicos.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroTecnicos.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
        }


        private void FiltroTodosTecnicos_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            RefreshTable(0);
        }

        private void FiltroJefes_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            RefreshTable(1);
        }


        private void FiltroSupervisores_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            RefreshTable(2);
        }

        private void FiltroLideres_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            RefreshTable(3);
        }

        private void FiltroAnalistas_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            RefreshTable(4);
        }

        private void TextBuscarTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            sliderFiltroTecnicos.Left = textBuscarTecnico.Left;
            sliderFiltroTecnicos.Width = textBuscarTecnico.Width;
            RefreshTable(textBuscarTecnico.Text);
        }

        private void BotonEliminarTecnico_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;
            aPIHelper.GetTecnicosHelper().RemoveTecnico(id_tecnico);
            RefreshTable(0);
        }


        private Alta_Tecnico alta_Tecnico;

        private void ButtonAgregarTecnico_Click(object sender, EventArgs e)
        {
            // 
            // alta_Tecnico1
            // 
            this.alta_Tecnico = new Alta_Tecnico(aPIHelper);
            this.alta_Tecnico.BackColor = System.Drawing.Color.Gainsboro;
            this.alta_Tecnico.Location = new System.Drawing.Point(0, 0);
            this.alta_Tecnico.Name = "alta_Tecnico1";
            this.alta_Tecnico.Size = new System.Drawing.Size(727, 561);
            this.alta_Tecnico.TabIndex = 6;
            this.Controls.Add(this.alta_Tecnico);
            alta_Tecnico.AgregarNuevo();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;

            Tecnico tecnico = aPIHelper.GetTecnicosHelper().GetTecnico(id_tecnico);
            ButtonAgregarTecnico_Click(sender, e);
            alta_Tecnico.Cargar(tecnico);
        }

        private void TablaTecnicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditar_Click(sender, e);
        }

    }
}
