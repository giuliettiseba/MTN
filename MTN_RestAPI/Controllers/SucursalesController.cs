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
    public class SucursalesController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";


        // GET api/Sucursales/
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                return Ok(db.Query<Sucursal>("SELECT * FROM SUCURSALES").ToList());
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
                            sucursal.id_cliente,
                            sucursal.numero,
                            sucursal.nombre,
                            sucursal.direccion,
                            sucursal.id_localidad,
                            //  sucursal.image
                        });
                        if (affectedRows == 1)
                            return Ok(affectedRows);
                        else return BadRequest("No se pudo insertar el tecnico con id: " + sucursal.id);
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
                            sucursal.id_cliente,
                            sucursal.numero,
                            sucursal.nombre,
                            sucursal.direccion,
                            sucursal.id_localidad,
                            //    cliente.image
                        });
                        if (affectedRows == 1)
                            return Ok(affectedRows);
                        else return BadRequest("No se pudo insertar el tecnico con id: " + sucursal.id);
                    }
                }



        

        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM SUCURSALES WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {

                try
                {
                    db.Execute(sql);
                }
                catch (System.Exception e)
                {

                    return BadRequest(e.ToString());
                }
                return Ok(1);

            }
        }
















    }
}
