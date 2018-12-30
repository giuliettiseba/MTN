using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_RestAPI.Models
{

    public class Cliente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String CUIT { get; set; }
        public String Direccion { get; set; }
        public int Id_localidad { get; set; }
      //  public byte[] image { get; set; }

    }
}
