using System.Collections.Generic;

namespace MTN_RestAPI.Models
{
    public class Resultado<T>
    {
        public Resultado() { }

        public Resultado(int checksum, List<T> lista)
        {
            this.Checksum = checksum;
            this.Lista = lista;
        }

        public int Checksum { get; set; }
        public List<T> Lista { get; set; }

    }
}