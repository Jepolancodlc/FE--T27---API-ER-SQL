using System.Collections.Generic;

namespace T27_Ejercicio1.Models
{
    public class Proveedor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Suministra> Suministra { get; set; }

        public Proveedor()
        {
            Suministra = new HashSet<Suministra>();
        }

    }
}
