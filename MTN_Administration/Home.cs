using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTN_Administration
{
    public partial class Home : Form
    {

        public Home()
        {
            
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            
        }

    





        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
            TituloHeader.Text = "Dashboard";
            headerDashboardPicture.Show();
            headerTecnicoPicture.Hide();
            headerClientePicture.Hide();


        }

        private void TecnicosButton_Click(object sender, EventArgs e)
        {
            amB_Tecnicos1.BringToFront();
            TituloHeader.Text = "Administracion de Tecnicos";
            headerDashboardPicture.Hide();
            headerTecnicoPicture.Show();
            headerClientePicture.Hide();

        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            TituloHeader.Text = "Administracion de Clientes";
            headerDashboardPicture.Hide();
            headerTecnicoPicture.Hide();
            headerClientePicture.Show();

        }
    }
}
