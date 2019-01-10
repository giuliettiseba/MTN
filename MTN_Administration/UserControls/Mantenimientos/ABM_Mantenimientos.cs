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
    public partial class ABM_Mantenimientos : Form
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
            RefreshTablaMantenientos();

        }

        private void RefreshTablaMantenientos()
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

          {
      
                tablaMantenimientos.Rows.Add();
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["id"].Value = mantenimiento.Id;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["cliente"].Value = aPIHelper.GetClientesHelper().GetCliente(mantenimiento.Id_Cliente).Nombre;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["sucursal"].Value = aPIHelper.GetSucursalesHelper().GetSucursal(mantenimiento.Id_Cliente, mantenimiento.Id_Sucursal).Nombre;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["tipoMantenimiento"].Value = (TypeTipoMantenimiento)mantenimiento.id_tipo_mantenimiento;
                tablaMantenimientos.Rows[tablaMantenimientos.Rows.Count - 1].Cells["tecnico"].Value = aPIHelper.GetTecnicosHelper().GetTecnico(mantenimiento.Tecnico1).Nombre;
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
            //transiciones.ShowSync(panelSwitches);
            transiciones.ShowSync(panelTabla);
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
    }
    
}
