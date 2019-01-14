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
    public partial class Alta_Manteniminto : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        private List<Cliente> listaClientes;

        public Alta_Manteniminto(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();

            //panel1.Visible = false;
            panel2.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel2.Location = new System.Drawing.Point(0, 0);

            // transiciones.ShowSync(panel1);

            bunifuRange1_RangeChanged(null, null);
        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listaClientes = aPIHelper.GetClientesHelper().GetClientes(); // Obtener Lista de clientes

            // Llenar la tabla cliente con todos los clientes
            foreach (Cliente cliente in listaClientes)
            {
                AddItem(cliente);
            }

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
            datePicker.Value = DateTime.Now;




        }

        private void AddItem(Cliente cliente)
        {
            tablaClientes.Rows.Add(cliente.Id, cliente.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Nombreynumero); // Inserta una linea nueva en la tabla clientes
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
            Mantenimiento newMantenimiento = new Mantenimiento();
            newMantenimiento.id_tipo_mantenimiento = (TypeTipoMantenimiento)comboBoxTipoMantenimiento.SelectedValue;
            newMantenimiento.Fecha = datePicker.Value;
            newMantenimiento.HoraInicio = new TimeSpan(Convert.ToInt16(textHoraInicio.Text), Convert.ToInt16(textMinutosInicio.Text), 0);
            newMantenimiento.HoraFin = new TimeSpan(Convert.ToInt16(textHoraFin.Text), Convert.ToInt16(textMinutosFin.Text), 0);
            newMantenimiento.Detalles = TextDetalles.Text;
            
            newMantenimiento.Id_Cliente = Convert.ToInt16(tablaClientes.SelectedRows[0].Cells["id_cliente"].Value);
            newMantenimiento.Id_Sucursal = Convert.ToInt16(tablaSucursales.SelectedRows[0].Cells["id_sucursal"].Value);
            if (checkBoxTecnico1.Checked)
            {
                newMantenimiento.Tecnico1 = Convert.ToInt16(comboBoxTecnico1.SelectedValue);
                newMantenimiento.Estado = TypeEstadoMantenimiento.Asignado;
                if (checkboxTecnico2.Checked)
                    newMantenimiento.Tecnico2 = Convert.ToInt16(comboBoxTecnico2.SelectedValue);
            }
            else
                newMantenimiento.Estado = TypeEstadoMantenimiento.Abierto;

            newMantenimiento.Incidentes = new List<Incidente>();
            foreach (DataGridViewRow selectedRow in tablaIncidentes.SelectedRows)
            {
                short id_incidente = Convert.ToInt16(selectedRow.Cells["id"].Value);
                Incidente incidente = aPIHelper.GetIncidenteHelper().GetIncidente(id_incidente);
                newMantenimiento.Incidentes.Add(incidente);
                incidente.Id_estado_incidente = (int)TypeEstadoIncidente.Progreso;
                aPIHelper.GetIncidenteHelper().AddIncidente(incidente); // Cambio el estado del incidente a en proceso

            }


            MensajeAlerta resultado = aPIHelper.GetMantenimientosHelper().AddManteniento(newMantenimiento);
            Alert.ShowAlert(resultado);
            ((ABM_Mantenimientos)Parent).RefreshTabla();
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }

        private int SucursalSeleccionada()
        {
            throw new NotImplementedException();
        }

        private int ClienteSeleccionado()
        {
            throw new NotImplementedException();
        }

        private void buttonSiguiente_Click_1(object sender, EventArgs e)
        {
            transiciones.HideSync(panel1);
            transiciones.ShowSync(panel2);
        }

        private void tablaClientes_SelectionChanged(object sender, EventArgs e)
        {
            tablaSucursales.Rows.Clear();  // Eliminar clientes
            tablaSucursales.Refresh(); // Refrescar tabla
            try
            {

                int id_cliente_Seleccionado = Convert.ToInt16(tablaClientes.SelectedRows[0].Cells["id_cliente"].Value);
                IEnumerable<Sucursal> listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales(id_cliente_Seleccionado);
                foreach (Sucursal sucursal in listaSucursales)
                {
                    if (sucursal.Nombre.ToUpper().Contains(textBuscarCliente.Text.ToUpper())) AddItem(sucursal); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
                }

            }
            catch (Exception)
            {


            }
        }

        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {

            tablaIncidentes.Rows.Clear();  // Eliminar clientes
            tablaIncidentes.Refresh(); // Refrescar tabla
            try
            {
                int id_cliente_Seleccionado = Convert.ToInt16(tablaClientes.SelectedRows[0].Cells["id_cliente"].Value);
                int id_sucursal_Seleccionada = Convert.ToInt16(tablaSucursales.SelectedRows[0].Cells["id_sucursal"].Value);
             
                List<Incidente> listaIncidente = aPIHelper.GetIncidenteHelper().GetIncidentes(id_cliente_Seleccionado, id_sucursal_Seleccionada);

                foreach (Incidente incidente in listaIncidente)
                {
                    if (incidente.Id_estado_incidente != (int) TypeEstadoIncidente.Cancelado
                        && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Progreso
                        && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Resuelto
                        ) AddItem(incidente); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
                }

            }
            catch (Exception)
            {


            }


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();

            Dispose();
        }

        private void CheckBoxTecnico2_OnChange(object sender, EventArgs e)
        {
            if (!checkboxTecnico2.Checked)
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
                checkboxTecnico2.Enabled = true;
            }
            else
            {
                comboBoxTecnico1.Enabled = false;
                checkboxTecnico2.Enabled = false;
                comboBoxTecnico2.Enabled = false;

                checkboxTecnico2.Checked = false;
                comboBoxTecnico1.SelectedItem = -1;
                comboBoxTecnico2.SelectedItem = -1;

                //comboBoxTecnico1.Enabled = fa
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panel2);
            transiciones.ShowSync(panel1);
        }
    }
}
