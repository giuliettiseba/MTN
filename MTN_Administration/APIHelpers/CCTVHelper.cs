using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    public class CCTVHelper
    {
        private String _partialurl;
        private ChecksumHelper checksumHelper;

        private List<DispositivoCCTV> dispositivosCCTV;
        private List<MarcaCCTV> marcasCCTV;
        private List<ModeloCCTV> modelosCCTV;
        private List<ModeloCamara> modelosCamara;

        public CCTVHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this.checksumHelper = checksumHelper;
            //GetMarcaCCTV();
            //GetModelosCCTV();
        }

        ////////////////////////////////////////////////MARCAS CCTV////////////////////////////////////////////////

        public List<MarcaCCTV> GetMarcaCCTV()
        {
            if (marcasCCTV == null )//|| !checksumHelper.VerificarChecksum("marcaCCTV"))
            {
                marcasCCTV = new List<MarcaCCTV>();
                CacheMarcaCCTV();
            }
            return marcasCCTV;
        }

        private void CacheMarcaCCTV()
        {
            String url = _partialurl + "Utiles/MarcaCCTV";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<MarcaCCTV> resultado = serializer.Deserialize<Resultado<MarcaCCTV>>(content);
                marcasCCTV = resultado.Lista.Cast<MarcaCCTV>().ToList();
                checksumHelper.ActualizarChecksum("marcaCCTV", resultado.Checksum);
            }
        }

        internal List<int> GetPosicionesDisponibles(int id_dispositivo)
        {
            return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /// Implementar verificacion 
            /// Segun el modelo obtener canales disponibles
            /// Complemento de canales disponibles con los canales asignados.. 

        }




        internal MarcaCCTV GetMarcaCCTV(int id_marca)
        {
            if (marcasCCTV == null) GetMarcaCCTV();
            return marcasCCTV.Find(x => x.Id == id_marca);
        }


        ////////////////////////////////////DISPOSITIVOS CCTV/////////////////////////////////////////////////


        Dictionary<int, List<DispositivoCCTV>> cacheDispositivosSucursal = new Dictionary<int, List<DispositivoCCTV>>();

        public List<DispositivoCCTV> GetDispositivosCCTVSucursal(int id_sucursal)
        {
            if (!cacheDispositivosSucursal.ContainsKey(id_sucursal) || !checksumHelper.VerificarChecksum("dispositivosCCTV_"+id_sucursal))
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
                checksumHelper.ActualizarChecksum("dispositivosCCTV_" + id_sucursal, resultado.Checksum);
            }
        }


        public List<DispositivoCCTV> GetDispositivosCCTV()
        {
            if (dispositivosCCTV == null || !checksumHelper.VerificarChecksum("dispositivosCCTV"))
            {
                dispositivosCCTV = new List<DispositivoCCTV>();
                CacheDispositivosCCTV();
            }
            return dispositivosCCTV;
        }

        public void CacheDispositivosCCTV()
        {
            String url = _partialurl + "DispositivosCCTV";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<DispositivoCCTV> resultado = serializer.Deserialize<Resultado<DispositivoCCTV>>(content);
                dispositivosCCTV = resultado.Lista.Cast<DispositivoCCTV>().ToList();
                checksumHelper.ActualizarChecksum("dispositivosCCTV", resultado.Checksum);
            }
        }

        public DispositivoCCTV GetDispositivoCCTV(int id_dispositivoCCTV)
        {
            return dispositivosCCTV.Find(x => x.Id == id_dispositivoCCTV);
        }



        internal string AddDispositivoCCTV(DispositivoCCTV newDispositivoCCTV)
        {
            String url = _partialurl + "DispositivosCCTV/";
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
                }
                else
                {
                    webClient.QueryString.Add("id", newDispositivoCCTV.Id.ToString());
                    webClient.UploadValues(url, "PUT", webClient.QueryString);
                }
                return "Se agrego correctamente el cliente: " + newDispositivoCCTV.Nombre;
            }

        }



        public string RemoveDispositivoCCTV(int id)
        {
            String url = _partialurl + "DispositivosCCTV/" + id;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return Encoding.ASCII.GetString(responseArray);
            }
        }



        ////////////////////////////////////////////////MODELOS CCTV////////////////////////////////////////////////


        public List<ModeloCCTV> GetModelosCCTV()
        {
            if (modelosCCTV != null && checksumHelper.VerificarChecksum("modelosCCTV"))
            {
                return modelosCCTV;
            }
            modelosCCTV = new List<ModeloCCTV>();
            CacheModelosCCTV();
            return modelosCCTV;

        }
        private void CacheModelosCCTV()
        {
            String url = _partialurl + "Utiles/ModelosCCTV";
            using (WebClient client = new WebClient())
            {

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<ModeloCCTV> resultado = serializer.Deserialize<Resultado<ModeloCCTV>>(content);
                modelosCCTV = resultado.Lista.Cast<ModeloCCTV>().ToList();
                checksumHelper.ActualizarChecksum("modelosCCTV", resultado.Checksum);
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


        /////////////////////////////////////////////////////GET CAMARAS///////////////////////////////////////////////////////////////

        Dictionary<int, List<Camara>> cacheCamarasDispositivo = new Dictionary<int, List<Camara>>();

        public List<Camara> GetCamarasDispositivo(int id_dispositivo)
        {
            if (!cacheCamarasDispositivo.ContainsKey(id_dispositivo) || !checksumHelper.VerificarChecksum("camaras_" + id_dispositivo))
            {
                cacheCamarasDispositivo.Remove(id_dispositivo);
                cacheCamarasDispositivo.Add(id_dispositivo, new List<Camara>());
                CacheCamarasDispositivo(id_dispositivo);
            }
            return cacheCamarasDispositivo[id_dispositivo];
        }



        private void CacheCamarasDispositivo(int id_dispositivo)
        {
            String url = _partialurl + "Camaras/" + id_dispositivo ;

            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Camara> resultado = serializer.Deserialize<Resultado<Camara>>(content);
                cacheCamarasDispositivo[id_dispositivo] = resultado.Lista.Cast<Camara>().ToList();
                checksumHelper.ActualizarChecksum("camaras_" + id_dispositivo, resultado.Checksum);
            }
        }

       


        internal Camara GetCamara(int id_dispositivo, int id_camara)
        {
            return cacheCamarasDispositivo[id_dispositivo].Find(x => x.Id == id_camara);
        }

        public List<ModeloCamara> GetModelosCamaras()
        {
            if (modelosCamara == null || !checksumHelper.VerificarChecksum("modelosCamara"))
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
                checksumHelper.ActualizarChecksum("modelosCamara", resultado.Checksum);
            }
        }



        internal string AddCamara(Camara newCamara)
        {
            String url = _partialurl + "Camaras";
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
                }
                else
                {
                    webClient.QueryString.Add("Id_camara", newCamara.Id.ToString());
                    webClient.UploadValues(url, "PUT", webClient.QueryString);
                }
                return "Se agrego correctamente el cliente: " + newCamara.Nombre;
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



