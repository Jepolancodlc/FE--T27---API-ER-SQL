namespace T27_Ejercicio3
{
    public class Venta
    {
        public int IdCajero { get; set; }
        public int IdMaquina { get; set; }
        public int IdProducto { get; set; }
        public virtual Cajero Cajero { get; set; }
        public virtual Maquina_Registradora Maquina { get; set; }
        public virtual Producto Producto { get; set; }
    }
}