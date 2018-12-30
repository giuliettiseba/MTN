using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class DispositivoCCTV : Dispositivo
    {
       
        //public Estado { get; set; }
        // public DateTime FechaInstalacion { get; set; }
        public int Id_Modelo { get; set; }
        public string EsIP { get; set; }



    }
}