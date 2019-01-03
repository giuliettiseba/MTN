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
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String tablaAux = tabla;

                if (tabla.StartsWith("dispositivosCCTV_"))
                {
                    String id_sucursal = tabla.Remove(0, 17);
                    tablaAux = tabla.Remove(16);
                    client.QueryString.Add("id_2", id_sucursal);
                }

                if (tabla.StartsWith("camaras_"))
                {
                    String id_dispositivo = tabla.Remove(0, 8);
                    tablaAux = tabla.Remove(7);
                    client.QueryString.Add("id_2", id_dispositivo);
                }

                if (tabla.StartsWith("sucursales_"))
                {
                    String id_dispositivo = tabla.Remove(0, 11);
                    tablaAux = tabla.Remove(10);
                    client.QueryString.Add("id_2", id_dispositivo);
                }


                String url = _partialurl + "checksum/" + tablaAux ;
                String content = client.DownloadString(url);
                int checksumActual = serializer.Deserialize<int>(content);
                return (_checksums[tabla] == checksumActual) ? true: false;
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
