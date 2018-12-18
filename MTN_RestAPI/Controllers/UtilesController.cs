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

                default:
                    return BadRequest("Parametros no validos. ID: " + id);
            }
        }
    }
}
