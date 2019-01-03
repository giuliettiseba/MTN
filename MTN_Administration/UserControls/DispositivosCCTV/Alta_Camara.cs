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
using MTN_Administration.Tabs;

namespace MTN_Administration
{
    public partial class Alta_Camara : UserControl
    {

        private APIHelper aPIHelper;
        private int id_dispositivo;

        public Alta_Camara(int id_dispositivo, APIHelper aPIHelper)
        {
            this.id_dispositivo = id_dispositivo;
            this.aPIHelper = aPIHelper;

            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";
            comboBoxMarca.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetMarcaCCTV(), null);

            comboBoxTecnologia.DisplayMember = "value";
            comboBoxTecnologia.ValueMember = "key";
            comboBoxTecnologia.DataSource = new BindingSource(aPIHelper.GetTecnologiaCamara(), null);

            comboBoxEstado.DisplayMember = "value";
            comboBoxEstado.ValueMember = "key";
            comboBoxEstado.DataSource = new BindingSource(aPIHelper.GetEstados(), null);


            comboBoxPos.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetPosicionesDisponibles(id_dispositivo), null);


        }


        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
            comboBoxModelo.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetModelosMarcasCamaras((int)comboBoxMarca.SelectedValue), null);

        }



        private void ButtonCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int id_camara;
        internal void Cargar(Camara camara)
        {
            this.id_camara = camara.Id;

            textNombre.Text = camara.Nombre;
            ModeloCamara camaraModelo = aPIHelper.GetCCTVHelper().GetModeloCamara(camara.Id_modelo);
            comboBoxMarca.SelectedValue = camaraModelo.Id_marca;
            comboBoxTecnologia.SelectedValue = camaraModelo.Id_Tecnologia;
            comboBoxModelo.SelectedValue = camara.Id_modelo;

            DatePickerFechaInstalacion.Value = camara.FechaInsta;

            string[] valuesIP = camara.Ip.Split('.'); ;
            TextIP_OCT_1.Text = valuesIP[0];
            TextIP_OCT_2.Text = valuesIP[1];
            TextIP_OCT_3.Text = valuesIP[2];
            TextIP_OCT_4.Text = valuesIP[3];

            string[] valuesMask = camara.Mask.Split('.'); ;
            Text_Mask_OCT_1.Text = valuesMask[0];
            Text_Mask_OCT_2.Text = valuesMask[1];
            Text_Mask_OCT_3.Text = valuesMask[2];
            Text_Mask_OCT_4.Text = valuesMask[3];


            string[] valuesGateway = camara.Gateway.Split('.'); ;
            Text_Gateway_OCT_1.Text = valuesGateway[0];
            Text_Gateway_OCT_2.Text = valuesGateway[1];
            Text_Gateway_OCT_3.Text = valuesGateway[2];
            Text_Gateway_OCT_4.Text = valuesGateway[3];

            Text_NumeroSerie.Text = camara.Sn;
            Text_Observaciones.Text = camara.Observaciones;

            comboBoxEstado.SelectedValue = camara.Id_estado;

            comboBoxPos.SelectedItem = camara.Pos;

        }

        private void buttonGuardarAltaCamara_Click(object sender, EventArgs e)
        {

            Camara newCamara = new Camara();

            newCamara.Id = this.id_camara;
            newCamara.Nombre = textNombre.Text;

            newCamara.Id_modelo = (int)comboBoxModelo.SelectedValue;
            newCamara.Id_estado = (int)comboBoxEstado.SelectedValue;

            newCamara.Ip = TextIP_OCT_1.Text + ".";
            newCamara.Ip += TextIP_OCT_2.Text + ".";
            newCamara.Ip += TextIP_OCT_3.Text + ".";
            newCamara.Ip += TextIP_OCT_4.Text;

            newCamara.Mask = Text_Mask_OCT_1.Text + ".";
            newCamara.Mask += Text_Mask_OCT_2.Text + ".";
            newCamara.Mask += Text_Mask_OCT_3.Text + ".";
            newCamara.Mask += Text_Mask_OCT_4.Text;

            newCamara.Gateway = Text_Mask_OCT_1.Text + ".";
            newCamara.Gateway += Text_Mask_OCT_2.Text + ".";
            newCamara.Gateway += Text_Mask_OCT_3.Text + ".";
            newCamara.Gateway += Text_Mask_OCT_4.Text;

            newCamara.FechaInsta = DatePickerFechaInstalacion.Value;

            newCamara.Sn = Text_NumeroSerie.Text;
            newCamara.Observaciones = Text_Observaciones.Text;

            newCamara.Id_dispositivo = id_dispositivo;
            newCamara.Pos = (int)comboBoxPos.SelectedValue;

            string result = aPIHelper.GetCCTVHelper().AddCamara(newCamara);
            System.Windows.Forms.MessageBox.Show(result);
            
            ((Alta_Dispositivo)this.Parent).RefreshTable();
            this.Dispose();
        }
    }
}
