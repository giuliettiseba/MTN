using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace MTN_RestAPI.Models
{
    public abstract class Dispositivo : Mantenible
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Id_sucursal { get; set; }
        public DateTime Fecha_insta { get; set; }
        public String Observaciones { get; set; }
        public String Sn { get; set; }
        public String Ip { get; set; }
        public String Mask { get; set; }
        public String Gateway { get; set; }
        public int Id_estado { get; set; }
        

    }

}