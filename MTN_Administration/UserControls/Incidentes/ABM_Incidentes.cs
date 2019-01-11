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
using System.Threading;

namespace MTN_Administration.Tabs
{
    public partial class ABM_Incidentes : Form, Animated
    {
        APIHelper aPIHelper;
        private Alta_Incidente alta_Incidentes;
        private List<Incidente> listaIncidentes;

        public ABM_Incidentes(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
           // panelSwitches.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTablaIncidentes();

        }

        public void RefreshTablaIncidentes()
        {

            tablaIncidentes.Rows.Clear();
            listaIncidentes = aPIHelper.GetIncidenteHelper().GetIncidentes();

            // Llenar la tabla cliente con todos los clientes
            foreach (Incidente incidente in listaIncidentes)
            {
                AddItem(incidente);
            }
            tablaIncidentes.Refresh();
        }



        private void AddItem(Incidente incidente)
        {

            /// Filtros segun los switchs
            if (((incidente.Id_criticidad == 1 && switchCriticidadMuyAlta.Value) ||
                    (incidente.Id_criticidad == 2 && switchCriticidadAlta.Value) ||
                (incidente.Id_criticidad == 3 && switchCriticidadMedia.Value) ||
                (incidente.Id_criticidad == 4 && switchCriticidadBaja.Value) ||
                (incidente.Id_criticidad == 5 && switchCriticidadMuyBaja.Value)) &&
                (
                incidente.Id_estado_incidente == 1 && switchEstadoIncidenteAbierto.Value ||
                incidente.Id_estado_incidente == 2 && switchEstadoIncidenteProceso.Value ||
                incidente.Id_estado_incidente == 3 && switchEstadoIncidenteCerrado.Value
                ))


            {
                DispositivoCCTV dispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1);
                Camara camara = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2);
                tablaIncidentes.Rows.Add();
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["id"].Value = incidente.Id;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["cliente"].Value = aPIHelper.GetClientesHelper().GetCliente(incidente.Id_cliente).Nombre;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["sucursal"].Value = aPIHelper.GetSucursalesHelper().GetSucursal(incidente.Id_cliente, incidente.Id_suc).Nombreynumero;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["tipoDispositivo"].Value = incidente.Id_tipo_mantenible;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["dispositivo"].Value = dispositivoCCTV.Nombre;
                if (incidente.Id_2 != 0)
                {
                    tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["camara"].Value = camara.Nombre;
                    tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(camara.Id_estado);
                }
                else
                    tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(dispositivoCCTV.Id_estado);

                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["asignado"].Value = aPIHelper.GetMantenimientosHelper().TieneMantenimientoAsignado(incidente.Id);

                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["criticidad"].Value = aPIHelper.GetCriticidad(incidente.Id_criticidad);
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estadoIncidente"].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alta_Incidentes = new Alta_Incidente(aPIHelper);
            alta_Incidentes.Location = new System.Drawing.Point(0, 0);
            alta_Incidentes.Name = "alta_Incidentes";
            alta_Incidentes.Size = new System.Drawing.Size(739, 561);
            alta_Incidentes.TabIndex = 2;
            Controls.Add(this.alta_Incidentes);
            alta_Incidentes.BringToFront();

        }
        private void close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void BotonAgregarIncidente_Click(object sender, EventArgs e)
        {

            transiciones.HideSync(panelTabla);
            alta_Incidentes = new Alta_Incidente(aPIHelper);
            alta_Incidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            alta_Incidentes.Location = new System.Drawing.Point(236, 39);
            alta_Incidentes.Name = "alta_incidentes";
            alta_Incidentes.Size = new System.Drawing.Size(739, 561);
            alta_Incidentes.TabIndex = 2;
            Controls.Add(this.alta_Incidentes);
            alta_Incidentes.BringToFront();
        }

        public void showPanelSwitchs()
        {
            //transiciones.ShowSync(panelSwitches);
            transiciones.Show(panelTabla);
        }

 

        Ver_Incidente ver_Incidente;
        private void BotonVerIncidente_Click(object sender, EventArgs e)
        {

            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentes.SelectedRows[0].Cells["id"].Value);
            transiciones.HideSync(panelTabla);
            Incidente incidente = aPIHelper.GetIncidenteHelper().GetIncidente(id_incidente_seleccionado);
            ver_Incidente = new Ver_Incidente(aPIHelper, incidente);
            ver_Incidente.Dock = System.Windows.Forms.DockStyle.Fill;
            ver_Incidente.Location = new System.Drawing.Point(236, 39);
            ver_Incidente.Name = "alta_incidentes";
            ver_Incidente.Size = new System.Drawing.Size(739, 561);
            ver_Incidente.TabIndex = 2;
            Controls.Add(this.ver_Incidente);
            ver_Incidente.BringToFront();
            
        }

        private void tablaIncidentes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BotonVerIncidente_Click(null, null);
        }

        private void switchCriticidadMuyAlta_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchCriticidadAlta_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchCriticidadMedia_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchCriticidadBaja_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchCriticidadMuyBaja_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchEstadoIncidenteAbierto_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchEstadoIncidenteCerrado_OnValueChange(object sender, EventArgs e)
        {

        }

        private void switchEstadoIncidenteProceso_OnValueChange(object sender, EventArgs e)
        {

        }
    }
}
