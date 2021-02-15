namespace T27_Ejercicio1.Models
{
    public class Suministra
    {

        public int CodigoPieza { get; set; }
        public string IdProveedor { get; set; }
        public int Precio { get; set; }
        public virtual Pieza Pieza { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}