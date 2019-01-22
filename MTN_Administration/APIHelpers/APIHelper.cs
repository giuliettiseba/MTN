using MTN_Administration.APIHelpers;
using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace MTN_Administration
{
    /// <summary>
    /// Helper principal, se instancia al iniciar la aplicacion y es el responsable de mantener la las referencias de todos los Helpers. 
    /// Mantiene en memoria diccionarios y listas de las entidades comunes.
    /// </summary>
    public class APIHelper
    {
        private readonly string partialurl;
        private readonly ClientesHelper clientesHelper;
        private readonly SucursalesHelper sucursalesHelper;
        private readonly CCTVHelper cCTVHelper;
        private readonly TecnicosHelper tecnicosHelper;
        private readonly IncidenteHelper incidentesHelper;
        private readonly MantenimientoHelper mantenimientoHelper;
        private ChecksumHelper checksumHelper;
        private FileStorageHelper fileStorageHelper;

        List<Localidad> localidades;
        private Dictionary<int, string> provincias;
        private Dictionary<int, string> tecnologiasCamaras;

        /// <summary>
        /// Constructor de Helper principal. 
        /// </summary>
        /// <param name="partialurl">Ruta parcial de la URI donde esta alojada el MTN_API</param>
        public APIHelper(string partialurl)
        {
            this.partialurl = partialurl;

            /// instancia cada uno de los helpers
            checksumHelper = new ChecksumHelper(partialurl);
            clientesHelper = new ClientesHelper(partialurl, checksumHelper);
            cCTVHelper = new CCTVHelper(partialurl, checksumHelper);
            sucursalesHelper = new SucursalesHelper(partialurl, checksumHelper);
            tecnicosHelper = new TecnicosHelper(partialurl, checksumHelper);
            incidentesHelper = new IncidenteHelper(partialurl, checksumHelper);
            mantenimientoHelper = new MantenimientoHelper(partialurl, checksumHelper);
            fileStorageHelper = new FileStorageHelper();

            GetLocalidades(); // Lista almacenada en archivo, solo se consulta el checksum, si este cambia con respecto al almacenado se pullea la tabla
            GetProvincias();
            GetTecnologiaCamara();
        }

        /// <summary>
        /// Devuelve el helper para la entidad Cliente 
        /// </summary>
        /// <returns>Helper de clientes</returns>
        public ClientesHelper GetClientesHelper()
        {
            return clientesHelper;
        }

        /// <summary>
        /// Devuelve el helper para la entidad Dispositivos de CCTV
        /// </summary>
        /// <returns>Helper de Dispositivos de CCTV</returns>
        public CCTVHelper GetCCTVHelper()
        {
            return cCTVHelper;
        }

        /// <summary>
        /// Devuelve el Helper de la entidad Sucursales
        /// </summary>
        /// <returns>Helper de Sucursalaes</returns>
        public SucursalesHelper GetSucursalesHelper()
        {
            return sucursalesHelper;
        }

        /// <summary>
        /// Devuelve el Helper de la entidad Tecnicos
        /// </summary>
        /// <returns>Helper de tecnicos</returns>
        public TecnicosHelper GetTecnicosHelper()
        {
            return tecnicosHelper;
        }


        /// <summary>
        /// Devuelve el Helper de la entidad Incidentes
        /// </summary>
        /// <returns>Helper de Incidentes</returns>
        public IncidenteHelper GetIncidenteHelper()
        {
            return incidentesHelper;
        }

        /// <summary>
        /// Devuelve el Helper de la entidad Mantenimientos
        /// </summary>
        /// <returns>Helper de Mantenimientos</returns>
        public MantenimientoHelper GetMantenimientosHelper()
        {
            return mantenimientoHelper;
        }


        /// <summary>
        /// Metodo para acceder a los diccionarios de las entidades Provincias, Cuidades, Documentos, Tipo Empleado, Estados, Tecnologia Camara, 
        /// </summary>
        /// <param name="tipo">Nombre del diccionario</param>
        /// <returns>Diccionario</returns>
        public void Get(String tipo)
        {
            Dictionary<int, string> diccionario = null;
            String url = "";

            switch (tipo)
            {
                case "Provincia":
                    url = partialurl + "Utiles/Provincias";
                    diccionario = provincias;
                    break;

                case "TecnologiaCamara":
                    url = partialurl + "Utiles/TecnologiaCamara";
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

        /// <summary>
        /// Si el diccionario esta vacio, obtiene de la base de datos la tabla tecnologia de camaras, sino retorna el diccionario almacenado en memoria
        /// </summary>
        /// <returns>Diccionario de tecnologia de camaras</returns>
        internal Dictionary<int, String> GetTecnologiaCamara()
        {
            if (tecnologiasCamaras == null)
            {
                tecnologiasCamaras = new Dictionary<int, string>();
                Get("TecnologiaCamara");
            }
            return tecnologiasCamaras;
        }


        ////////////////////////////////////////////////LOCALIDADES////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Si la lista esta vacia, obtiene listado de localidades. 
        /// </summary>
        /// <returns>Lista de localidades de la republica argentina</returns>
        internal List<Localidad> GetLocalidades()
        {
            if (localidades == null)
            {
                localidades = new List<Localidad>();
                CacheLocalidades();
            }
            return localidades;
        }


        /// <summary>
        /// Almacena en memoria una lista completa de las localidades de la Republica Argentina
        /// Primero busca la informacion en un archivo local en formato XML
        /// Si el archivo no existe obtiene de la base de datos el listado de localidades
        /// Si el archivo almacenado tiene un checksum distinto al de la base de datos, obtiene una copia actualizada de la tabla localidades
        /// </summary>
        private void CacheLocalidades()
        {
            String tabla = "Localidades"; // Nombre de la tabla 
            String file = @"localCache\" + tabla + ".mtn"; // Path donde se almacena 
            Resultado<Localidad> resultadoLocal = fileStorageHelper.DeSerializeObject<Resultado<Localidad>>(file); // Si el archivo existe recupera el objeteo Resultado<MarcaCCTV>
            if (resultadoLocal != null)
            {
                localidades = resultadoLocal.Lista.Cast<Localidad>().ToList();
                checksumHelper.ActualizarChecksum(tabla, resultadoLocal.Checksum); // Si logra recuperar el objeto actualiza el checksum local
            }
            if (!checksumHelper.VerificarChecksum(tabla)) // Verifica que el checksum sea el mismo que el de la tabla actual
            {
                String url = partialurl + "Utiles/Localidades";
                using (WebClient client = new WebClient())
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    String content = client.DownloadString(url); // Consulta a la API por la tabla completa
                    Resultado<Localidad> resultado = serializer.Deserialize<Resultado<Localidad>>(content); // Convierte el resultado de la consulta a un objeto del tipo Resultado
                    fileStorageHelper.SerializeObject(resultado, file); // Actualiza o crea un archivo local
                    localidades = resultado.Lista.Cast<Localidad>().ToList(); // separa el checksum del objeto
                }
            }
        }


        /// <summary>
        /// Obtiene un diccionario con localidades de una provincia
        /// </summary>
        /// <param name="id_provincia">Provincia de la cual se quiere obtener las localidades</param>
        /// <returns>Diccionario con las localidades de una provincia</returns>
        internal Dictionary<int, string> GetLocalidades(int id_provincia)
        {
            Dictionary<int, string> dicLocalidades = new Dictionary<int, string>();
            foreach (Localidad l in GetLocalidades())
            {
                if (l.Id_provincia == id_provincia) dicLocalidades.Add(l.Id, l.Nombre);
            }
            return dicLocalidades;
        }

        /// <summary>
        /// Obtiene el nombre del id de una Localidad
        /// </summary>
        /// <param name="i">Id de la localidad</param>
        /// <returns>Nombre de la localidad</returns>
        internal string GetNombreLocalidad(int i)
        {
            if (localidades == null) GetLocalidades();
            return localidades.Find(x => x.Id == i).Nombre;
        }

        ////////////////////////////////////////////////PROVINCIA////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Si el diccionario esta vacio, obtiene de la base de datos la tabla Provincias, sino retorna el diccionario almacenado en memoria
        /// </summary>
        /// <returns>Diccionario de Provincias</returns>
        internal Dictionary<int, string> GetProvincias()
        {
            if (provincias == null)
            {
                provincias = new Dictionary<int, string>();
                Get("Provincia");
            }
            return provincias;
        }

        /// <summary>
        /// Obtiene el nombre del id de una Provincia
        /// </summary>
        /// <param name="i">id de la provincia</param>
        /// <returns>Nombre de la provincia</returns>
        internal string GetNombreProvincia(int i)
        {
            if (provincias == null) GetProvincias();
            return provincias[i];
        }


        /// <summary>
        ///  Dada el id de una localidad obtiene el id de la provincia a la que pertenece
        /// </summary>
        /// <param name="id_localidad">id de la localidad</param>
        /// <returns>id de la provincia a la que pertenece</returns>
        internal int GetProvincia(int id_localidad)
        {
            if (localidades == null) GetLocalidades();
            return localidades.Find(x => x.Id == id_localidad).Id_provincia;
        }

    }
}