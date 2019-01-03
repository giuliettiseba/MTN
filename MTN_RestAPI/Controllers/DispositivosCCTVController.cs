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
    public class DispositivosCCTVController : ApiController
    {
        static readonly string connectionStringSettings = "MTNdb";


        // GET api/Dispositivos/
        public IHttpActionResult GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<DispositivoCCTV> respuesta = db.Query<DispositivoCCTV>("SELECT [id],[nombre],[id_sucursal],[id_modelo],dbo.ipIntToString([ip]) as ip ,dbo.ipIntToString([mask]) as mask,dbo.ipIntToString([gateway]) as gateway,[fecha_insta],[observaciones],[id_estado],[sn] FROM DISPOSITIVOSCCTV", transaction: transaction).ToList();
                int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM dispositivosCCTV", transaction: transaction).First();
                transaction.Commit();
                db.Close();
                Resultado<DispositivoCCTV> resultado = new Resultado<DispositivoCCTV>(checksum, respuesta);
                return Ok(resultado);

            }




        }

        // GET api/Dispositivos/id
        public IHttpActionResult Get(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                db.Open();
                IDbTransaction transaction = db.BeginTransaction();
                List<DispositivoCCTV> respuesta = db.Query<DispositivoCCTV>("SELECT * FROM DISPOSITIVOSCCTV WHERE id_sucursal = " + id , transaction: transaction).ToList();
                int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM dispositivosCCTV WHERE id_sucursal = " + id , transaction: transaction).First();
                transaction.Commit();
                db.Close();
                Resultado<DispositivoCCTV> resultado = new Resultado<DispositivoCCTV>(checksum, respuesta);
                return Ok(resultado);
            }
        }


  
        // POST api/Dispositivos
        public IHttpActionResult Post([FromUri] DispositivoCCTV dispositivoCCTV)
        {
            string sql = "INSERT INTO [dbo].[DispositivosCCTV]" +
                "([nombre]," +
                "[id_sucursal]," +
                "[id_modelo]," +
                "[ip]," +
                "[mask]," +
                "[gateway]," +
                "[fecha_insta]," +
                "[observaciones]," +
                "[id_estado]," +
                "[sn]" +
                    ") VALUES" +
                "(@nombre," +
                "@id_sucursal," +
                "@id_modelo," +
                "[dbo].[ipStringToInt](@ip)," +
                "[dbo].[ipStringToInt](@mask)," +
                "[dbo].[ipStringToInt](@gateway)," +
                "@fecha_insta," +
                "@observaciones," +
                "@id_estado," +
                "@sn)";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {


                var affectedRows = db.Execute(sql, new
                {
                    dispositivoCCTV.Nombre,
                    dispositivoCCTV.Id_sucursal,
                    dispositivoCCTV.Id_Modelo,
                    dispositivoCCTV.Ip,
                    dispositivoCCTV.Mask,
                    dispositivoCCTV.Gateway,
                    dispositivoCCTV.Fecha_insta,
                    dispositivoCCTV.Observaciones,
                    dispositivoCCTV.Id_estado,
                    dispositivoCCTV.Sn

                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + dispositivoCCTV.Nombre);
            }
        }


        // PUT api/Dispositivos/id
        public IHttpActionResult Put(int id, [FromUri] DispositivoCCTV dispositivoCCTV)
        {
            string sql = "UPDATE DispositivosCCTV SET" +
             "[nombre] = @nombre," +
             "[id_sucursal] = @id_sucursal," +
             "[id_modelo] = @id_modelo," +
             "[ip] = [dbo].[ipStringToInt](@ip)," +
             "[mask] = [dbo].[ipStringToInt](@mask)," +
             "[gateway] = [dbo].[ipStringToInt](@gateway)," +
             "[fecha_insta] = @fecha_insta," +
             "[observaciones] = @observaciones," +
             "[id_estado] = @id_estado," +
             "[sn] = @sn WHERE id = " + id
             ;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql, new
                {

                    dispositivoCCTV.Nombre,
                    dispositivoCCTV.Id_sucursal,
                    dispositivoCCTV.Id_Modelo,
                    dispositivoCCTV.Ip,
                    dispositivoCCTV.Mask,
                    dispositivoCCTV.Gateway,
                    dispositivoCCTV.Fecha_insta,
                    dispositivoCCTV.Observaciones,
                    dispositivoCCTV.Id_estado,
                    dispositivoCCTV.Sn

                });
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se pudo insertar el tecnico con id: " + dispositivoCCTV.Id);
            }
        }

        // DELETE api/Dispositivos/id
        public IHttpActionResult Delete(int id)
        {
            string sql = "DELETE FROM DispositivosCCTV WHERE id=" + id;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringSettings].ConnectionString))
            {
                var affectedRows = db.Execute(sql);
                if (affectedRows == 1)
                    return Ok(affectedRows);
                else return BadRequest("No se encontro un DispositivosCCTV con el ID:" + id);
            }
        }



















    }
}
