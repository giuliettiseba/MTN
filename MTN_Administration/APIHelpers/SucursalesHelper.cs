using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    public class SucursalesHelper
    {

        private String _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Sucursal> sucursales;

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="partialurl"></param>
        /// <param name="checksumHelper"></param>
        public SucursalesHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            _checksumHelper = checksumHelper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Sucursal> GetSucursales()
        {
            if (sucursales == null || !(_checksumHelper.VerificarChecksum("sucursales")))
            {
                sucursales = new List<Sucursal>();
                CacheSucursales();
            }
            return sucursales;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CacheSucursales()
        {
            String url = _partialurl + "Sucursales";
               using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Sucursal> resultado = serializer.Deserialize<Resultado<Sucursal>>(content);
                sucursales = resultado.Lista.Cast<Sucursal>().ToList();
                _checksumHelper.ActualizarChecksum("sucursales", resultado.Checksum);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_cliente"></param>
        /// <returns></returns>
        public List<Sucursal> GetSucursales(int id_cliente)
        {
            if (sucursales == null) GetSucursales();
            List<Sucursal> sucursalesCliente = new List<Sucursal>();
            foreach (Sucursal sucursal in sucursales)
            {
                if (sucursal.Id_cliente.Equals(id_cliente)) sucursalesCliente.Add(sucursal);
            }

            return sucursalesCliente;
        }

        internal int getClienteDeSucursal(int id_sucursal)
        {
            if (sucursales == null) GetSucursales();
            return sucursales.Find(x => x.Id == id_sucursal).Id_cliente;

        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="id_sucursal"></param>
        /// <returns></returns>
        internal Sucursal GetSucursal(int id_sucursal)
        {
            if (sucursales == null) GetSucursales();
            return sucursales.Find(x => x.Id == id_sucursal);
        }

        internal string RemoveSucursal(int id_sucursal)
        {
            String url = _partialurl + "sucursales/" + id_sucursal;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return Encoding.ASCII.GetString(responseArray);
            }
        }

        internal string PostSucursal(Sucursal newSucursal)
        {
            String url = _partialurl + "sucursales";
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
                }
                else
                {
                    webClient.QueryString.Add("id", newSucursal.Id.ToString());
                    webClient.UploadValues(url, "PUT", webClient.QueryString);
                }
                return "Se agrego correctamente la sucursal" + newSucursal.Numero;
            }

        }


    }
}