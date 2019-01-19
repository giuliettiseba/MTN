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
    /// Interfaz de Administracion de dispositivos de CCTV
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ABM_Dispositivos : UserControl
    {
        APIHelper aPIHelper;
        private Alta_Dispositivo alta_Dispositivo;
        private List<DispositivoCCTV> listaGrabadores;
        private Bitmap image_ok;
        private Bitmap image_error;
        private Bitmap image_warning;

        /// <summary>
        /// Initializes a new instance of the <see cref="ABM_Dispositivos"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public ABM_Dispositivos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));
        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            comboCliente.DisplayMember = "Nombre";
            comboCliente.ValueMember = "id";
            comboCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);
        }

        /// <summary>
        /// Refresca el contenido de la tabla de grabadores.
        /// </summary>
        public void RefreshTableDispositivos()
        {
            
            tablaGrabadoresDigitales.Refresh();
            listaGrabadores = aPIHelper.GetCCTVHelper().GetDispositivosCCTVSucursal(GetSucursalSeleccionada());
            foreach (DispositivoCCTV grabador in listaGrabadores)
            {
                AddItem(grabador);
            }
            tablaGrabadoresDigitales.Rows.Clear();
        }


        /// <summary>
        /// Agrega una fila en la tabla de grabadores.
        /// </summary>
        /// <param name="grabador">The grabador.</param>
        private void AddItem(DispositivoCCTV grabador)
        {
            tablaGrabadoresDigitales.Rows.Add();
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["id"].Value = grabador.Id;
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["nombre"].Value = grabador.Nombre;
            ModeloCCTV _modelo = aPIHelper.GetCCTVHelper().GetModeloCCTV(grabador.Id_Modelo);
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["modelo"].Value = _modelo.Nombre;
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["marca"].Value = aPIHelper.GetCCTVHelper().GetMarcaCCTV(_modelo.Id_marca).Nombre;

            Image image;
            switch (grabador.Id_estado)
            {
                case 1:
                    image = image_ok;
                    break;
                case 2:
                    image = image_error;
                    break;
                case 3:
                    image = image_warning;
                    break;

                default:
                    image = image_warning;
                    break;
            }
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["estado"].Value = image;
        }

        /// <summary>
        /// Handles the Click event of the BotonAgregarDispotivo control.
        /// Muestra la interfaz de Alta de dispositivo de CCTV
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonAgregarDispotivo_Click(object sender, EventArgs e)
        {
            if (GetSucursalSeleccionada() != 0)
            {
                this.alta_Dispositivo = new Alta_Dispositivo(aPIHelper, ObtenerClienteSeleccionado().Id, GetSucursalSeleccionada());
                this.alta_Dispositivo.Location = new System.Drawing.Point(0, 0);
                this.alta_Dispositivo.Name = "alta_Cliente";
                this.alta_Dispositivo.Size = new System.Drawing.Size(727, 561);
                this.alta_Dispositivo.TabIndex = 6;
                this.Controls.Add(this.alta_Dispositivo);
                this.alta_Dispositivo.BringToFront();
            }
            else
            {
                Alert.ShowAlert("ERROR: Se debe agregar una sucural al cliente.", AlertType.error);
            }
        }


        /// <summary>
        /// Handles the Click event of the buttonEditarDispositivo control.
        /// Muestra la venta de Alta de dispositivo con los datos del dispositivo seleccionado 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonEditarDispositivo_Click(object sender, EventArgs e)
        {
            // obtengo el id del dispositivo seleccionado en la tabla
            int id_dispositivoCCTV = (int)tablaGrabadoresDigitales.SelectedRows[0].Cells["id"].Value;

            // obtengo el dispositivo con el CCTVHelper
            DispositivoCCTV dispositivoCCTV = ObtenerDispositivoSeleccionado();

            // Cargo la interfaz 
            BotonAgregarDispotivo_Click(sender, e);

            // completo los campos
            alta_Dispositivo.Cargar((int)comboCliente.SelectedValue, dispositivoCCTV);
        }


        /// <summary>
        /// Handles the CellDoubleClick event of the TablaDipositivo control.
        /// Muestra la venta de Alta de dispositivo con los datos del dispositivo seleccionado 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaDipositivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditarDispositivo_Click(sender, e);
        }


        /// <summary>
        /// Obtiene el cliente seleccionado en la tabla clientes.
        /// </summary>
        /// <returns></returns>
        private Cliente ObtenerClienteSeleccionado()
        {

            int id_cliente = (int)comboCliente.SelectedValue;
            return aPIHelper.GetClientesHelper().GetCliente(id_cliente);
        }

        /// <summary>
        /// Obtiene la sucursal seleccionada en la tabla de sucursales.
        /// </summary>
        /// <returns></returns>
        private Sucursal ObtenerSucuralSeleccionada()
        {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            int id_sucursal = (int)selectedRow[0].Cells["idSuc"].Value;
            return aPIHelper.GetSucursalesHelper().GetSucursal(ObtenerClienteSeleccionado().Id, id_sucursal);
        }


        /// <summary>
        /// Obtiene el Dispositivo seleccionado de la tabla de dispositivos.
        /// </summary>
        /// <returns></returns>
        private DispositivoCCTV ObtenerDispositivoSeleccionado()
        {
            DataGridViewSelectedRowCollection selectedRow = tablaGrabadoresDigitales.SelectedRows;
            int id_dispositivo = (int)selectedRow[0].Cells["id"].Value;
            return aPIHelper.GetCCTVHelper().GetDispositivoCCTV(ObtenerSucuralSeleccionada().Id, id_dispositivo);
        }

        /// <summary>
        /// Handles the Click event of the BotonEliminar control.
        /// Elimina el dispositivo seleccionado de la base de datos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar el grabador", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MensajeAlerta resultado = aPIHelper.GetCCTVHelper().RemoveDispositivoCCTV(ObtenerDispositivoSeleccionado());
                Alert.ShowAlert(resultado);
                RefreshTableDispositivos();
            }
        }


        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboCliente control.
        /// Cuando cambia el cliente seleccionado muestra la lista de sucursales del cliente en la tabla sucursales
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
         private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshComboSucursales((int)comboCliente.SelectedValue);
        }


        /// <summary>
        /// Refresca la tabla sucursales de acuerdo al cliente seleccionado
        /// </summary>
        /// <param name="id_cliente_seleccionado">The selected cliente.</param>
        private void RefreshComboSucursales(int id_cliente_seleccionado)
        {
            tablaSucursales.Rows.Clear();
            tablaSucursales.Refresh();
            List<Sucursal> listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales(id_cliente_seleccionado);
            foreach (Sucursal sucursal in listaSucursales)
            {
                if (sucursal.Id_cliente == (int)comboCliente.SelectedValue)
                {
                    AddItem(sucursal);
                }
            }
        }


        /// <summary>
        /// Agrega un nuevo item a la tabla de sucursales
        /// </summary>
        /// <param name="sucursal">The sucursal.</param>
        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Numero, sucursal.Nombre);
        }


        /// <summary>
        /// Handles the SelectionChanged event of the tablaSucursales control.
        /// Cuando cambia la fila seleccionada en la tabla de sucursales muestra la lista de dispositivos en la tabla dispositivos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {
            RefreshTableDispositivos();
        }


        /// <summary>
        /// Obtiene el ID de la sucursal seleccionada en la tabla sucursales.
        /// </summary>
        /// <returns></returns>
        private int GetSucursalSeleccionada()
        {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;

            if (selectedRow.Count != 0 && selectedRow[0].Cells["idSuc"].Value != null)
                return (int)selectedRow[0].Cells["idSuc"].Value;
            return 0;
        }
    }
}
