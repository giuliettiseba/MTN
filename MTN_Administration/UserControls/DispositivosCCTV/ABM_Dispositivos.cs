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

namespace MTN_Administration.Tabs
{
    public partial class ABM_Dispositivos : UserControl
    {
        private Alta_Dispositivo alta_Dispositivo;
        private Bitmap image_ok;
        private Bitmap image_error;
        private Bitmap image_warning;

        public ABM_Dispositivos(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15,15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            tablaSucursales.Columns[0].Visible = false;
        }



        APIHelper aPIHelper;

        private List<DispositivoCCTV> listaGrabadores;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            comboCliente.DisplayMember = "Nombre";
            comboCliente.ValueMember = "id";
            comboCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);

        }

        public void RefreshTable()
        {
            tablaGrabadoresDigitales.Rows.Clear();
            tablaGrabadoresDigitales.Refresh();
            listaGrabadores = aPIHelper.GetCCTVHelper().GetDispositivosCCTV();

            foreach (DispositivoCCTV grabador in listaGrabadores)
            {
                if (grabador.Id_sucursal == SucursalSeleccionada()) AddItem(grabador);
            }

        }


        private void AddItem(DispositivoCCTV grabador)
        {
            tablaGrabadoresDigitales.Rows.Add();
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["id"].Value = grabador.Id;
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["nombre"].Value = grabador.Nombre;
            ModeloCCTV _modelo = aPIHelper.GetCCTVHelper().GetModeloCCTV(grabador.Id_Modelo);
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["modelo"].Value = _modelo.Nombre;
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["marca"].Value = aPIHelper.GetCCTVHelper().GetMarcaCCTV(_modelo.Id_marca).Nombre;

            Image image;
            switch (grabador.Id_estado)
            {
                case 1: image = image_ok;
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
            tablaGrabadoresDigitales.Rows[tablaGrabadoresDigitales.Rows.Count - 1].Cells["estado"].Value = image;
        }

        
        private void BotonAgregarDispotivo_Click(object sender, EventArgs e)
        {
            this.alta_Dispositivo = new Alta_Dispositivo(aPIHelper,SucursalSeleccionada());
            this.alta_Dispositivo.BackColor = System.Drawing.Color.Gainsboro;
            this.alta_Dispositivo.Location = new System.Drawing.Point(0, 0);
            this.alta_Dispositivo.Name = "alta_Cliente";
            this.alta_Dispositivo.Size = new System.Drawing.Size(727, 561);
            this.alta_Dispositivo.TabIndex = 6;
            this.Controls.Add(this.alta_Dispositivo);
            this.alta_Dispositivo.BringToFront();
        }


        private void buttonEditarDispositivo_Click(object sender, EventArgs e)
        {
            // obtengo el id del dispositivo seleccionado en la tabla
            int id_dispositivoCCTV = (int)tablaGrabadoresDigitales.SelectedRows[0].Cells["id"].Value;

            // obtengo el dispositivo con el APIhelper
            DispositivoCCTV dispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(id_dispositivoCCTV);

            // Cargo la interfaz 
            BotonAgregarDispotivo_Click(sender, e);

           // completo los campos
            alta_Dispositivo.Cargar(dispositivoCCTV);
        }

        private void TablaSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditarDispositivo_Click(sender, e);
        }


        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaGrabadoresDigitales.SelectedRows;
            aPIHelper.GetCCTVHelper().RemoveDispositivoCCTV((int)selectedRow[0].Cells["id"].Value);
            RefreshTable();
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshComboSucursales((int)comboCliente.SelectedValue);
        }

        private void RefreshComboSucursales(int selectedValue)
        {
            tablaSucursales.Rows.Clear();
            tablaSucursales.Refresh();
            List<Sucursal> listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales(selectedValue);
            foreach (Sucursal sucursal in listaSucursales)
            {
                if (sucursal.Id_cliente == (int)comboCliente.SelectedValue)
                {
                    AddItem(sucursal);
                }
            }
        }

        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Numero, sucursal.Nombre);
        }

        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private int SucursalSeleccionada()
        {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;

            if (selectedRow.Count != 0 && selectedRow[0].Cells["idSuc"].Value != null )
                return (int)selectedRow[0].Cells["idSuc"].Value;
            return 0;
        }
    }
}
