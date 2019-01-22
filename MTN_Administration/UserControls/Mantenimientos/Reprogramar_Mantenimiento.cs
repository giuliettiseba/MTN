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
using MTN_Administration.Alerts;
using Bunifu.Framework.UI;

namespace MTN_Administration.Tabs
{
    /// <summary>
    /// Interfaz Reprogramar Mantenimiento
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Reprogramar_Mantenimiento : UserControl
    {
        private APIHelper aPIHelper;
        private Mantenimiento mantenimiento;

        public Reprogramar_Mantenimiento(APIHelper aPIHelper, Mantenimiento mantenimiento)
        {
            this.mantenimiento = mantenimiento;
            this.aPIHelper = aPIHelper;

            InitializeComponent();

            panel1.Visible = false;
            panel.Visible = true;
            panel.Location = new System.Drawing.Point(0, 0);
            panel1.Location = new System.Drawing.Point(0, 0);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.rangeHora.RangeMax = 36;
            this.rangeHora.RangeMin = 18;

            // Populate combobox de tecnicos
            List<Tecnico> listaTecnicos = aPIHelper.GetTecnicosHelper().GetTecnicos();
            comboBoxTecnico1.DataSource = new BindingSource(listaTecnicos, null);
            comboBoxTecnico1.DisplayMember = "ApellidoYNombre";
            comboBoxTecnico1.ValueMember = "id";
            comboBoxTecnico1.Enabled = false;
            comboBoxTecnico1.SelectedIndex = -1;

            comboBoxTecnico2.DataSource = new BindingSource(listaTecnicos, null);
            comboBoxTecnico2.DisplayMember = "ApellidoYNombre";
            comboBoxTecnico2.ValueMember = "id";
            comboBoxTecnico2.SelectedIndex = -1;
            comboBoxTecnico2.Enabled = false;

            comboBoxTipoMantenimiento.DataSource = Enum.GetValues(typeof(TypeTipoMantenimiento));

            BunifuRange1_RangeChanged(null, null); // revisar

            TextDetalles.Text = mantenimiento.Detalles;

            if (mantenimiento.Tecnico1 != 0)
            {
                checkBoxTecnico1.Checked = true;
                comboBoxTecnico1.SelectedValue = mantenimiento.Tecnico1;
                comboBoxTecnico1.Enabled = true;
                if (mantenimiento.Tecnico2 != 0)
                {
                    checkBoxTecnico2.Checked = true;
                    comboBoxTecnico2.SelectedValue = mantenimiento.Tecnico2;
                    comboBoxTecnico1.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Handles the RangeChanged event of the bunifuRange1 control.
        /// Convierte el tiempo seleccionado en horas y minutos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            textHoraInicio.Text = (rangeHora.RangeMin / 2).ToString();
            int minIni;
            minIni = (rangeHora.RangeMin % 2 == 1) ? 30 : 0;
            textMinutosInicio.Text = minIni.ToString();
            textHoraFin.Text = (rangeHora.RangeMax / 2).ToString();
            int minFin;
            minFin = (rangeHora.RangeMax % 2 == 1) ? 30 : 0;
            textMinutosFin.Text = minFin.ToString();
        }

        /// <summary>
        /// Handles the Click event of the buttonGuardar control.
        /// Guarda los cambios de la reprogramacion de un mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            mantenimiento.id_tipo_mantenimiento = (TypeTipoMantenimiento)comboBoxTipoMantenimiento.SelectedValue;
            mantenimiento.Fecha = datePicker.Value;
            mantenimiento.HoraInicio = new TimeSpan(Convert.ToInt16(textHoraInicio.Text), Convert.ToInt16(textMinutosInicio.Text), 0);
            mantenimiento.HoraFin = new TimeSpan(Convert.ToInt16(textHoraFin.Text), Convert.ToInt16(textMinutosFin.Text), 0);
            mantenimiento.Detalles = TextDetalles.Text;

            // si el checkbox del tecnico 1 el mantenimietno pasa a un estado de asignado
            if (checkBoxTecnico1.Checked)
            {
                mantenimiento.Tecnico1 = Convert.ToInt16(comboBoxTecnico1.SelectedValue);
                mantenimiento.Estado = TypeEstadoMantenimiento.Asignado;
                if (checkBoxTecnico2.Checked)
                {
                    mantenimiento.Tecnico2 = Convert.ToInt16(comboBoxTecnico2.SelectedValue);
                }
                else // si el checkbox del tecnico 2 no esta marcado elimina el tecnico del mantenimiento
                {
                    mantenimiento.Tecnico2 = 0;
                }
            }
            else// si el checkbox del tecnico 1 no esta marcado elimina el tecnico del mantenimiento y el mantenimiento pasa a estar abierto
            {
                mantenimiento.Tecnico1 = 0;
                mantenimiento.Estado = TypeEstadoMantenimiento.Abierto;
            }

            MensajeAlerta resultado = aPIHelper.GetMantenimientosHelper().AddManteniento(mantenimiento);
            Alert.ShowAlert(resultado);
            ((ABM_Mantenimientos)Parent).RefreshTabla();
            ((ABM_Mantenimientos)Parent).ShowPanelSwitchs();
            Dispose();
        }

        /// <summary>
        /// Handles the Click event of the BotonCancelar control.
        /// Cancela la reprogramacion de un mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).ShowPanelSwitchs();
            Dispose();
        }

        /// <summary>
        /// Handles the OnChange event of the CheckBoxTecnico2 control.
        /// Habilita y deshabilita el combobox del tecnico 2
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxTecnico2_OnChange(object sender, EventArgs e)
        {
            if (!checkBoxTecnico2.Checked)
            {
                comboBoxTecnico2.Enabled = false;
            }
            else comboBoxTecnico2.Enabled = true;

        }
        /// <summary>
        /// Handles the OnChange event of the CheckBoxTecnico1 control.
        /// Habilita y deshabilita el combobox del tecnico 1.
        /// El tecnico 2 no puede estar habilitado si el tecnico 1 no esta asignado
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxTecnico1_OnChange(object sender, EventArgs e)
        {
            if (checkBoxTecnico1.Checked)
            {
                comboBoxTecnico1.Enabled = true;
                checkBoxTecnico2.Enabled = true;
            }
            else
            {
                comboBoxTecnico1.Enabled = false;
                checkBoxTecnico2.Enabled = false;
                comboBoxTecnico2.Enabled = false;

                checkBoxTecnico2.Checked = false;
                comboBoxTecnico1.SelectedItem = -1;
                comboBoxTecnico2.SelectedItem = -1;
            }
        }

        ///// MODIFICAR LISTA DE INCIDENTES DE MANTENIMIENTO

        private List<Incidente> listaIncidentesAsignados;
        private List<Incidente> listaIncidentesSucursal;
        private List<Incidente> listaIncidentesNoAsignados;


        /// <summary>
        /// Muestra el panel para editar la lista de incidentes asignados a un mantenimiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditarListaIncidentes_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panel); // animacion

            // inicializa las listas temporales
            listaIncidentesSucursal = aPIHelper.GetIncidenteHelper().GetIncidentes(mantenimiento.Id_Cliente, mantenimiento.Id_Sucursal);
            listaIncidentesAsignados = new List<Incidente>(mantenimiento.Incidentes);
            listaIncidentesNoAsignados = new List<Incidente>();

            // Para cada incidente que esta en la lista de incidentes de la sucursal, pero no esta en la lista de incidentes asignados lo agrega a la lista de incidentes no asignados
            foreach (Incidente incidente in listaIncidentesSucursal)
            {
                if (listaIncidentesAsignados.FirstOrDefault(x => x.Id == incidente.Id) == null)
                    listaIncidentesNoAsignados.Add(incidente);
            }

            RefreshTables();
            panel1.Visible = true;

        }

