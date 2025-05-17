using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteDemoMVC.Models
{
    public class Mesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MesaId { get; set; }

        public int Capacidad { get; set; }

        public Boolean Ocupada { get; set; }
    }
}
