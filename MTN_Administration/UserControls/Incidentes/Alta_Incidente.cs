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
    public partial class panelFondo : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        public panelFondo(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));



            InitializeComponent();

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel3.Location = new System.Drawing.Point(0, 0);

            bunifuTransition1.ShowSync(panel1);

        }



        List<Cliente> listaClientes;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //create a for loop thats sets the odd rows color to White and the even rows color to a different color
            for (int i = 0; i < tablaClientes.Rows.Count; i++)
            {
                // odd rows
                if (i % 2 != 0)
                {
                    tablaClientes.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                // even rows
                else
                {
                    tablaClientes.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 247, 252);
                }
            }

            listaClientes = aPIHelper.GetClientesHelper().GetClientes(); // Obtener Lista de clientes

            // Llenar la tabla cliente con todos los clientes
            foreach (Cliente cliente in listaClientes)
            {
                AddItem(cliente);
            }

        }

        private void AddItem(Cliente cliente)
        {
            tablaClientes.Rows.Add(cliente.Id, cliente.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(Sucursal sucursal)
        {
            tablaSucursales.Rows.Add(sucursal.Id, sucursal.Nombreynumero); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(DispositivoCCTV dispositivoCCTV)
        {
            tablaMantenible.Rows.Add(dispositivoCCTV.Id, "[DVR] -> " + dispositivoCCTV.Nombre); // Inserta una linea nueva en la tabla clientes
        }

        private void AddItem(DispositivoCCTV dispositivoCCTV, Camara camara)
        {
            tablaMantenible.Rows.Add(camara.Id, "[CAMARA]  -> (" + dispositivoCCTV.Nombre + ") : " + camara.Pos + " - " + camara.Nombre); // Inserta una linea nueva en la tabla clientes
        }






        private void textBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            tablaClientes.Rows.Clear();  // Eliminar clientes
            tablaClientes.Refresh(); // Refrescar tabla

            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nombre.ToUpper().Contains(textBuscarCliente.Text.ToUpper())) AddItem(cliente); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
            }
        }

        private void tablaClientes_SelectionChanged(object sender, EventArgs e)
        {

            tablaSucursales.Rows.Clear();  // Eliminar clientes
            tablaSucursales.Refresh(); // Refrescar tabla
            try
            {

                int id_cliente_Seleccionado = Convert.ToInt16(tablaClientes.SelectedRows[0].Cells["id_cliente"].Value);
                IEnumerable<Sucursal> listaSucursales = aPIHelper.GetSucursalesHelper().GetSucursales(id_cliente_Seleccionado);
                foreach (Sucursal sucursal in listaSucursales)
                {
                    if (sucursal.Nombre.ToUpper().Contains(textBuscarCliente.Text.ToUpper())) AddItem(sucursal); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
                }

            }
            catch (Exception)
            {


            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {

            bunifuTransition1.HideSync(panel1);
            bunifuTransition1.ShowSync(panel2);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel3);
            bunifuTransition1.ShowSync(panel2);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel2);
            bunifuTransition1.ShowSync(panel1);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel2);
            bunifuTransition1.ShowSync(panel3);
        }

        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {


            tablaMantenible.Rows.Clear();  // Eliminar clientes

            try
            {

                int id_sucursal_Seleccionada = Convert.ToInt16(tablaSucursales.SelectedRows[0].Cells["id_sucursal"].Value);


                List<DispositivoCCTV> listadispositivoCCTV = aPIHelper.GetCCTVHelper().GetDispositivosCCTVSucursal(id_sucursal_Seleccionada);

                foreach (DispositivoCCTV dispositivoCCTV in listadispositivoCCTV)
                {
                    if (dispositivoCCTV.Nombre.ToUpper().Contains(TextBuscarMantenible.Text.ToUpper())) AddItem(dispositivoCCTV);

                    List<Camara> listaCamaras = aPIHelper.GetCCTVHelper().GetCamarasDispositivo(dispositivoCCTV.Id);

                    foreach (Camara camara in listaCamaras)
                    {
                        if (camara.Nombre.ToUpper().Contains(TextBuscarMantenible.Text.ToUpper())) AddItem(dispositivoCCTV, camara);
                    }
                }

            }


            catch (Exception exp)
            {
                Console.WriteLine(exp);

            }

            tablaMantenible.Refresh(); // Refrescar tabla

        }



        private void textBuscarSucural_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
