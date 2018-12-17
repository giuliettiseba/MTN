using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Localidad
    {
        public int id { get; set; }
        public int id_provincia { get; set; }
        public String nombre { get; set; }
        public int codigoPostal { get; set; }

    }
}