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
    public class MantenimientoHelper
    {

        private string _partialurl;
        private ChecksumHelper _checksumHelper;
        private List<Mantenimiento> _mantenimientos;


        public MantenimientoHelper(string partialurl, ChecksumHelper checksumHelper)
        {
            _partialurl = partialurl;
            this._checksumHelper = checksumHelper;
        }


        public List<Mantenimiento> GetMantenimientos()
        {
            if ((_mantenimientos == null) || !(_checksumHelper.VerificarChecksum("Mantenimientos")))
            {
                _mantenimientos = new List<Mantenimiento>();
                CacheMantenimientos();
            }
            return _mantenimientos;
        }

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
                        removeRelationesMantenimiento(newMantenimiento.Id);
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

        private void removeRelationesMantenimiento(int id)
        {
            String url = _partialurl + "Mantenimiento/"+id;
            using (WebClient webClient = new WebClient())
            {
                //webClient.QueryString.Add("id_mantenimiento", id.ToString());
                webClient.UploadValues(url, "DELETE", webClient.QueryString);
            }
        }
        
        internal bool TieneMantenimientoAsignado(int id)
        {
            Incidente a;
            if (_mantenimientos == null) GetMantenimientos();
            foreach (Mantenimiento mantenimiento in _mantenimientos)
            {
            a = mantenimiento.Incidentes.Find(x => x.Id == id);
                if (a != null) return true;
            }

            return false;


        }

        internal Mantenimiento GetMantenimiento(int id_mantenimiento)
        {
            if (_mantenimientos == null) GetMantenimientos();
            return _mantenimientos.Find(x => x.Id == id_mantenimiento);

        }

        private void addRelationMantenimientoIncidente(int id1, int id2)
        {
            String url = _partialurl + "Mantenimiento";
            using (WebClient webClient = new WebClient())
            {
                webClient.QueryString.Add("id_mantenimiento", id1.ToString());
                webClient.QueryString.Add("id_incidente", id2.ToString());

                webClient.UploadValues(url, "POST", webClient.QueryString);
            }
        }

        internal bool TieneCambios()
        {
            return !_checksumHelper.VerificarChecksum("Mantenimientos");
        }
    }
}
    
            
            
