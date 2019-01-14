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
    public partial class Reprogramar_Mantenimiento : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        Mantenimiento mantenimiento;

        public Reprogramar_Mantenimiento(APIHelper aPIHelper, Mantenimiento mantenimiento)
        {
            this.mantenimiento = mantenimiento;
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();

            panel1.Visible = false;
            panel.Visible = true;
            panel.Location = new System.Drawing.Point(0, 0);
            panel1.Location = new System.Drawing.Point(0, 0);
            // transiciones.ShowSync(panel1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

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

            bunifuRange1_RangeChanged(null, null); // revisar



            if (mantenimiento.Tecnico1 != 0)
            {
                checkBoxTecnico1.Checked = true;
                comboBoxTecnico1.SelectedValue = mantenimiento.Tecnico1;
                if (mantenimiento.Tecnico2 != 0)
                {
                    checkBoxTecnico2.Checked = true;
                    comboBoxTecnico2.SelectedValue = mantenimiento.Tecnico2;
                }
            }
        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            mantenimiento.id_tipo_mantenimiento = (TypeTipoMantenimiento)comboBoxTipoMantenimiento.SelectedValue;
            mantenimiento.Fecha = datePicker.Value;
            mantenimiento.HoraInicio = new TimeSpan(Convert.ToInt16(textHoraInicio.Text), Convert.ToInt16(textMinutosInicio.Text), 0);
            mantenimiento.HoraFin = new TimeSpan(Convert.ToInt16(textHoraFin.Text), Convert.ToInt16(textMinutosFin.Text), 0);
            mantenimiento.Detalles = TextDetalles.Text;

            if (checkBoxTecnico1.Checked)
            {
                mantenimiento.Tecnico1 = Convert.ToInt16(comboBoxTecnico1.SelectedValue);
                mantenimiento.Estado = TypeEstadoMantenimiento.Asignado;
                if (checkBoxTecnico2.Checked)
                {
                    mantenimiento.Tecnico2 = Convert.ToInt16(comboBoxTecnico2.SelectedValue);
                }
                else
                {
                    mantenimiento.Tecnico2 = 0;
                }
            }
            else
            {
                mantenimiento.Tecnico1 = 0;
                mantenimiento.Estado = TypeEstadoMantenimiento.Abierto;
            }

            MensajeAlerta resultado = aPIHelper.GetMantenimientosHelper().AddManteniento(mantenimiento);
            Alert.ShowAlert(resultado);
            ((ABM_Mantenimientos)Parent).RefreshTabla();
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }





        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            ((ABM_Mantenimientos)Parent).showPanelSwitchs();

            Dispose();
        }

        private void CheckBoxTecnico2_OnChange(object sender, EventArgs e)
        {
            if (!checkBoxTecnico2.Checked)
            {
                comboBoxTecnico2.Enabled = false;
            }
            else comboBoxTecnico2.Enabled = true;

        }

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

                //comboBoxTecnico1.Enabled = fa
            }
        }

        ///// MODIFICAR LISTA DE INCIDENTES DE MANTENIMIENTO


        List<Incidente> listaIncidentesAsignados;
        List<Incidente> listaIncidentesSucursal;
        List<Incidente> listaIncidentesNoAsignados;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditarListaIncidentes_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panel);
            listaIncidentesSucursal = aPIHelper.GetIncidenteHelper().GetIncidentes(mantenimiento.Id_Cliente, mantenimiento.Id_Sucursal);
            listaIncidentesAsignados = new List<Incidente>(mantenimiento.Incidentes);
            listaIncidentesNoAsignados = new List<Incidente>();
            foreach (Incidente incidente in listaIncidentesSucursal)
            {
                if (listaIncidentesAsignados.FirstOrDefault(x => x.Id == incidente.Id) == null)
                    listaIncidentesNoAsignados.Add(incidente);
            }

            RefreshTables();
            panel1.Visible = true;

        }


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
                if (incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Cancelado
    && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Progreso
    && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Resuelto
)

                    AddRow(tablaIncidentesNoAsignados, incidente);
            }
            tablaIncidentesNoAsignados.Refresh();
        }



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

        private void tablaIncidentesNoAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesNoAsignados.SelectedRows[0].Cells[0].Value);
            Incidente item = listaIncidentesNoAsignados.Find(x => x.Id == id_incidente_seleccionado);

            listaIncidentesNoAsignados.Remove(item);
            listaIncidentesAsignados.Add(item);
            RefreshTables();
        }

        private void tablaIncidentesAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesAsignados.SelectedRows[0].Cells[0].Value);
            Incidente item = listaIncidentesAsignados.Find(x => x.Id == id_incidente_seleccionado);

            listaIncidentesAsignados.Remove(item);
            listaIncidentesNoAsignados.Add(item);
            RefreshTables();
        }

        private void buttonGuardarCambiosIncidentes_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            transiciones.Hide(panel1);
            mantenimiento.Incidentes = listaIncidentesAsignados;

        }

        private void buttonCancelarModificarIncidentes_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            transiciones.Hide(panel1);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }
    }
}
