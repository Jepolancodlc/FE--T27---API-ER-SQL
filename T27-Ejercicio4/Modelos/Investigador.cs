using System.Collections.Generic;

namespace T27_Ejercicio4.Modelos
{
    public class Investigador
    {
        public int IdFacultad { get; set; }
        public string DNI { get; set; }
        public string NomApels { get; set; }
        public virtual Facultad Facultad { get; set; }
        public ICollection<Reserva> Reservas { get; set; }

        public Investigador()
        {
            Reservas = new HashSet<Reserva>();
        }
    }
}