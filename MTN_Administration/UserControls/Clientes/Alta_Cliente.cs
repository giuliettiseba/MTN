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
using MTN_Administration.Alerts;

namespace MTN_Administration
{
    /// <summary>
    /// Interfaz para dar de alta o modificar un cliente 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Alta_Cliente : UserControl
    {
        private int id_cliente;
        private APIHelper aPIHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Alta_Cliente"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public Alta_Cliente(APIHelper aPIHelper)
        {
            if (!this.DesignMode)
            {
                this.aPIHelper = aPIHelper;
                InitializeComponent();
            }
        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            comboBoxProvincia.DisplayMember = "value";
            comboBoxProvincia.ValueMember = "key";
            comboBoxProvincia.DataSource = new BindingSource(aPIHelper.GetProvincias(), null);
        }


        /// <summary>
        /// Handles the click event of the BotonCargarFoto control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="Exception">No se pede cargar archivo</exception>
        private void BotonCargarFoto_click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog { Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" };

            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                try
                {
                    pictureFoto.Image = Image.FromFile(dialog.FileName);
                }
                catch (Exception)
                {
                    throw new Exception("No se pede cargar archivo");
                }
            }
        }

        /// <summary>
        /// Handles the onItemSelected event of the ComboBoxProvincia control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ComboBoxProvincia_onItemSelected(object sender, EventArgs e)
        {
                comboBoxLocalidad.SelectedIndex = -1;
                int id_provincia = (int)comboBoxProvincia.SelectedValue;
                Dictionary<int, string> localidades = aPIHelper.GetLocalidades(id_provincia);
                comboBoxLocalidad.DataSource = new BindingSource(localidades, null);
                comboBoxLocalidad.DisplayMember = "value";
                comboBoxLocalidad.ValueMember = "key";
                comboBoxLocalidad.Enabled = true;
        }

        /// <summary>
        /// Carga los datos del cliente especificado
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        public void Cargar(Cliente cliente)
        {
            id_cliente = cliente.Id;
            textRazonSocial.Text = cliente.Nombre;
            textCUIT.Text = cliente.CUIT;
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(cliente.Id_localidad);
            comboBoxLocalidad.SelectedValue = cliente.Id_localidad;
            textDireccion.Text = cliente.Direccion;
        }

        /// <summary>
        /// Handles the Click event of the ButtonGuardarAltaCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonGuardarAltaCliente_Click(object sender, EventArgs e)
        {
            Cliente newCliente = new Cliente();
            newCliente.Id = id_cliente;
            newCliente.Nombre = textRazonSocial.Text;
            newCliente.CUIT = textCUIT.Text;
            newCliente.Direccion = textDireccion.Text;
            newCliente.Id_localidad = (int) comboBoxLocalidad.SelectedValue;
            //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image);

            MensajeAlerta resultado = aPIHelper.GetClientesHelper().AddCliente(newCliente);
            Alert.ShowAlert(resultado);

            ((ABM_Clientes)this.Parent).RefreshTable();
            this.Dispose();
        }

        /// <summary>
        /// Handles the Click event of the ButtonCancelarAltaTecnico control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelarAltaTecnico_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
