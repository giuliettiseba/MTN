using System.Collections.Generic;

namespace MTN_RestAPI.Models
{

    /// <summary>
    /// Entidad Marca de CCTV. Se utiliza tanto para DVRs como para Camaras
    /// </summary>
    public class MarcaCCTV
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}