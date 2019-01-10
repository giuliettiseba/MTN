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
    public partial class Ver_Incidente : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        public Ver_Incidente(APIHelper aPIHelper, Incidente incidente)
        {
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();




            textCliente.Text = aPIHelper.GetClientesHelper().GetCliente(incidente.Id_cliente).Nombre;
            Sucursal sucursal = aPIHelper.GetSucursalesHelper().GetSucursal(incidente.Id_cliente, incidente.Id_suc);
            textSucursal.Text = sucursal.Nombre;

            textSucursalCiudad.Text = aPIHelper.GetNombreLocalidad(sucursal.Id_localidad);
            textSucursalProvincia.Text = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(sucursal.Id_localidad));
            
            TextFalla.Text = incidente.Falla;
            textCriticidad.Text = aPIHelper.GetCriticidad(incidente.Id_criticidad);

            DispositivoCCTV dispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1);
            textDispositivo.Text = dispositivoCCTV.Nombre;
            textDispositivoMarca.Text = aPIHelper.GetCCTVHelper().GetModeloCCTV(dispositivoCCTV.Id_Modelo).Nombre;
            textDispositivoModelo.Text = aPIHelper.GetCCTVHelper().GetMarcaCCTV(dispositivoCCTV.Id_Modelo).Nombre;
            textTipoFalla.Text = aPIHelper.GetEstado(dispositivoCCTV.Id_estado);
            if (incidente.Id_tipo_mantenible == 2)
            {
                Camara camara = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_1, incidente.Id_2);
                textTipoFalla.Text = aPIHelper.GetEstado(camara.Id_estado);
                textCamara.Text = camara.Nombre;
                textCamara.Text = camara.Nombre;
                textCamaraMarca.Text = aPIHelper.GetCCTVHelper().GetModeloCamara(dispositivoCCTV.Id_Modelo).Nombre;
                textCamaraModelo.Text = aPIHelper.GetCCTVHelper().GetModeloCamara(dispositivoCCTV.Id_Modelo).Nombre;
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ((ABM_Incidentes)Parent).showPanelSwitchs();
            Dispose();
        }
    }
}
