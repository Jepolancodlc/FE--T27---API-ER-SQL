using System.Collections.Generic;

namespace T27_Ejercicio2.Models
{
    public class Proyecto
    {
        public Proyecto()
        {
            AsignadoA = new HashSet<AsignadoA>();
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public ICollection<AsignadoA> AsignadoA { get; set; }
    }
}