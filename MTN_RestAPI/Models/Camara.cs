using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{

    /// <summary>
    /// Entidad Camara. Representa una camara. que tiene una posicion en un dispositivo y un modelo
    /// </summary>
    /// <seealso cref="MTN_RestAPI.Models.Dispositivo" />
    public class Camara : Dispositivo
    {
        public int Id_dispositivo { get; set; }
        public int Pos { get; set; }
        public int Id_modelo { get; set; }
    }
}