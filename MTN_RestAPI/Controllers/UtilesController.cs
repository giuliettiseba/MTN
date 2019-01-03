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

                case "MarcaCCTV":

                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {

                        db.Open();
                        IDbTransaction transaction = db.BeginTransaction();
                        List<MarcaCCTV> marcaCCTV = db.Query<MarcaCCTV>("SELECT * FROM MarcaCCTV", transaction: transaction).ToList();
                        int checksum = db.Query<int>("SELECT CHECKSUM_AGG(binary_checksum(*)) FROM MarcaCCTV", transaction: transaction).First();
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





                //// MEJORAR 

                case "Localidades":
                    List<Localidad> localidadesTodasList = new List<Localidad>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        localidadesTodasList = db.Query<Localidad>("Select * FROM Localidades").ToList();
                    }
                    return Ok(localidadesTodasList);

                case "Provincias":
                    List<Provincia> provinciaList = new List<Provincia>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        provinciaList = db.Query<Provincia>("Select * FROM Provincias").ToList();
                    }
                    return Ok(provinciaList);

                case "TipoEmpleado":
                    List<Tipo_Empleado> tipoEmpleadoList = new List<Tipo_Empleado>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        tipoEmpleadoList = db.Query<Tipo_Empleado>("Select * FROM Tipo_Empleado").ToList();
                    }
                    return Ok(tipoEmpleadoList);

                case "TipoDocumento":
                    List<Tipo_Documento> tipo_Documentos = new List<Tipo_Documento>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString)) 
                    {
                        tipo_Documentos = db.Query<Tipo_Documento>("Select * FROM Tipo_Documento").ToList();
                    }
                    return Ok(tipo_Documentos);

                case "Estados":
                    List<Estado> estados = new List<Estado>();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MTNdb"].ConnectionString))
                    {
                        estados = db.Query<Estado>("Select * FROM Estados").ToList();
                    }
                    return Ok(estados);





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
