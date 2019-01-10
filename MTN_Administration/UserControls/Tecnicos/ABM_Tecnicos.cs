using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;

namespace MTN_Administration
{
    public partial class ABM_Tecnicos : UserControl
    {
        private APIHelper aPIHelper;
        private List<Tecnico> listaTecnicos;
        private Alta_Tecnico alta_Tecnico;

        private FiltosTecnicos filtroSeleccionado;

        public ABM_Tecnicos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTable();
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public void RefreshTable()
        {
            listaTecnicos = aPIHelper.GetTecnicosHelper().GetTecnicos();
            RefreshTable(filtroSeleccionado);
            RefreshTable(textBuscarTecnico.Text);
        }


        


        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="str"></param>        
        public void RefreshTable(string str)
        {
            tablaTecnicos.Rows.Clear();

            foreach (Tecnico tecnico in listaTecnicos)
            {
                if (tecnico.Nombre.ToUpper().Contains(str.ToUpper()) || tecnico.Apellido.ToUpper().Contains(str.ToUpper()))
                {
                  
                        if ((int)filtroSeleccionado == 0)
                        {
                            AddItem(tecnico);
                        }
                        else if ((int)filtroSeleccionado == tecnico.Id_tipo_empleado)
                            AddItem(tecnico);
                  
                }
            }
            tablaTecnicos.Refresh();
        }


        private enum FiltosTecnicos{
            todos, jefes, supervisores, lideres, analistas
            }

        private void RefreshTable(FiltosTecnicos filtro)
        {
            RefreshTable(textBuscarTecnico.Text);
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
            filtroSeleccionado = FiltosTecnicos.todos;
            RefreshTable(FiltosTecnicos.todos);
        }

        private void FiltroJefes_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.jefes;
            RefreshTable(FiltosTecnicos.jefes);
        }


        private void FiltroSupervisores_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.supervisores;
            RefreshTable(FiltosTecnicos.supervisores);
        }

        private void FiltroLideres_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.lideres;
            RefreshTable(FiltosTecnicos.lideres);
        }

        private void FiltroAnalistas_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.analistas;
            RefreshTable(FiltosTecnicos.analistas);
        }

        private void textBuscarTecnico_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(textBuscarTecnico.Text);
        }

        private void BotonEliminarTecnico_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;
            aPIHelper.GetTecnicosHelper().RemoveTecnico(id_tecnico);
            RefreshTable();
        }

        private void ButtonAgregarTecnico_Click(object sender, EventArgs e)
        {
            // 
            // alta_Tecnico1
            // 
            this.alta_Tecnico = new Alta_Tecnico(aPIHelper);
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
