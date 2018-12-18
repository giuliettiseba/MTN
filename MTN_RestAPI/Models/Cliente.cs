using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_RestAPI.Models
{

    public class Cliente
    {
        public int id { get; set; }
        public String RazonSocial { get; set; }
        public String CUIT { get; set; }
        public String direccion { get; set; }
        public int id_localidad { get; set; }
      //  public byte[] image { get; set; }

    }
}
