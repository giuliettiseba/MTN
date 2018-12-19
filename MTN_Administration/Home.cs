using MTN_Administration.Tabs;
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

        private APIHelper aPIHelper;
        private AMB_Tecnicos aBM_Tecnicos;
        private ABM_Clientes aBM_Clientes;
        private ABM_Sucursales aBM_Sucursales;


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        public Home()
        {
            if (!this.DesignMode)
            {
                aPIHelper = new APIHelper();
                InitializeComponent();
                Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            }
        }

        internal APIHelper GetAPIHelper()
        {
            return aPIHelper;
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
            headerSucursalesPicture.Hide();
        }


        private void TecnicosButton_Click(object sender, EventArgs e)
        {

            if (aBM_Sucursales != null) aBM_Sucursales.Dispose();
            if (aBM_Clientes != null) aBM_Clientes.Dispose();


            // 
            // amB_Tecnicos1
            // 
            aBM_Tecnicos = new MTN_Administration.AMB_Tecnicos();
            aBM_Tecnicos.BackColor = System.Drawing.Color.Gainsboro;
            aBM_Tecnicos.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Tecnicos.Location = new System.Drawing.Point(236, 39);
            aBM_Tecnicos.Name = "aBM_Tecnicos";
            aBM_Tecnicos.Size = new System.Drawing.Size(739, 561);
            aBM_Tecnicos.TabIndex = 2;
            Controls.Add(this.aBM_Tecnicos);


            aBM_Tecnicos.RefreshTable(0);
            aBM_Tecnicos.BringToFront();

            TituloHeader.Text = "Administracion de Tecnicos";
            headerDashboardPicture.Hide();
            headerTecnicoPicture.Show();
            headerClientePicture.Hide();
            headerSucursalesPicture.Hide();

        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {

            if (aBM_Tecnicos != null) aBM_Tecnicos.Dispose();
            if (aBM_Sucursales != null) aBM_Sucursales.Dispose();
            // 
            // ABM_CLIENTES
            // 
            aBM_Clientes = new ABM_Clientes();
            aBM_Clientes.BackColor = System.Drawing.Color.Gainsboro;
            aBM_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Clientes.Location = new System.Drawing.Point(236, 39);
            aBM_Clientes.Name = "aBM_Clientes1";
            aBM_Clientes.Size = new System.Drawing.Size(739, 561);
            aBM_Clientes.TabIndex = 2;
            Controls.Add(this.aBM_Clientes);
            
            aBM_Clientes.BringToFront();
            TituloHeader.Text = "Administracion de Clientes";
            headerDashboardPicture.Hide();
            headerTecnicoPicture.Hide();
            headerClientePicture.Show();
            headerSucursalesPicture.Hide();


        }

        private void SucuralesButton_Click(object sender, EventArgs e)
        {
            if (aBM_Tecnicos != null) aBM_Tecnicos.Dispose();
            if (aBM_Clientes != null) aBM_Clientes.Dispose();


            aBM_Sucursales = new ABM_Sucursales();
            aBM_Sucursales.BackColor = System.Drawing.Color.Gainsboro;
            aBM_Sucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Sucursales.Location = new System.Drawing.Point(236, 39);
            aBM_Sucursales.Name = "aBM_Sucursales";
            aBM_Sucursales.Size = new System.Drawing.Size(739, 561);
            aBM_Sucursales.TabIndex = 2;
            Controls.Add(this.aBM_Sucursales);

            aBM_Sucursales.BringToFront();
            TituloHeader.Text = "Administracion de Sucursales";
            headerDashboardPicture.Hide();
            headerTecnicoPicture.Hide();
            headerClientePicture.Hide();
            headerSucursalesPicture.Show();
        }



    }
}
