using System;

namespace T27_Ejercicio4.Modelos
{
    public class Reserva
    {
        public string IdInvestigador { get; set; }
        public string IdEquipo { get; set; }
        public DateTime Comienzo { get; set; }
        public DateTime Fin { get; set; }
        public virtual Investigador Investigador { get; set; }
        public virtual Equipo Equipo { get; set; }
    }
}