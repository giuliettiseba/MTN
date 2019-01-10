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

        APIHelper aPIHelper;
        private static readonly string _host = "http://localhost";
        //    private  static readonly string port = "2510";
        private static readonly string _port = "50411";
        private static readonly string _apiRoute = "api";
        private static readonly string _partialurl = _host + ":" + _port + "/" + _apiRoute + "/";

        private ABM_Tecnicos aBM_Tecnicos;
        private ABM_Clientes aBM_Clientes;
        private ABM_Sucursales aBM_Sucursales;
        private ABM_Dispositivos aBM_Dispositivos;


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
                aPIHelper = new APIHelper(_partialurl);
                InitializeComponent();
                this.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2);
                this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2);
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

            TituloHeader.Text = "Dashboard";
            headerDashboardPicture.Show();
            headerTecnicoPicture.Hide();
            headerClientePicture.Hide();
            headerSucursalesPicture.Hide();
        }


     

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            DisposeAllPanels();
            // 
            // ABM_CLIENTES
            // 
            aBM_Clientes = new ABM_Clientes(aPIHelper);
            aBM_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Clientes.Location = new System.Drawing.Point(236, 39);
            aBM_Clientes.Name = "aBM_Clientes1";
            aBM_Clientes.Size = new System.Drawing.Size(739, 561);
            aBM_Clientes.TabIndex = 2;
            Controls.Add(this.aBM_Clientes);
            
            aBM_Clientes.BringToFront();
            TituloHeader.Text = "Administracion de Clientes";
            ShowHeaderIcon(headerClientePicture);

        }

        private void SucuralesButton_Click(object sender, EventArgs e)
        {

            DisposeAllPanels();
            aBM_Sucursales = new ABM_Sucursales(aPIHelper);
            aBM_Sucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Sucursales.Location = new System.Drawing.Point(236, 39);
            aBM_Sucursales.Name = "aBM_Sucursales";
            aBM_Sucursales.Size = new System.Drawing.Size(739, 561);
            aBM_Sucursales.TabIndex = 2;
            Controls.Add(this.aBM_Sucursales);

            aBM_Sucursales.BringToFront();
            TituloHeader.Text = "Administracion de Sucursales";

            ShowHeaderIcon(headerSucursalesPicture);
        }

        private void BotonDispositivos_Click(object sender, EventArgs e)
        {
            DisposeAllPanels();
            aBM_Dispositivos = new ABM_Dispositivos(aPIHelper);
            aBM_Dispositivos.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Dispositivos.Location = new System.Drawing.Point(236, 39);
            aBM_Dispositivos.Name = "aBM_Dispositivos";
            aBM_Dispositivos.Size = new System.Drawing.Size(739, 561);
            aBM_Dispositivos.TabIndex = 2;
            Controls.Add(this.aBM_Dispositivos);
            aBM_Dispositivos.BringToFront();
            TituloHeader.Text = "Administracion de Dispositivos";
            ShowHeaderIcon(headerDipsitivosPicture);

        }

        private void ShowHeaderIcon(PictureBox selectedPic)
        {
            if (selectedPic != headerDashboardPicture) headerDashboardPicture.Hide();
            if (selectedPic != headerTecnicoPicture) headerTecnicoPicture.Hide();
            if (selectedPic != headerClientePicture) headerClientePicture.Hide();
            if (selectedPic != headerSucursalesPicture) headerSucursalesPicture.Hide();
            selectedPic.Show();

        }



        private void DisposeAllPanels() {

            if (aBM_Tecnicos != null) aBM_Tecnicos.Dispose();
            if (aBM_Clientes != null) aBM_Clientes.Dispose();
            if (aBM_Sucursales != null) aBM_Sucursales.Dispose();
            if (aBM_Dispositivos != null) aBM_Dispositivos.Dispose();
            if (aBM_Incidentes != null) aBM_Incidentes.Dispose();
        }

        private void TecnicosButton_Click_1(object sender, EventArgs e)
        {

            DisposeAllPanels();
            aBM_Tecnicos = new ABM_Tecnicos(aPIHelper);
            aBM_Tecnicos.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Tecnicos.Location = new System.Drawing.Point(236, 39);
            aBM_Tecnicos.Name = "aBM_Tecnicos";
            aBM_Tecnicos.Size = new System.Drawing.Size(739, 561);
            aBM_Tecnicos.TabIndex = 2;
            Controls.Add(this.aBM_Tecnicos);
            aBM_Tecnicos.BringToFront();
            TituloHeader.Text = "Administracion de Tecnicos";
            ShowHeaderIcon(headerTecnicoPicture);

        }

        ABM_Incidentes aBM_Incidentes;

        private void BottonIncidente_Click(object sender, EventArgs e)
        {

            //DisposeAllPanels();
            aBM_Incidentes = new ABM_Incidentes(aPIHelper);
            aBM_Incidentes.Owner = this;
            aBM_Incidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Incidentes.Name = "aBM_Incidentes";
            aBM_Incidentes.TabIndex = 2;
            //Controls.Add(this.aBM_Incidentes);
            aBM_Incidentes.Show();
            aBM_Incidentes.BringToFront();
            //TituloHeader.Text = "Administracion de Incidentes";
            //ShowHeaderIcon(headerIncidentePicture);
        }




        ABM_Mantenimientos aBM_Mantenimientos;

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            aBM_Mantenimientos = new ABM_Mantenimientos(aPIHelper);
            aBM_Mantenimientos.Owner = this;
            aBM_Mantenimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            aBM_Mantenimientos.Name = "aBM_Mantenimientos";
            aBM_Mantenimientos.TabIndex = 2;
            aBM_Mantenimientos.Show();
            aBM_Mantenimientos.BringToFront();

        }
    }
}
