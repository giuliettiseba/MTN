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
    public partial class Alta_Sucursal : UserControl
    {
        
        private APIHelper aPIHelper;
        private int id_cliente;

        public Alta_Sucursal(int id_cliente)
        {
            this.id_cliente = id_cliente;
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            aPIHelper = ((Home)this.Parent.Parent).GetAPIHelper();

            comboBoxProvincia.DisplayMember = "value";
            comboBoxProvincia.ValueMember = "key";
            comboBoxProvincia.DataSource = new BindingSource(aPIHelper.GetProvincias(), null);
        }



        private void LimpiarTodo()
        {
            id_sucursal = 0;
            textNumero.Text = "";
            textNombre.Text = "";
            textDireccion.Text = "";
            comboBoxProvincia.SelectedIndex = -1;
            comboBoxLocalidad.SelectedIndex = -1;
            this.pictureFoto.Image = global::MTN_Administration.Properties.Resources._036_suitcase;
        }

        private void ButtonCancelarAlta_Click(object sender, EventArgs e)
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

        private int id_sucursal;

        internal void Cargar(Sucursal sucursal)
        {
            id_sucursal = sucursal.id;
            textNumero.Text = sucursal.numero;
            textNombre.Text = sucursal.nombre;
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(sucursal.id_localidad);
            comboBoxLocalidad.SelectedValue = sucursal.id_localidad;
            textDireccion.Text = sucursal.direccion;
        }

        private void buttonGuardarAltaSucursal_Click(object sender, EventArgs e)
        {
            Sucursal newSucursal = new Sucursal();
            newSucursal.id = id_sucursal;
            newSucursal.numero = textNumero.Text;
            newSucursal.nombre = textNombre.Text;
            newSucursal.id_cliente = id_cliente;
            newSucursal.direccion = textDireccion.Text;
            newSucursal.id_localidad = (int) comboBoxLocalidad.SelectedValue;
         //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image);
            string result = aPIHelper.PostSucursal(newSucursal);
            System.Windows.Forms.MessageBox.Show(result);
            ((ABM_Sucursales)this.Parent).RefreshTable(0);
            this.Dispose();
        }
    }
}
