using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MTN_Administration.APIHelpers
{
    public class ChecksumHelper
    {
        Dictionary<String, int> _checksums;
        private string _partialurl;
       
        public ChecksumHelper(String partialurl)
        {
            _partialurl = partialurl;
            _checksums = new Dictionary<String, int>();
        }


        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns>verdadero si la tabla no cambio</returns>
        public bool VerificarChecksum(string tabla)
        {
            using (WebClient client = new WebClient())
            {
                String url = _partialurl + "checksum/" + tabla;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String content = client.DownloadString(url);

                return (_checksums[tabla] == serializer.Deserialize<int>(content)) ? true: false;

            }
        }


        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="checksum"></param>
        public void ActualizarChecksum(string tabla, int checksum)
        {
            _checksums[tabla] = checksum;
        }
    }



}
