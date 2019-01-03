using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_Administration.Alerts
{
   public class MensajeAlerta
    {

        public MensajeAlerta(string mensaje, AlertType type)
        {
            this.Mensaje = mensaje;
            this.Type = type;
        }

        public String Mensaje { get; set; }
        public AlertType Type { get; set; }
    }
}
