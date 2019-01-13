using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public enum TypeEstadoIncidente
    {
         Abierto = 1,
        Progreso = 2,
        Resuelto = 3,
        Cancelado = 4,
            Reabierto = 5
    }
}