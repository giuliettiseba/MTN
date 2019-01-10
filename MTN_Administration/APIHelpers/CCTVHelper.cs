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

        Dictionary<int, List<DispositivoCCTV>> cacheDispositivosSucursal = new Dictionary<int, List<DispositivoCCTV>>();

        public List<DispositivoCCTV> GetDispositivosCCTVSucursal(int id_sucursal)
        {
            if (!cacheDispositivosSucursal.ContainsKey(id_sucursal) || !_checksumHelper.VerificarChecksum("dispositivosCCTV_" + id_sucursal))
            {
                cacheDispositivosSucursal[id_sucursal] = new List<DispositivoCCTV>();
                CacheDispositivosCCTVSucursal(id_sucursal);
            }
            return cacheDispositivosSucursal[id_sucursal];
        }

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


        public DispositivoCCTV GetDispositivoCCTV(int id_sucursal, int id_dispositivoCCTV)
        {
            if (!cacheDispositivosSucursal.ContainsKey(id_sucursal)) GetDispositivosCCTVSucursal(id_sucursal);
            return cacheDispositivosSucursal[id_sucursal].Find(x => x.Id == id_dispositivoCCTV);
        }

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
                        webClient.UploadValues(url, "POST", webClient.QueryString);
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newDispositivoCCTV.Nombre, AlertType.success);
                    }
                    else
                    {
                        webClient.QueryString.Add("id", newDispositivoCCTV.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newDispositivoCCTV.Nombre, AlertType.success);
                    }
                }
            }
            catch (Exception)
            {

                return new MensajeAlerta("Error" + Environment.NewLine + newDispositivoCCTV.Nombre, AlertType.error);
            }

        }

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

        Dictionary<int, List<Camara>> cacheCamarasDispositivo = new Dictionary<int, List<Camara>>();

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

        public Camara GetCamara(int id_dispositivo, int id_camara)
        {
            if (!cacheCamarasDispositivo.ContainsKey(id_dispositivo)) GetCamarasDispositivo(id_dispositivo);
            return cacheCamarasDispositivo[id_dispositivo].Find(x => x.Id == id_camara);
        }

        public List<ModeloCamara> GetModelosCamaras()
        {
            if (modelosCamara == null || !_checksumHelper.VerificarChecksum("modelosCamara"))
            {
                modelosCamara = new List<ModeloCamara>();
                CacheModelosCamaras();
            }
            return modelosCamara;
        }
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
                    webClient.QueryString.Add("FechaInsta", newCamara.FechaInsta.ToString());
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

        public List<MarcaCCTV> GetMarcaCCTV()
        {
            if (marcasCCTV == null)
            {
                marcasCCTV = new List<MarcaCCTV>();
                CacheMarcaCCTV();
            }
            return marcasCCTV;
        }

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


        ////////////////////////////////////////////////MODELOS CCTV////////////////////////////////////////////////


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

        internal ModeloCCTV GetModeloCCTV(int id_modelo)
        {
            if (modelosCCTV == null) GetModelosCCTV();
            return modelosCCTV.Find(x => x.Id == id_modelo);
        }

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

        internal ModeloCamara GetModeloCamara(int id_modelo)
        {
            if (modelosCamara == null) GetModelosCamaras();
            return modelosCamara.Find(x => x.Id == id_modelo);

        }
    }
}



