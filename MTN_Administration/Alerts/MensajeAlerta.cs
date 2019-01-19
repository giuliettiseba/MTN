using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_Administration.Alerts
{

    /// <summary>
    /// Mensaje de alerta. Conjunto de atributos de una notificacion
    /// </summary>
   public class MensajeAlerta
    {
        /// <summary>
        /// Constructor de mensaje de alerta
        /// </summary>
        /// <param name="mensaje">Mensaje</param>
        /// <param name="type">Tipo</param>
        public MensajeAlerta(string mensaje, AlertType type)
        {
            this.Mensaje = mensaje;
            this.Type = type;
        }

        public String Mensaje { get; set; }
        public AlertType Type { get; set; }
    }
}
