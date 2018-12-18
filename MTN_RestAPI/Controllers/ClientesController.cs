using MTN_RestAPI.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using Dapper;
using System.Data;

namespace MTN_RestAPI.Controllers
{
    public class ClientesController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";

           
        // GET api/Clientes/
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                return Ok(db.Query<Cliente>("SELECT * FROM CLIENTES").ToList());
            }
        }

        // GET api/Clientes/id
        public IHttpActionResult Get(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                return Ok(db.Query<Cliente>("SELECT * FROM CLIENTES WHERE id=" + id).FirstOrDefault<Cliente>());
            }
        }


        // POST api/Tecnico
        public IHttpActionResult Post([FromUri] Cliente cliente)
        {
            string sql = "INSERT INTO CLIENTES (razonSocial,CUIT,direccion,id_localidad) VALUES (@razonSocial,@CUIT,@direccion,@id_localidad)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    cliente.RazonSocial,
                    cliente.CUIT,
                    cliente.direccion,
                    cliente.id_localidad,
                  //  cliente.image
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + cliente.id);
            }
        }


        // PUT api/values/id
        public IHttpActionResult Put(int id, [FromUri] Cliente cliente)
        {
            string sql = "UPDATE CLIENTES SET razonSocial = @razonSocial,CUIT = @CUIT,direccion = @direccion,id_localidad = @id_localidad WHERE ID =" + id;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    cliente.RazonSocial,
                    cliente.CUIT,
                    cliente.direccion,
                    cliente.id_localidad,
                //    cliente.image
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + cliente.id);
            }
        }

        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM CLIENTES WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se encuentro un cliente con el ID" + id);
            }
        }



















    }
}
