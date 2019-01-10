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
    public class IncidenteHelper
    {

        private string _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Incidente> _incidentes;


        public IncidenteHelper(string partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this._checksumHelper = checksumHelper;
        }

        internal Incidente GetIncidente(int id_incidente) {
            return _incidentes.Find(x => x.Id == id_incidente);
        }



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

                    webClient.QueryString.Add("asigado", newIncidente.Asignado.ToString());

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

                return new MensajeAlerta("Error" + Environment.NewLine + newIncidente.Id, AlertType.error);
            }
        } 

        public List<Incidente> GetIncidentes()
        {
            if ((_incidentes == null) || !(_checksumHelper.VerificarChecksum("Incidentes")))
            {
                _incidentes = new List<Incidente>();
                CacheIncidentes();
            }
            return _incidentes;
        }

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


    }
}
