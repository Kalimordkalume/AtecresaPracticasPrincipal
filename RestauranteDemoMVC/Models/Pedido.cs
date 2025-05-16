using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteDemoMVC.Models
{
    
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdMesa { get; set; }

        public string Comanda { get; set; } = string.Empty;
    }
}
