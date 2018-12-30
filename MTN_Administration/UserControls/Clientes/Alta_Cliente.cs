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

namespace MTN_Administration
{
    public partial class Alta_Cliente : UserControl
    {


        private int id_cliente;
        private APIHelper aPIHelper;


        public Alta_Cliente(APIHelper aPIHelper)
        {
            if (!this.DesignMode)
            {
                this.aPIHelper = aPIHelper;
                InitializeComponent();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            comboBoxProvincia.DisplayMember = "value";
            comboBoxProvincia.ValueMember = "key";
            comboBoxProvincia.DataSource = new BindingSource(aPIHelper.GetProvincias(), null);

        }

        private void ButtonCancelarAltaTecnico_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }

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

        public void Cargar(Cliente cliente)
        {
            id_cliente = cliente.Id;
            textRazonSocial.Text = cliente.Nombre;
            textCUIT.Text = cliente.CUIT;
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(cliente.Id_localidad);
            comboBoxLocalidad.SelectedValue = cliente.Id_localidad;
            textDireccion.Text = cliente.Direccion;
        }

        private void buttonGuardarAltaCliente_Click(object sender, EventArgs e)
        {
            Cliente newCliente = new Cliente();
            newCliente.Id = id_cliente;
            newCliente.Nombre = textRazonSocial.Text;
            newCliente.CUIT = textCUIT.Text;
            newCliente.Direccion = textDireccion.Text;
            newCliente.Id_localidad = (int) comboBoxLocalidad.SelectedValue;
         //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image);
            string result = aPIHelper.GetClientesHelper().AddCliente(newCliente);
            System.Windows.Forms.MessageBox.Show(result);
            ((ABM_Clientes)this.Parent).RefreshTable();
            this.Dispose();
        }
    }
}
