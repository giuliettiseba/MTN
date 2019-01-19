using System;

namespace MTN_Administration.APIHelpers
{
    /// <summary>
    /// Logger de eventos. Funcion no implementada en su totalidad. 
    /// Falta implementar controlador para almacenar eventos en la base de datos 
    /// </summary>
    public class Logger
    {
        internal static void AgregarEntrada(string v, Severity severity)
        {
            switch (severity)
            {
                case Severity.error:
                    Console.WriteLine("ERROR: " + v);
                    break;
                case Severity.warning:
                    Console.WriteLine("WARNING: " + v);
                    break;
                case Severity.informative:
                    Console.WriteLine("Informative: " + v);
                    break;
                default:
                    break;
            }
        }

        public enum Severity {
            error, warning, informative
        }
    }
}