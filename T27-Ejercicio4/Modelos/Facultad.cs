using System.Collections.Generic;

namespace T27_Ejercicio4.Modelos
{
    public class Facultad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Investigador> Investigadores { get; set; }
        public ICollection<Equipo> Equipos { get; set; }

        public Facultad()
        {
            Investigadores = new HashSet<Investigador>();
            Equipos = new HashSet<Equipo>();
        }
    }
}
