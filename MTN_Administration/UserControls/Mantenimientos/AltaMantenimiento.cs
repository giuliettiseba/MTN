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
using MTN_Administration.Alerts;

namespace MTN_Administration.Tabs
{
    public partial class Alta_Manteniminto : UserControl
    {
        APIHelper aPIHelper;
        private readonly Bitmap image_ok;
        private readonly Bitmap image_error;
        private readonly Bitmap image_warning;

        private List<Cliente> listaClientes;

        public Alta_Manteniminto(APIHelper aPIHelper)
        {
            this.aPIHelper = aPIHelper;

            image_ok = new Bitmap(global::MTN_Administration.Properties.Resources.success, new Size(15, 15));
            image_error = new Bitmap(global::MTN_Administration.Properties.Resources.error, new Size(15, 15));
            image_warning = new Bitmap(global::MTN_Administration.Properties.Resources.warning, new Size(15, 15));

            InitializeComponent();

            //panel1.Visible = false;
            panel2.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel2.Location = new System.Drawing.Point(0, 0);

           // transiciones.ShowSync(panel1);

            bunifuRange1_RangeChanged(null, null);
        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
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


        private void AddItem(Incidente incidente)
        {
            tablaIncidentes.Rows.Add(); // Inserta una linea nueva en la tabla clientes

            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["id"].Value = incidente.Id;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["tipo"].Value = (TypeTipoMantenible)incidente.Id_tipo_mantenible;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["dipositivo"].Value = aPIHelper.GetCCTVHelper().GetDispositivoCCTV(incidente.Id_suc, incidente.Id_1).Nombre;
            if (incidente.Id_tipo_mantenible == 2)
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["camara"].Value = aPIHelper.GetCCTVHelper().GetCamara(incidente.Id_suc, incidente.Id_2).Nombre;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["criticidad"].Value = aPIHelper.GetCriticidad(incidente.Id_criticidad);
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["estado"].Value = (TypeEstadoIncidente)incidente.Id_estado_incidente;
            tablaIncidentes.Rows[tablaIncidentes.Rows.Count - 1].Cells["asignado"].Value = incidente.Asignado;
        }






        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            textHoraInicio.Text = (rangeHora.RangeMin / 2).ToString();
            int minIni;
            minIni = (rangeHora.RangeMin % 2 == 1) ? 30 : 0;
            textMinutosInicio.Text = minIni.ToString();
            textHoraFin.Text = (rangeHora.RangeMax / 2).ToString();
            int minFin;
            minFin = (rangeHora.RangeMax % 2 == 1) ? 30 : 0;
            textMinutosFin.Text = minFin.ToString();
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            
        }



        private void buttonSiguiente_Click_1(object sender, EventArgs e)
        {
            transiciones.HideSync(panel1);
            transiciones.ShowSync(panel2);
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

        private void tablaSucursales_SelectionChanged(object sender, EventArgs e)
        {



            tablaIncidentes.Rows.Clear();  // Eliminar clientes
            tablaIncidentes.Refresh(); // Refrescar tabla
            try
            {
                int id_sucursal_Seleccionada = Convert.ToInt16(tablaSucursales.SelectedRows[0].Cells["id_sucursal"].Value);
                List<Incidente> listaIncidente = aPIHelper.GetIncidenteHelper().GetIncidentes();

                foreach (Incidente incidente in listaIncidente)
                {
                    if (incidente.Id_suc == id_sucursal_Seleccionada) AddItem(incidente); // Inserta una fila en la tabla clientes si el nombre del cliente contiene la palabra ingresada en el cuadro de busqueda. 
                }

            }
            catch (Exception)
            {


            }


        }

    }
}
