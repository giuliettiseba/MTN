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
using System.Net;
using MTN_Administration.Alerts;

namespace MTN_Administration
{
    public partial class Alta_Dispositivo : UserControl
    {
        
        private APIHelper aPIHelper;
        private Bitmap image_ok;
        private Bitmap image_error;
        private Bitmap image_warning;
        private int id_sucursal;
        private int id_dispositivo;
        private int id_cliente;

        public Alta_Dispositivo(APIHelper aPIHelper,int id_cliente, int id_sucursal)
        {
            this.aPIHelper = aPIHelper;
            this.id_cliente = id_cliente;

            this.id_sucursal = id_sucursal;

            if (!this.DesignMode)
            {
                InitializeComponent();

                image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
                image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
                image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            /// Populate Combobox Marca 
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";
            comboBoxMarca.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetMarcaCCTV(), null);

            /// Populate Combobox Estado
            comboBoxEstado.DisplayMember = "value";
            comboBoxEstado.ValueMember = "key";
            comboBoxEstado.DataSource = new BindingSource(aPIHelper.GetEstados(), null);


            /// Populate Combobox Cliente
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "id";
            comboBoxCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);
            comboBoxCliente.SelectedValue = id_cliente;

            // Oculto la columna Id, no tiene ningun valor para el usuario. 
            tablaCamaras.Columns[3].Visible = false;
        }

        public void RefreshTable()
        {
            tablaCamaras.Rows.Clear();
            tablaCamaras.Refresh();
            foreach (Camara camara in aPIHelper.GetCCTVHelper().GetCamarasDispositivo(id_dispositivo))
            {
                AddItem(camara);
            }
        }

        private void AddItem(Camara camara)
        {
            tablaCamaras.Rows.Add();
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["pos"].Value = camara.Pos;
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["nombre"].Value = camara.Nombre;
            //tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["estado"].Value = aPIHelper.GetEstado(camara.Id_estado);
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["id"].Value = camara.Id;

            Image image;
            switch (camara.Id_estado)
            {
                case 1:
                    image = image_ok;
                    break;
                case 2:
                    image = image_error;
                    break;
                case 3:
                    image = image_warning;
                    break;

                default:
                    image = null;
                    break;
            }
            tablaCamaras.Rows[tablaCamaras.Rows.Count - 1].Cells["estado"].Value = image;
        }

