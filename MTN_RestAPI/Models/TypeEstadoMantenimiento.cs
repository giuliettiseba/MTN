using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Models
{
    public enum TypeEstadoMantenimiento
    {
        Abierto = 1,
        Asignado = 2,
        Progreso = 3,
        Cerrado = 4,
        Demorado = 5,
        Cancelado = 6

    }
}