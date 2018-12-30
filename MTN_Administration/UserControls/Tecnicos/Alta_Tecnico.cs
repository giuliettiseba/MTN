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

namespace MTN_Administration
{
    public partial class Alta_Tecnico : UserControl
    {
        
        Dictionary<int, string> provincias;
        Dictionary<int, string> tipo_empleado;
        Dictionary<int, string> tipo_documento;

        APIHelper aPIHelper;

        public Alta_Tecnico(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void LimpiarTodo()
        {
            provincias = aPIHelper.GetProvincias();
            comboBoxProvincia.DisplayMember = "value";
            comboBoxProvincia.ValueMember = "key";
            comboBoxProvincia.DataSource = new BindingSource(provincias, null);

            tipo_documento = aPIHelper.GetTipoDocumento();
            comboBoxTipoDocumento.DataSource = new BindingSource(tipo_documento, null);
            comboBoxTipoDocumento.DisplayMember = "value";
            comboBoxTipoDocumento.ValueMember = "key";

            tipo_empleado = aPIHelper.GetTipoEmpleado();
            comboBoxTipoEmpleado.DataSource = new BindingSource(tipo_empleado, null);
            comboBoxTipoEmpleado.DisplayMember = "value";
            comboBoxTipoEmpleado.ValueMember = "key";

            id_tecnico = 0;
            textNombre.Text = "";
            textApellido.Text = "";
            textDocumento.Text = "";
            textLegajo.Text = "";
            textDireccion.Text = "";

            comboBoxTipoEmpleado.SelectedIndex = -1;
            comboBoxTipoDocumento.SelectedIndex = -1;
            comboBoxProvincia.SelectedIndex = -1;
            comboBoxLocalidad.SelectedIndex = -1;

            this.pictureFoto.Image = global::MTN_Administration.Properties.Resources._008_friend;
            
        }

        private void ButtonCancelarAltaTecnico_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private int id_tecnico;

        internal void Cargar(Tecnico tecnico)
        {
            LimpiarTodo();
            id_tecnico = tecnico.Id;
            textNombre.Text = tecnico.Nombre;
            textApellido.Text = tecnico.Apellido;
            comboBoxTipoEmpleado.SelectedIndex = tecnico.Id_tipo_empleado -1;
            comboBoxTipoDocumento.SelectedIndex = tecnico.Id_tipo_documento - 1;
            textDocumento.Text = tecnico.Documento.ToString();
            textLegajo.Text = tecnico.Legajo.ToString();
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(tecnico.Id_localidad);
            comboBoxLocalidad.SelectedValue = tecnico.Id_localidad;
            textDireccion.Text = tecnico.Direccion;
            this.BringToFront();
        }


        internal void AgregarNuevo()
        {
            LimpiarTodo();
            this.BringToFront();
        }

        private void buttonGuardarAltaTecnico_Click(object sender, EventArgs e)
        {
            Tecnico newTecnico = new Tecnico();
            newTecnico.Id = id_tecnico;
            newTecnico.Nombre = textNombre.Text;
            newTecnico.Apellido = textApellido.Text;
            newTecnico.Documento = int.Parse(textDocumento.Text);
            newTecnico.Legajo = int.Parse(textLegajo.Text);
            newTecnico.Direccion = textDireccion.Text;
            newTecnico.Id_tipo_empleado = (int) comboBoxTipoEmpleado.SelectedValue;
            newTecnico.Id_tipo_documento = (int) comboBoxTipoDocumento.SelectedValue;
            newTecnico.Id_localidad = (int) comboBoxLocalidad.SelectedValue;
         //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image);

            string result = aPIHelper.GetTecnicosHelper().PostTecnico(newTecnico);

            System.Windows.Forms.MessageBox.Show(result);
             ((ABM_Tecnicos)this.Parent).RefreshTable(0);
            Dispose();

        }

        
    }
}
