using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;

namespace MTN_Administration
{

    /// <summary>
    /// Interfaz Alta Tecnico
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Alta_Tecnico : UserControl
    {

        private Dictionary<int, string> provincias;
        private int id_tecnico;
        private APIHelper aPIHelper;

        public Alta_Tecnico(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        /// <summary>
        /// Limpiars the todo.
        /// </summary>
        private void LimpiarTodo()
        {

            /// Populate combobox provincias
            provincias = aPIHelper.GetProvincias();
            comboBoxProvincia.DisplayMember = "value";
            comboBoxProvincia.ValueMember = "key";
            comboBoxProvincia.DataSource = new BindingSource(provincias, null);

            /// Populate Combobox  Tipo Documento
            comboBoxTipoDocumento.DataSource = Enum.GetValues(typeof(TypeDocumento));

            /// Populate Combobox Tipo de empleado
            comboBoxTipoEmpleado.DataSource = Enum.GetValues(typeof(TypeEmpleado));

            id_tecnico = 0;
            textNombre.Text = "";
            textApellido.Text = "";
            textDocumento.Text = "";
            textLegajo.Text = "";
            textDireccion.Text = "";

            comboBoxTipoEmpleado.SelectedIndex = -1;

            this.pictureFoto.Image = global::MTN_Administration.Properties.Resources._008_friend;
        }

        /// <summary>
        /// Handles the Click event of the ButtonCancelarAltaTecnico control.
        /// Cancela el alta o modificacion de un tecnico y retorna a la interfaz AMB Tecnico
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelarAltaTecnico_Click(object sender, EventArgs e)
        {
            Dispose();
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
                //comboBoxLocalidad.SelectedIndex = -1;
                int id_provincia = (int)comboBoxProvincia.SelectedValue;
                Dictionary<int, string> localidades = aPIHelper.GetLocalidades(id_provincia);
                comboBoxLocalidad.DataSource = new BindingSource(localidades, null);
                comboBoxLocalidad.DisplayMember = "value";
                comboBoxLocalidad.ValueMember = "key";
                comboBoxLocalidad.Enabled = true;
            }
        }

        /// <summary>
        /// Carga los datos de un tecnico para modificar
        /// </summary>
        /// <param name="tecnico">The tecnico.</param>
        internal void Cargar(Tecnico tecnico)
        {
            LimpiarTodo();
            id_tecnico = tecnico.Id;
            textNombre.Text = tecnico.Nombre;
            textApellido.Text = tecnico.Apellido;
            comboBoxTipoEmpleado.SelectedIndex = tecnico.Id_tipo_empleado - 1;
            comboBoxTipoDocumento.SelectedIndex = tecnico.Id_tipo_documento - 1;
            textDocumento.Text = tecnico.Documento.ToString();
            textLegajo.Text = tecnico.Legajo.ToString();
            comboBoxProvincia.SelectedValue = aPIHelper.GetProvincia(tecnico.Id_localidad);
            comboBoxLocalidad.SelectedValue = tecnico.Id_localidad;
            textDireccion.Text = tecnico.Direccion;
            this.BringToFront();
        }


        /// <summary>
        /// Handles the Click event of the buttonGuardarAltaTecnico control.
        /// Valida que los datos ingresados esten correctos luego guardad un tecnico nuevo o modifica un tecnico
        /// existente.
        /// Al finalizar muestra una notificacion con el resultado de la operacion
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.Exception">
        /// Debe ingresar un nombre 
        /// or
        /// Debe ingresar un apellido
        /// or
        /// Numero de documento invalido
        /// or
        /// Numero de legajo invalido
        /// or
        /// Elejir tipo de empleado
        /// or
        /// Elejir tipo de documento
        /// </exception>
        private void ButtonGuardarAltaTecnico_Click(object sender, EventArgs e)
        {
            Tecnico newTecnico = new Tecnico { Id = id_tecnico }; // Crea un nuevo tecnico, si es una modificacion carga el ID

            try
            {
                if (textNombre.Text != "")
                    newTecnico.Nombre = textNombre.Text;
                else
                    throw new Exception("Debe ingresar un nombre"); // Valida que se este cargado un nombre

                if (textApellido.Text != "")
                    newTecnico.Apellido = textApellido.Text;
                else
                    throw new Exception("Debe ingresar un apellido");  // Valida que se este cargado un apellido

                if (int.TryParse(textDocumento.Text, out int nd))
                    newTecnico.Documento = nd;
                else
                    throw new Exception("Numero de documento invalido");  // Valida que el numero de documento sea un numero

                if (int.TryParse(textLegajo.Text, out int nl))
                    newTecnico.Legajo = nl;
                else
                    throw new Exception("Numero de legajo invalido");  // Valida que el numero de legajo sea un numero

                newTecnico.Direccion = textDireccion.Text;

                if (comboBoxTipoEmpleado.SelectedValue != null)
                    newTecnico.Id_tipo_empleado = (int)comboBoxTipoEmpleado.SelectedValue;
                else
                {
                    throw new Exception("Elejir tipo de empleado");  // Valida que se este seleccionado un tipo de empleado
                }

                if (comboBoxTipoDocumento.SelectedValue != null)
                    newTecnico.Id_tipo_documento = (int)comboBoxTipoDocumento.SelectedValue;
                else
                {
                    throw new Exception("Elejir tipo de documento");  // Valida que se este seleccionado un tipo de documento
                }

                newTecnico.Id_localidad = (int)comboBoxLocalidad.SelectedValue;

                //   newTecnico.foto = ImageProcess.imageToByteArray(pictureFoto.Image);

                MensajeAlerta resultado = aPIHelper.GetTecnicosHelper().AddTecnico(newTecnico); // Guarda o modifica el tecnico en la base de datos

                Alert.ShowAlert(resultado); // muestra el mensaje de exito
                ((ABM_Tecnicos)this.Parent).RefreshTable(); // refresca la tabla tecnicos en la interfaz de administracion de Tecnicos
                Dispose(); // cierra la interfaz alta tencicos
            }
            catch (Exception ex)
            {
                Alert.ShowAlert("ERROR" + Environment.NewLine + ex.Message, AlertType.error); // Muestra la notificacion con el error correspondiente
            }
        }
    }
}
