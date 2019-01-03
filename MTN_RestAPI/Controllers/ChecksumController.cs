using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using Dapper;
using System.Data;

namespace MTN_RestAPI.Controllers
{
    public class ChecksumController : ApiController
    {
        /// <summary>
        /// Recupera de la tabla checksums el valor de la tabla que se pasa como parametro
        /// 
        /// ej> GET /api/checksum/clientes
        /// 
        /// </summary>
        /// <param name="tabla">Tabla de la que se quiere recuperar el checksum</param>
        /// <returns>valor numerico que se utiliza para saber si la tabla cambio desde la ultima consulta.</returns>
        public IHttpActionResult Get(String id)
        {
            string sqlquery = "SELECT CHECKSUM_AGG(binary_checksum(*)) FROM " + id ;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                return Ok(db.Query<int>(sqlquery).FirstOrDefault());
            }
        }

        /// <summary>
        /// Se utiliza para obtener de solo el check sum de las camaras asociadas a los dispositivos de una sucursal
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id_sucursal"></param>
        /// <returns></returns>
        public IHttpActionResult Get(String id, [FromUri] int id_dispositivo)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                int checksum = db.Query<int>("sp_getChecksumCamarasDispositivo", new { id_dispositivo = id_dispositivo }, commandType: CommandType.StoredProcedure).First();

                return Ok(checksum);
            }
        }




    }
}
