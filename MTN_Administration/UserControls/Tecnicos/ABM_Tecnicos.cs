using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;

namespace MTN_Administration
{
    /// <summary>
    /// Intefaz de Administracion de Tecnicos
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ABM_Tecnicos : UserControl
    {
        private APIHelper aPIHelper;
        private List<Tecnico> listaTecnicos;
        private Alta_Tecnico alta_Tecnico;

        private FiltosTecnicos filtroSeleccionado;

        /// <summary>
        /// Initializes a new instance of the <see cref="ABM_Tecnicos"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public ABM_Tecnicos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTable();
        }

        /// <summary>
        ///  refresca la lista de tecnicos y refresca la tabla
        /// 
        /// </summary>
        public void RefreshTable()
        {
            listaTecnicos = aPIHelper.GetTecnicosHelper().GetTecnicos();

            RefreshTable(textBuscarTecnico.Text);
        }

        /// <summary>
        /// Refresca la tabla de tecnicos aplicando los filtros y busquedas correspondintes 
        /// </summary>
        /// <param name="str"></param>        
        public void RefreshTable(string str)
        {
            tablaTecnicos.Rows.Clear();


            // Para cada tecnico de la lista filtra por nombre o apellido segun el cuadro de busqueda
            // Filtra segun el tipo de empleado
            foreach (Tecnico tecnico in listaTecnicos)
            {
                if ((tecnico.Nombre.ToUpper().Contains(str.ToUpper()) || tecnico.Apellido.ToUpper().Contains(str.ToUpper())) &&
                    ((int)filtroSeleccionado == 0 || (int)filtroSeleccionado == tecnico.Id_tipo_empleado)
                    )
                {
                    AddItem(tecnico);
                }
            }
            tablaTecnicos.Refresh();
        }

        private enum FiltosTecnicos
        {
            todos = 0,
            jefes = 1,
            supervisores = 2,
            lideres = 3,
            analistas = 4
        }


        /// <summary>
        /// Agrega una nueva fila con un tecnico a la tabla de tecnicos
        /// </summary>
        /// <param name="tecnico">The tecnico.</param>
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
            tablaTecnicos.Rows[tablaTecnicos.Rows.Count - 1].Cells["tipo_empleado"].Value = (TypeEmpleado)tecnico.Id_tipo_empleado;

        }

        /// <summary>
        /// Mueve la barra de seleccion de filtro al filtro seleccionado
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void MoverSlider(object sender)
        {
            sliderFiltroTecnicos.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroTecnicos.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
        }

        /// <summary>
        /// Handles the Click event of the FiltroTodosTecnicos control.
        /// Selecciona el filtro todos y refresca la tabla
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FiltroTodosTecnicos_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.todos;
            RefreshTable(textBuscarTecnico.Text);
        }

        /// <summary>
        /// Handles the Click event of the FiltroJefes control.
        /// Selecciona el filtro jefes y refresca la tabla
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FiltroJefes_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.jefes;
            RefreshTable(textBuscarTecnico.Text);
        }


        /// <summary>
        /// Handles the Click event of the FiltroSupervisores control.
        /// Selecciona el filtro Supervisores y refresca la tabla
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FiltroSupervisores_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.supervisores;
            RefreshTable(textBuscarTecnico.Text);
        }


        /// <summary>
        /// Handles the Click event of the FiltroLideres control.
        /// Selecciona el filtro Lideres y refresca la tabla
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FiltroLideres_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.lideres;
            RefreshTable(textBuscarTecnico.Text);
        }

        /// <summary>
        /// Handles the Click event of the FiltroAnalistas control.
        /// Selecciona el filtro Analistas y refresca la tabla
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FiltroAnalistas_Click(object sender, EventArgs e)
        {
            MoverSlider(sender);
            filtroSeleccionado = FiltosTecnicos.analistas;
            RefreshTable(textBuscarTecnico.Text);
        }


        /// <summary>
        /// Handles the OnValueChanged event of the textBuscarTecnico control.
        /// Cuando el texto del cuadro de busqueda refresca el contenido de la tabla
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBuscarTecnico_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(textBuscarTecnico.Text);
        }


        /// <summary>
        /// Handles the Click event of the BotonEliminarTecnico control.
        /// Solitita confirmacion, elimina el tecnico seleccionado de la base de datos y muestra el resultado
        /// de la operacion como una notificacion
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonEliminarTecnico_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar el tecnico", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MensajeAlerta resultado = aPIHelper.GetTecnicosHelper().RemoveTecnico(TecnicoSeleccionado());
                Alert.ShowAlert(resultado);
                RefreshTable();
            }
        }

        private Tecnico TecnicoSeleccionado()
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;
            return aPIHelper.GetTecnicosHelper().GetTecnico(id_tecnico);
        }


        /// <summary>
        /// Handles the Click event of the ButtonAgregarTecnico control.
        /// Muestra la interfaz para dar de alta un nuevo tecnico
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        }


        /// <summary>
        /// Handles the Click event of the ButtonEditar control.
        /// Muestra la interfaz Alta Tecnico, con los datos del tecnico seleccionado para modificar
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaTecnicos.SelectedRows;
            int id_tecnico = (int)selectedRow[0].Cells["id"].Value;

            Tecnico tecnico = aPIHelper.GetTecnicosHelper().GetTecnico(id_tecnico);
            ButtonAgregarTecnico_Click(sender, e);
            alta_Tecnico.Cargar(tecnico);
        }


        /// <summary>
        /// Handles the CellDoubleClick event of the TablaTecnicos control.
        /// Muestra la interfaz Alta Tecnico, con los datos del tecnico seleccionado para modificar
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaTecnicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditar_Click(sender, e);
        }

    }
}
