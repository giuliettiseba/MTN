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
            String url = _partialurl + "Mantenimientos";
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);
                Resultado<Mantenimiento> resultado = serializer.Deserialize<Resultado<Mantenimiento>>(content);
                _mantenimientos = resultado.Lista.Cast<Mantenimiento>().ToList();
                _checksumHelper.ActualizarChecksum("Mantenimientos", resultado.Checksum);
            }
        }
    }
}
