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


        /// <summary>
        /// Obtiene todos los los clientes 
        /// GET api/Clientes/
        /// </summary>
        /// <returns>Resultado con un campo checksum y otro la lista de clientes </returns>
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<Cliente> clientes = db.Query<Cliente>("SELECT * FROM CLIENTES", transaction: transaction).ToList(); // Consulto la lista 
                int checksum = db.Query<int>("SELECT checksums FROM checksums WHERE table_name = 'clientes'", transaction: transaction).First(); // consulto el checksum
                transaction.Commit();
                db.Close();

                Resultado<Cliente> resultado = new Resultado<Cliente>(checksum , clientes); // armo la respuesta

                return Ok(resultado);
            }
        }

        // GET api/Clientes/id
        /// <summary>
        /// Obtiene el cliente con el ID pasado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
            string sql = "INSERT INTO CLIENTES (nombre,CUIT,direccion,id_localidad) VALUES (@nombre,@CUIT,@direccion,@id_localidad)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    cliente.Nombre,
                    cliente.CUIT,
                    cliente.Direccion,
                    cliente.Id_localidad,
                  //  cliente.image
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + cliente.Id);
            }
        }


        // PUT api/values/id
        public IHttpActionResult Put(int id, [FromUri] Cliente cliente)
        {
            string sql = "UPDATE CLIENTES SET nombre = @nombre,CUIT = @CUIT,direccion = @direccion,id_localidad = @id_localidad WHERE ID =" + id;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    cliente.Nombre,
                    cliente.CUIT,
                    cliente.Direccion,
                    cliente.Id_localidad,
                //    cliente.image
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + cliente.Id);
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
