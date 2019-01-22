using MTN_Administration.Alerts;
using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    /// <summary>
    /// Helper Sucursales
    /// </summary>
    public class SucursalesHelper
    {

        private readonly String _partialurl;
        private ChecksumHelper _checksumHelper;
        private Dictionary<int, List<Sucursal>> cacheSucursales = new Dictionary<int, List<Sucursal>>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SucursalesHelper"/> class.
        /// </summary>
        /// <param name="partialurl">The partialurl.</param>
        /// <param name="checksumHelper">The checksum helper.</param>
        public SucursalesHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            _checksumHelper = checksumHelper;
        }

        /// <summary>
        /// Obtiene la lista de sucursales de un cliente
        /// </summary>
        /// <param name="id_cliente">The identifier cliente.</param>
        /// <returns></returns>
        public List<Sucursal> GetSucursales(int id_cliente)
        {
            if (!cacheSucursales.ContainsKey(id_cliente) || !_checksumHelper.VerificarChecksum("sucursales_" + id_cliente))

            {
                cacheSucursales[id_cliente] = new List<Sucursal>();
                CacheSucursales(id_cliente);
            }
            return cacheSucursales[id_cliente];
        }


        /// <summary>
        /// Almacena en memoria una lista de las sucursales de un cliente.
        /// </summary>
        /// <param name="id_cliente">The identifier cliente.</param>
        public void CacheSucursales(int id_cliente)
        {
            String url = _partialurl + "Sucursales/" + id_cliente;
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Sucursal> resultado = serializer.Deserialize<Resultado<Sucursal>>(content);
                cacheSucursales[id_cliente] = resultado.Lista.Cast<Sucursal>().ToList();
                _checksumHelper.ActualizarChecksum("sucursales_" + id_cliente, resultado.Checksum);
            }
        }

        /// <summary>
        /// Obtiene la sucursal de un cliente dado un id de sucursal
        /// </summary>
        /// <param name="id_cliente">The identifier cliente.</param>
        /// <param name="id_sucursal">The identifier sucursal.</param>
        /// <returns></returns>
        internal Sucursal GetSucursal(int id_cliente, int id_sucursal)
        {
            if (!cacheSucursales.ContainsKey(id_cliente)) GetSucursales(id_cliente);
            return cacheSucursales[id_cliente].Find(x => x.Id == id_sucursal);

        }

        /// <summary>
        /// Elimina una sucursal 
        /// </summary>
        /// <param name="removeSucursal">The remove sucursal.</param>
        /// <returns></returns>
        internal MensajeAlerta RemoveSucursal(Sucursal removeSucursal)
        {
            String url = _partialurl + "sucursales/" + removeSucursal.Id;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return new MensajeAlerta("ELIMINADO" + Environment.NewLine + removeSucursal.Nombre, AlertType.warning);
            }
        }

        /// <summary>
        /// Agrega o modifica una sucursal.
        /// </summary>
        /// <param name="newSucursal">The new sucursal.</param>
        /// <returns></returns>
        internal MensajeAlerta AddSucursal(Sucursal newSucursal)
        {
            String url = _partialurl + "sucursales";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.QueryString.Add("numero", newSucursal.Numero);
                    webClient.QueryString.Add("nombre", newSucursal.Nombre);
                    webClient.QueryString.Add("id_cliente", newSucursal.Id_cliente.ToString());
                    webClient.QueryString.Add("direccion", newSucursal.Direccion);
                    webClient.QueryString.Add("id_localidad", newSucursal.Id_localidad.ToString());
                    //   webClient.QueryString.Add("foto", tecnico.foto.ToString());
                    if (newSucursal.Id == 0)
                    {
                        webClient.UploadValues(url, "POST", webClient.QueryString);
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newSucursal.Nombre, AlertType.success);
                    }
                    else
                    {
                        webClient.QueryString.Add("id", newSucursal.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newSucursal.Nombre, AlertType.success);

                    }
                }
            }
            catch (Exception e)
            {
                return new MensajeAlerta("Error: " + e.ToString() + Environment.NewLine + newSucursal.Nombre, AlertType.error);
            }
        }
    }
}