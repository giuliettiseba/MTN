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
           
            comboCliente.DisplayMember = "Nombre";
            comboCliente.ValueMember = "id";
            comboCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);
        }

        public void RefreshTable()
        {

            listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales();
            RefreshTable("");
        }

        public void RefreshTable(string s)
        {
            tablaSucursales.Rows.Clear();
            tablaSucursales.Refresh();
            foreach (Sucursal sucursal in listaSucursales)
            {
                if ((sucursal.Id_cliente == (int)comboCliente.SelectedValue) && (sucursal.Nombre.ToUpper().Contains(s.ToUpper()) || sucursal.Numero.Contains(s)))
                {
                    AddItem(sucursal);
                }
            }
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

        private void textBuscarTecnico_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(textBuscarSucursal.Text);
        }

        private void BotonAgregarSucursal_Click(object sender, EventArgs e)
        {
            this.alta_Sucursal = new Alta_Sucursales((int)comboCliente.SelectedValue, aPIHelper);
            this.alta_Sucursal.BackColor = System.Drawing.Color.Gainsboro;
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
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            int id_sucursal = (int)selectedRow[0].Cells["id"].Value;
            Sucursal sucursal = aPIHelper.GetSucursalesHelper().GetSucursal(id_sucursal);
            alta_Sucursal.Cargar(sucursal);
        }

        private void TablaSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditarSucursal_Click(sender, e);
        }


        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            aPIHelper.GetSucursalesHelper().RemoveSucursal((int)selectedRow[0].Cells["id"].Value);
            RefreshTable();
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
