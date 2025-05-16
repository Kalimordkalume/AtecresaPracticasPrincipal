namespace RestauranteDemoMVC.Models
{
    public class Reserva
    {
        public int MesaId { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
