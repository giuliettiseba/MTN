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
using MTN_Administration.Alerts;

namespace MTN_Administration.Tabs
{
    /// <summary>
    /// Interfaz para ver un incidente
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class Ver_Incidente : UserControl
    {
        private APIHelper aPIHelper;
        private Incidente incidente;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ver_Incidente"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        /// <param name="incidente">The incidente.</param>
        public Ver_Incidente(APIHelper aPIHelper, Incidente incidente)
        {
            this.aPIHelper = aPIHelper;
            this.incidente = incidente;
            InitializeComponent();

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textCliente.Text = aPIHelper.GetClientesHelper().GetCliente(incidente.Id_cliente).Nombre;
            Sucursal sucursal = aPIHelper.GetSucursalesHelper().GetSucursal(incidente.Id_cliente, incidente.Id_suc);
            textSucursal.Text = sucursal.Nombre;

            textSucursalCiudad.Text = aPIHelper.GetNombreLocalidad(sucursal.Id_localidad);
            textSucursalProvincia.Text = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(sucursal.Id_localidad));

            TextFalla.Text = incidente.Falla;
            textCriticidad.Text = ((TypeCriticidad)incidente.Id_criticidad).ToString();

            DispositivoCCTV dispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1);
            textDispositivo.Text = dispositivoCCTV.Nombre;
            textDispositivoMarca.Text = aPIHelper.GetCCTVHelper().GetModeloCCTV(dispositivoCCTV.Id_Modelo).Nombre;
            textDispositivoModelo.Text = aPIHelper.GetCCTVHelper().GetMarcaCCTV(dispositivoCCTV.Id_Modelo).Nombre;
            textTipoFalla.Text = dispositivoCCTV.Id_estado.ToString();
            if (incidente.Id_tipo_mantenible == 2)
            {
                Camara camara = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2);
                textTipoFalla.Text = camara.Id_estado.ToString();
                textCamara.Text = camara.Nombre;
                textCamara.Text = camara.Nombre;
                textCamaraMarca.Text = aPIHelper.GetCCTVHelper().GetModeloCamara(dispositivoCCTV.Id_Modelo).Nombre;
                textCamaraModelo.Text = aPIHelper.GetCCTVHelper().GetModeloCamara(dispositivoCCTV.Id_Modelo).Nombre;
            }

            textEstado.Text = ((TypeEstadoIncidente)incidente.Id_estado_incidente).ToString();


        }
        /// <summary>
        /// Handles the Click event of the buttonCerrar control.
        /// Cierra la ventana Ver Incidente
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            ((IAnimated)Parent).ShowPanelSwitchs();
            Dispose();
        }

    }
}
