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
    public partial class ABM_Mantenimientos : Form, Animated
    {
        APIHelper aPIHelper;
        private Alta_Incidente alta_Incidentes;
        private List<Mantenimiento> listaMantenimientos;

        public ABM_Mantenimientos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
            panelSwitches.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTabla();
   //         WindowState = FormWindowState.Maximized;


        }

        internal void RefreshTabla()
        {

            tablaMantenimientos.Rows.Clear();
            listaMantenimientos = aPIHelper.GetMantenimientosHelper().GetMantenimientos();

            // Llenar la tabla cliente con todos los clientes
            foreach (Mantenimiento mantenimiento in listaMantenimientos)
            {
                AddItem(mantenimiento);
            }
            tablaMantenimientos.Refresh();
        }

    


        private void AddItem(Mantenimiento mantenimiento)
        {

            if (
            mantenimiento.Estado == TypeEstadoMantenimiento.Abierto && switchEstadoMantenimeintoAbierto.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Asignado && switchEstadoMantenimeintoAsignado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Cancelado && switchEstadoMantenimeintoCancelado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Cerrado && switchEstadoMantenimeintoCerrado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Demorado && switchEstadoMantenimeintoDemorado.Value ||
            mantenimiento.Estado == TypeEstadoMantenimiento.Progreso && switchEstadoMantenimeintoProgreso.Value
            )
            {
                tablaMantenimientos.Rows.Add();
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["id"].Value = mantenimiento.Id;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["cliente"].Value = aPIHelper.GetClientesHelper().GetCliente(mantenimiento.Id_Cliente).Nombre;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["sucursal"].Value = aPIHelper.GetSucursalesHelper().GetSucursal(mantenimiento.Id_Cliente, mantenimiento.Id_Sucursal).Nombre;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["tipoMantenimiento"].Value = (TypeTipoMantenimiento)mantenimiento.id_tipo_mantenimiento;
                Tecnico tecnico1 = aPIHelper.GetTecnicosHelper().GetTecnico(mantenimiento.Tecnico1);
                if (tecnico1 != null)
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["tecnico"].Value = tecnico1.Nombre;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["estadoMantenimiento"].Value = (TypeEstadoMantenimiento)mantenimiento.Estado;
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




        public void showPanelSwitchs()
        {
            transiciones.Show(panelTabla);


        }

        Alta_Manteniminto crear_Manteniminto;
 

        private void BotonAgregarMantenimiento_Click(object sender, EventArgs e)

        {
            transiciones.HideSync(panelTabla);
            crear_Manteniminto = new Alta_Manteniminto(aPIHelper);
            crear_Manteniminto.Dock = System.Windows.Forms.DockStyle.Fill;
            crear_Manteniminto.Location = new System.Drawing.Point(236, 39);
            crear_Manteniminto.Name = "crear_Manteniminto";
            crear_Manteniminto.Size = new System.Drawing.Size(739, 561);
            crear_Manteniminto.TabIndex = 2;
            Controls.Add(this.crear_Manteniminto);
            crear_Manteniminto.BringToFront();

        }



        Ver_Mantenimiento ver_Mantenimiento;

        private void BotonVerMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);

            int id_mantenimiento = Convert.ToInt16(tablaMantenimientos.SelectedRows[0].Cells["id"].Value);
            Mantenimiento mantenimiento = aPIHelper.GetMantenimientosHelper().GetMantenimiento(id_mantenimiento);
            ver_Mantenimiento = new Ver_Mantenimiento(aPIHelper, mantenimiento);
            ver_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            ver_Mantenimiento.Location = new System.Drawing.Point(236, 39);
            ver_Mantenimiento.Name = "ver_Manteniminto";
            ver_Mantenimiento.Size = new System.Drawing.Size(739, 561);
            ver_Mantenimiento.TabIndex = 2;
            Controls.Add(this.ver_Mantenimiento);
            ver_Mantenimiento.BringToFront();


        }

        private void tablaMantenimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BotonVerMantenimiento_Click(null, null);
        }


        Reprogramar_Mantenimiento reprogramar_Mantenimiento;

        private void buttonReprogramarMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);

            int id_mantenimiento = Convert.ToInt16(tablaMantenimientos.SelectedRows[0].Cells["id"].Value);
            Mantenimiento mantenimiento = aPIHelper.GetMantenimientosHelper().GetMantenimiento(id_mantenimiento);
            reprogramar_Mantenimiento = new Reprogramar_Mantenimiento(aPIHelper, mantenimiento);
            reprogramar_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            reprogramar_Mantenimiento.Location = new System.Drawing.Point(236, 39);
            reprogramar_Mantenimiento.Name = "reprogramar_Mantenimiento";
            reprogramar_Mantenimiento.Size = new System.Drawing.Size(739, 561);
            reprogramar_Mantenimiento.TabIndex = 2;
            Controls.Add(this.reprogramar_Mantenimiento);
            reprogramar_Mantenimiento.BringToFront();

        }
        Cerrar_Mantenimiento cerrar_Mantenimiento;
        private void buttonCerrarMantenimiento_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panelTabla);

            int id_mantenimiento = Convert.ToInt16(tablaMantenimientos.SelectedRows[0].Cells["id"].Value);
            Mantenimiento mantenimiento = aPIHelper.GetMantenimientosHelper().GetMantenimiento(id_mantenimiento);
            cerrar_Mantenimiento = new Cerrar_Mantenimiento(aPIHelper, mantenimiento);
            cerrar_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            cerrar_Mantenimiento.Location = new System.Drawing.Point(236, 39);
            cerrar_Mantenimiento.Name = "cerrar_Mantenimiento";
            cerrar_Mantenimiento.Size = new System.Drawing.Size(739, 561);
            cerrar_Mantenimiento.TabIndex = 2;
            Controls.Add(this.cerrar_Mantenimiento);
            cerrar_Mantenimiento.BringToFront();

        }

        private void RefreshTabla(object sender, EventArgs e)
        {
            RefreshTabla();
        }
    }
    
}
