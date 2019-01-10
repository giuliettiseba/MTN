using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Tecnico
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Legajo { get; set; }
        public String Direccion { get; set; }
        public int Id_localidad { get; set; }
        public int Documento { get; set; }
        public int Id_tipo_documento { get; set; }
        public int Id_tipo_empleado{ get; set; }
        //public string Foto { get; set; }


        public String ApellidoYNombre { get => Apellido + ", " + Nombre; }


    }
}