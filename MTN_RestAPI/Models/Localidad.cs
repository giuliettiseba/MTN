using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Localidad
    {
        public int Id { get; set; }
        public int Id_provincia { get; set; }
        public String Nombre { get; set; }
        public int CodigoPostal { get; set; }

    }
}