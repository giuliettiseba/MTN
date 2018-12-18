﻿using System;
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

        public Alta_Tecnico()
        {

            InitializeComponent();
            
        }


        private void LimpiarTodo()
        {
            aPIHelper = ((AMB_Tecnicos)this.Parent).GetAPIHelper();

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
            
            this.SendToBack();
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
            id_tecnico = tecnico.id;
            textNombre.Text = tecnico.nombre;
            textApellido.Text = tecnico.apellido;
            comboBoxTipoEmpleado.SelectedIndex = tecnico.id_tipo_empleado -1;
            comboBoxTipoDocumento.SelectedIndex = tecnico.id_tipo_documento - 1;
            textDocumento.Text = tecnico.documento.ToString();
            textLegajo.Text = tecnico.legajo.ToString();
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(tecnico.id_localidad);
            comboBoxLocalidad.SelectedValue = tecnico.id_localidad;
            textDireccion.Text = tecnico.direccion;
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
            newTecnico.id = id_tecnico;
            newTecnico.nombre = textNombre.Text;
            newTecnico.apellido = textApellido.Text;
            newTecnico.documento = int.Parse(textDocumento.Text);
            newTecnico.legajo = int.Parse(textLegajo.Text);
            newTecnico.direccion = textDireccion.Text;
            newTecnico.id_tipo_empleado = (int) comboBoxTipoEmpleado.SelectedValue;
            newTecnico.id_tipo_documento = (int) comboBoxTipoDocumento.SelectedValue;
            newTecnico.id_localidad = (int) comboBoxLocalidad.SelectedValue;
         //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image);

            string result = aPIHelper.PostTecnico(newTecnico);

            System.Windows.Forms.MessageBox.Show(result);
            this.SendToBack();
             ((AMB_Tecnicos)this.Parent).RefreshTable();
            
        }

        
    }
}