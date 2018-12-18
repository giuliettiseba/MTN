using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MTN_Administration
{
    class APIHelper
    {
      
        static readonly string host = "http://localhost";
    //    static readonly string port = "2510";
        static readonly string port = "50411";
        static readonly string apiRoute = "api";
        static readonly string _partialurl = host + ":" + port + "/" + apiRoute + "/";

        public APIHelper()
        {
            GetTipoDocumento();
            GetTipoEmpleado();
            GetLocalidades();
            GetProvincias();
        }

        // CACHES
        List<Tecnico> tecnicos;
        List<Localidad> localidades;
        private Dictionary<int, string> provincias;
        private Dictionary<int, string> tipoDocumento;
        private Dictionary<int, string> tipoEmpleado;

        public void clearCache()
        {
            tecnicos = null;
            localidades = null;
            provincias = null;
            tipoDocumento = null;
            tipoEmpleado = null;
        }
        
        public List<Tecnico> GetTecnicos()
        {
            if (tecnicos == null)
            {
                tecnicos = new List<Tecnico>();
                CacheTecnicos();
            }
            return tecnicos;
        }

        public void CacheTecnicos()
        {
            String url = _partialurl + "tecnicos/";
            WebClient client = new WebClient();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String content = client.DownloadString(url);
            tecnicos = serializer.Deserialize<List<Tecnico>>(content);
        }


        internal Tecnico GetTecnico(int id_tecnico)
        {
            return tecnicos.Find(x => x.id == id_tecnico);
        }

        internal string RemoveTecnico(int id_tecnico)
        {
            tecnicos.Remove(tecnicos.Find(x => x.id == id_tecnico)); // actualizo cache

            String url = _partialurl + "tecnicos/" + id_tecnico;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return Encoding.ASCII.GetString(responseArray);
            }
        }

        internal string PostTecnico(Tecnico tecnico)
        {
            
            String url = _partialurl + "tecnicos";
            using (WebClient webClient = new WebClient())
            {
                webClient.QueryString.Add("nombre", tecnico.nombre);
                webClient.QueryString.Add("apellido", tecnico.apellido);
                webClient.QueryString.Add("legajo", tecnico.legajo.ToString());
                webClient.QueryString.Add("direccion", tecnico.direccion);
                webClient.QueryString.Add("id_localidad", tecnico.id_localidad.ToString());
                webClient.QueryString.Add("documento", tecnico.documento.ToString());
                webClient.QueryString.Add("id_tipo_documento", tecnico.id_tipo_documento.ToString());
                webClient.QueryString.Add("id_tipo_empleado", tecnico.id_tipo_empleado.ToString());
                //   webClient.QueryString.Add("foto", tecnico.foto.ToString());
                if (tecnico.id == 0)
                {
                    tecnicos.Add(tecnico); // actualizo cache
                    webClient.UploadValues(url, "POST", webClient.QueryString);
                }
                else
                {
                    tecnicos.Remove(tecnicos.Find(x => x.id == tecnico.id)); // actualizo cache
                    tecnicos.Add(tecnico); // actualizo cache
                    webClient.QueryString.Add("id", tecnico.id.ToString());
                    webClient.UploadValues(url, "PUT", webClient.QueryString);
                }
                return "Se agrego correctamente el empleado " + tecnico.legajo;
            }
        }

        public List<Object> Get(String tipo)
        {
            String url = "";
            switch (tipo)
            {
                case "Provincia": url = _partialurl + "Utiles/Provincias"; break;
                case "TipoDocuementos": url = _partialurl + "Utiles/TipoDocumento"; break;
                case "TipoEmpleado": url = _partialurl + "Utiles/TipoEmpleado"; break;
                default:
                    return null;//no se conoce el objeto 
            }
            WebClient client = new WebClient();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String content = client.DownloadString(url);
            return serializer.Deserialize<List<dynamic>>(content);
        }






        private void CacheLocalidades()
        {
            String url = _partialurl + "Utiles/Localidades";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                localidades = serializer.Deserialize<List<Localidad>>(content);
            }
        }

        public List<Localidad> GetLocalidades()
        {
            if (localidades == null)
            {
                localidades = new List<Localidad>();
                CacheLocalidades();
            }
            return localidades;
        }


        public Dictionary<int, string> GetLocalidades(int id_provincia)
        {
            Dictionary<int, string> dicLocalidades = new Dictionary<int, string>();
            foreach (Localidad l in GetLocalidades())
            {
                if (l.id_provincia == id_provincia) dicLocalidades.Add(l.id, l.nombre);
            }
            return dicLocalidades;
        }



        private void CacheProvincias()
        {
            List<object> list = Get("Provincia");
            foreach (Dictionary<String, Object> o in list)
            {
                provincias.Add((int)o["id"], (String)(o["nombre"]));
            }
        }

        public Dictionary<int, string> GetProvincias()
        {
            if (provincias == null)
            {
                provincias = new Dictionary<int, string>();
                CacheProvincias();
            }
            return provincias;
        }

        private void CacheTipoDocumento()
        {
            List<object> list = Get("TipoDocuementos");
            foreach (Dictionary<String, Object> o in list)
            {
                tipoDocumento.Add((int)o["id"], (String)(o["nombre"]));
            }
        }

        public Dictionary<int, string> GetTipoDocumento()
        {
            if (tipoDocumento == null)
            {
                tipoDocumento = new Dictionary<int, string>();
                CacheTipoDocumento();
            }
            return tipoDocumento;
        }
        private void CacheTipoEmpleado()
        {
            List<object> list = Get("TipoEmpleado");
            foreach (Dictionary<String, Object> o in list)
            {
                tipoEmpleado.Add((int)o["id"], (String)(o["nombre"]));
            }
        }

        public Dictionary<int, string> GetTipoEmpleado()
        {
            if (tipoEmpleado == null)
            {
                tipoEmpleado = new Dictionary<int, string>();
                CacheTipoEmpleado();
            }
            return tipoEmpleado;
        }

    

        
        
        
        
        // Obtener nombres
                     
        public int GetProvincia(int id_localidad)
        {
            return localidades.Find(x => x.id == id_localidad).id_provincia;
        }

         public string GetTipoEmpleado(int i)
        {
            return tipoEmpleado[i];
        }

        public string GetNombreLocalidad(int i)
        {
            return localidades.Find(x => x.id == i).nombre;
        }

        public string GetNombreProvincia(int i) {
            return provincias[i];
        }

    }
}
