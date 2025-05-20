using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteDemoMVC.Models
{
    
    public class Pedido
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

        //public int IdMesa { get; set; }

        //public string Comanda { get; set; } = string.Empty;


        public string IdOrderPublic { get; set; } = string.Empty;
        public string? IdOrderChannel { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Ref { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Provenance { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<string> Productos { get; set; } = new();
    }
}
