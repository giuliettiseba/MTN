using MTN_Administration.APIHelpers;
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
    public class APIHelper
    {

        private String _partialurl;
        private ChecksumHelper checksumHelper;
        private ClientesHelper clientesHelper;
        private SucursalesHelper sucursalesHelper;
        private CCTVHelper cCTVHelper;
        private TecnicosHelper tecnicosHelper;

        List<Localidad> localidades;
        private Dictionary<int, string> provincias;
        private Dictionary<int, string> tipoDocumento;
        private Dictionary<int, string> tipoEmpleado;
        private Dictionary<int, string> estados;
        private Dictionary<int, string> tecnologiasCamaras;

        public APIHelper(string _partialurl)
        {
            this._partialurl = _partialurl;
            checksumHelper = new ChecksumHelper(_partialurl);
            clientesHelper = new ClientesHelper(_partialurl, checksumHelper);
            cCTVHelper = new CCTVHelper(_partialurl, checksumHelper);
            sucursalesHelper = new SucursalesHelper(_partialurl, checksumHelper);
            tecnicosHelper = new TecnicosHelper(_partialurl, checksumHelper);
        }

        public ClientesHelper GetClientesHelper()
        {
            return clientesHelper;
        }

        public CCTVHelper GetCCTVHelper()
        {
            return cCTVHelper;
        }

        public SucursalesHelper GetSucursalesHelper()
        {
            return sucursalesHelper;
        }

        public TecnicosHelper GetTecnicosHelper()
        {
            return tecnicosHelper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public void Get(String tipo)
        {
            Dictionary<int, string> diccionario = null;
            String url = "";

            switch (tipo)
            {
                case "Provincia":
                    url = _partialurl + "Utiles/Provincias";
                    diccionario = provincias;
                    break;
                case "TipoDocuementos":
                    url = _partialurl + "Utiles/TipoDocumento";
                    diccionario = tipoDocumento;
                    break;
                case "TipoEmpleado":
                    url = _partialurl + "Utiles/TipoEmpleado";
                    diccionario = tipoEmpleado;
                    break;
                case "Estados":
                    url = _partialurl + "Utiles/Estados";
                    diccionario = estados;
                    break;
                case "TecnologiaCamara":
                    url = _partialurl + "Utiles/TecnologiaCamara";
                    diccionario = tecnologiasCamaras;
                    break;
                default:
                    break;
            }
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                List<object> list = serializer.Deserialize<List<dynamic>>(content);

                foreach (Dictionary<String, Object> o in list)
                {
                    diccionario.Add((int)o["Id"], (String)(o["Nombre"]));
                }

            }
        }


        ////////////////////////////////////////////////TECNOLOGIA CAMARAS//////////////////////////////////////////////////////////////

        internal Dictionary<int, String> GetTecnologiaCamara()
        {
            if (tecnologiasCamaras == null)
            {
                tecnologiasCamaras = new Dictionary<int, string>();
                Get("TecnologiaCamara");
            }
            return tecnologiasCamaras;
        }

        ////////////////////////////////////////////////PROVINCIA////////////////////////////////////////////////////////////////////////

        public Dictionary<int, string> GetProvincias()
        {
            if (provincias == null)
            {
                provincias = new Dictionary<int, string>();
                Get("Provincia");
            }
            return provincias;
        }

        public string GetNombreProvincia(int i)
        {
            if (provincias == null) GetProvincias();
            return provincias[i];
        }

        //////////////////////////////////////////////ESTADOS//////////////////////////////////////////////////////////////////////////////

        public Dictionary<int, string> GetEstados()
        {
            if (estados == null)
            {
                estados = new Dictionary<int, string>();
                Get("Estados");
            }
            return estados;
        }

        public string GetEstado(int id)
        {
            if (estados == null) GetEstados();
            return estados[id];
        }

        ////////////////////////////////////////////////TIPO DOCUMENTO///////////////////////////////////////////////////////////////////

        public Dictionary<int, string> GetTipoDocumento()
        {
            if (tipoDocumento == null)
            {
                tipoDocumento = new Dictionary<int, string>();
                Get("TipoDocuementos");
            }
            return tipoDocumento;
        }

        ////////////////////////////////////////////////TIPO EMPLEADO///////////////////////////////////////////////////////////////////////

        public Dictionary<int, string> GetTipoEmpleado()
        {
            if (tipoEmpleado == null)
            {
                tipoEmpleado = new Dictionary<int, string>();
                Get("TipoEmpleado");
            }
            return tipoEmpleado;
        }


        public string GetTipoEmpleado(int i)
        {
            if (tipoEmpleado == null) GetTipoEmpleado();
            return tipoEmpleado[i];
        }

        ////////////////////////////////////////////////LOCALIDADES////////////////////////////////////////////////////////////////////////

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
                if (l.Id_provincia == id_provincia) dicLocalidades.Add(l.Id, l.Nombre);
            }
            return dicLocalidades;
        }


        public int GetProvincia(int id_localidad)
        {
            if (localidades == null) GetLocalidades();
            return localidades.Find(x => x.Id == id_localidad).Id_provincia;
        }

        public string GetNombreLocalidad(int i)
        {
            if (localidades == null) GetLocalidades();
            return localidades.Find(x => x.Id == i).Nombre;
        }

    }
}