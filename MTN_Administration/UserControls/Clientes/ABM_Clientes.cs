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
    public partial class ABM_Clientes : UserControl
    {
        private APIHelper aPIHelper;
        private List<Cliente> listaClientes;
        private Alta_Cliente alta_Cliente;

        public ABM_Clientes(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshTable();
        }

        /// <summary>
        /// 
        /// </summary>
        public void RefreshTable()
        {
            listaClientes = aPIHelper.GetClientesHelper().GetClientes();
            RefreshTable("");
        }

        /// <summary>
        /// Filtro por texto para la tabla
        /// </summary>
        /// <param name="s"></param>
        public void RefreshTable(string s)
        {
            tablaClientes.Rows.Clear();
            
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nombre.ToUpper().Contains(s.ToUpper()) || cliente.CUIT.ToUpper().Contains(s.ToUpper()))
                {
                    AddItem(cliente);
                }
            }
            tablaClientes.Refresh();
        }

        private void AddItem(Cliente cliente)
        {
            tablaClientes.Rows.Add();
            tablaClientes.Rows[tablaClientes.Rows.Count - 1].Cells["id"].Value = cliente.Id;
            tablaClientes.Rows[tablaClientes.Rows.Count - 1].Cells["razonSocial"].Value = cliente.Nombre;
            tablaClientes.Rows[tablaClientes.Rows.Count - 1].Cells["cuit"].Value = cliente.CUIT;
            tablaClientes.Rows[tablaClientes.Rows.Count - 1].Cells["direccion"].Value = cliente.Direccion;
            tablaClientes.Rows[tablaClientes.Rows.Count - 1].Cells["localidad"].Value = aPIHelper.GetNombreLocalidad(cliente.Id_localidad);
            tablaClientes.Rows[tablaClientes.Rows.Count - 1].Cells["provincia"].Value = aPIHelper.GetNombreProvincia(aPIHelper.GetProvincia(cliente.Id_localidad));
        }

        private void textBuscarTecnico_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(textBuscarTecnico.Text);
        }

        private void BotonAgregarCliente_Click(object sender, EventArgs e)
        {
            this.alta_Cliente = new Alta_Cliente(aPIHelper);
            this.alta_Cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.alta_Cliente.Location = new System.Drawing.Point(0, 0);
            this.alta_Cliente.Name = "alta_Cliente";
            this.alta_Cliente.Size = new System.Drawing.Size(727, 561);
            this.alta_Cliente.TabIndex = 6;
            this.Controls.Add(this.alta_Cliente);
            this.alta_Cliente.BringToFront();
        }


        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            BotonAgregarCliente_Click(sender, e);


            DataGridViewSelectedRowCollection selectedRow = tablaClientes.SelectedRows;
            int id_cliente = (int)selectedRow[0].Cells["id"].Value;
            Cliente cliente = aPIHelper.GetClientesHelper().GetCliente(id_cliente);

            alta_Cliente.Cargar(cliente);
        }

        private void tablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditarCliente_Click(sender, e);
        }


        private void BotonEliminarCliente_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = tablaClientes.SelectedRows;
            aPIHelper.GetClientesHelper().RemoveCliente((int)selectedRow[0].Cells["id"].Value);
            RefreshTable();
        }

    }
}
