using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Tabs;
using MTN_Administration.Alerts;

namespace MTN_Administration
{
    /// <summary>
    /// Intefaz Alta de Sucursales
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Alta_Sucursales : UserControl
    {
        private APIHelper aPIHelper;
        private int id_cliente;

        /// <summary>
        /// Initializes a new instance of the <see cref="Alta_Sucursales"/> class.
        /// </summary>
        /// <param name="id_cliente">The identifier cliente.</param>
        /// <param name="aPIHelper">a pi helper.</param>
        public Alta_Sucursales(int id_cliente, APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            this.id_cliente = id_cliente;
            if (!this.DesignMode)
            {
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

            /// Populate combox Provincia
            comboBoxProvincia.DisplayMember = "value";
            comboBoxProvincia.ValueMember = "key";
            comboBoxProvincia.DataSource = new BindingSource(aPIHelper.GetProvincias(), null);
        }

        /// <summary>
        /// Handles the Click event of the ButtonCancelarAlta control.
        /// Cuando el usuario hace click sobre el boton cancelar alta, cierra la interfaz Alta sucursales y 
        /// Muestra la interfaz AMB sucursales
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelarAlta_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }


        /// <summary>
        /// Handles the click event of the BotonCargarFoto control.
        /// Cuando el usuario hace click sobre el boton Cargar Foto muestra la ventana de seleccion de archivos 
        /// con los filtros para los tipos de archivos de imagenes mas utilizados.
        /// 
        /// FALTA IMPLEMENTAR EL MANEJO DE IMAGENES
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.Exception">No se pede cargar archivo</exception>
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
        /// Cuando se selecciona una provincia habilita el combobox de localidad mostrando las 
        /// localidades de la provincia seleccionada.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ComboBoxProvincia_onItemSelected(object sender, EventArgs e)
        {
            if (comboBoxProvincia.SelectedValue == null) { comboBoxLocalidad.Enabled = false; }
            else
            {
                comboBoxLocalidad.SelectedIndex = -1;
                int id_provincia = (int)comboBoxProvincia.SelectedValue;
                Dictionary<int, string> localidades = aPIHelper.GetLocalidades(id_provincia);
                comboBoxLocalidad.DataSource = new BindingSource(localidades, null);
                comboBoxLocalidad.DisplayMember = "value";
                comboBoxLocalidad.ValueMember = "key";
                comboBoxLocalidad.Enabled = true;
            }
        }

        private int id_sucursal;
        /// <summary>
        /// Carga los datos de una sucursal para modificar sus parametros
        /// </summary>
        /// <param name="sucursal">The sucursal.</param>
        internal void Cargar(Sucursal sucursal)
        {
            id_sucursal = sucursal.Id;
            textNumero.Text = sucursal.Numero;
            textNombre.Text = sucursal.Nombre;
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(sucursal.Id_localidad);
            comboBoxLocalidad.SelectedValue = sucursal.Id_localidad;
            textDireccion.Text = sucursal.Direccion;
        }

        /// <summary>
        /// Handles the Click event of the buttonGuardarAltaSucursal control.
        /// Cuando el usuario preciona el boton Guardar Sucural. Guarda o modifica la sucursal.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonGuardarAltaSucursal_Click(object sender, EventArgs e)
        {
            Sucursal newSucursal = new Sucursal();
            newSucursal.Id = id_sucursal;
            newSucursal.Numero = textNumero.Text;
            newSucursal.Nombre = textNombre.Text;
            newSucursal.Id_cliente = id_cliente;
            newSucursal.Direccion = textDireccion.Text;
            newSucursal.Id_localidad = (int) comboBoxLocalidad.SelectedValue;
            //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image); 

            MensajeAlerta resultado = aPIHelper.GetSucursalesHelper().AddSucursal(newSucursal);
            Alert.ShowAlert(resultado);

            ((ABM_Sucursales)this.Parent).RefreshTable();
            this.Dispose();
        }
    }
}
