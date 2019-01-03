using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_RestAPI.Models
{
    public interface Mantenible
    {
        int Id { get; set; }
        String Nombre { get; set; }
        int Id_estado { get; set; }
    }

}
