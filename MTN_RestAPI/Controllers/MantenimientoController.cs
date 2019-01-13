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
    public class MantenimientoController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";

        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();

                List<Mantenimiento> mantenimientos = db.Query<Mantenimiento>("SELECT * FROM Mantenimientos", transaction: transaction).ToList();
                int checksum = 0;

                foreach (Mantenimiento mantenimiento in mantenimientos)
                {
                    mantenimiento.Incidentes = db.Query<Incidente>("select * FROM Mantenimiento_tiene_Incidentes JOIN Incidentes ON Mantenimiento_tiene_Incidentes.id_incidente = Incidentes.id WHERE id_mantenimiento = " + mantenimiento.Id, transaction: transaction).ToList();
                }


                if (mantenimientos.Count != 0)
                {
                    checksum = db.Query<int>("select ISNULL(CHECKSUM_AGG(binary_checksum(*)),0) FROM Mantenimientos JOIN Mantenimiento_tiene_Incidentes ON Mantenimientos.id = Mantenimiento_tiene_Incidentes.id_mantenimiento JOIN Incidentes ON Mantenimiento_tiene_Incidentes.id_incidente = Incidentes.id;", transaction: transaction).First();
                }


                transaction.Commit();
                db.Close();
                Resultado<Mantenimiento> resultado = new Resultado<Mantenimiento>(checksum, mantenimientos);
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
        public IHttpActionResult Post([FromUri] Mantenimiento mantenimiento)
        {

            string sql = "INSERT INTO Mantenimientos (id_tipo_mantenimiento,Fecha,Ot,HoraInicio,HoraFin,Detalles,Estado,Id_Sucursal,Id_Cliente,Tecnico1,Tecnico2) VALUES (@id_tipo_mantenimiento,@Fecha,@Ot,@HoraInicio,@HoraFin,@Detalles,@Estado,@Id_Sucursal,@Id_Cliente,@Tecnico1,@Tecnico2)";
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();

                var affectedRows = db.Execute(sql, new
                {
                    mantenimiento.id_tipo_mantenimiento,
                    mantenimiento.Fecha,
                    mantenimiento.Ot,
                    mantenimiento.HoraInicio,
                    mantenimiento.HoraFin,
                    mantenimiento.Detalles,
                    mantenimiento.Estado,
                    mantenimiento.Id_Sucursal,
                    mantenimiento.Id_Cliente,
                    mantenimiento.Tecnico1,
                    mantenimiento.Tecnico2,
                }, transaction: transaction);
                string sql2 = "SELECT MAX(Id) AS LastID FROM Mantenimientos";
                int id = db.Query<int>(sql2, transaction: transaction).First();
                transaction.Commit();
                db.Close();
                return Ok(id);

            }

        }


        public IHttpActionResult Post([FromUri] int id_mantenimiento, int id_incidente)
        {

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                string sql2 = "INSERT INTO Mantenimiento_tiene_Incidentes (id_mantenimiento,id_incidente) VALUES (@id_mantenimiento, @id_incidente)";
                int affectedRows = db.Execute(sql2, new
                {
                    id_mantenimiento,
                    id_incidente
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el mantenimiento con id: " + id_mantenimiento);
            }
        }


        // PUT api/Sucursales/id
        public IHttpActionResult Put(int id, [FromUri] Mantenimiento mantenimiento)
        {
            string sql = "UPDATE Mantenimientos SET id_tipo_mantenimiento = @id_tipo_mantenimiento ,Fecha = @Fecha,Ot =@Ot,HoraInicio =@HoraInicio,HoraFin =@HoraFin,Detalles= @Detalles,Estado =@Estado,Id_Sucursal =@Id_Sucursal,Id_Cliente =@Id_Cliente,Tecnico1 =@Tecnico1,Tecnico2 =@Tecnico2 WHERE ID =" + id;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {

                    mantenimiento.Id,
                    mantenimiento.id_tipo_mantenimiento,
                    mantenimiento.Fecha,
                    mantenimiento.Ot,
                    mantenimiento.HoraInicio,
                    mantenimiento.HoraFin,
                    mantenimiento.Detalles,
                    mantenimiento.Estado,
                    mantenimiento.Id_Sucursal,
                    mantenimiento.Id_Cliente,
                    mantenimiento.Tecnico1,
                    mantenimiento.Tecnico2,

                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el mantenimiento con id: " + id);
            }
        }

        // DELETE api/Tecnicos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM Mantenimiento_tiene_Incidentes WHERE id_mantenimiento=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                    return Ok(affectedRows);
             
            }

        }
        

    }
}
