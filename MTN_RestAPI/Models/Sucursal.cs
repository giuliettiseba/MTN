using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_RestAPI.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public String Numero { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int Id_localidad { get; set; }

        public String Nombreynumero  // read-only instance property
        {
            get
            {
                return Numero + " - " + Nombre;
            }
        }

    }
}
