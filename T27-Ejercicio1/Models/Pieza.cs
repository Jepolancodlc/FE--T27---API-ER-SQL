using System.Collections.Generic;

namespace T27_Ejercicio1.Models
{
    public class Pieza
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Suministra> Suministra { get; set; }

        public Pieza()
        {
            Suministra = new HashSet<Suministra>();
        }
    }
}