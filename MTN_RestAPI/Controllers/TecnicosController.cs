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
    public class TecnicosController : ApiController
    {

        static readonly string connectionStringSettings = "MTNdb";



        // GET api/Tecnicos/
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<Tecnico> respuesta = db.Query<Tecnico>("SELECT * FROM Tecnicos", transaction: transaction).ToList();
                int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM tecnicos", transaction: transaction).First();
                transaction.Commit();
                db.Close();
                Resultado<Tecnico> resultado = new Resultado<Tecnico>(checksum, respuesta);
                return Ok(resultado);
            }

        }

        // GET api/Tecnico/id
        public IHttpActionResult Get(int id)
        {
            List<Tecnico> TecnicoList = new List<Tecnico>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                return Ok(db.Query<Tecnico>("Select * FROM Tecnicos WHERE id=" + id).ToList());
            }
        }

        // POST api/Tecnico
        public IHttpActionResult Post([FromUri] Tecnico tecnico)
        {
            string sql = "INSERT INTO Tecnicos (nombre,apellido,legajo,direccion,id_localidad,documento,id_tipo_documento,id_tipo_empleado) VALUES (@nombre,@apellido,@legajo,@direccion,@id_localidad,@documento,@id_tipo_documento, @id_tipo_empleado)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    tecnico.Nombre,
                    tecnico.Apellido,
                    tecnico.Legajo,
                    tecnico.Direccion,
                    tecnico.Id_localidad,
                    tecnico.Documento,
                    tecnico.Id_tipo_documento,
                    tecnico.Id_tipo_empleado,
                
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: "+ tecnico.Id);
            }
        }


        // PUT api/values/id
        public IHttpActionResult Put(int id, [FromUri] Tecnico tecnico)
        {
            string sql = "UPDATE Tecnicos SET nombre = @nombre,apellido = @apellido,legajo = @legajo,direccion = @direccion,id_localidad =@id_localidad,documento = @documento,id_tipo_documento = @id_tipo_documento, id_tipo_empleado = @id_tipo_empleado WHERE ID =" + id;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    tecnico.Nombre,
                    tecnico.Apellido,
                    tecnico.Legajo,
                    tecnico.Direccion,
                    tecnico.Id_localidad,
                    tecnico.Documento,
                    tecnico.Id_tipo_documento,
                    tecnico.Id_tipo_empleado,
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se encuentro un tecnico con el ID" + tecnico.Id);
            }
        }

        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM TECNICOS WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                if (affectedRows == 1)
                    return Ok(affectedRows);
                    else return BadRequest("No se encuentro un tecnico con el ID" + id);
            }
        }
    }
}