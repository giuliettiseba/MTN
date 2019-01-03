using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;

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
        /// Refresca tabla
        /// Busca una nueva lista de clientes
        /// </summary>
        public void RefreshTable()
        {
            listaClientes = aPIHelper.GetClientesHelper().GetClientes();
            RefreshTable(textBuscarCliente.Text);
        }

        /// <summary>
        /// Filtro por texto para la tabla clientes 
        /// </summary>
        /// <param name="s">Se busca el parametro s en el nombre o en el CUIT</param>
        public void RefreshTable(String str)
        {
            tablaClientes.Rows.Clear();
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nombre.ToUpper().Contains(str.ToUpper()) || (cliente.CUIT != null && cliente.CUIT.ToUpper().Contains(str.ToUpper())))
                {
                    AddItem(cliente);
                }
            }
            tablaClientes.Refresh();
        }

        /// <summary>
        /// Agregar una nueva fila a la tabla clientes seguin el cliente pasado como parametro
        /// </summary>
        /// <param name="cliente"></param>
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

        /// <summary>
        /// Disparador para refrescar la tabla clientes cuando una caracter es ingresado en el cuadro de busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBuscarTecnico_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }


        /// <summary>
        /// El boton Agregar clientes es presionado. Muestra la interfaz Agregar cliente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonAgregarCliente_Click(object sender, EventArgs e)
        {
            this.alta_Cliente = new Alta_Cliente(aPIHelper);
            this.alta_Cliente.Location = new System.Drawing.Point(0, 0);
            this.alta_Cliente.Name = "alta_Cliente";
            this.alta_Cliente.Size = new System.Drawing.Size(727, 561);
            this.alta_Cliente.TabIndex = 6;
            this.Controls.Add(this.alta_Cliente);
            this.alta_Cliente.BringToFront();
        }

        /// <summary>
        /// El boton Editar cliente es presionado. Muestra la interfaz Agregar cliente, con los datos del cliente seleccionado. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditarCliente_Click(object sender, EventArgs e)
        {
            BotonAgregarCliente_Click(sender, e);
            alta_Cliente.Cargar(ObtenerClienteSeleccionado());
        }


        /// <summary>
        /// Elimina el cliente seleccionado
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonEliminarCliente_Click(object sender, EventArgs e)
        {
            
            MensajeAlerta resultado = aPIHelper.GetClientesHelper().RemoveCliente(ObtenerClienteSeleccionado());
            Alert.ShowAlert(resultado);
            RefreshTable();
        }

        /// <summary>
        /// Obtiene el cliente seleccionado de la tablaClientes
        /// Consulta HelperCliente para obtener el cliente por medio del ID
        /// </summary>
        /// <returns>Cliente Selecionado</returns>
        private Cliente ObtenerClienteSeleccionado() {
            DataGridViewSelectedRowCollection selectedRow = tablaClientes.SelectedRows;
            int id_cliente = (int)selectedRow[0].Cells["id"].Value;
            return aPIHelper.GetClientesHelper().GetCliente(id_cliente);
        }

    }
}
