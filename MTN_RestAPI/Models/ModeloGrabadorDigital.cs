using System.Net;

namespace MTN_RestAPI.Models
{
    public class ModeloGrabadorDigital
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadEntradas { get; set; }
        public string Descripcion { get; set; }
        public MarcaCCTV MarcaCCTV { get; set; }

    }
}