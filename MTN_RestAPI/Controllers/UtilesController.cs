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
    public class UtilesController : ApiController
    {

        public IHttpActionResult Get(String id)
        {
            switch (id)
            {

                case "MarcasCCTV":

                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {

                        db.Open();
                        IDbTransaction transaction = db.BeginTransaction();
                        List<MarcaCCTV> marcaCCTV = db.Query<MarcaCCTV>("SELECT * FROM MarcasCCTV", transaction: transaction).ToList();
                        int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM MarcasCCTV", transaction: transaction).First();
                        transaction.Commit();
                        db.Close();
                        Resultado<MarcaCCTV> resultado = new Resultado<MarcaCCTV>(checksum, marcaCCTV);
                        return Ok(resultado);
                    }


                case "ModelosCCTV":
                    List<ModeloCCTV> modelos = new List<ModeloCCTV>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {

                        db.Open();
                        IDbTransaction transaction = db.BeginTransaction();
                        List<ModeloCCTV> respuesta = db.Query<ModeloCCTV>("Select * FROM ModelosCCTV", transaction: transaction).ToList();
                        int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM ModelosCCTV", transaction: transaction).First();
                        transaction.Commit();
                        db.Close();
                        Resultado<ModeloCCTV> resultado = new Resultado<ModeloCCTV>(checksum, respuesta);
                        return Ok(resultado);
                    }

                case "ModelosCamara":
                    List<ModeloCamara> camaras = new List<ModeloCamara>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        db.Open();
                        IDbTransaction transaction = db.BeginTransaction();
                        List<ModeloCamara> respuesta = db.Query<ModeloCamara>("Select * FROM ModelosCamara", transaction: transaction).ToList();
                        int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM ModelosCamara", transaction: transaction).First();
                        transaction.Commit();
                        db.Close();
                        Resultado<ModeloCamara> resultado = new Resultado<ModeloCamara>(checksum, respuesta);
                        return Ok(resultado);
                    }


                case "Localidades":
                    List<Localidad> localidadesTodasList = new List<Localidad>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        db.Open();
                        IDbTransaction transaction = db.BeginTransaction();
                        List<Localidad> respuesta = db.Query<Localidad>("Select * FROM Localidades", transaction: transaction).ToList();
                        int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM Localidades", transaction: transaction).First();
                        transaction.Commit();
                        db.Close();
                        Resultado<Localidad> resultado = new Resultado<Localidad>(checksum, respuesta);
                        return Ok(resultado);

                    }

                    


                case "Provincias":
                    List<Provincia> provinciaList = new List<Provincia>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        provinciaList = db.Query<Provincia>("Select * FROM Provincias").ToList();
                    }
                    return Ok(provinciaList);

         

               case "TecnologiaCamara":
                    List<TecnologiaCamara> tecnologias = new List<TecnologiaCamara>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        tecnologias = db.Query<TecnologiaCamara>("Select * FROM TecnologiaCamara").ToList();
                    }
                    return Ok(tecnologias);



                default:
                    return BadRequest("Parametros no validos. ID: " + id);
            }
        }
    }
}
