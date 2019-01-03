using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;

namespace MTN_Administration.Tabs
{
    public partial class ABM_Sucursales : UserControl
    {
        APIHelper aPIHelper;
        private List<Sucursal> listaSucursales;
        private Alta_Sucursales alta_Sucursal;

        public ABM_Sucursales(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            //PopulateComboCliente
            comboCliente.DisplayMember = "Nombre";
            comboCliente.ValueMember = "id";
            comboCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);
        }

        public void RefreshTable()
        {
            listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales((int)comboCliente.SelectedValue);
            RefreshTable(textBuscar.Text);
        }

        public void RefreshTable(string str)
        {
            tablaSucursales.Rows.Clear();
            foreach (Sucursal sucursal in listaSucursales)
            {
                if (sucursal.Nombre.ToUpper().Contains(str.ToUpper()) || sucursal.Numero.Contains(str))
                {
                    AddItem(sucursal);
                }
            }
            tablaSucursales.Refresh();
        }

        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add();
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["id"].Value = sucursal.Id;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["numero"].Value = sucursal.Numero;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["nombre"].Value = sucursal.Nombre;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["direccion"].Value = sucursal.Direccion;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["localidad"].Value = aPIHelper.GetNombreLocalidad(sucursal.Id_localidad);
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["provincia"].Value = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(sucursal.Id_localidad));
        }

        private void textBuscar_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(textBuscar.Text);
        }

        private void BotonAgregarSucursal_Click(object sender, EventArgs e)
        {
            this.alta_Sucursal = new Alta_Sucursales((int)comboCliente.SelectedValue, aPIHelper);
            this.alta_Sucursal.Location = new System.Drawing.Point(0, 0);
            this.alta_Sucursal.Name = "alta_Cliente";
            this.alta_Sucursal.Size = new System.Drawing.Size(727, 561);
            this.alta_Sucursal.TabIndex = 6;
            this.Controls.Add(this.alta_Sucursal);
            this.alta_Sucursal.BringToFront();
        }

        private void ButtonEditarSucursal_Click(object sender, EventArgs e)
        {
            BotonAgregarSucursal_Click(sender, e);
            alta_Sucursal.Cargar(ObtenerSucursalSeleccionada());
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            MensajeAlerta resultado = aPIHelper.GetSucursalesHelper().RemoveSucursal(ObtenerSucursalSeleccionada());
            Alert.ShowAlert(resultado);
            RefreshTable();
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void TablaSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditarSucursal_Click(sender, e);
        }

        private Sucursal ObtenerSucursalSeleccionada() {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            int id_sucursal = (int)selectedRow[0].Cells["id"].Value;
            return aPIHelper.GetSucursalesHelper().GetSucursal((int)comboCliente.SelectedValue, id_sucursal);
        }

        private void comboCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void tablaSucursales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditarSucursal_Click(sender, e);
        }
    }
}