        private void ButtonCancelarAlta_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }


        internal void Cargar(int cliente_id, DispositivoCCTV grabadorDigital)
        {
            id_dispositivo = grabadorDigital.Id;
            id_sucursal = grabadorDigital.Id_sucursal;

            DatePicketFechaDeInstalacion.Value = grabadorDigital.Fecha_insta;

            comboBoxCliente.SelectedValue = cliente_id;
            comboBoxSucursal.SelectedValue = grabadorDigital.Id_sucursal;

            textNombre.Text = grabadorDigital.Nombre;

            ModeloCCTV modeloSeleccionado = aPIHelper.GetCCTVHelper().GetModeloCCTV(grabadorDigital.Id_Modelo);
            comboBoxMarca.SelectedValue = modeloSeleccionado.Id_marca;
            comboBoxModelo.SelectedValue = modeloSeleccionado.Id;

            string[] valuesIP = grabadorDigital.Ip.Split('.'); ;
            TextIP_OCT_1.Text = valuesIP[0];
            TextIP_OCT_2.Text = valuesIP[1];
            TextIP_OCT_3.Text = valuesIP[2];
            TextIP_OCT_4.Text = valuesIP[3];

            string[] valuesMask = grabadorDigital.Mask.Split('.'); ;
            Text_Mask_OCT_1.Text = valuesMask[0];
            Text_Mask_OCT_2.Text = valuesMask[1];
            Text_Mask_OCT_3.Text = valuesMask[2];
            Text_Mask_OCT_4.Text = valuesMask[3];

            string[] valuesGateway = grabadorDigital.Gateway.Split('.'); ;
            Text_Gateway_OCT_1.Text = valuesGateway[0];
            Text_Gateway_OCT_2.Text = valuesGateway[1];
            Text_Gateway_OCT_3.Text = valuesGateway[2];
            Text_Gateway_OCT_4.Text = valuesGateway[3];

            Text_NumeroSerie.Text = grabadorDigital.Sn;
            text_Observaciones.Text = grabadorDigital.Observaciones;

            comboBoxEstado.SelectedValue = grabadorDigital.Id_estado;

            RefreshTable();

        }

        private void buttonGuardarAltaDispositivo_Click(object sender, EventArgs e)
        {
            try
            {
                DispositivoCCTV newDispositivoCCTV = new DispositivoCCTV();

                newDispositivoCCTV.Id_sucursal = (int)comboBoxSucursal.SelectedValue;

                newDispositivoCCTV.Id = this.id_dispositivo;

                newDispositivoCCTV.Nombre = textNombre.Text;
                newDispositivoCCTV.Id_Modelo = (int)comboBoxModelo.SelectedValue;

                newDispositivoCCTV.Ip = TextIP_OCT_1.Text + ".";
                newDispositivoCCTV.Ip += TextIP_OCT_2.Text + ".";
                newDispositivoCCTV.Ip += TextIP_OCT_3.Text + ".";
                newDispositivoCCTV.Ip += TextIP_OCT_4.Text;

                newDispositivoCCTV.Mask = Text_Mask_OCT_1.Text + ".";
                newDispositivoCCTV.Mask += Text_Mask_OCT_2.Text + ".";
                newDispositivoCCTV.Mask += Text_Mask_OCT_3.Text + ".";
                newDispositivoCCTV.Mask += Text_Mask_OCT_4.Text;

                newDispositivoCCTV.Gateway = Text_Gateway_OCT_1.Text + ".";
                newDispositivoCCTV.Gateway += Text_Gateway_OCT_2.Text + ".";
                newDispositivoCCTV.Gateway += Text_Gateway_OCT_3.Text + ".";
                newDispositivoCCTV.Gateway += Text_Gateway_OCT_4.Text;

                newDispositivoCCTV.Fecha_insta = DatePicketFechaDeInstalacion.Value;

                newDispositivoCCTV.Sn = Text_NumeroSerie.Text;
                newDispositivoCCTV.Id_estado = (int)comboBoxEstado.SelectedValue;

                newDispositivoCCTV.Observaciones = text_Observaciones.Text;

                MensajeAlerta resultado = aPIHelper.GetCCTVHelper().AddDispositivoCCTV(newDispositivoCCTV);
                Alert.ShowAlert(resultado);

                ((ABM_Dispositivos)this.Parent).RefreshTable();
                this.Dispose();
            }
            catch (Exception exe)
            {

                Alert.ShowAlert("Error al agregar dispositivo.",AlertType.error);
            }
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
            comboBoxModelo.DataSource = new BindingSource(aPIHelper.GetCCTVHelper().GetModelosMarcasCCTV((int)comboBoxMarca.SelectedValue), null);
        }

        private Alta_Camara alta_Camara;
        private void botonAgregarCamara_Click(object sender, EventArgs e)
        {
            this.alta_Camara = new Alta_Camara(id_dispositivo, aPIHelper);
            this.alta_Camara.Location = new System.Drawing.Point(0, 0);
            this.alta_Camara.Name = "alta_Camara";
            this.alta_Camara.Size = new System.Drawing.Size(727, 561);
            this.alta_Camara.TabIndex = 6;
            this.Controls.Add(this.alta_Camara);
            this.alta_Camara.BringToFront();
        }

        private void botonModificarCamara_Click(object sender, EventArgs e)
        {
            int id_camara = (int) tablaCamaras.SelectedRows[0].Cells["id"].Value;
            Camara camara = aPIHelper.GetCCTVHelper().GetCamara(id_dispositivo, id_camara);
            botonAgregarCamara_Click(sender, e);
            this.alta_Camara.Cargar(camara); 
        }

        private void comboBoxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            /// Polulate Combobox Sucursales
            comboBoxSucursal.DisplayMember = "Nombre";
            comboBoxSucursal.ValueMember = "Id";
            comboBoxSucursal.DataSource = new BindingSource(aPIHelper.GetSucursalesHelper().GetSucursales((int)comboBoxCliente.SelectedValue), null);
            comboBoxSucursal.SelectedValue = id_sucursal;

        }

        private void botonEliminarCamara_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaCamaras.SelectedRows;
            aPIHelper.GetCCTVHelper().RemoveCamara((int)selectedRow[0].Cells["id"].Value);
            RefreshTable();
        }

        private void tablaCamaras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            botonModificarCamara_Click(sender, e);
        }
    }
}
