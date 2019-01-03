using MTN_Administration.Alerts;
using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    public class TecnicosHelper
    {

        private String _partialurl;
        private ChecksumHelper checksumHelper;
        List<Tecnico> tecnicos;

        public TecnicosHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this.checksumHelper = checksumHelper;
        }

        public List<Tecnico> GetTecnicos()
        {
            if (tecnicos == null || !checksumHelper.VerificarChecksum("tecnicos"))
            {
                tecnicos = new List<Tecnico>();
                CacheTecnicos();
            }
            return tecnicos;
        }

        /// <summary>
        /// Consulta la API para traer la lista de los tecnicos completa.
        /// </summary>
        public void CacheTecnicos()
        {
            String url = _partialurl + "tecnicos/";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Tecnico> resultado = serializer.Deserialize<Resultado<Tecnico>>(content);
                tecnicos = resultado.Lista.Cast<Tecnico>().ToList(); 
                checksumHelper.ActualizarChecksum("tecnicos", resultado.Checksum);
            }
        }

        internal Tecnico GetTecnico(int id_tecnico)
        {
            return tecnicos.Find(x => x.Id == id_tecnico);
        }

        internal string RemoveTecnico(int id_tecnico)
        {
            String url = _partialurl + "tecnicos/" + id_tecnico;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return Encoding.ASCII.GetString(responseArray);
            }

        }

        internal MensajeAlerta AddTecnico(Tecnico newTecnico)
        {
            String url = _partialurl + "tecnicos";
            using (WebClient webClient = new WebClient())
            {
                webClient.QueryString.Add("nombre", newTecnico.Nombre);
                webClient.QueryString.Add("apellido", newTecnico.Apellido);
                webClient.QueryString.Add("legajo", newTecnico.Legajo.ToString());
                webClient.QueryString.Add("direccion", newTecnico.Direccion);
                webClient.QueryString.Add("id_localidad", newTecnico.Id_localidad.ToString());
                webClient.QueryString.Add("documento", newTecnico.Documento.ToString());
                webClient.QueryString.Add("id_tipo_documento", newTecnico.Id_tipo_documento.ToString());
                webClient.QueryString.Add("id_tipo_empleado", newTecnico.Id_tipo_empleado.ToString());
                //   webClient.QueryString.Add("foto", tecnico.foto.ToString());
                if (newTecnico.Id == 0)
                {
                    webClient.UploadValues(url, "POST", webClient.QueryString);
                    return new MensajeAlerta("Agregado" + Environment.NewLine + newTecnico.Nombre, AlertType.success);
                }
                else
                {
                    webClient.QueryString.Add("id", newTecnico.Id.ToString());
                    webClient.UploadValues(url, "PUT", webClient.QueryString);
                    return new MensajeAlerta("Modificado" + Environment.NewLine + newTecnico.Nombre, AlertType.success);
                }
            }
        }
    }
}
