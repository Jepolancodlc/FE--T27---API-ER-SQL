using System.Collections.Generic;

namespace T27_Ejercicio2.Models
{
    public class Cientifico
    {
        public Cientifico()
        {
            AsignadoA= new HashSet<AsignadoA>();
        }
        public string DNI { get; set; }
        public string NomApels { get; set; }
        public ICollection<AsignadoA> AsignadoA { get; set; }
    }
}

