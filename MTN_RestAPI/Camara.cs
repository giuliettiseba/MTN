using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Camara
    {

        public int Id_camara { get; set; }
        public int Id_dispositivo { get; set; }
        public int Pos { get; set; }
        public String Nombre { get; set; }
        public int Id_estado { get; set; }
        public DateTime FechaInsta { get; set; }
        public int Id_modelo { get; set; }
        public String Ip { get; set; }
        public String Mask { get; set; }
        public String Gateway { get; set; }
        public String Sn { get; set; }
        public String Observaciones { get; set; }

    }
}