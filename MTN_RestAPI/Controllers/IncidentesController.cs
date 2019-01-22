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

    /// <summary>
    /// Controlador de Incidentes
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class IncidentesController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";

        /// <summary>
        /// Obtiene una lista de los incidentes de la base de datos
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<Incidente> respuesta = db.Query<Incidente>("SELECT * FROM Incidentes", transaction: transaction).ToList();
                int checksum = 0;
                if (respuesta.Count != 0)
                {
                    checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM Incidentes", transaction: transaction).First();
                }
                transaction.Commit();
                db.Close();
                Resultado<Incidente> resultado = new Resultado<Incidente>(checksum, respuesta);
                return Ok(resultado);
            }
        }



        /// <summary>
        /// ID Estado 1 - Abierto
        /// ID Estado 2 - Proceso
        /// ID Estado 3 - Cerrado
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {

                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<Incidente> respuesta = db.Query<Incidente>("SELECT * FROM Incidentes WHERE id = " + id, transaction: transaction).ToList();
                int checksum = 0;
                if (respuesta.Count != 0)
                {
                    checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM Incidentes WHERE id_estado = " + id, transaction: transaction).FirstOrDefault();
                }
                transaction.Commit();
                db.Close();
                Resultado<Incidente> resultado = new Resultado<Incidente>(checksum, respuesta);
                return Ok(resultado);
            }
        }

        // POST api/Sucursales
        public IHttpActionResult Post([FromUri] Incidente incidente)
        {
            string sql = "INSERT INTO IncidenteS (id_cliente, id_suc,id_tipo_mantenible,id_1,id_2,falla,id_criticidad,Id_estado_incidente) VALUES (@id_cliente, @Id_suc,@Id_tipo_mantenible,@Id_1,@Id_2,@Falla,@Id_criticidad,@Id_estado_incidente)";
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    incidente.Id_cliente,
                    incidente.Id_suc,
                    incidente.Id_tipo_mantenible,
                    incidente.Id_1,
                    incidente.Id_2,
                    incidente.Falla,
                    incidente.Id_criticidad,
                    incidente.Id_estado_incidente,
                    
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el incidente con id: " + incidente.Id);
            }
        }

        // PUT api/Sucursales/id
        public IHttpActionResult Put(int id, [FromUri] Incidente incidente)
        {
            string sql = "UPDATE IncidenteS SET id_cliente = @id_cliente,id_suc = @id_suc,id_tipo_mantenible = @id_tipo_mantenible,id_1 = @id_1,id_2 =@id_2,falla = @falla,id_criticidad =@id_criticidad,Id_estado_incidente = @Id_estado_incidente WHERE ID =" + id;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    incidente.Id,
                    incidente.Id_cliente,
                    incidente.Id_suc,
                    incidente.Id_tipo_mantenible,
                    incidente.Id_1,
                    incidente.Id_2,
                    incidente.Falla,
                    incidente.Id_criticidad,
                    incidente.Id_estado_incidente,


                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el incidente con id: " + id);
            }
        }

        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM Incidente WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo eliminar el incidente con id: " + id);
            }
        }
    }
}
