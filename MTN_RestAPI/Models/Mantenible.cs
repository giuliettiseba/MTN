using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_RestAPI.Models
{
    public interface IMantenible
    {
        int Id { get; set; }
        String Nombre { get; set; }
        TypeEstadoMantenible Id_estado { get; set; }
    }

}
