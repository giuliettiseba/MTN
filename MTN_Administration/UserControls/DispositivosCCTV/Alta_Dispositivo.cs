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
using MTN_Administration.Tabs;
using System.Net;
using MTN_Administration.Alerts;

namespace MTN_Administration
{
    /// <summary>
    /// Interfaz Alta de dispositivos. Se utiliza tanto para alta como para modificaciones
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Alta_Dispositivo : UserControl
    {

        private APIHelper aPIHelper;
        private Bitmap image_ok;
        private Bitmap image_error;
        private Bitmap image_warning;
        private int id_sucursal;
        private int id_dispositivo;
        private int id_cliente;

        /// <summary>
        /// Initializes a new instance of the <see cref="Alta_Dispositivo"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        /// <param name="id_cliente">The identifier cliente.</param>
        /// <param name="id_sucursal">The identifier sucursal.</param>
        public Alta_Dispositivo(APIHelper aPIHelper, int id_cliente, int id_sucursal)
        {
            this.aPIHelper = aPIHelper;
            this.id_cliente = id_cliente;
            this.id_sucursal = id_sucursal;

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

            /// Populate Combobox Marca 
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";
            comboBoxMarca.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetMarcaCCTV(), null);

            /// Populate Combobox Estado
            comboBoxEstado.DataSource = Enum.GetValues(typeof(TypeEstadoMantenible));



            /// Populate Combobox Cliente
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "id";
            comboBoxCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);
            comboBoxCliente.SelectedValue = id_cliente;

