namespace RestauranteDemoMVC.Models
{
    public class Mesa
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int Capacidad { get; set; }

        public Boolean EstaOcupada { get; set; }
    }
}
