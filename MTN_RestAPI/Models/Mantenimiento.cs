using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Sucursal { get; set; }
        public int Tecnico1 { get; set; }
        public int Tecnico2 { get; set; }
        public TypeEstadoMantenimiento Estado { get; set; }
        public TypeTipoMantenimiento id_tipo_mantenimiento { get; set; }
        public DateTime Fecha { get; set; }
        public String Ot { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public String Detalles { get; set; }
        public List<Incidente> Incidentes{ get; set; }

    }
}