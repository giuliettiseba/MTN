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
        public ABM_Sucursales()
        {
            InitializeComponent();
        }

        

        APIHelper aPIHelper;

        private List<Sucursal> listaSucursales;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (aPIHelper == null) aPIHelper = ((Home)this.Parent).GetAPIHelper();
            comboCliente.DisplayMember = "RazonSocial";
            comboCliente.ValueMember = "id";
            comboCliente.DataSource = new BindingSource(aPIHelper.GetClientes(), null);

            RefreshTable((int) comboCliente.SelectedValue);




        }

        public void RefreshTable()
        {
            tablaSucursales.Rows.Clear();
            tablaSucursales.Refresh();
            listaSucursales = aPIHelper.GetSucursales();
        }

        public void RefreshTable(string s)
        {
            RefreshTable();
            foreach (Sucursal sucursal in listaSucursales)
            {
                if (sucursal.nombre.ToUpper().Contains(s.ToUpper()) || sucursal.numero.Contains(s))
                {
                    AddItem(sucursal);
                }
            }
        }

        public void RefreshTable(int i)
        {
            RefreshTable();
            foreach (Sucursal sucursal in listaSucursales)
            {
                if(sucursal.id_cliente == (int)comboCliente.SelectedValue) AddItem(sucursal);
            }
        }

        private void AddItem(Sucursal sucursal)
        {

            tablaSucursales.Rows.Add();
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["id"].Value = sucursal.id;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["numero"].Value = sucursal.numero;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["nombre"].Value = sucursal.nombre;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["direccion"].Value = sucursal.direccion;
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["localidad"].Value = aPIHelper.GetNombreLocalidad(sucursal.id_localidad);
            tablaSucursales.Rows[tablaSucursales.Rows.Count - 1].Cells["provincia"].Value = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(sucursal.id_localidad));
        }

        private void textBuscarTecnico_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Text);
        }

        private Alta_Sucursal alta_Sucursal;

        private void BotonAgregarSucursal_Click(object sender, EventArgs e)
        {
            this.alta_Sucursal = new Alta_Sucursal((int)comboCliente.SelectedValue);
            this.alta_Sucursal.BackColor = System.Drawing.Color.Gainsboro;
            this.alta_Sucursal.Location = new System.Drawing.Point(0, 0);
            this.alta_Sucursal.Name = "alta_Cliente";
            this.alta_Sucursal.Size = new System.Drawing.Size(727, 561);
            this.alta_Sucursal.TabIndex = 6;
            this.Controls.Add(this.alta_Sucursal);
            this.alta_Sucursal.BringToFront();
        }


        private void buttonEditarSucursal_Click(object sender, EventArgs e)
        {
            BotonAgregarSucursal_Click(sender, e);
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            int id_sucursal = (int)selectedRow[0].Cells["id"].Value;
            Sucursal sucursal = aPIHelper.GetSucursal(id_sucursal);
            alta_Sucursal.Cargar(sucursal);
        }

        private void tablaSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditarSucursal_Click(sender, e);
        }


        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            aPIHelper.RemoveSucursal((int)selectedRow[0].Cells["id"].Value);
            RefreshTable(0);
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable((int)comboCliente.SelectedValue);
        }
    }
}
