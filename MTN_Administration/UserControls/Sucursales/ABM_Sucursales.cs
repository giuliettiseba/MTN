using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MTN_RestAPI.Models;
using MTN_Administration.Alerts;

namespace MTN_Administration.Tabs
{
    /// <summary>
    /// Interfaz ABM Sucursales
    /// </summary>
    public partial class ABM_Sucursales : UserControl
    {
        private APIHelper aPIHelper;
        private List<Sucursal> listaSucursales;
        private Alta_Sucursales alta_Sucursal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ABM_Sucursales"/> class.
        /// </summary>
        /// <param name="aPIHelper">a pi helper.</param>
        public ABM_Sucursales(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;
            InitializeComponent();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            //PopulateComboCliente
            comboCliente.DisplayMember = "Nombre";
            comboCliente.ValueMember = "id";
            comboCliente.DataSource = new BindingSource(aPIHelper.GetClientesHelper().GetClientes(), null);
        }

        /// <summary>
        /// Refresca la tabla de sucursales
        /// </summary>
        public void RefreshTable()
        {
            listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales((int)comboCliente.SelectedValue);
            RefreshTable(textBuscar.Text);
        }

        /// <summary>
        /// Refreshes the table filtrando por el string ingresado en el cuadro de busqueda. 
        /// </summary>
        /// <param name="str">The string.</param>
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

        /// <summary>
        /// Agrega una fila con una sucursal a la tabla sucursales
        /// </summary>
        /// <param name="sucursal">The sucursal.</param>
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

        /// <summary>
        /// Handles the OnValueChanged event of the textBuscar control.
        /// Cuando cambia el valor del cuadro de busqueda refresca la tabla de sucursales.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBuscar_OnValueChanged(object sender, EventArgs e)
        {
            RefreshTable(textBuscar.Text);
        }

        /// <summary>
        /// Handles the Click event of the BotonAgregarSucursal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the ButtonEditarSucursal control.
        /// Muestra la interfaz alta sucursal con los datos de la sucursal seleccionada en la tabla sucursales.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonEditarSucursal_Click(object sender, EventArgs e)
        {
            BotonAgregarSucursal_Click(sender, e);
            alta_Sucursal.Cargar(ObtenerSucursalSeleccionada());
        }

        /// <summary>
        /// Handles the Click event of the BotonEliminar control.
        /// Muestra un cuadro de dialgo solicitando la confirmacion para eliminar una sucursal
        /// Si el usuario confirma elimina la sucursal y muestra la notificacion con el resultado de la operacion
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar la sucursal", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MensajeAlerta resultado = aPIHelper.GetSucursalesHelper().RemoveSucursal(ObtenerSucursalSeleccionada());
                Alert.ShowAlert(resultado);
                RefreshTable();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboCliente control.
        /// Cuando el usuario selecciona un nuevo cliente muestra en la tabla de suscursales las sucursales del cliente seleccionado 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the TablaSucursal control.
        /// Cuando el usuario hace doble click sobre una sucursal, muestra la interfaz de alta de sucursal con los datos de 
        /// la sucursal seleccionada
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void TablaSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditarSucursal_Click(sender, e);
        }

        /// <summary>
        /// Obtiene la sucursal seleccionada en la tabla sucursale4s
        /// </summary>
        /// <returns></returns>
        private Sucursal ObtenerSucursalSeleccionada() {
            DataGridViewSelectedRowCollection selectedRow = tablaSucursales.SelectedRows;
            int id_sucursal = (int)selectedRow[0].Cells["id"].Value;
            return aPIHelper.GetSucursalesHelper().GetSucursal((int)comboCliente.SelectedValue, id_sucursal);
        }
    }
}
