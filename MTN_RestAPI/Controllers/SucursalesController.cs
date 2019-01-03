using MTN_RestAPI.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace MTN_RestAPI.Controllers
{
    public class SucursalesController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";


        // GET api/Sucursales/
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<Sucursal> respuesta = db.Query<Sucursal>("SELECT * FROM SUCURSALES", transaction: transaction).ToList();
                int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM Sucursales", transaction: transaction).First();
                transaction.Commit();
                db.Close();
                Resultado<Sucursal> resultado = new Resultado<Sucursal>(checksum, respuesta);
                return Ok(resultado);
            }
        }

        // GET api/Sucursales/id
        public IHttpActionResult Get(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                return Ok(db.Query<Sucursal>("SELECT * FROM SUCURSALES WHERE id=" + id).FirstOrDefault<Sucursal>());
            }
        }



        // POST api/Sucursales
        public IHttpActionResult Post([FromUri] Sucursal sucursal)
        {
            string sql = "INSERT INTO SUCURSALES (id_cliente, numero,nombre,direccion,id_localidad) VALUES (@id_cliente,@numero,@nombre,@direccion,@id_localidad)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    sucursal.Id_cliente,
                    sucursal.Numero,
                    sucursal.Nombre,
                    sucursal.Direccion,
                    sucursal.Id_localidad,
                    //  sucursal.image
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar la sucursal con id: " + sucursal.Id);
            }
        }


        // PUT api/Sucursales/id
        public IHttpActionResult Put(int id, [FromUri] Sucursal sucursal)
        {
            string sql = "UPDATE SUCURSALES SET id_cliente = @id_cliente,numero = @numero,nombre = @nombre,direccion = @direccion,id_localidad = @id_localidad WHERE ID =" + id;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    sucursal.Id_cliente,
                    sucursal.Numero,
                    sucursal.Nombre,
                    sucursal.Direccion,
                    sucursal.Id_localidad,
                    //    cliente.image
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar la sucursal con id: " + sucursal.Id);
            }
        }

        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM SUCURSALES WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo elimanar la sucursal con id: " + id);
            }

        }
















    }
}
