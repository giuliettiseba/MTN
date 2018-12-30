using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    public class ClientesHelper
    {
        private readonly String _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Cliente> clientes;

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="partialurl"></param>
        /// <param name="checksumHelper"></param>
        public ClientesHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            _checksumHelper = checksumHelper;
        }

        /// <summary>
        /// Obtiene una lista de clientes si
        /// 1) es la primera consulta desde el inicio de la aplicacion
        /// 2) el Checksum de la tabla clientes cambio desde el ultimo pull
        /// </summary>
        /// <returns>Lista actualizada de los clientes</returns>
        public List<Cliente> GetClientes()
        {
            if ((clientes == null) || !(_checksumHelper.VerificarChecksum("clientes")))
            {
                clientes = new List<Cliente>();
                CacheClientes();
            }
            return clientes;
        }

        /// <summary>
        /// Actualiza la lista de clientes almacenada en memoria
        /// Actualiza el checksum de la nueva lista almacenada en memoria. 
        /// 
        /// Utiliza JavaStriptSerializer para obtener de JSON un objeto Resultado que contiene un checksum y una lista de clientes
        /// </summary>
        private void CacheClientes()
        {
            String url = _partialurl + "Clientes";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Cliente> resultado = serializer.Deserialize<Resultado<Cliente>>(content);
                clientes = resultado.Lista.Cast<Cliente>().ToList();
                _checksumHelper.ActualizarChecksum("clientes", resultado.Checksum);
            }
        }

        /// <summary>
        /// Retorna el objeto del tipo cliente que tiene como identificador el id pasado
        /// </summary>
        /// <param name="id_cliente">ID del cliente</param>
        /// <returns>Cliente con el ID pasdo</returns>
        public Cliente GetCliente(int id_cliente)
        {
            return clientes.Find(x => x.Id == id_cliente);
        }
        
        /// <summary>
        /// Remueve de la base de datos un cliente 
        /// </summary>
        /// <param name="id_cliente">ID del cliente a eliminar</param>
        /// <returns>resultado de la eliminacion</returns>
        public string RemoveCliente(int id_cliente)
        {
            String url = _partialurl + "clientes/" + id_cliente;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return Encoding.ASCII.GetString(responseArray);
            }
        }
        
        /// <summary>
        /// Crea en la base de datos un nuevo cliente o modifica uno existente si se pasa un ID existente. 
        /// </summary>
        /// <param name="newCliente">Cliente a agregar en la base de datos</param>
        /// <returns>Resultado de la insercion</returns>
        public string AddCliente(Cliente newCliente)
        {
            String url = _partialurl + "clientes/";
            using (WebClient webClient = new WebClient())
            {
                webClient.QueryString.Add("nombre", newCliente.Nombre);
                webClient.QueryString.Add("CUIT", newCliente.CUIT);
                webClient.QueryString.Add("direccion", newCliente.Direccion);
                webClient.QueryString.Add("id_localidad", newCliente.Id_localidad.ToString());
                //   webClient.QueryString.Add("foto", tecnico.foto.ToString());
                if (newCliente.Id == 0)
                {
                    webClient.UploadValues(url, "POST", webClient.QueryString);
                }
                else
                {
                    webClient.QueryString.Add("id", newCliente.Id.ToString());
                    webClient.UploadValues(url, "PUT", webClient.QueryString);
                }
                return "Se agrego correctamente el cliente: " + newCliente.CUIT;
            }
        }
    }
}
