using MTN_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using System.Data;

namespace MTN_RestAPI.Controllers
{
    public class TecnicosController : ApiController
    {
        // GET api/Tecnico/5s
        public IHttpActionResult GetAll()
        {
            List<Tecnico> TecnicoList = new List<Tecnico>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                TecnicoList = db.Query<Tecnico>("Select * From Tecnico").ToList();
            }
            return Ok(TecnicoList);
        }

        // GET api/Tecnico/id
        public IHttpActionResult Get(int id)
        {

            List<Tecnico> TecnicoList = new List<Tecnico>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                TecnicoList = db.Query<Tecnico>("Select * FROM Tecnico WHERE id=" + id).ToList();
            }
            if (TecnicoList.Count == 0) return BadRequest("No se encuentro un tecnico con ese ID");
            else return Ok(TecnicoList);
        }

        // POST api/Tecnico
        public IHttpActionResult Post([FromUri] Tecnico tecnico)
        {
            string sql = "INSERT INTO Tecnico (nombre,apellido,legajo,direccion,id_localidad,documento,id_tipo_documento,id_tipo_empleado) VALUES (@nombre,@apellido,@legajo,@direccion,@id_localidad,@documento,@id_tipo_documento, @id_tipo_empleado)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    tecnico.nombre,
                    tecnico.apellido,
                    tecnico.legajo,
                    tecnico.direccion,
                    tecnico.id_localidad,
                    tecnico.documento,
                    tecnico.id_tipo_documento,
                    tecnico.id_tipo_empleado,
                
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: "+ tecnico.id);

            }

        }


        // PUT api/values/id
        public IHttpActionResult Put(int id, [FromUri] Tecnico tecnico)
        {

            string sql = "UPDATE Tecnico SET nombre = @nombre,apellido = @apellido,legajo = @legajo,direccion = @direccion,id_localidad =@id_localidad,documento = @documento,id_tipo_documento = @id_tipo_documento, id_tipo_empleado = @id_tipo_empleado WHERE ID =" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    tecnico.nombre,
                    tecnico.apellido,
                    tecnico.legajo,
                    tecnico.direccion,
                    tecnico.id_localidad,
                    tecnico.documento,
                    tecnico.id_tipo_documento,
                    tecnico.id_tipo_empleado,
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se encuentro un tecnico con el ID" + tecnico.id);

            }

        }


        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM TECNICO WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                if (affectedRows == 1)
                    return Ok(affectedRows);
                    else return BadRequest("No se encuentro un tecnico con el ID" + id);

            }

        }
    }
}