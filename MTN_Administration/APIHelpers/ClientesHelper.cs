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
    /// Helper de clientes
    /// </summary>
    public class ClientesHelper
    {
        private readonly String _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Cliente> _clientes;

        /// <summary>
        /// Constructor de la clase ClienteHelper, Se pasa como parametros la URL parcial del WEB API y el ayudante de checksums
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
            if ((_clientes == null) || !(_checksumHelper.VerificarChecksum("clientes")))
            {
                _clientes = new List<Cliente>();
                CacheClientes();
            }
            return _clientes;
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
                _clientes = resultado.Lista.Cast<Cliente>().ToList();
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
            if (_clientes == null) GetClientes();
            return _clientes.Find(x => x.Id == id_cliente);
        }


        /// <summary>
        /// Verifica si el cuit esta cargado en el sistema, si es una modificacion no controla el cliente a modificar
        /// </summary>
        /// <param name="cuit">EL CUIT.</param>
        /// <param name="id">El id del cliente, 0 si es un alta.</param>
        /// <returns>Verdadero si el CUIT esta duplicado.</returns>
        private bool CuitExiste(String cuit, int id)
        {
            List<Cliente> clientesTemp;
            if (_clientes == null) GetClientes();
            clientesTemp = new List<Cliente>(_clientes);
            if (id != 0)
                clientesTemp.Remove(clientesTemp.Find(x => x.Id == id));

            return clientesTemp.Find(x => x.CUIT == cuit) != null;
        }

        /// <summary>
        /// Remueve de la base de datos un cliente 
        /// </summary>
        /// <param name="id_cliente">ID del cliente a eliminar</param>
        /// <returns>resultado de la eliminacion</returns>
        public MensajeAlerta RemoveCliente(Cliente removeCliente)
        {
            String url = _partialurl + "clientes/" + removeCliente.Id;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return new MensajeAlerta("ELIMINADO" + Environment.NewLine + removeCliente.Nombre, AlertType.warning);
            }
        }

        /// <summary>
        /// Crea en la base de datos un nuevo cliente o modifica uno existente si se pasa un ID existente. 
        /// </summary>
        /// <param name="newCliente">Cliente a agregar en la base de datos</param>
        /// <returns>Resultado de la insercion</returns>
        public MensajeAlerta AddCliente(Cliente newCliente)
        {
            try
            {
                Convert.ToInt64(newCliente.CUIT);
                if (CuitExiste(newCliente.CUIT, newCliente.Id)) return new MensajeAlerta("ERROR" + Environment.NewLine + "El numero de CUIT ya esta cargado en el sistema", AlertType.error);
            }
            catch (Exception)
            {
                return new MensajeAlerta("ERROR" + Environment.NewLine + "El numero de CUIT deben ser solo numeros", AlertType.error);
            }


            String url = _partialurl + "clientes/";
            try
            {
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
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newCliente.Nombre, AlertType.success);
                    }
                    else
                    {
                        webClient.QueryString.Add("id", newCliente.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newCliente.Nombre, AlertType.success);
                    }
                }
            }
            catch (Exception e)
            {

                return new MensajeAlerta("Error" + Environment.NewLine + newCliente.Nombre, AlertType.error);
            }
        }

    }
}
