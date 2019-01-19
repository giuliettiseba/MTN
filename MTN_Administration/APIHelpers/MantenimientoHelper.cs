using MTN_Administration.Alerts;
using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http;

namespace MTN_Administration.APIHelpers
{
    /// <summary>
    /// Helper de mantenimientos.
    /// </summary>
    public class MantenimientoHelper
    {

        private string _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Mantenimiento> _mantenimientos;

        /// <summary>
        /// Initializes a new instance of the <see cref="MantenimientoHelper"/> class.
        /// </summary>
        /// <param name="partialurl">The partialurl.</param>
        /// <param name="checksumHelper">The checksum helper.</param>
        public MantenimientoHelper(string partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this._checksumHelper = checksumHelper;
        }

        /// <summary>
        /// Obtiene la lista de mantenimientos
        /// </summary>
        /// <returns></returns>
        public List<Mantenimiento> GetMantenimientos()
        {
            if ((_mantenimientos == null) || !(_checksumHelper.VerificarChecksum("Mantenimientos")))
            {
                _mantenimientos = new List<Mantenimiento>();
                CacheMantenimientos();
            }
            return _mantenimientos;
        }

        /// <summary>
        /// Almacena en memoria la lista de mantenimientos
        /// </summary>
        private void CacheMantenimientos()
        {
            String url = _partialurl + "Mantenimiento";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Mantenimiento> resultado = serializer.Deserialize<Resultado<Mantenimiento>>(content);
                _mantenimientos = resultado.Lista.Cast<Mantenimiento>().ToList();
                _checksumHelper.ActualizarChecksum("Mantenimientos", resultado.Checksum);
            }
        }


        /// <summary>
        /// Agrega o modifica un manenimietno.
        /// </summary>
        /// <param name="newMantenimiento">The new mantenimiento.</param>
        /// <returns></returns>
        internal MensajeAlerta AddManteniento(Mantenimiento newMantenimiento)
        {
            String url = _partialurl + "Mantenimiento";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.QueryString.Add("id_tipo_mantenimiento", newMantenimiento.id_tipo_mantenimiento.ToString());
                    webClient.QueryString.Add("Fecha", newMantenimiento.Fecha.ToString());
                    webClient.QueryString.Add("ot", newMantenimiento.Ot);
                    webClient.QueryString.Add("HoraInicio", newMantenimiento.HoraInicio.ToString());
                    webClient.QueryString.Add("HoraFin", newMantenimiento.HoraFin.ToString());
                    webClient.QueryString.Add("detalles", newMantenimiento.Detalles);
                    webClient.QueryString.Add("estado", ((int)newMantenimiento.Estado).ToString());

                    webClient.QueryString.Add("id_sucursal", newMantenimiento.Id_Sucursal.ToString());
                    webClient.QueryString.Add("id_cliente", newMantenimiento.Id_Cliente.ToString());
                    webClient.QueryString.Add("tecnico1", newMantenimiento.Tecnico1.ToString());
                    webClient.QueryString.Add("tecnico2", newMantenimiento.Tecnico2.ToString());

                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    if (newMantenimiento.Id == 0)
                    {
                        newMantenimiento.Id = Convert.ToInt16(Encoding.ASCII.GetString(webClient.UploadValues(url, "POST", webClient.QueryString)));
                        /// agrega los incidentes al manentimiento
                        foreach (Incidente incidente in newMantenimiento.Incidentes)
                        {
                            addRelationMantenimientoIncidente(newMantenimiento.Id, incidente.Id);
                        }
                        return new MensajeAlerta("Agregado" + Environment.NewLine + newMantenimiento.Id, AlertType.success);
                    }
                    else
                    {
                        webClient.QueryString.Add("id", newMantenimiento.Id.ToString());
                        webClient.UploadValues(url, "PUT", webClient.QueryString);
                        /// Limpia los incidentes de un mantenimiento 
                        removeRelationesMantenimiento(newMantenimiento.Id);
                        ///Agrega la relacion entre los incidentes y el mantenimiento
                        foreach (Incidente incidente in newMantenimiento.Incidentes)
                        {
                            addRelationMantenimientoIncidente(newMantenimiento.Id, incidente.Id);
                        }
                        return new MensajeAlerta("Modificado" + Environment.NewLine + newMantenimiento.Id, AlertType.success);
                    }
                }
            }
            catch (Exception e)
            {
                return new MensajeAlerta("Error" + Environment.NewLine + newMantenimiento.Detalles, AlertType.error);
            }
        }

        /// <summary>
        /// Elimina las relaciones de un mantenimiento
        /// </summary>
        /// <param name="id">The identifier.</param>
        private void removeRelationesMantenimiento(int id)
        {
            String url = _partialurl + "Mantenimiento/"+id;
            using (WebClient webClient = new WebClient())
            {
                //webClient.QueryString.Add("id_mantenimiento", id.ToString());
                webClient.UploadValues(url, "DELETE", webClient.QueryString);
            }
        }

        /// <summary>
        /// Verifica si un incidente tiene un mantenimiento asignado
        /// </summary>
        /// <param name="id_incidente">The identifier.</param>
        /// <returns></returns>
        internal bool TieneMantenimientoAsignado(int id_incidente)
        {
            Incidente a;
            if (_mantenimientos == null) GetMantenimientos();
            foreach (Mantenimiento mantenimiento in _mantenimientos)
            {
            a = mantenimiento.Incidentes.Find(x => x.Id == id_incidente);
                if (a != null) return true;
            }
            return false;
        }

        /// <summary>
        /// Obtiene un mantenimiento dado un ID
        /// </summary>
        /// <param name="id_mantenimiento">The identifier mantenimiento.</param>
        /// <returns></returns>
        internal Mantenimiento GetMantenimiento(int id_mantenimiento)
        {
            if (_mantenimientos == null) GetMantenimientos();
            return _mantenimientos.Find(x => x.Id == id_mantenimiento);

        }

        /// <summary>
        /// Agrega una relacion entre un incidente y un mantenimiento
        /// </summary>
        /// <param name="id_mantenimiento">The id1.</param>
        /// <param name="id_incidente">The id2.</param>
        private void addRelationMantenimientoIncidente(int id_mantenimiento, int id_incidente)
        {
            String url = _partialurl + "Mantenimiento";
            using (WebClient webClient = new WebClient())
            {
                webClient.QueryString.Add("id_mantenimiento", id_mantenimiento.ToString());
                webClient.QueryString.Add("id_incidente", id_incidente.ToString());
                webClient.UploadValues(url, "POST", webClient.QueryString);
            }
        }

        /// <summary>
        /// Verifica si hubo cambios en la lista de mantenimientos
        /// </summary>
        /// <returns></returns>
        internal bool TieneCambios()
        {
            return !_checksumHelper.VerificarChecksum("Mantenimientos");
        }
    }
}
    
            
            
