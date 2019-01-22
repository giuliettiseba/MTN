using MTN_Administration.APIHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTN_Administration.Alerts
{   /// <summary>
    /// Clase alerta, Muestra una notificacion cuando se modifica la base de datos. 
    /// Existen 4 tipos de notificaciones
    /// 1) Success. Cuando la accion se llevo a cabo correctamente
    /// 2) Info. cuando se quiere notificar algun evento 
    /// 3) Warning. Un evento que requiere especial atencion del usuario
    /// 4) Error. Cuando no existe algun error en la accion solicitada
    /// </summary>
    public partial class Alert : Form
    {

        /// <summary>
        /// Constructor de la notificacion
        /// </summary>
        /// <param name="mensaje">Mensaje que se mostrara en la notificacion</param>
        /// <param name="type">Tipo de notificacion</param>
        public Alert(String mensaje, AlertType type)
        {
            InitializeComponent();
            LabelMensaje.Text = mensaje;
            this.Top = -this.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;


            /// determina el tipo de notificacion para seleccionar la imagen y el color de la ventana foltante
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    iconImage.Image = imageList1.Images[0];
                    Logger.AgregarEntrada(DateTime.Now + ":" + mensaje, Logger.Severity.informative);
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    iconImage.Image = imageList1.Images[1];
                    Logger.AgregarEntrada(DateTime.Now + ":" + mensaje, Logger.Severity.informative);
                    break;
                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    iconImage.Image = imageList1.Images[2];
                    Logger.AgregarEntrada(DateTime.Now + ":" + mensaje, Logger.Severity.warning);
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    iconImage.Image = imageList1.Images[3];
                    Logger.AgregarEntrada(DateTime.Now + ":" + mensaje, Logger.Severity.error);
                    break;

            }

        }


        /// <summary>
        /// Metodo estatico para mostrar la alerta. 
        /// </summary>
        /// <param name="mensaje">Menaje</param>
        /// <param name="type">Tipo de notificacion</param>
        public static void ShowAlert(String mensaje, AlertType type)
        {
            new Alert(mensaje, type).Show();
        }

        /// <summary>
        /// Metodo estatico para mostrar la aleta
        /// </summary>
        /// <param name="resultado">respuesta que etregan las Helpers con los metodos de AMB</param>
        internal static void ShowAlert(MensajeAlerta resultado)
        {
            new Alert(resultado.Mensaje, resultado.Type).Show();
        }

        /// <summary>
        /// Cierra la ventana flotante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            cerrar.Start();
        }


        /// <summary>
        /// Cierra la ventana flotante despues de un tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }



        private int interval = 0;
        /// <summary>
        /// Efecto de animacion para mostrar la ventana flotante. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }


        /// <summary>
        /// Efecto de para desaparecer la notificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cerrar_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else { this.Close(); }
        }
    }




    public enum AlertType
    {
        success, info, warning, error
    }
}
