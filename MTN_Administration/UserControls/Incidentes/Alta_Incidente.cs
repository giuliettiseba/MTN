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
    public partial class Alta_Incidente : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        public Alta_Incidente(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel2.Location = new System.Drawing.Point(0, 0);

            bunifuTransition1.ShowSync(panel1);

        }
        List<Cliente> listaClientes;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listaClientes = aPIHelper.GetClientesHelper().GetClientes(); // Obtener Lista de clientes

            // Llenar la tabla cliente con todos los clientes
            foreach (Cliente cliente in listaClientes)
            {
                AddItem(cliente);
            }


            comboBoxEstado.DisplayMember = "value";
            comboBoxEstado.ValueMember = "key";
            Dictionary<int, string> estadosSinOK = new Dictionary<int, string>(aPIHelper.GetEstados());
            estadosSinOK.Remove(1);
            comboBoxEstado.DataSource = new BindingSource(estadosSinOK, null);



            comboBoxCriticidad.DisplayMember = "value";
            comboBoxCriticidad.ValueMember = "key";
            comboBoxCriticidad.DataSource = new BindingSource(aPIHelper.GetCriticidad(), null);

/*
            ComboBoxEstadoIncidente.DisplayMember = "value";
            ComboBoxEstadoIncidente.ValueMember = "key";
            ComboBoxEstadoIncidente.DataSource = new BindingSource(aPIHelper.GetEstadoIncidente(), null);*/

        }

        private void AddItem(Cliente cliente)
        {
            tablaClientes.Rows.Add(cliente.Id, cliente.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Nombreynumero); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(DispositivoCCTV dispositivoCCTV)
        {
            tablaMantenible.Rows.Add(dispositivoCCTV.Id, null, "dispositivoCCTV", "[DVR] -> " + dispositivoCCTV.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(DispositivoCCTV dispositivoCCTV, Camara camara)
        {
            tablaMantenible.Rows.Add(dispositivoCCTV.Id, camara.Id, "camara", "[CAMARA]  -> (" + dispositivoCCTV.Nombre + ") : " + camara.Pos + " - " + camara.Nombre); // Inserta una linea nueva en la tabla clientes
        }






        private void textBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            tablaClientes.Rows.Clear();  // Eliminar clientes
            tablaClientes.Refresh(); // Refrescar tabla

            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nombre.ToUpper().Contains(textBuscarCliente.Text.ToUpper())) AddItem(cliente); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
            }
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

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel1);
            bunifuTransition1.ShowSync(panel2);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Incidentes)Parent).showPanelSwitchs();
            Dispose();
        }

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
                default:
                    break;
            }

             /// Obtener criticidad 
            newIncidente.Id_criticidad = (int)comboBoxCriticidad.SelectedValue;

            /// Obtener Falla
            newIncidente.Falla = TextFalla.Text;

            /// Solo se puede marcar un incidente como abierto desde esta ventana

            newIncidente.Id_estado_incidente = (int) TypeEstadoIncidente.Abierto;

            /// Agregar Incidente y Mostrar notificacion
            MensajeAlerta resultado = aPIHelper.GetIncidenteHelper().AddIncidente(newIncidente);
            Alert.ShowAlert(resultado);
            ((ABM_Incidentes)Parent).RefreshTablaIncidentes();
            ((Animated)Parent).showPanelSwitchs();
            Dispose();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel2);
            bunifuTransition1.ShowSync(panel1);

        }

        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {
            tablaMantenible.Rows.Clear();  // Eliminar clientes

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
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
            tablaMantenible.Refresh(); // Refrescar tabla
        }



        private void textBuscarSucural_OnValueChanged(object sender, EventArgs e)
        {

        }



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
