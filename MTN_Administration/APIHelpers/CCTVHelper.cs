using MTN_Administration.Alerts;
using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    /// <summary>
    /// Helper de Dispositivos de CCTV
    /// </summary>
    public class CCTVHelper
    {
        private readonly String _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<MarcaCCTV> marcasCCTV;
        private List<ModeloCCTV> modelosCCTV;
        private List<ModeloCamara> modelosCamara;
        private FileStorageHelper fileStorageHelper;

        public CCTVHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this._checksumHelper = checksumHelper;
            fileStorageHelper = new FileStorageHelper(); // Creo una instancia de un fileStorageHelper
            GetMarcaCCTV(); // Obtiene desde un archivo el listado MArcasCCTV, si el checksum cambio busca la version actual desde la base de datos. 
            GetModelosCCTV();
        }

        //////////////////////////////////////////////////POSICIONES DISPONIBLES EN UN DVR////////////////////////////

        internal List<int> GetPosicionesDisponibles(int id_dispositivo)
        {
            return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            /// Implementar verificacion 
            /// Segun el modelo obtener canales disponibles
            /// Complemento de canales disponibles con los canales asignados.. 
        }

        ////////////////////////////////////DISPOSITIVOS CCTV/////////////////////////////////////////////////

        private Dictionary<int, List<DispositivoCCTV>> cacheDispositivosSucursal = new Dictionary<int, List<DispositivoCCTV>>();

        /// <summary>
        /// Obtiene los dispositivos de grabacion de una sucursal dada
        /// </summary>
        /// <param name="id_sucursal">The identifier sucursal.</param>
        /// <returns></returns>
        public List<DispositivoCCTV> GetDispositivosCCTVSucursal(int id_sucursal)
        {
            if (!cacheDispositivosSucursal.ContainsKey(id_sucursal) || !_checksumHelper.VerificarChecksum("dispositivosCCTV_" + id_sucursal))
            {
                cacheDispositivosSucursal[id_sucursal] = new List<DispositivoCCTV>();
                CacheDispositivosCCTVSucursal(id_sucursal);
            }
            return cacheDispositivosSucursal[id_sucursal];
        }

        /// <summary>
        /// Almacena en una lista los dispositivos de grabacion de un a sucursal
        /// </summary>
        /// <param name="id_sucursal">The identifier sucursal.</param>
        public void CacheDispositivosCCTVSucursal(int id_sucursal)
        {
            String url = _partialurl + "DispositivosCCTV/" + id_sucursal;
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<DispositivoCCTV> resultado = serializer.Deserialize<Resultado<DispositivoCCTV>>(content);
                cacheDispositivosSucursal[id_sucursal] = resultado.Lista.Cast<DispositivoCCTV>().ToList();
                _checksumHelper.ActualizarChecksum("dispositivosCCTV_" + id_sucursal, resultado.Checksum);
            }
        }

        /// <summary>
        /// Obtiene un dispositivo de grabacion de una sucursal
        /// </summary>
        /// <param name="id_sucursal">The identifier sucursal.</param>
        /// <param name="id_dispositivoCCTV">The identifier dispositivo CCTV.</param>
        /// <returns></returns>
        public DispositivoCCTV GetDispositivoCCTV(int id_sucursal, int id_dispositivoCCTV)
        {
            if (!cacheDispositivosSucursal.ContainsKey(id_sucursal)) GetDispositivosCCTVSucursal(id_sucursal);
            return cacheDispositivosSucursal[id_sucursal].Find(x => x.Id == id_dispositivoCCTV);
        }


        /// <summary>
        /// Agregega o modifica un dispositivo de grabacion
        /// </summary>
        /// <param name="newDispositivoCCTV">The new dispositivo CCTV.</param>
        /// <returns></returns>
        internal MensajeAlerta AddDispositivoCCTV(DispositivoCCTV newDispositivoCCTV)
        {
            String url = _partialurl + "DispositivosCCTV/";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.QueryString.Add("nombre", newDispositivoCCTV.Nombre);
                    webClient.QueryString.Add("id_sucursal", newDispositivoCCTV.Id_sucursal.ToString());
                    webClient.QueryString.Add("id_modelo", newDispositivoCCTV.Id_Modelo.ToString());
                    webClient.QueryString.Add("ip", newDispositivoCCTV.Ip);
                    webClient.QueryString.Add("mask", newDispositivoCCTV.Mask);
                    webClient.QueryString.Add("gateway", newDispositivoCCTV.Gateway);
                    webClient.QueryString.Add("fecha_insta", newDispositivoCCTV.Fecha_insta.ToString());
                    webClient.QueryString.Add("observaciones", newDispositivoCCTV.Observaciones);
                    webClient.QueryString.Add("id_estado", newDispositivoCCTV.Id_estado.ToString());
                    webClient.QueryString.Add("sn", newDispositivoCCTV.Sn);
                    //   webClient.QueryString.Add("foto", tecnico.foto.ToString());
                    if (newDispositivoCCTV.Id == 0)
                    {
                        /// Si el dispositivo de grabacion no tiene ID agrega uno nuevo
                        webClient.UploadValues(url, "POST", webClient.QueryString);
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newDispositivoCCTV.Nombre, AlertType.success);
                    }
                    else
                    {
                        /// Modifica un dispositivo ya cargado
                        webClient.QueryString.Add("id", newDispositivoCCTV.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newDispositivoCCTV.Nombre, AlertType.success);
                    }
                }
            }
            catch (Exception e)
            {

                return new MensajeAlerta("Error: " + e.ToString() + Environment.NewLine + newDispositivoCCTV.Nombre, AlertType.error);
            }

        }

        /// <summary>
        /// Elimina un dispositivo de grabacion
        /// </summary>
        /// <param name="removeDispositivo">El dispositico a eliminar.</param>
        /// <returns></returns>
        public MensajeAlerta RemoveDispositivoCCTV(DispositivoCCTV removeDispositivo)
        {
            String url = _partialurl + "DispositivosCCTV/" + removeDispositivo.Id;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return new MensajeAlerta("ELIMINADO" + Environment.NewLine + removeDispositivo.Nombre, AlertType.warning);
            }
        }

        /////////////////////////////////////////////////////GET CAMARAS///////////////////////////////////////////////////////////////

        private Dictionary<int, List<Camara>> cacheCamarasDispositivo = new Dictionary<int, List<Camara>>();

        /// <summary>
        /// Obtiene las camaras de un grabador.
        /// </summary>
        /// <param name="id_dispositivo">The identifier dispositivo.</param>
        /// <returns></returns>
        public List<Camara> GetCamarasDispositivo(int id_dispositivo)
        {
            if (!cacheCamarasDispositivo.ContainsKey(id_dispositivo) || !_checksumHelper.VerificarChecksum("camaras_" + id_dispositivo))
            {
                cacheCamarasDispositivo.Remove(id_dispositivo);
                cacheCamarasDispositivo.Add(id_dispositivo, new List<Camara>());
                CacheCamarasDispositivo(id_dispositivo);
            }
            return cacheCamarasDispositivo[id_dispositivo];
        }

        /// <summary>
        /// Almacena en memoria la lista de camaras de un dispositivo
        /// </summary>
        /// <param name="id_dispositivo">The identifier dispositivo.</param>
        private void CacheCamarasDispositivo(int id_dispositivo)
        {
            String url = _partialurl + "Camaras/" + id_dispositivo;

            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Camara> resultado = serializer.Deserialize<Resultado<Camara>>(content);
                cacheCamarasDispositivo[id_dispositivo] = resultado.Lista.Cast<Camara>().ToList();
                _checksumHelper.ActualizarChecksum("camaras_" + id_dispositivo, resultado.Checksum);
            }
        }

        /// <summary>
        /// Obtiene una camara de un dipositivo 
        /// </summary>
        /// <param name="id_dispositivo">The identifier dispositivo.</param>
        /// <param name="id_camara">The identifier camara.</param>
        /// <returns></returns>
        public Camara GetCamara(int id_dispositivo, int id_camara)
        {
            if (!cacheCamarasDispositivo.ContainsKey(id_dispositivo)) GetCamarasDispositivo(id_dispositivo);
            return cacheCamarasDispositivo[id_dispositivo].Find(x => x.Id == id_camara);
        }


        /// <summary>
        /// Agrega una nueva camara a un dispositivo 
        /// </summary>
        /// <param name="newCamara">The new camara.</param>
        /// <returns></returns>
        internal MensajeAlerta AddCamara(Camara newCamara)
        {
            String url = _partialurl + "Camaras";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.QueryString.Add("Nombre", newCamara.Nombre);
                    webClient.QueryString.Add("Id_modelo", newCamara.Id_modelo.ToString());
                    webClient.QueryString.Add("Id_estado", newCamara.Id_estado.ToString());
                    webClient.QueryString.Add("Fecha_insta", newCamara.Fecha_insta.ToString());
                    webClient.QueryString.Add("Ip", newCamara.Ip);
                    webClient.QueryString.Add("Mask", newCamara.Mask);
                    webClient.QueryString.Add("Gateway", newCamara.Gateway);
                    webClient.QueryString.Add("Observaciones", newCamara.Observaciones);
                    webClient.QueryString.Add("Sn", newCamara.Sn);

                    webClient.QueryString.Add("Id_dispositivo", newCamara.Id_dispositivo.ToString());
                    webClient.QueryString.Add("Pos", newCamara.Pos.ToString());

                    //   webClient.QueryString.Add("foto", tecnico.foto.ToString());
                    if (newCamara.Id == 0)
                    {
                        webClient.UploadValues(url, "POST", webClient.QueryString);
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newCamara.Nombre, AlertType.success);
                    }
                    else
                    {
                        webClient.QueryString.Add("Id_camara", newCamara.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newCamara.Nombre, AlertType.success);
                    }
                }
            }
            catch (Exception)
            {
                return new MensajeAlerta("Error" + Environment.NewLine + newCamara.Nombre, AlertType.error);
            }
        }

        /// <summary>
        /// Elimina una camara.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string RemoveCamara(int id)
        {
            String url = _partialurl + "Camaras/" + id;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return Encoding.ASCII.GetString(responseArray);
            }
        }

        ////////////////////////////////////////////////MARCAS CCTV////////////////////////////////////////////////

        /// <summary>
        /// Obtiene las marcas de los dispositivos de CCTV.
        /// </summary>
        /// <returns></returns>
        public List<MarcaCCTV> GetMarcaCCTV()
        {
            if (marcasCCTV == null)
            {
                marcasCCTV = new List<MarcaCCTV>();
                CacheMarcaCCTV();
            }
            return marcasCCTV;
        }

        /// <summary>
        /// Almacena en memoria el listado de las marcas de CCTV.
        /// Antes de traer el listado de la base de datos busca si existe el archivo local actualizado con la informacion
        /// </summary>
        private void CacheMarcaCCTV()
        {
            String tabla = "MarcasCCTV"; // Nombre de la tabla 
            String file = @"localCache\" + tabla + ".mtn"; // Path donde se almacena 
            Resultado<MarcaCCTV> resultadoLocal = fileStorageHelper.DeSerializeObject<Resultado<MarcaCCTV>>(file); // Si el archivo existe recupera el objeteo Resultado<MarcaCCTV>
            if (resultadoLocal != null)
            {
                marcasCCTV = resultadoLocal.Lista.Cast<MarcaCCTV>().ToList();
                _checksumHelper.ActualizarChecksum(tabla, resultadoLocal.Checksum); // Si logra recuperar el objeto actualiza el checksum local
            }
            if (!_checksumHelper.VerificarChecksum(tabla)) // Verifica que el checksum sea el mismo que el de la tabla actual
            {
                String url = _partialurl + "Utiles/" + tabla;
                using (WebClient client = new WebClient())
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    String content = client.DownloadString(url); // Consulta a la API por la tabla completa
                    Resultado<MarcaCCTV> resultado = serializer.Deserialize<Resultado<MarcaCCTV>>(content); // Convierte el resultado de la consulta a un objeto del tipo Resultado
                    fileStorageHelper.SerializeObject(resultado, file); // Actualiza o crea un archivo local
                    marcasCCTV = resultado.Lista.Cast<MarcaCCTV>().ToList(); // separa el checksum del objeto
                }
            }
        }

        internal MarcaCCTV GetMarcaCCTV(int id_marca)
        {
            return marcasCCTV.Find(x => x.Id == id_marca);
        }
        ////////////////////////////////////////////MODELOS DE CAMARAS////////////////////////////////////////////////////

        /// <summary>
        /// Obtiene los modelos de camaras
        /// </summary>
        /// <returns></returns>
        public List<ModeloCamara> GetModelosCamaras()
        {
            if (modelosCamara == null || !_checksumHelper.VerificarChecksum("modelosCamara"))
            {
                modelosCamara = new List<ModeloCamara>();
                CacheModelosCamaras();
            }
            return modelosCamara;
        }

        /// <summary>
        /// Caches the modelos camaras.
        /// </summary>
        private void CacheModelosCamaras()
        {
            String url = _partialurl + "Utiles/ModelosCamara";
            using (WebClient client = new WebClient())
            {

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<ModeloCamara> resultado = serializer.Deserialize<Resultado<ModeloCamara>>(content);
                modelosCamara = resultado.Lista.Cast<ModeloCamara>().ToList();
                _checksumHelper.ActualizarChecksum("modelosCamara", resultado.Checksum);
            }
        }


        ////////////////////////////////////////////////MODELOS CCTV////////////////////////////////////////////////

        /// <summary>
        /// Obtiene los modelos de CCTV 
        /// </summary>
        /// <returns></returns>
        public List<ModeloCCTV> GetModelosCCTV()
        {
            if (modelosCCTV != null)
            {
                return modelosCCTV;
            }
            modelosCCTV = new List<ModeloCCTV>();
            CacheModelosCCTV();
            return modelosCCTV;

        }

        /// <summary>
        /// Guarda en memoria los modelos de CCTV
        /// Antes de traer el listado de la base de datos busca si existe el archivo local actualizado con la informacion
        /// </summary>
        private void CacheModelosCCTV()
        {

            String tabla = "ModelosCCTV"; // Nombre de la tabla 
            String file = @"localCache\" + tabla + ".mtn"; // Path donde se almacena 
            Resultado<ModeloCCTV> resultadoLocal = fileStorageHelper.DeSerializeObject<Resultado<ModeloCCTV>>(file); // Si el archivo existe recupera el objeteo Resultado<ModeloCCTV>
            if (resultadoLocal != null)
            {
                modelosCCTV = resultadoLocal.Lista.Cast<ModeloCCTV>().ToList();
                _checksumHelper.ActualizarChecksum(tabla, resultadoLocal.Checksum); // Si logra recuperar el objeto actualiza el checksum local
            }
            if (!_checksumHelper.VerificarChecksum(tabla)) // Verifica que el checksum sea el mismo que el de la tabla actual
            {
                String url = _partialurl + "Utiles/" + tabla;
                using (WebClient client = new WebClient())
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    String content = client.DownloadString(url); // Consulta a la API por la tabla completa
                    Resultado<ModeloCCTV> resultado = serializer.Deserialize<Resultado<ModeloCCTV>>(content); // Convierte el resultado de la consulta a un objeto del tipo Resultado
                    fileStorageHelper.SerializeObject(resultado, file); // Actualiza o crea un archivo local
                    modelosCCTV = resultado.Lista.Cast<ModeloCCTV>().ToList(); // separa el checksum del objeto
                }
            }
        }

        /// <summary>
        /// Obtiene el modelo de CCTV del id dado
        /// </summary>
        /// <param name="id_modelo">The identifier modelo.</param>
        /// <returns></returns>
        internal ModeloCCTV GetModeloCCTV(int id_modelo)
        {
            if (modelosCCTV == null) GetModelosCCTV();
            return modelosCCTV.Find(x => x.Id == id_modelo);
        }

        /// <summary>
        /// Obtiene los modelos de Grabadores dada una marca
        /// </summary>
        /// <param name="id_marca">The identifier marca.</param>
        /// <returns></returns>
        internal List<ModeloCCTV> GetModelosMarcasCCTV(int id_marca)
        {
            if (modelosCCTV == null) GetModelosCCTV();
            List<ModeloCCTV> modelosMarcasCCTV = new List<ModeloCCTV>();
            foreach (ModeloCCTV modelo in modelosCCTV)
            {
                if (modelo.Id_marca.Equals(id_marca)) modelosMarcasCCTV.Add(modelo);
            }
            return modelosMarcasCCTV;
        }

        /// <summary>
        /// Obtiene las modelos de Camaras dada una marca
        /// </summary>
        /// <param name="id_marca">The identifier marca.</param>
        /// <returns></returns>
        internal List<ModeloCamara> GetModelosMarcasCamaras(int id_marca)
        {
            if (modelosCamara == null) GetModelosCamaras();
            List<ModeloCamara> modelosMarcasCamara = new List<ModeloCamara>();
            foreach (ModeloCamara modelo in modelosCamara)
            {
                if (modelo.Id_marca.Equals(id_marca)) modelosMarcasCamara.Add(modelo);
            }
            return modelosMarcasCamara;
        }

        /// <summary>
        /// Obtiene el modelo de una camara dado el id
        /// </summary>
        /// <param name="id_modelo">The identifier modelo.</param>
        /// <returns></returns>
        internal ModeloCamara GetModeloCamara(int id_modelo)
        {
            if (modelosCamara == null) GetModelosCamaras();
            return modelosCamara.Find(x => x.Id == id_modelo);
        }
    }
}



