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

    /// <summary>
    /// Interfaz de Alta de mantenimientos
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Alta_Manteniminto : UserControl
    {
        APIHelper aPIHelper;
        private List<Cliente> listaClientes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Alta_Manteniminto"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public Alta_Manteniminto(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;

            panel2.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel2.Location = new System.Drawing.Point(0, 0);

            InitializeComponent();
            this.rangeHora.RangeMax = 36;
            this.rangeHora.RangeMin = 18;

            bunifuRange1_RangeChanged(null, null);
        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listaClientes = aPIHelper.GetClientesHelper().GetClientes(); // Obtener Lista de clientes

            // Llenar la tabla cliente con todos los clientes
            foreach (Cliente cliente in listaClientes)
            {
                AddItem(cliente);
            }

            // Populate comboboxes de tecnicos 
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


        /// <summary>
        /// Agrega una nueva fila a la tabla clientes
        /// </summary>
        /// <param name="cliente"></param>
        private void AddItem(Cliente cliente)
        {
            tablaClientes.Rows.Add(cliente.Id, cliente.Nombre);
        }

        /// <summary>
        /// Agrega una nueva fila a la tabla sucursales.
        /// </summary>
        /// <param name="sucursal">The sucursal.</param>
        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Nombreynumero); // Inserta una fila 
        }

        /// <summary>
        /// Agrega una nueva fila a la tabla incidentes.
        /// </summary>
        /// <param name="incidente">The incidente.</param>
        private void AddItem(Incidente incidente)
        {
            tablaIncidentes.Rows.Add(); // Inserta una fila

            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["id"].Value = incidente.Id;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["tipo"].Value = (TypeTipoMantenible)incidente.Id_tipo_mantenible;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["dipositivo"].Value = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1).Nombre;
            if (incidente.Id_tipo_mantenible == 2) // si el incidente es de una camara agrega la camara a la tabla
                tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["camara"].Value = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2).Nombre;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["criticidad"].Value = (TypeCriticidad)incidente.Id_criticidad;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["asignado"].Value = aPIHelper.GetMantenimientosHelper().TieneMantenimientoAsignado(incidente.Id);
        }

        /// <summary>
        /// Handles the RangeChanged event of the bunifuRange1 control.
        /// Convierte el valor de la barra de seleccion de tiempo a horas y minutos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the buttonGuardar control.
        /// Agrega un mantenimiento nuevo, o modifica uno existente
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

            /// Si el tecnico principal esta asignado el mantenimiento se marca como asignado
            if (checkBoxTecnico1.Checked)
            {
                newMantenimiento.Tecnico1 = Convert.ToInt16(comboBoxTecnico1.SelectedValue);
                newMantenimiento.Estado = TypeEstadoMantenimiento.Asignado;
                if (checkboxTecnico2.Checked)
                    newMantenimiento.Tecnico2 = Convert.ToInt16(comboBoxTecnico2.SelectedValue);
            }
            else // si no tiene tecnico principal asignado el mantenimietno se marca como abierto
                newMantenimiento.Estado = TypeEstadoMantenimiento.Abierto;

            newMantenimiento.Incidentes = new List<Incidente>();
            /// Para cada incidente seleccionado de la tabla incidentes agrega el incidente a la lista de incidentes del mantenimiento
            foreach (DataGridViewRow selectedRow in tablaIncidentes.SelectedRows)
            {
                short id_incidente = Convert.ToInt16(selectedRow.Cells["id"].Value);
                Incidente incidente = aPIHelper.GetIncidenteHelper().GetIncidente(id_incidente);
                newMantenimiento.Incidentes.Add(incidente);

                incidente.Id_estado_incidente = (int)TypeEstadoIncidente.Progreso;
                aPIHelper.GetIncidenteHelper().AddIncidente(incidente); // Cambio el estado del incidente en la base de datos a "Progreso"
            }

            MensajeAlerta resultado = aPIHelper.GetMantenimientosHelper().AddManteniento(newMantenimiento); // agrega el mantenimiento a la base de datos

            Alert.ShowAlert(resultado);
            ((ABM_Mantenimientos)Parent).RefreshTabla();
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }

        /// <summary>
        /// Obtiene el id de la sucursal seleccionada.
        /// </summary>
        /// <returns></returns>
        private int SucursalSeleccionada()
        {
            return Convert.ToInt16(tablaSucursales.SelectedRows[0].Cells["id_sucursal"].Value);
        }

        /// <summary>
        /// Obtiene el id del cliente seleccionada.
        /// </summary>
        /// <returns></returns>
        private int ClienteSeleccionado()
        {
            return Convert.ToInt16(tablaClientes.SelectedRows[0].Cells["id_cliente"].Value);
        }

        /// <summary>
        /// Handles the SelectionChanged event of the tablaClientes control.
        /// Cuando cambia el cliente seleccionada muestra la lista de sucursales en la tabla sucursales
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tablaClientes_SelectionChanged(object sender, EventArgs e)
        {
            tablaSucursales.Rows.Clear();  // Eliminar clientes
            tablaSucursales.Refresh(); // Refrescar tabla
            try
            {
                IEnumerable<Sucursal> listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales(ClienteSeleccionado());
                foreach (Sucursal sucursal in listaSucursales)
                {
                    if (sucursal.Nombre.ToUpper().Contains(textBuscarCliente.Text.ToUpper())) AddItem(sucursal); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
                }

            }
            catch (Exception)
            {
                // El cliente no tiene sucursales cargadas

            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the tablaSucursales control.
        /// Cuando la sucursal seleccionada cambia muestra la lista de incidentes en la tabla incidentes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {

            tablaIncidentes.Rows.Clear();  // Eliminar clientes
            tablaIncidentes.Refresh(); // Refrescar tabla
            try
            {
                List<Incidente> listaIncidente = aPIHelper.GetIncidenteHelper().GetIncidentes(ClienteSeleccionado(), SucursalSeleccionada());

                foreach (Incidente incidente in listaIncidente)
                {
                    ///Filtro los incidentes segun el estado de los switches
                    if (incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Cancelado
                        && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Progreso
                        && incidente.Id_estado_incidente != (int)TypeEstadoIncidente.Resuelto
                        ) AddItem(incidente);
                }
            }
            catch (Exception)
            {
                // la sucursal no tiene incidentes
            }
        }

        /// <summary>
        /// Handles the Click event of the BotonCancelar control.
        /// Cancela el alta de manteniento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Mantenimientos)Parent).showPanelSwitchs();
            Dispose();
        }

        /// <summary>
        /// Handles the OnChange event of the CheckBoxTecnico2 control.
        /// habilita o deshabilita el combobox de tecnico 2 vos si se va a asignar un tecnico 2
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxTecnico2_OnChange(object sender, EventArgs e)
        {
            if (!checkboxTecnico2.Checked)
            {
                comboBoxTecnico2.Enabled = false;
            }
            else comboBoxTecnico2.Enabled = true;
        }

        /// <summary>
        /// Handles the OnChange event of the CheckBoxTecnico2 control.
        /// habilita o deshabilita el combobox de tecnico 1 vos si se va a asignar un tecnico 1
        /// Si no se asigna un tecnico 1, no se puede asignar un tecnico 2
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

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
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonAtras control.
        /// Muestra la siguiente ventana de la interfaz Alta Mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            transiciones.HideSync(panel2);
            transiciones.ShowSync(panel1);
        }

        /// <summary>
        /// Handles the 1 event of the buttonSiguiente_Click control.
        /// Muestra la ventana anterior de la interfaz Alta Mantenimiento
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSiguiente_Click_1(object sender, EventArgs e)
        {
            transiciones.HideSync(panel1);
            transiciones.ShowSync(panel2);
        }

    }
}
