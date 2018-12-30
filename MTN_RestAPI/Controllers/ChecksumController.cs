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
            string sqlquery = "SELECT checksums FROM checksums WHERE table_name ='" + id + "'";
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                return Ok(db.Query<int>(sqlquery).FirstOrDefault());
            }
        }
    }
}
