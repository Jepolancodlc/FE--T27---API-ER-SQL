using System.Collections.Generic;

namespace T27_Ejercicio3
{
    public class Maquina_Registradora
    {
            public Maquina_Registradora()
            {
                Venta = new HashSet<Venta>();
            }
            public int Codigo { get; set; }
            public int Piso { get; set; }
            public ICollection<Venta> Venta { get; set; }
        
    }
}