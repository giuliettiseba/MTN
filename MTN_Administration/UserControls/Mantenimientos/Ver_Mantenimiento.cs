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

namespace MTN_Administration.Tabs
{
    public partial class Ver_Mantenimiento : UserControl, Animated
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        Mantenimiento mantenimiento;


        public Ver_Mantenimiento(APIHelper aPIHelper, Mantenimiento mantenimiento)
        {
            this.mantenimiento = mantenimiento;
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textCliente.Text = aPIHelper.GetClientesHelper().GetCliente(mantenimiento.Id_Cliente).Nombre;
            Sucursal sucursal = aPIHelper.GetSucursalesHelper().GetSucursal(mantenimiento.Id_Cliente, mantenimiento.Id_Sucursal);
            textSucursal.Text = sucursal.Nombre;

            textSucursalCiudad.Text = aPIHelper.GetNombreLocalidad(sucursal.Id_localidad);
            textSucursalProvincia.Text = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(sucursal.Id_localidad));

            textTipoMantenimiento.Text = ((TypeTipoMantenimiento)mantenimiento.id_tipo_mantenimiento).ToString();
            textHoraInicio.Text = mantenimiento.HoraInicio.ToString();
            textHoraFin.Text = mantenimiento.HoraFin.ToString();

            Tecnico tecnico1 = aPIHelper.GetTecnicosHelper().GetTecnico(mantenimiento.Tecnico1);

            if (tecnico1 != null)
            {
                textTecnico1_nombre.Text = tecnico1.Nombre;
                textTecnico1_Apellido.Text = tecnico1.Apellido;
                textTecnico1_Rango.Text = aPIHelper.GetTipoEmpleado(tecnico1.Id_tipo_empleado);
            }

            Tecnico tecnico2 = aPIHelper.GetTecnicosHelper().GetTecnico(mantenimiento.Tecnico2);
            if (tecnico2 != null)
            {
                textTecnico2_nombre.Text = tecnico2.Nombre;
                textTecnico2_Apellido.Text = tecnico2.Apellido;
                textTecnico2_Rango.Text = aPIHelper.GetTipoEmpleado(tecnico2.Id_tipo_empleado);
            }

            TextObservaciones.Text = mantenimiento.Detalles;

            textEstado.Text = mantenimiento.Estado.ToString();


            List<Incidente> incidentes = mantenimiento.Incidentes;
            foreach (Incidente incidente in incidentes)
            {
                AddItem(incidente);
            }
            tablaIncidentes.Refresh();
        }

        private void AddItem(Incidente incidente)
        {
            tablaIncidentes.Rows.Add(); // Inserta una linea nueva en la tabla clientes

            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["id"].Value = incidente.Id;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["tipo"].Value = (TypeTipoMantenible)incidente.Id_tipo_mantenible;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["dipositivo"].Value = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1).Nombre;
            if (incidente.Id_tipo_mantenible == 2)
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["camara"].Value = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2).Nombre;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["criticidad"].Value = (TypeCriticidad)incidente.Id_criticidad;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["asignado"].Value = aPIHelper.GetMantenimientosHelper().TieneMantenimientoAsignado(incidente.Id);

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }


        
        private void tablaIncidentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonVerIncidente_Click(null, null);



        }

        public void showPanelSwitchs()
        {
            transiciones.Show(panel1);
        }

        Ver_Incidente ver_Incidente;
        private void buttonVerIncidente_Click(object sender, EventArgs e)
        {
            int id_incidente_seleccionado = Convert.ToInt16(tablaIncidentes.SelectedRows[0].Cells["id"].Value);
            transiciones.HideSync(panel1);
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


    }
}
