using MTN_Administration.Alerts;
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
        private FileStorageHelper fileStorageHelper;
        private IncidenteHelper incidentesHelper;
        private MantenimientoHelper mantenimientoHelper;

        List<Localidad> localidades;
        private Dictionary<int, string> provincias;
        private Dictionary<int, string> tipoDocumento;
        private Dictionary<int, string> tipoEmpleado;
        private Dictionary<int, string> estados;
        private Dictionary<int, string> tecnologiasCamaras;

        internal MantenimientoHelper GetMantenimientosHelper()
        {
            return mantenimientoHelper;
        }

        public APIHelper(string _partialurl)
        {
            this._partialurl = _partialurl;
            checksumHelper = new ChecksumHelper(_partialurl);
            clientesHelper = new ClientesHelper(_partialurl, checksumHelper);
            cCTVHelper = new CCTVHelper(_partialurl, checksumHelper);
            sucursalesHelper = new SucursalesHelper(_partialurl, checksumHelper);
            tecnicosHelper = new TecnicosHelper(_partialurl, checksumHelper);
            incidentesHelper = new IncidenteHelper(_partialurl, checksumHelper);
            mantenimientoHelper = new MantenimientoHelper(_partialurl, checksumHelper);
            fileStorageHelper = new FileStorageHelper();

            //// Carga tablas pesadas que no se modifican con el tiempo. Ver de tener una copia en archivo local y solo controlar el checksum al inicio

            GetLocalidades();
            GetProvincias();
            GetTipoEmpleado();
            GetTipoDocumento();
            GetEstados();
            GetTecnologiaCamara();
            
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

        public IncidenteHelper GetIncidenteHelper()
        {
            return incidentesHelper;
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





        
        //////////////////////////////////////////////////////////////////////Estados Incidentes//////////////////////////////////////////////////////////////////////
        /*
        private Dictionary<int, String> estadosIncidente;

        public String GetEstadoIncidente(int id_estadoIncidente)
        {
            if (estadosIncidente == null)
            {
                GetEstadoIncidente();
            }
            return estadosIncidente[id_estadoIncidente];
        }

            public Dictionary<int, String> GetEstadoIncidente()
        {
            if (estadosIncidente != null)
            {
                return estadosIncidente;
            }
            estadosIncidente = new Dictionary<int, String>();
            CacheEstadosIncidente();
            return estadosIncidente;
        }


        private void CacheEstadosIncidente()
        {
            String tabla = "EstadosIncidente"; // Nombre de la tabla 
            String file = @"localCache\" + tabla + ".mtn"; // Path donde se almacena 
            Resultado<EstadoIncidente> resultadoLocal = fileStorageHelper.DeSerializeObject<Resultado<EstadoIncidente>>(file); // Si el archivo existe recupera el objeteo Resultado<ModeloCCTV>
            if (resultadoLocal != null)
            {
                estadosIncidente = resultadoLocal.Lista.Cast<EstadoIncidente>().ToDictionary(x => x.Id, x => x.Nombre);
                checksumHelper.ActualizarChecksum(tabla, resultadoLocal.Checksum); // Si logra recuperar el objeto actualiza el checksum local
            }
            if (!checksumHelper.VerificarChecksum(tabla)) // Verifica que el checksum sea el mismo que el de la tabla actual
            {
                String url = _partialurl + "Utiles/" + tabla;
                using (WebClient client = new WebClient())
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    String content = client.DownloadString(url); // Consulta a la API por la tabla completa
                    Resultado<EstadoIncidente> resultado = serializer.Deserialize<Resultado<EstadoIncidente>>(content); // Convierte el resultado de la consulta a un objeto del tipo Resultado
                    fileStorageHelper.SerializeObject(resultado, file); // Actualiza o crea un archivo local
                    estadosIncidente = resultado.Lista.Cast<EstadoIncidente>().ToDictionary(x => x.Id, x => x.Nombre); // separa el checksum del objeto
                }
            }
        }

    */


    }
}