using System.Collections.Generic;

namespace T27_Ejercicio3
{
    public class Producto
    {
        public Producto()
        {
            Venta = new HashSet<Venta>();
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public ICollection<Venta> Venta { get; set; }
    }
}