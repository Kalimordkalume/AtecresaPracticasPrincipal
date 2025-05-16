namespace RestauranteDemoMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public int IdMesa { get; set; }

        public string Comanda { get; set; } = string.Empty;
    }
}
