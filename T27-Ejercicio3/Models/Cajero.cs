using System.Collections.Generic;

namespace T27_Ejercicio3
{
    public class Cajero
    {
        public Cajero()
        {
            Venta = new HashSet<Venta>();
        }
        public int Codigo { get; set; }
        public string NomApels { get; set; }
        public ICollection<Venta> Venta { get; set; }
    }
}