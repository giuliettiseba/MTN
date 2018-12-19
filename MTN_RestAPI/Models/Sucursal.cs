using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_RestAPI.Models
{
    public class Sucursal
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public String numero { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public int id_localidad { get; set; }
    }
}
