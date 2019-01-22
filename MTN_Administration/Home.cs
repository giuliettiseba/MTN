using MTN_Administration.Tabs;
using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTN_Administration
{

    /// <summary>
    /// Interfaz Principal
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Home : Form
    {
        private APIHelper aPIHelper;

        // private static readonly string _host = "http://mtnapi-ee7fc8b4.eastus.cloudapp.azure.com"; // azure
        private static readonly string _host = "http://localhost";
        // private static readonly string _port = "80"; /// Azure PORT
        //    private  static readonly string _port = "2510"; /// LOCAL PORT
        private static readonly string _port = "50411"; /// TEST PORT
        private static readonly string _apiRoute = "api";
        private static readonly string _partialurl = _host + ":" + _port + "/" + _apiRoute + "/";

        private ABM_Tecnicos aBM_Tecnicos;
        private ABM_Clientes aBM_Clientes;
        private ABM_Sucursales aBM_Sucursales;
        private ABM_Dispositivos aBM_Dispositivos;
        private ABM_Mantenimientos aBM_Mantenimientos;
        private Dashboard dashboard;
        private ABM_Incidentes aBM_Incidentes;

        /// <summary>
        /// Gets the required creation parameters when the control handle is created.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        public Home()
        {
            // Muestra el splash screen
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();

            if (!this.DesignMode)
            {

                aPIHelper = new APIHelper(_partialurl); /// Inicializa una nueva instancia de un API Helper con los parametros del servidor IIS
                InitializeComponent();

                // Centra la ventana
                this.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2);
                this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2);

                Bunifu.Framework.Lib.Elipse.Apply(this, 20);

                DashBoardButton_Click(null, null);
            }
            t.Abort();
        }

        /// <summary>
        /// Splash screen.
        /// </summary>
        private void SplashScreen()
        {
            try
            {
                Application.Run(new Splash());
            }
            catch {

            }
        }

        /// <summary>
        /// Handles the Click event of the Close control.
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the Minimize control.
        /// Minimiza la aplicacion
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// Handles the Click event of the DashBoardButton control.
        /// Nuestra el dashboard
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DisposeAllPanels();
            // 
            // DASHBOARD
            // 
            dashboard = new Dashboard(aPIHelper)
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "dashboard1",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.dashboard);

            dashboard.BringToFront();
            TituloHeader.Text = "Dashboard";
            ShowHeaderIcon(headerClientePicture);
        }


        /// <summary>
        /// Handles the Click event of the ClientesButton control.
        /// Muestra la interfaz Clientes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClientesButton_Click(object sender, EventArgs e)
        {
            DisposeAllPanels();

            aBM_Clientes = new ABM_Clientes(aPIHelper)
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "aBM_Clientes1",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.aBM_Clientes);

            aBM_Clientes.BringToFront();
            TituloHeader.Text = "Administracion de Clientes";
            ShowHeaderIcon(headerClientePicture);

        }

        /// <summary>
        /// Handles the Click event of the SucuralesButton control.
        /// Muestra la interfaz Sucursales
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SucuralesButton_Click(object sender, EventArgs e)
        {
            DisposeAllPanels();

            aBM_Sucursales = new ABM_Sucursales(aPIHelper)
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "aBM_Sucursales",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.aBM_Sucursales);

            aBM_Sucursales.BringToFront();
            TituloHeader.Text = "Administracion de Sucursales";

            ShowHeaderIcon(headerSucursalesPicture);
        }

        /// <summary>
        /// Handles the Click event of the BotonDispositivos control.
        /// Muestra la interfaz Dispositivos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonDispositivos_Click(object sender, EventArgs e)
        {
            DisposeAllPanels();
            aBM_Dispositivos = new ABM_Dispositivos(aPIHelper)
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "aBM_Dispositivos",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.aBM_Dispositivos);
            aBM_Dispositivos.BringToFront();
            TituloHeader.Text = "Administracion de Dispositivos";
            ShowHeaderIcon(headerDipsitivosPicture);

        }


        /// <summary>
        /// Handles the event of the TecnicosButton_Click control.
        /// Muestra la interfaz de administracion de tecnicos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TecnicosButton_Click_1(object sender, EventArgs e)
        {

            DisposeAllPanels();
            aBM_Tecnicos = new ABM_Tecnicos(aPIHelper)
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(236, 39),
                Name = "aBM_Tecnicos",
                Size = new System.Drawing.Size(739, 561),
                TabIndex = 2
            };
            Controls.Add(this.aBM_Tecnicos);
            aBM_Tecnicos.BringToFront();
            TituloHeader.Text = "Administracion de Tecnicos";
            ShowHeaderIcon(headerTecnicoPicture);

        }



        /// <summary>
        /// Handles the Click event of the BottonIncidente control.
        /// muestra la interfaz de administracion de incidentes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BottonIncidente_Click(object sender, EventArgs e)
        {

            aBM_Incidentes = new ABM_Incidentes(aPIHelper)
            {
                Owner = this,
                Name = "aBM_Incidentes",
                TabIndex = 2
            };
            aBM_Incidentes.Show();
            aBM_Incidentes.BringToFront();
        }


        /// <summary>
        /// Handles the Click event of the BotoMantenimientos control.
        /// Muestra la interfaz de administracion de mantenimientos
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotoMantenimientos_Click(object sender, EventArgs e)
        {
            aBM_Mantenimientos = new ABM_Mantenimientos(aPIHelper)
            {
                Owner = this,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Name = "aBM_Mantenimientos",
                TabIndex = 2
            };
            aBM_Mantenimientos.Show();
            aBM_Mantenimientos.BringToFront();
        }

        /// <summary>
        /// Cambia el icono del header 
        /// </summary>
        /// <param name="selectedPic">The selected pic.</param>
        private void ShowHeaderIcon(PictureBox selectedPic)
        {
            if (selectedPic != headerDashboardPicture) headerDashboardPicture.Hide();
            if (selectedPic != headerTecnicoPicture) headerTecnicoPicture.Hide();
            if (selectedPic != headerClientePicture) headerClientePicture.Hide();
            if (selectedPic != headerSucursalesPicture) headerSucursalesPicture.Hide();
            selectedPic.Show();

        }



        // Cierra el panel que se esta mostrando
        private void DisposeAllPanels()
        {

            if (aBM_Tecnicos != null) aBM_Tecnicos.Dispose();
            if (aBM_Clientes != null) aBM_Clientes.Dispose();
            if (aBM_Sucursales != null) aBM_Sucursales.Dispose();
            if (aBM_Dispositivos != null) aBM_Dispositivos.Dispose();
            if (dashboard != null) dashboard.Dispose();

        }


    }
}
