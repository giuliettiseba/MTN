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
    /// Helper para verificar que las listas almacenadas en memoria o en disco esten actualizadas con la informacion de la base de datos
    /// </summary>
    public class ChecksumHelper
    {
        private Dictionary<String, int> _checksums;
        private readonly string _partialurl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksumHelper"/> class.
        /// </summary>
        /// <param name="partialurl">The partialurl.</param>
        public ChecksumHelper(String partialurl)
        {
            _partialurl = partialurl;
            _checksums = new Dictionary<String, int>();
        }

        /// <summary>
        /// Dada una tabla verifica que el numero verificador almacenado en memoria sea igual al actual al de la base de datos
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns>verdadero si la tabla no cambio</returns>
        public bool VerificarChecksum(string tabla)
        {
            using (WebClient client = new WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                String tablaAux = tabla;


                //prepara la consulta para verificar cambios en los grabadores de una sucursal
                if (tabla.StartsWith("dispositivosCCTV_"))
                {
                    String id_sucursal = tabla.Remove(0, 17);
                    tablaAux = tabla.Remove(16);
                    client.QueryString.Add("id_2", id_sucursal);
                }

                //prepara la consulta para verificar cambios en las camaras de un grabador
                if (tabla.StartsWith("camaras_"))
                {
                    String id_dispositivo = tabla.Remove(0, 8);
                    tablaAux = tabla.Remove(7);
                    client.QueryString.Add("id_2", id_dispositivo);
                }

                //prepara la consulra para verificar cambios en las sucursales de un cliente
                if (tabla.StartsWith("sucursales_"))
                {
                    String id_sucursal = tabla.Remove(0, 11);
                    tablaAux = tabla.Remove(10);
                    client.QueryString.Add("id_2", id_sucursal);
                }

                String url = _partialurl + "checksum/" + tablaAux;
                String content = client.DownloadString(url);
                int checksumActual = serializer.Deserialize<int>(content);
                if (!_checksums.ContainsKey(tabla)) return false;
                else
                    return (_checksums[tabla] == checksumActual) ? true : false;
            }
        }

        /// <summary>
        /// Cuando se pullean datos de una tabla para almacenar en memoria y/o disco actualiza el numero verificador
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="checksum"></param>
        public void ActualizarChecksum(string tabla, int checksum)
        {
            _checksums[tabla] = checksum;
        }
    }



}
