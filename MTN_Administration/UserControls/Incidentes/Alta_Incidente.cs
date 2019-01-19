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
    /// Interfaz Alta Incidente
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Alta_Incidente : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;
        private List<Cliente> listaClientes;


        /// <summary>
        /// Initializes a new instance of the <see cref="Alta_Incidente"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public Alta_Incidente(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel2.Location = new System.Drawing.Point(0, 0);
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

            /// Populate combobox Estados sin el estado OK ya que se generara un incidente sobre un dispositivo con fallas
            comboBoxEstado.DisplayMember = "value";
            comboBoxEstado.ValueMember = "key";
            Dictionary<int, string> estadosSinOK = new Dictionary<int, string>(aPIHelper.GetEstados());
            estadosSinOK.Remove(1);
            comboBoxEstado.DataSource = new BindingSource(estadosSinOK, null);


            /// Populate combobox Criticidad 
            comboBoxCriticidad.DisplayMember = "value";
            comboBoxCriticidad.ValueMember = "key";
            comboBoxCriticidad.DataSource = Enum.GetValues(typeof(TypeCriticidad));
        }

        /// <summary>
        /// Agrega una fila a la tabla clientes.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        private void AddItem(Cliente cliente)
        {
            tablaClientes.Rows.Add(cliente.Id, cliente.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        /// <summary>
        /// Agraga una fila a la tabla sucursales
        /// </summary>
        /// <param name="sucursal">The sucursal.</param>
        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Nombreynumero); // Inserta una linea nueva en la tabla clientes
        }

        /// <summary>
        /// Agrega una fila con un grabador a la tabla dispositivos.
        /// </summary>
        /// <param name="dispositivoCCTV">The dispositivo CCTV.</param>
        private void AddItem(DispositivoCCTV dispositivoCCTV)
        {
            tablaMantenible.Rows.Add(dispositivoCCTV.Id, null, "dispositivoCCTV", "[DVR] -> " + dispositivoCCTV.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        /// <summary>
        /// Agrega una fila con una camara a la tabla dispositivos.
        /// </summary>
        /// <param name="dispositivoCCTV">The dispositivo CCTV.</param>
        /// <param name="camara">The camara.</param>
        private void AddItem(DispositivoCCTV dispositivoCCTV, Camara camara)
        {
            tablaMantenible.Rows.Add(dispositivoCCTV.Id, camara.Id, "camara", "[CAMARA]  -> (" + dispositivoCCTV.Nombre + ") : " + camara.Pos + " - " + camara.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        /// <summary>
        /// Handles the KeyUp event of the textBuscarCliente control.
        /// Buscador de cliente
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs" /> instance containing the event data.</param>
        private void textBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            tablaClientes.Rows.Clear();  // Eliminar clientes
            
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nombre.ToUpper().Contains(textBuscarCliente.Text.ToUpper())) AddItem(cliente); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
            }

            tablaClientes.Refresh(); // Refrescar tabla

        }

        /// <summary>
        /// Handles the SelectionChanged event of the tablaClientes control.
        /// Cuando cambia la seleccion del cliente seleccionado muestra la lista de sucursales 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void tablaClientes_SelectionChanged(object sender, EventArgs e)
        {

            tablaSucursales.Rows.Clear();  // Eliminar sucursales
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
                // el cliente no tiene sucursales para mostrar
            }

            tablaSucursales.Refresh(); // Refrescar tabla
        }


        /// <summary>
        /// Handles the Click event of the buttonSiguiente control.
        /// Muesta la siguiente pantalla para el alta de incidentes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel1);
            bunifuTransition1.ShowSync(panel2);
        }

        /// <summary>
        /// Handles the Click event of the Boton_Atras control.
        /// Muesta la pantalla anterior para el alta de incidentes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Boton_Atras_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel2);
            bunifuTransition1.ShowSync(panel1);

        }

        /// <summary>
        /// Handles the Click event of the buttonCancelar control.
        /// Cancela el alta de un incidente
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Incidentes)Parent).showPanelSwitchs();
            Dispose();
        }

        /// <summary>
        /// Handles the Click event of the ButtonFinalizar control.
        /// Completa la carga de un incidente 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            Mantenible mantenible;

            /// Crear un nuevo incidente
            Incidente newIncidente = new Incidente();


            /// Obtener el cliente seleccionado
            DataGridViewSelectedRowCollection rowCliente = tablaClientes.SelectedRows;
            int id_sel_cliente = (int)rowCliente[0].Cells["id_cliente"].Value;
            newIncidente.Id_cliente = id_sel_cliente;

            /// Obtener la sucursal seleccionada
            DataGridViewSelectedRowCollection rowSucursal = tablaSucursales.SelectedRows;
            int id_sel_sucursal = (int)rowSucursal[0].Cells["id_sucursal"].Value;
            newIncidente.Id_suc = id_sel_sucursal;

            /// obtener el tipo de mantenible
            DataGridViewSelectedRowCollection rowMantenible = tablaMantenible.SelectedRows;
            string sel_tipoMantenible = (String)rowMantenible[0].Cells["tipo"].Value;

            /// obtener del combobox el nuevo estado para el dispositivo
            int id_estado = (int)comboBoxEstado.SelectedValue;


            switch (sel_tipoMantenible)
            {
                case "dispositivoCCTV":
                    {
                        /// Obtener el dispositivo
                        int id_sel_disp = (int)rowMantenible[0].Cells["id_disp"].Value;
                        DispositivoCCTV dispositivo = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(id_sel_sucursal, id_sel_disp);
                        mantenible = dispositivo;

                        /// cambiar el estado del dispositivo
                        dispositivo.Id_estado = id_estado;
                        aPIHelper.GetCCTVHelper().AddDispositivoCCTV(dispositivo);

                        /// Peparar datos para crear incidente
                        newIncidente.Id_tipo_mantenible = 1;
                        newIncidente.Id_1 = id_sel_disp;
                    }
                    break;

                case "camara":
                    {
                        /// Obtener la camara
                        int id_sel_disp = (int)rowMantenible[0].Cells["id_disp"].Value;
                        int id_sel_cam = (int)rowMantenible[0].Cells["id_cam"].Value;
                        Camara camara = aPIHelper.GetCCTVHelper().GetCamara(id_sel_disp, id_sel_cam);

                        /// Cambiar el estado de la camara
                        camara.Id_estado = id_estado;
                        aPIHelper.GetCCTVHelper().AddCamara(camara);

                        /// Peparar datos para crear incidente
                        newIncidente.Id_tipo_mantenible = 2;
                        newIncidente.Id_1 = id_sel_disp;
                        newIncidente.Id_2 = id_sel_cam;
                        mantenible = camara;
                    }
                    break;
            }

            /// Obtener criticidad 
            newIncidente.Id_criticidad = (int)comboBoxCriticidad.SelectedValue;

            /// Obtener Falla
            newIncidente.Falla = TextFalla.Text;

            /// Solo se puede marcar un incidente como abierto desde esta ventana

            newIncidente.Id_estado_incidente = (int)TypeEstadoIncidente.Abierto;

            /// Agregar Incidente y Mostrar notificacion
            MensajeAlerta resultado = aPIHelper.GetIncidenteHelper().AddIncidente(newIncidente);
            Alert.ShowAlert(resultado);

            ((ABM_Incidentes)Parent).RefreshTablaIncidentes();
            ((Animated)Parent).showPanelSwitchs();
            Dispose();
        }


        /// <summary>
        /// Handles the SelectionChanged event of the tablaSucursales control.
        /// Cuando la seleccion de la tabla sucursales cambia actualiza la tabla de dispositivos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {
            tablaMantenible.Rows.Clear();  // Eliminar los dispositivos de la tabla

            try
            {
                int id_sucursal_Seleccionada = Convert.ToInt16(tablaSucursales.SelectedRows[0].Cells["id_sucursal"].Value);
                List<DispositivoCCTV> listadispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivosCCTVSucursal(id_sucursal_Seleccionada);
                foreach (DispositivoCCTV dispositivoCCTV in listadispositivoCCTV)
                {
                    if (dispositivoCCTV.Nombre.ToUpper().Contains(TextBuscarMantenible.Text.ToUpper())) AddItem(dispositivoCCTV);
                    List<Camara> listaCamaras = aPIHelper.GetCCTVHelper().GetCamarasDispositivo(dispositivoCCTV.Id);
                    foreach (Camara camara in listaCamaras)
                    {
                        if (camara.Nombre.ToUpper().Contains(TextBuscarMantenible.Text.ToUpper())) AddItem(dispositivoCCTV, camara);
                    }
                }
            }
            catch (Exception )
            {
                /// La sucursal no tiene dispositivos cargados
            }
            tablaMantenible.Refresh(); // Refrescar tabla
        }


        /// <summary>
        /// Mover the slider severidad a boton seleccionado.
        /// FILTRO NO IMPLEMENTADO YA QUE NO ESTAN IMPLEMENTADAS LAS CARACTERISTICAS DE ALARMAS
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void MoverSliderSeveridad(object sender)
        {
            sliderFiltroDispositivo.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            sliderFiltroDispositivo.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
        }

        private void filtroTodo_Click(object sender, EventArgs e)
        {
            MoverSliderSeveridad(sender);
        }

        private void filtroCCTV_Click(object sender, EventArgs e)
        {
            MoverSliderSeveridad(sender);
        }

        private void filtroAlarmas_Click(object sender, EventArgs e)
        {
            MoverSliderSeveridad(sender);
        }

    }
}
