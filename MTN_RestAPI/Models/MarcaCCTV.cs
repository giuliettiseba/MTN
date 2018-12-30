using System.Collections.Generic;

namespace MTN_RestAPI.Models
{
    public class MarcaCCTV
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Provedores> ListaProvedores { get; set; }
}
}