using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteDemoMVC.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservaId { get; set; }
        [ForeignKey("ReservaId")]
        public int MesaId { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

    }
}
