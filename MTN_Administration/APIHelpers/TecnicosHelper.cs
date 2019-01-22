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
    /// <summary>
    /// Helper de tecnicos
    /// </summary>
    public class TecnicosHelper
    {

        private readonly String _partialurl;
        private ChecksumHelper checksumHelper;
        private List<Tecnico> tecnicos;

        /// <summary>
        /// Initializes a new instance of the <see cref="TecnicosHelper"/> class.
        /// </summary>
        /// <param name="partialurl">The partialurl.</param>
        /// <param name="checksumHelper">The checksum helper.</param>
        public TecnicosHelper(String partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this.checksumHelper = checksumHelper;
        }

        /// <summary>
        /// Obtiene la lista de tecnicos.
        /// </summary>
        /// <returns></returns>
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
        /// Almacena en memoria la lista de tecnicos,
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

        /// <summary>
        /// Obtiene un tecnico dado un ID
        /// </summary>
        /// <param name="id_tecnico">The identifier tecnico.</param>
        /// <returns></returns>
        internal Tecnico GetTecnico(int id_tecnico)
        {
            if (tecnicos == null) GetTecnicos();

            return tecnicos.Find(x => x.Id == id_tecnico);
        }

        /// <summary>
        /// Elimina un tecnico
        /// </summary>
        /// <param name="id_tecnico">The identifier tecnico.</param>
        /// <returns></returns>
        internal MensajeAlerta RemoveTecnico(Tecnico tecnico)
        {
            String url = _partialurl + "tecnicos/" + tecnico.Id;
            using (WebClient webClient = new WebClient())
            {
                var responseArray = webClient.UploadValues(url, "DELETE", webClient.QueryString);
                return new MensajeAlerta("ELIMINADO" + Environment.NewLine + tecnico.Apellido + ", " + tecnico.Nombre, AlertType.warning);
            }

        }

        /// <summary>
        /// Agrega o modifica un tecnico.
        /// </summary>
        /// <param name="newTecnico">The new tecnico.</param>
        /// <returns></returns>
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
