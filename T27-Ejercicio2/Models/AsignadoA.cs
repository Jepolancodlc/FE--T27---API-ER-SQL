namespace T27_Ejercicio2.Models
{
    public class AsignadoA
    {
        public string IdCientifico { get; set; }
        public string IdProyecto { get; set; }
        public virtual Cientifico Cientifico { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}