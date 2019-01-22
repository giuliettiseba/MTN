using MTN_Administration.Alerts;
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
    /// <summary>
    /// Helper de Incidentes.
    /// </summary>
    public class IncidenteHelper
    {

        private readonly string _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Incidente> _incidentes;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidenteHelper"/> class.
        /// </summary>
        /// <param name="partialurl">The partialurl.</param>
        /// <param name="checksumHelper">The checksum helper.</param>
        public IncidenteHelper(string partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this._checksumHelper = checksumHelper;
        }

        /// <summary>
        /// Obtiene un incidente dado un ID de incidente
        /// </summary>
        /// <param name="id_incidente">The identifier incidente.</param>
        /// <returns></returns>
        internal Incidente GetIncidente(int id_incidente)
        {
            if (_incidentes == null) GetIncidentes();
            return _incidentes.Find(x => x.Id == id_incidente);
        }


        /// <summary>
        /// Agrega un nuevo incidente o modifica uno existente
        /// </summary>
        /// <param name="newIncidente">The new incidente.</param>
        /// <returns></returns>
        internal MensajeAlerta AddIncidente(Incidente newIncidente)
        {
            String url = _partialurl + "incidentes";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.QueryString.Add("Id_cliente", newIncidente.Id_cliente.ToString());
                    webClient.QueryString.Add("Id_suc", newIncidente.Id_suc.ToString());
                    webClient.QueryString.Add("Id_tipo_mantenible", newIncidente.Id_tipo_mantenible.ToString());
                    webClient.QueryString.Add("Id_1", newIncidente.Id_1.ToString());
                    webClient.QueryString.Add("Id_2", newIncidente.Id_2.ToString());
                    webClient.QueryString.Add("Falla", newIncidente.Falla);
                    webClient.QueryString.Add("Id_criticidad", newIncidente.Id_criticidad.ToString());
                    webClient.QueryString.Add("Id_estado_incidente", newIncidente.Id_estado_incidente.ToString());

                    if (newIncidente.Id == 0)
                    {
                        webClient.UploadValues(url, "POST", webClient.QueryString);
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newIncidente.Id, AlertType.success);

                    }
                    else
                    {
                        webClient.QueryString.Add("id", newIncidente.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newIncidente.Id, AlertType.success);

                    }
                }
            }
            catch (Exception e)
            {

                return new MensajeAlerta("Error: " + e.ToString() + Environment.NewLine + newIncidente.Id, AlertType.error);
            }
        }

        /// <summary>
        /// Obtiene una lista de incidentes
        /// </summary>
        /// <returns></returns>
        public List<Incidente> GetIncidentes()
        {
            if ((_incidentes == null) || !(_checksumHelper.VerificarChecksum("Incidentes")))
            {
                _incidentes = new List<Incidente>();
                CacheIncidentes();
            }
            return _incidentes;
        }

        /// <summary>
        /// Guarda una lista de incidentes en memoria
        /// </summary>
        private void CacheIncidentes()
        {
            String url = _partialurl + "Incidentes";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Incidente> resultado = serializer.Deserialize<Resultado<Incidente>>(content);
                _incidentes = resultado.Lista.Cast<Incidente>().ToList();
                _checksumHelper.ActualizarChecksum("Incidentes", resultado.Checksum);
            }
        }

        /// <summary>
        /// Obtiene los incidentes de una sucursal
        /// </summary>
        /// <param name="id_Cliente">The identifier cliente.</param>
        /// <param name="id_Sucursal">The identifier sucursal.</param>
        /// <returns></returns>
        internal List<Incidente> GetIncidentes(int id_Cliente, int id_Sucursal)
        {
            GetIncidentes();
            List<Incidente> incidentesSucursal = new List<Incidente>();
            foreach (Incidente incidente in _incidentes)
            {
                if (incidente.Id_cliente == id_Cliente && incidente.Id_suc == id_Sucursal)
                    incidentesSucursal.Add(incidente);
            }
            return incidentesSucursal;
        }

        /// <summary>
        /// Verifica si hay cambios en la tabla de incidentes.
        /// </summary>
        /// <returns></returns>
        internal bool TieneCambios()
        {
            return (!_checksumHelper.VerificarChecksum("Incidentes"));
        }
    }
}
