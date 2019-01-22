using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;
using Bunifu.Framework.UI;

/// <summary>
/// Interfaz Cerrar Mantenimiento
/// </summary>
namespace MTN_Administration.Tabs
{
    public partial class Cerrar_Mantenimiento : UserControl
    {
        private APIHelper aPIHelper;
        private Mantenimiento mantenimiento;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cerrar_Mantenimiento"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        /// <param name="mantenimiento">The mantenimiento.</param>
        public Cerrar_Mantenimiento(APIHelper aPIHelper, Mantenimiento mantenimiento)
        {
            this.mantenimiento = mantenimiento;
            this.aPIHelper = aPIHelper;

            InitializeComponent();

            panel.Visible = true;
            panel.Location = new System.Drawing.Point(0, 0);

        }

        private List<Incidente> listaIncidentesAsignados;
        private List<Incidente> listaIncidentesResueltos;
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            listaIncidentesAsignados = new List<Incidente>(mantenimiento.Incidentes);
            listaIncidentesResueltos = new List<Incidente>();
            TextDetalles.Text = mantenimiento.Detalles;

            RefreshTables();
        }

        /// <summary>
        /// Refresca las tablas de incidentes asignados e incidentes resueltos
        /// </summary>
        private void RefreshTables()
        {
            tablaIncidentesAsignados.Rows.Clear();
            foreach (Incidente incidente in listaIncidentesAsignados)
            {
                AddRow(tablaIncidentesAsignados, incidente);
            }
            tablaIncidentesAsignados.Refresh();

            tablaIncidentesResueltos.Rows.Clear();
            foreach (Incidente incidente in listaIncidentesResueltos)
            {
                AddRow(tablaIncidentesResueltos, incidente);
            }
            tablaIncidentesResueltos.Refresh();
        }

        /// <summary>
        /// Agrega una nueva fila con un incidente a una de las tablas.
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
            {
                tabla.Rows[tabla.Rows.Count - 1].Cells[3].Value = camara.Nombre;
            }
            else
                tabla.Rows[tabla.Rows.Count - 1].Cells[4].Value = (TypeCriticidad)incidente.Id_criticidad;
            tabla.Rows[tabla.Rows.Count - 1].Cells[5].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
        }

        /// <summary>
        /// Handles the Click event of the buttonGuardar control.
        /// Cierra el mantenimiento y marca los incidentes como resuelto si esta en la tabla de resueltos o abiertos si no pudo ser solucionado
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            mantenimiento.Detalles = TextDetalles.Text;

            mantenimiento.Estado = TypeEstadoMantenimiento.Cerrado;

            foreach (Incidente incidente in listaIncidentesResueltos) // si fue resuelto cambio el estado de incidente a resuelto
            {
                incidente.Id_estado_incidente = (int)TypeEstadoIncidente.Resuelto;
                aPIHelper.GetIncidenteHelper().AddIncidente(incidente);
            }

            foreach (Incidente incidente in listaIncidentesAsignados) // si no fue resuelto cambio el estado de incidente a abierto
            {
                incidente.Id_estado_incidente = (int)TypeEstadoIncidente.Abierto; // Cierro el mantenimiento pero el incidente no fue resuelto, vuelve al estado abierto
                aPIHelper.GetIncidenteHelper().AddIncidente(incidente);
            }

            MensajeAlerta resultado = aPIHelper.GetMantenimientosHelper().AddManteniento(mantenimiento);
            Alert.ShowAlert(resultado);
            ((ABM_Mantenimientos)Parent).RefreshTabla();
            ((ABM_Mantenimientos)Parent).ShowPanelSwitchs();
            Dispose();
        }

        /// <summary>
        /// Handles the Click event of the buttonCancelar control.
        /// Cancela el cierre de un mantenimiento y cierra la interfaz
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).ShowPanelSwitchs();
            Dispose();
        }


        /// <summary>
        /// 
        /// Saca un incidente de la lista de asignados y lo coloca en la lista de resueltos
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TablaIncidentesAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesAsignados.SelectedRows[0].Cells[0].Value);
            Incidente item = listaIncidentesAsignados.Find(x => x.Id == id_incidente_seleccionado);

            listaIncidentesAsignados.Remove(item);
            listaIncidentesResueltos.Add(item);
            RefreshTables();
        }


        /// <summary>
        /// Handles the CellDoubleClick event of the tablaIncidentesResueltos control.
        /// Saca un incidente de la lista de resueltos y lo coloca en la lista de asignados
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaIncidentesResueltos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesResueltos.SelectedRows[0].Cells[0].Value);
            var item = listaIncidentesResueltos.Single(x => x.Id == id_incidente_seleccionado);
            listaIncidentesResueltos.Remove(item);
            listaIncidentesAsignados.Add(item);
            RefreshTables();
        }
    }
}
