using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Incidente
    {
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public int Id_suc { get; set; }
        public int Id_tipo_mantenible { get; set; }
        public int Id_1 { get; set; }
        public int Id_2 { get; set; }
        public int Id_criticidad { get; set; }
        public string Falla { get; set; }
        public int Id_estado_incidente { get; set; }
      //  public bool Asignado { get; set; }
    }
}