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
    /// <summary>
    /// Interfaz de administracion de mantenimientos
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="MTN_Administration.Tabs.IAnimated" />
    public partial class ABM_Mantenimientos : Form, IAnimated
    {
        APIHelper aPIHelper;
        private List<Mantenimiento> listaMantenimientos;

        /// <summary>
        /// Initializes a new instance of the <see cref="ABM_Mantenimientos"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public ABM_Mantenimientos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
            panelSwitches.Visible = true;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTabla();

            // Reubica los componentes de la interfaz de acuerdo al tamaño de la pantalla
            close.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 20, 8);
            minimize.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 35, 8);
            progressBar.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }


        /// <summary>
        /// Refresca la tabla de mantenimientos
        /// </summary>
        internal void RefreshTabla()
        {

            //tablaMantenimientos.Rows.Clear();
            listaMantenimientos = aPIHelper.GetMantenimientosHelper().GetMantenimientos();

            // Llenar la tabla de mantenimientos
            foreach (Mantenimiento mantenimiento in listaMantenimientos)
            {
                AddItem(mantenimiento);
            }
            tablaMantenimientos.Refresh();
        }

        /// <summary>
        /// Agrega una nueva fila a la tabla de mantenientos.
        /// </summary>
        /// <param name="mantenimiento">The mantenimiento.</param>
        private void AddItem(Mantenimiento mantenimiento)
        {
            // filtra los mantenimiento de acuerdo con el estado de los switches
            if (
            mantenimiento.Estado == TypeEstadoMantenimiento.Abierto && switchEstadoMantenimeintoAbierto.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Asignado && switchEstadoMantenimeintoAsignado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Cancelado && switchEstadoMantenimeintoCancelado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Cerrado && switchEstadoMantenimeintoCerrado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Demorado && switchEstadoMantenimeintoDemorado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Progreso && switchEstadoMantenimeintoProgreso.Value
            )
            {

                Tecnico tecnico1 = aPIHelper.GetTecnicosHelper().GetTecnico(mantenimiento.Tecnico1);
                string nombreTecnico = "";
                if (tecnico1 != null) nombreTecnico = tecnico1.ApellidoYNombre;
                tablaMantenimientos.Rows.Add(mantenimiento.Id,
                aPIHelper.GetClientesHelper().GetCliente(mantenimiento.Id_Cliente).Nombre,
                 aPIHelper.GetSucursalesHelper().GetSucursal(mantenimiento.Id_Cliente, mantenimiento.Id_Sucursal).Nombre,
                 mantenimiento.id_tipo_mantenimiento,
                 nombreTecnico,
                 mantenimiento.Estado);
            }

        }

        /// <summary>
        /// Handles the Click event of the close control.
        /// Cierra la Interfaz de mantenimientos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Minimiza la Interfaz de mantenimientos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Animacion de ventana
        /// </summary>
        public void ShowPanelSwitchs()
        {
            transiciones.Show(panelTabla);
        }

        private Alta_Manteniminto Alta_Manteniminto;
        /// <summary>
        /// Handles the Click event of the BotonAgregarMantenimiento control.
        /// Muestra la interfaz de Alta Mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);
            Alta_Manteniminto = new Alta_Manteniminto(aPIHelper)
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "crear_Manteniminto",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.Alta_Manteniminto);
            Alta_Manteniminto.BringToFront();
        }

        private Ver_Mantenimiento ver_Mantenimiento;
        /// <summary>
        /// Handles the Click event of the BotonVerMantenimiento control.
        /// Muestra el mantenimiento seleccionado en una interfaz 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonVerMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);

            ver_Mantenimiento = new Ver_Mantenimiento(aPIHelper, ObtenerManetnimientoSeleccionado())
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "ver_Manteniminto",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.ver_Mantenimiento);
            ver_Mantenimiento.BringToFront();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the tablaMantenimientos control.
        /// Muestra la interfaz para reprogramar un mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaMantenimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonReprogramarMantenimiento_Click(null, null);
        }


        private Reprogramar_Mantenimiento reprogramar_Mantenimiento;
        /// <summary>
        /// Handles the Click event of the buttonReprogramarMantenimiento control.
        /// Muestra la interfaz para reprogramar un mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonReprogramarMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);

            reprogramar_Mantenimiento = new Reprogramar_Mantenimiento(aPIHelper, ObtenerManetnimientoSeleccionado())
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "reprogramar_Mantenimiento",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.reprogramar_Mantenimiento);
            reprogramar_Mantenimiento.BringToFront();
        }

        private Mantenimiento ObtenerManetnimientoSeleccionado()
        {

            int id_mantenimiento = Convert.ToInt16(tablaMantenimientos.SelectedRows[0].Cells["id"].Value);
            return aPIHelper.GetMantenimientosHelper().GetMantenimiento(id_mantenimiento);
        }

        private Cerrar_Mantenimiento cerrar_Mantenimiento;
        /// <summary>
        /// Handles the Click event of the buttonCerrarMantenimiento control.
        /// Muestra la interfaz para cerrar un mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCerrarMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);

            cerrar_Mantenimiento = new Cerrar_Mantenimiento(aPIHelper, ObtenerManetnimientoSeleccionado())
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "cerrar_Mantenimiento",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.cerrar_Mantenimiento);
            cerrar_Mantenimiento.BringToFront();
        }


        /// <summary>
        /// Refresca la tabla de mantenimiento cada vez que un switch cambia de estado
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RefreshTabla(object sender, EventArgs e)
        {
            RefreshTabla();
        }

        int tick = 0;
        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// Cuando el contador de ticks alcanza el 100 se verifica si la tabla de mantenimientos sufrio cambios
        /// Si hay cambios se refresca la tabla de mantenimientos. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (tick == 100)
            {
                if (aPIHelper.GetMantenimientosHelper().TieneCambios())
                {
                    RefreshTabla();
                }
                tick = 0;
            }
            else
            {
                tick += 1;
                progressBar.Value = tick;
            }
        }

        private void TablaMantenimientos_SelectionChanged(object sender, EventArgs e)
        {
            TypeEstadoMantenimiento estado = ObtenerManetnimientoSeleccionado().Estado;
            if (estado == TypeEstadoMantenimiento.Asignado ||
                estado == TypeEstadoMantenimiento.Demorado ||
                estado == TypeEstadoMantenimiento.Progreso)
                buttonCerrarMantenimiento.Visible = true;
            else
                buttonCerrarMantenimiento.Visible = false;
        }
    }
}
