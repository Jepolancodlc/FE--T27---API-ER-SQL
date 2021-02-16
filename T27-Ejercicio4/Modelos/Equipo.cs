using System.Collections.Generic;

namespace T27_Ejercicio4.Modelos
{
    public class Equipo
    {
        public int IdFacultad { get; set; }
        public string NumSerie { get; set; }
        public string Nombre { get; set; }
        public virtual Facultad Facultad { get; set; }
        public ICollection<Reserva> Reservas
        {
            get; set;
        }

        public Equipo()
        {
            Reservas = new HashSet<Reserva>();
        }
    }
    }