            // Oculto la columna Id, no tiene ningun valor para el usuario. 
            tablaCamaras.Columns[3].Visible = false;
        }

        /// <summary>
        /// Refreshes the table.
        /// </summary>
        public void RefreshTableCamaras()
        {
            tablaCamaras.Rows.Clear();
            foreach (Camara camara in aPIHelper.GetCCTVHelper().GetCamarasDispositivo(id_dispositivo))
            {
                AddItem(camara);
            }
            tablaCamaras.Refresh();
        }


        /// <summary>
        /// Agrega una nueva fila a la tabla
        /// </summary>
        /// <param name="camara">The camara.</param>
        private void AddItem(Camara camara)
        {
            tablaCamaras.Rows.Add();
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["pos"].Value = camara.Pos;
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["nombre"].Value = camara.Nombre;
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["id"].Value = camara.Id;


            Image image = null;
            switch (camara.Id_estado)
            {
                case TypeEstadoMantenible.Normal:
                    image = image_ok;
                    break;
                case TypeEstadoMantenible.No_Conecta:
                    image = image_error;
                    break;
                case TypeEstadoMantenible.Falla:
                    image = image_warning;
                    break;

                case TypeEstadoMantenible.En_Reparacion:
                    image = image_warning;
                    break;


            }
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["estado"].Value = image;
        }

        /// <summary>
        /// Handles the Click event of the ButtonCancelarAlta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Carga la informacion de un dispositivo para modificar sus parametros
        /// </summary>
        /// <param name="cliente_id">The cliente identifier.</param>
        /// <param name="grabadorDigital">The grabador digital.</param>
        internal void Cargar(int cliente_id, DispositivoCCTV grabadorDigital)
        {
            id_dispositivo = grabadorDigital.Id;
            id_sucursal = grabadorDigital.Id_sucursal;

            DatePicketFechaDeInstalacion.Value = grabadorDigital.Fecha_insta;

            comboBoxCliente.SelectedValue = cliente_id;
            comboBoxSucursal.SelectedValue = grabadorDigital.Id_sucursal;

            textNombre.Text = grabadorDigital.Nombre;

            ModeloCCTV modeloSeleccionado = aPIHelper.GetCCTVHelper().GetModeloCCTV(grabadorDigital.Id_Modelo);
            comboBoxMarca.SelectedValue = modeloSeleccionado.Id_marca;
            comboBoxModelo.SelectedValue = modeloSeleccionado.Id;

            string[] valuesIP = grabadorDigital.Ip.Split('.'); ;
            TextIP_OCT_1.Text = valuesIP[0];
            TextIP_OCT_2.Text = valuesIP[1];
            TextIP_OCT_3.Text = valuesIP[2];
            TextIP_OCT_4.Text = valuesIP[3];

            string[] valuesMask = grabadorDigital.Mask.Split('.'); ;
            Text_Mask_OCT_1.Text = valuesMask[0];
            Text_Mask_OCT_2.Text = valuesMask[1];
            Text_Mask_OCT_3.Text = valuesMask[2];
            Text_Mask_OCT_4.Text = valuesMask[3];

            string[] valuesGateway = grabadorDigital.Gateway.Split('.'); ;
            Text_Gateway_OCT_1.Text = valuesGateway[0];
            Text_Gateway_OCT_2.Text = valuesGateway[1];
            Text_Gateway_OCT_3.Text = valuesGateway[2];
            Text_Gateway_OCT_4.Text = valuesGateway[3];

            Text_NumeroSerie.Text = grabadorDigital.Sn;
            text_Observaciones.Text = grabadorDigital.Observaciones;

            comboBoxEstado.SelectedItem = grabadorDigital.Id_estado;

            RefreshTableCamaras();
        }

        /// <summary>
        /// Handles the Click event of the buttonGuardarAltaDispositivo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonGuardarAltaDispositivo_Click(object sender, EventArgs e)
        {
            try /// Mejorar la validacion de datos
            {
                if (textNombre.Text == "")
                    throw new Exception("Debe ingresar un nombre"); // Valida que se este cargado un nombre



                DispositivoCCTV newDispositivoCCTV = new DispositivoCCTV();

                newDispositivoCCTV.Id_sucursal = (int)comboBoxSucursal.SelectedValue;

                newDispositivoCCTV.Id = this.id_dispositivo;

                newDispositivoCCTV.Nombre = textNombre.Text;
                newDispositivoCCTV.Id_Modelo = (int)comboBoxModelo.SelectedValue;

                newDispositivoCCTV.Ip = TextIP_OCT_1.Text + ".";
                newDispositivoCCTV.Ip += TextIP_OCT_2.Text + ".";
                newDispositivoCCTV.Ip += TextIP_OCT_3.Text + ".";
                newDispositivoCCTV.Ip += TextIP_OCT_4.Text;

                newDispositivoCCTV.Mask = Text_Mask_OCT_1.Text + ".";
                newDispositivoCCTV.Mask += Text_Mask_OCT_2.Text + ".";
                newDispositivoCCTV.Mask += Text_Mask_OCT_3.Text + ".";
                newDispositivoCCTV.Mask += Text_Mask_OCT_4.Text;

                newDispositivoCCTV.Gateway = Text_Gateway_OCT_1.Text + ".";
                newDispositivoCCTV.Gateway += Text_Gateway_OCT_2.Text + ".";
                newDispositivoCCTV.Gateway += Text_Gateway_OCT_3.Text + ".";
                newDispositivoCCTV.Gateway += Text_Gateway_OCT_4.Text;

                newDispositivoCCTV.Fecha_insta = DatePicketFechaDeInstalacion.Value;

                newDispositivoCCTV.Sn = Text_NumeroSerie.Text;
                newDispositivoCCTV.Id_estado = (TypeEstadoMantenible)comboBoxEstado.SelectedItem;

                newDispositivoCCTV.Observaciones = text_Observaciones.Text;

                MensajeAlerta resultado = aPIHelper.GetCCTVHelper().AddDispositivoCCTV(newDispositivoCCTV);
                Alert.ShowAlert(resultado);

                ((ABM_Dispositivos)this.Parent).RefreshTableDispositivos();
                this.Dispose();


            }
            catch (Exception ex)
            {

                Alert.ShowAlert("Error al agregar dispositivo. " + ex.ToString(), AlertType.error);
            }
        }


        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBoxMarca control.
        /// Cuando cambia el elemento seleccionado del BomboboxMarca Muesta la lista de grabadores de esa marca
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
            comboBoxModelo.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetModelosMarcasCCTV((int)comboBoxMarca.SelectedValue), null);
        }

        private Alta_Camara alta_Camara;
        /// <summary>
        /// Handles the Click event of the botonAgregarCamara control.
        /// Muestra la interfaz para dar de alta una nueva camara en el grabador
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonAgregarCamara_Click(object sender, EventArgs e)
        {
            if (id_dispositivo == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Para poder agregar camaras primero debe guardar los cambios del grabador", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    ButtonGuardarAltaDispositivo_Click(null, null);
            }
            else
            {
                this.alta_Camara = new Alta_Camara(id_dispositivo, aPIHelper)
                {
                    Location = new System.Drawing.Point(0, 0),
                    Name = "alta_Camara",
                    Size = new System.Drawing.Size(727, 561),
                    TabIndex = 6
                };
                this.Controls.Add(this.alta_Camara);
                this.alta_Camara.BringToFront();
            }
        }

        /// <summary>
        /// Handles the Click event of the botonModificarCamara control.
        /// Muestra la interfaz con para modificar los parametros de una camara
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonModificarCamara_Click(object sender, EventArgs e)
        {
            int id_camara = (int)tablaCamaras.SelectedRows[0].Cells["id"].Value;
            Camara camara = aPIHelper.GetCCTVHelper().GetCamara(id_dispositivo, id_camara);
            BotonAgregarCamara_Click(sender, e);
            this.alta_Camara.Cargar(camara);
        }

        /// <summary>
        /// Handles the SelectedValueChanged event of the comboBoxCliente control.
        /// Cuando cambia la seleccion del cliente muestra la sucursales del cliente seleccionado
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ComboBoxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            /// Polulate Combobox Sucursales
            comboBoxSucursal.DisplayMember = "Nombre";
            comboBoxSucursal.ValueMember = "Id";
            comboBoxSucursal.DataSource = new BindingSource(aPIHelper.GetSucursalesHelper().GetSucursales((int)comboBoxCliente.SelectedValue), null);
            comboBoxSucursal.SelectedValue = id_sucursal;

        }

        /// <summary>
        /// Handles the Click event of the botonEliminarCamara control.
        /// Elimina la camara seleccionada
        /// 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonEliminarCamara_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar la camara", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRow = tablaCamaras.SelectedRows;
                aPIHelper.GetCCTVHelper().RemoveCamara((int)selectedRow[0].Cells["id"].Value);
                RefreshTableCamaras();
            }
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the tablaCamaras control. 
        /// Abre la interfar Modificar camara
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaCamaras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BotonModificarCamara_Click(sender, e);
        }
    }
}
