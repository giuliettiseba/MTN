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
    public partial class Cerrar_Mantenimiento : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        Mantenimiento mantenimiento;

        public Cerrar_Mantenimiento(APIHelper aPIHelper, Mantenimiento mantenimiento)
        {
            this.mantenimiento = mantenimiento;
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();

            //panel1.Visible = false;
            panel.Visible = true;
            panel.Location = new System.Drawing.Point(0, 0);

            // transiciones.ShowSync(panel1);

        }


        List<Incidente> listaIncidentesAsignados;
        List<Incidente> listaIncidentesResueltos;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            listaIncidentesAsignados = new List<Incidente>(mantenimiento.Incidentes);
            listaIncidentesResueltos = new List<Incidente>();

            RefreshTables();
        }

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
                //   tabla.Rows[tabla.Rows.Count - 1].Cells[6].Value = aPIHelper.GetEstado(camara.Id_estado);
            }
            else
                //    tabla.Rows[tabla.Rows.Count - 1].Cells[6].Value = aPIHelper.GetEstado(dispositivoCCTV.Id_estado);

                //tabla.Rows[tabla.Rows.Count - 1].Cells["asignado"].Value = aPIHelper.GetMantenimientosHelper().TieneMantenimientoAsignado(incidente.Id);

                tabla.Rows[tabla.Rows.Count - 1].Cells[4].Value = (TypeCriticidad)incidente.Id_criticidad;
            tabla.Rows[tabla.Rows.Count - 1].Cells[5].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            //    tabla.Rows[tabla.Rows.Count - 1].Cells["id"].Value = incidente.Id;
            //    tabla.Rows[tabla.Rows.Count - 1].Cells["tipo"].Value = incidente.Id_tipo_mantenible;
            //    tabla.Rows[tabla.Rows.Count - 1].Cells["dispositivo"].Value = dispositivoCCTV.Nombre;
            //    if (incidente.Id_2 != 0)
            //    {
            //        tabla.Rows[tabla.Rows.Count - 1].Cells["camara"].Value = camara.Nombre;
            //        tabla.Rows[tabla.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(camara.Id_estado);
            //    }
            //    else
            //        tabla.Rows[tabla.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(dispositivoCCTV.Id_estado);

            //    tabla.Rows[tabla.Rows.Count - 1].Cells["asignado"].Value = aPIHelper.GetMantenimientosHelper().TieneMantenimientoAsignado(incidente.Id);

            //    tabla.Rows[tabla.Rows.Count - 1].Cells["criticidad"].Value = aPIHelper.GetCriticidad(incidente.Id_criticidad);
            //    tabla.Rows[tabla.Rows.Count - 1].Cells["estado"].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            //
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            mantenimiento.Detalles = TextDetalles.Text;

            mantenimiento.Estado = TypeEstadoMantenimiento.Cerrado;

            foreach (Incidente incidente in listaIncidentesResueltos) // si fue resuelto cambio el estado de incidente a resuelto
            {
                incidente.Id_estado_incidente = (int)TypeEstadoIncidente.Resuelto;
                aPIHelper.GetIncidenteHelper().AddIncidente(incidente);
            }

            foreach (Incidente incidente in listaIncidentesAsignados) // si fue resuelto cambio el estado de incidente a resuelto
            {
                incidente.Id_estado_incidente = (int)TypeEstadoIncidente.Abierto; // Cierro el mantenimiento pero el incidente no fue resuelto, vuelve al estado abierto
                aPIHelper.GetIncidenteHelper().AddIncidente(incidente);
            }


            MensajeAlerta resultado = aPIHelper.GetMantenimientosHelper().AddManteniento(mantenimiento);
            Alert.ShowAlert(resultado);
            ((ABM_Mantenimientos)Parent).RefreshTabla();
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();

            Dispose();
        }


        /// <summary>
        /// 
        /// Saca un incidente de la lista de asignados y lo coloca en la lista de resueltos
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tablaIncidentesAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesAsignados.SelectedRows[0].Cells[0].Value);
            Incidente item = listaIncidentesAsignados.Find(x => x.Id == id_incidente_seleccionado);

            listaIncidentesAsignados.Remove(item);
            listaIncidentesResueltos.Add(item);
            RefreshTables();
        }


        /// <summary>
        /// 
        /// Saca un incidente de la lista de resueltos y lo coloca en la lista de asignados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tablaIncidentesResueltos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentesResueltos.SelectedRows[0].Cells[0].Value);
            var item = listaIncidentesResueltos.Single(x => x.Id == id_incidente_seleccionado);
            listaIncidentesResueltos.Remove(item);
            listaIncidentesAsignados.Add(item);
            RefreshTables();
        }
    }
}
