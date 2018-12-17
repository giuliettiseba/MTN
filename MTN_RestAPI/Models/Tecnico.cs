using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Tecnico
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int legajo { get; set; }
        public String direccion { get; set; }
        public int id_localidad { get; set; }
        public int documento { get; set; }
        public int id_tipo_documento { get; set; }
        public int id_tipo_empleado{ get; set; }
        public string foto { get; set; }
    }
}