        /// <summary>
        /// Refresca las tablas de incidentes asignados y no asignados
        /// </summary>
        private void RefreshTables()
        {
            tablaIncidentesAsignados.Rows.Clear();
            foreach (Incidente incidente in listaIncidentesAsignados)
            {
                AddRow(tablaIncidentesAsignados, incidente);
            }
            tablaIncidentesAsignados.Refresh();

            tablaIncidentesNoAsignados.Rows.Clear();
            foreach (Incidente incidente in listaIncidentesNoAsignados)
            {
                // no muestra incidentes resueltos, cancelados o en progreso
                if (incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Cancelado
    && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Progreso
    && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Resuelto
)
                    AddRow(tablaIncidentesNoAsignados, incidente);
            }
            tablaIncidentesNoAsignados.Refresh();
        }

        /// <summary>
        /// Agrega una un incidente a una tablaa una tabla .
        /// </summary>
        /// <param name="tabla">The tabla.</param>
        /// <param name="incidente">The incidente.</param>
        private void AddRow(BunifuCustomDataGrid tabla, Incidente incidente)
        {

            tabla.Rows.Add();
            DispositivoCCTV dispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1);
            Camara camara = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2);
            tabla.Rows[tabla.Rows.Count - 1].Cells[0].Value = incidente.Id;
            tabla.Rows[tabla.Rows.Count - 1].Cells[1].Value = incidente.Id_tipo_mantenible;
            tabla.Rows[tabla.Rows.Count - 1].Cells[2].Value = dispositivoCCTV.Nombre;
            if (incidente.Id_2 != 0)
                tabla.Rows[tabla.Rows.Count - 1].Cells[3].Value = camara.Nombre;
            else
                tabla.Rows[tabla.Rows.Count - 1].Cells[4].Value = (TypeCriticidad)incidente.Id_criticidad;
            tabla.Rows[tabla.Rows.Count - 1].Cells[5].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
        }


        /// <summary>
        /// Handles the CellDoubleClick event of the tablaIncidentesNoAsignados control.
        /// Cuando se hace doble click en un incidente no asignado se elimina de la lista de no asignados 
        /// y se agrega a la lista de asignados
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
         private void TablaIncidentesNoAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesNoAsignados.SelectedRows[0].Cells[0].Value);
            Incidente item = listaIncidentesNoAsignados.Find(x => x.Id == id_incidente_seleccionado);

            listaIncidentesNoAsignados.Remove(item);
            listaIncidentesAsignados.Add(item);
            RefreshTables();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the tablaIncidentesAsignados control.
        /// Cuando se hace doble click en un insidente asignado se elimina de la lista de asignados 
        /// y se agrega a la lista de no asignados
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaIncidentesAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesAsignados.SelectedRows[0].Cells[0].Value);
            Incidente item = listaIncidentesAsignados.Find(x => x.Id == id_incidente_seleccionado);

            listaIncidentesAsignados.Remove(item);
            listaIncidentesNoAsignados.Add(item);
            RefreshTables();
        }

        /// <summary>
        /// Handles the Click event of the buttonGuardarCambiosIncidentes control.
        /// Modifica los incidentes asignados al mantenimiento que se esta reprogramando
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonGuardarCambiosIncidentes_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            transiciones.Hide(panel1);
            mantenimiento.Incidentes = listaIncidentesAsignados;

        }


        /// <summary>
        /// Handles the Click event of the buttonCancelarModificarIncidentes control.
        /// Cancela la reasignacion de los incidentes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelarModificarIncidentes_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            transiciones.Hide(panel1);
        }

        /// <summary>
        /// Handles the Click event of the buttonCancelar control.
        /// Cancela la reprogramacion del mantenimeinto
        /// 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).ShowPanelSwitchs();
            Dispose();
        }
    }
}
