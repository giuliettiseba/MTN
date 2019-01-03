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
{
    public partial class Alert : Form
    {


        public Alert(String mensaje, AlertType type)
        {
            InitializeComponent();

            LabelMensaje.Text = mensaje;
            this.Top = -this.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

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

        public static void ShowAlert(String mensaje, AlertType type)
        {
            new Alert(mensaje, type).Show();
        }


        internal static void ShowAlert(MensajeAlerta resultado)
        {
            new Alert(resultado.Mensaje, resultado.Type).Show();
        }


        private void close_Click(object sender, EventArgs e)
        {
            cerrar.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }



        private int interval = 0;
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

        private void cerrar_Tick(object sender, EventArgs e)
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
