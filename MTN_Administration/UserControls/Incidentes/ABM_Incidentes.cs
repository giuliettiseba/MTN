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
using MTN_Administration.Alerts;

namespace MTN_Administration.Tabs
{
    /// <summary>Intefaz ABM Incidentes</summary>
    public partial class ABM_Incidentes : Form, Animated
    {

        APIHelper aPIHelper;
        private Alta_Incidente alta_Incidentes;
        private List<Incidente> listaIncidentes;

        /// <summary>
        /// Initializes a new instance of the <see cref="ABM_Incidentes"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public ABM_Incidentes(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
            close.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 20, 8);
            minimize.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 35, 8);
            progressBar.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTablaIncidentes();

        }

        /// <summary>
        /// Refresca la tabla incidentes
        /// </summary>
        public void RefreshTablaIncidentes()
        {
            tablaIncidentes.Rows.Clear(); // Elimina todas las entradas de la tabla
            listaIncidentes = aPIHelper.GetIncidenteHelper().GetIncidentes(); // Obtiene una lista actualizada de incidentes
            foreach (Incidente incidente in listaIncidentes) // Recorre la lista de incidentes 
            {
                AddItem(incidente); // Agrega el incidente a la tabla
            }
            tablaIncidentes.Refresh();
        }


        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="incidente">The incidente.</param>
        private void AddItem(Incidente incidente)
        {

            /// Filtra los incidentes segun el estado de los switchs segun los switchs
            if (((incidente.Id_criticidad == 1 && switchCriticidadMuyAlta.Value) ||
                    (incidente.Id_criticidad == 2 && switchCriticidadAlta.Value) ||
                (incidente.Id_criticidad == 3 && switchCriticidadMedia.Value) ||
                (incidente.Id_criticidad == 4 && switchCriticidadBaja.Value))
                &&
                (
                incidente.Id_estado_incidente == 1 && switchEstadoIncidenteAbierto.Value ||
                incidente.Id_estado_incidente == 2 && switchEstadoIncidenteProceso.Value ||
                incidente.Id_estado_incidente == 3 && switchEstadoIncidenteCerrado.Value ||
                incidente.Id_estado_incidente == 4 && switchEstadoIncidenteCancelado.Value ||
                incidente.Id_estado_incidente == 5 && switchEstadoIncidenteReabierto.Value
                ))


            {
                DispositivoCCTV dispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1); // Obtiene el dispositivo del incidente

                tablaIncidentes.Rows.Add();  // Crea una nueva entrada en la tabla 
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["id"].Value = incidente.Id;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["cliente"].Value = aPIHelper.GetClientesHelper().GetCliente(incidente.Id_cliente).Nombre;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["sucursal"].Value = aPIHelper.GetSucursalesHelper().GetSucursal(incidente.Id_cliente, incidente.Id_suc).Nombreynumero;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["tipoDispositivo"].Value = incidente.Id_tipo_mantenible;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["dispositivo"].Value = dispositivoCCTV.Nombre;
                
                if (incidente.Id_2 != 0)/// Si el incidente es en una camara muestra el estado de la camara
                {
                    Camara camara = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2); // Obtiene la camara del incidente. 
                    tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["camara"].Value = camara.Nombre;
                    tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(camara.Id_estado);
                }
                else // sino muestra el estado del grabador
                    tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(dispositivoCCTV.Id_estado);

                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["asignado"].Value = aPIHelper.GetMantenimientosHelper().TieneMantenimientoAsignado(incidente.Id) ? "Si" : "No"; 

                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["criticidad"].Value = (TypeCriticidad)incidente.Id_criticidad;
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estadoIncidente"].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            }
        }

        /// <summary>
        /// Handles the Click event of the close control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Handles the Click event of the minimize control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Handles the Click event of the BotonAgregarIncidente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        Ver_Incidente ver_Incidente;
        /// <summary>
        /// Handles the Click event of the BotonVerIncidente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonVerIncidente_Click(object sender, EventArgs e)
        {

            transiciones.HideSync(panelTabla);
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentes.SelectedRows[0].Cells["id"].Value);
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

        /// <summary>
        /// Animacion para mostrar el panel ABM
        /// </summary>
        public void showPanelSwitchs()
        {
            transiciones.Show(panelTabla);
        }

        /// <summary>
        /// Handles the CellMouseDoubleClick event of the tablaIncidentes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellMouseEventArgs"/> instance containing the event data.</param>
        private void tablaIncidentes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BotonVerIncidente_Click(null, null);
        }



        /// <summary>
        /// Refreshes the tabla incidentes. Es llamado por cada uno de los cambios de estado de los switches
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RefreshTablaIncidentes(object sender, EventArgs e)
        {
            RefreshTablaIncidentes();
        }


 



        int tick = 0;
        /// <summary>
        /// Handles the Tick event of the timer1 control. Al llegar a 100 ticks se verifica si la tabla incidentes sufrio cambios en la base de datos
        /// Si hay cambios refresca la tabla de incidentes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick == 100)
            {
                if (aPIHelper.GetIncidenteHelper().TieneCambios())
                {
                    RefreshTablaIncidentes();
                }
                tick = 0;
            }
            else
            {
                tick += 1;
                progressBar.Value = tick;
            }
        }


        /// <summary>
        /// Cambia el estado del incidente seleccionado
        /// </summary>
        /// <param name="estadoIncidente">The estado incidente.</param>
        private void cambiarEstadoIncidente(TypeEstadoIncidente estadoIncidente)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentes.SelectedRows[0].Cells["id"].Value);
            Incidente incidente = aPIHelper.GetIncidenteHelper().GetIncidente(id_incidente_seleccionado);
            incidente.Id_estado_incidente = (int)estadoIncidente;

            MensajeAlerta resultado = aPIHelper.GetIncidenteHelper().AddIncidente(incidente);
            Alert.ShowAlert(resultado);

            RefreshTablaIncidentes();

        }

        /// <summary>
        /// Handles the 1 event of the buttonCancelarIncidente_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonCancelarIncidente_Click_1(object sender, EventArgs e)
        {
            cambiarEstadoIncidente(TypeEstadoIncidente.Cancelado);
            RefreshTablaIncidentes();
        }


        /// <summary>
        /// Handles the Click event of the buttonReabrir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonReabrir_Click(object sender, EventArgs e)
        {
            cambiarEstadoIncidente(TypeEstadoIncidente.Reabierto);
            RefreshTablaIncidentes();
        }


    }
}
