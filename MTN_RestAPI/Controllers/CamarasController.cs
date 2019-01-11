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
    public class CamarasController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";

        // GET api/Camaras/
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<Camara> respuesta = db.Query<Camara>("SELECT [id],[nombre],[id_modelo],dbo.ipIntToString([ip]) as ip ,dbo.ipIntToString([mask]) as mask,dbo.ipIntToString([gateway]) as gateway,[fechaInsta],[observaciones],[id_estado],[sn] FROM Camaras", transaction: transaction).ToList();
                int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM Camaras", transaction: transaction).First();
                transaction.Commit();
                db.Close();
                Resultado<Camara> resultado = new Resultado<Camara>(checksum, respuesta);
                return Ok(resultado);
            }
        }

        // GET api/Camaras/id
        public IHttpActionResult Get(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {

                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                string sqlquery = "SELECT " +
                    "Dispositivo_tiene_camara.id_camara AS id, " +
                    "Dispositivo_tiene_camara.id_dispositivo, " +
                    "Dispositivo_tiene_camara.pos, " +
                    "camaras.[nombre], " +
                    "camaras.[id_estado], " +
                    "camaras.[fechaInsta], " +
                    "camaras.[id_modelo], " +
                    "dbo.ipIntToString(camaras.[ip]) as ip ," +
                    "dbo.ipIntToString(camaras.[mask]) as mask," +
                    "dbo.ipIntToString(camaras.[gateway]) as gateway, " +
                    "camaras.[sn], " +
                    "camaras.[observaciones] " +
                    "FROM [Dispositivo_tiene_camara] JOIN DispositivosCCTV ON Dispositivo_tiene_camara.id_dispositivo = DispositivosCCTV.id " +
                    "JOIN Camaras ON Dispositivo_tiene_camara.id_camara = Camaras.id   " +
                    "WHERE DispositivosCCTV.id = " + id;

                List<Camara> respuesta = db.Query<Camara>(sqlquery, transaction: transaction).ToList();
                int checksum =0;
                if (respuesta.Count != 0) 
                {
                    checksum = db.Query<int>("sp_getChecksumCamarasDispositivo", new { id_2 = id }, transaction: transaction, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
                transaction.Commit();
                db.Close();
                Resultado<Camara> resultado = new Resultado<Camara>(checksum, respuesta);
                return Ok(resultado);

            };
        }

        // POST api/Dispositivos
        public IHttpActionResult Post([FromUri] Camara camara)
        {
            string sql = "INSERT INTO [dbo].[Camaras]" +
                "([nombre]," +
                "[id_estado]," +
                "[FechaInsta]," +
                "[id_modelo]," +
                "[ip]," +
                "[mask]," +
                "[gateway]," +
                "[sn]," +
                "[observaciones]" +
                    ") VALUES" +
                "(@nombre," +
                "@id_estado," +
                "@FechaInsta," +
                "@id_modelo," +
                "[dbo].[ipStringToInt](@ip)," +
                "[dbo].[ipStringToInt](@mask)," +
                "[dbo].[ipStringToInt](@gateway)," +
                "@sn," +
                "@observaciones" +
                ")";

            string sql2 = "SELECT MAX(Id) AS LastID FROM Camaras";

            string sql1 = "INSERT INTO[dbo].[Dispositivo_tiene_camara]([id_dispositivo],[id_camara],[pos]) VALUES (@Id_dispositivo, @Id, @Pos)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {


                var affectedRows = db.Execute(sql, new
                {
                    camara.Nombre,
                    camara.Id_estado,
                    camara.FechaInsta,
                    camara.Id_modelo,
                    camara.Ip,
                    camara.Mask,
                    camara.Gateway,
                    camara.Observaciones,
                    camara.Sn

                });

                camara.Id = db.Query<int>(sql2).First();
                

                var affectedRows1 = db.Execute(sql1, new
                {
                    camara.Id_dispositivo,
                    camara.Id,
                    camara.Pos
                });


                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + camara.Id);
            }
        }




        // PUT api/Dispositivos/id
        public IHttpActionResult Put(int Id_camara, [FromUri] Camara camara)
        {
            string sql = "UPDATE Camaras SET" +
             "[nombre] = @nombre," +
             "[id_estado] = @id_estado," +
             "[fechaInsta] = @fechaInsta," +
             "[id_modelo] = @id_modelo," +
             "[ip] = [dbo].[ipStringToInt](@ip)," +
             "[mask] = [dbo].[ipStringToInt](@mask)," +
             "[gateway] = [dbo].[ipStringToInt](@gateway)," +
             "[sn] = @sn, " +
             "[observaciones] = @observaciones " +
             "WHERE id = " + Id_camara;

            string sql1 = "UPDATE Dispositivo_tiene_camara SET [pos] = @Pos WHERE id_dispositivo = @id_dispositivo AND id_camara = @id_camara";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {
                    camara.Nombre,
                    camara.Id_estado,
                    camara.FechaInsta,
                    camara.Id_modelo,
                    camara.Ip,
                    camara.Mask,
                    camara.Gateway,
                    camara.Observaciones,
                    camara.Sn
                });

                var affectedRows1 = db.Execute(sql1, new
                {
                    camara.Pos,
                    camara.Id_dispositivo,
                    id_camara = camara.Id
                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + camara.Id);
            }
        }

        // DELETE api/Dispositivos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM Camaras WHERE id=" + id;
            string sql1 = "DELETE FROM Dispositivo_tiene_camara WHERE id_camara=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows1 = db.Execute(sql1);
                var affectedRows = db.Execute(sql);

                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se encontro una Camara con el ID:" + id);
            }
        }



















    }
}
