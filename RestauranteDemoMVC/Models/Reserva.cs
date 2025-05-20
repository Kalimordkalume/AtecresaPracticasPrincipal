using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteDemoMVC.Models
{
    public class Reserva
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ReservaId { get; set; }
        //[ForeignKey("ReservaId")]
        //public int MesaId { get; set; }
        //public DateTime Fecha { get; set; }
        //public string NombreCliente { get; set; } = string.Empty;
        //public string Telefono { get; set; } = string.Empty;


        public string restaurant { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty; // formato "YYYY-MM-DD"
        public string hour { get; set; } = string.Empty; // formato "HH:mm"
        public string people { get; set; } = string.Empty;

        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;

        public string int_call_code { get; set; } = "34";
        public string phone { get; set; } = string.Empty;

        public string tags_client { get; set; } = string.Empty;
        public string source { get; set; } = string.Empty;
        public string commentary { get; set; } = string.Empty;

        public string pending { get; set; } = "0";
        public string discount { get; set; } = "0";
        public string not_notify { get; set; } = "0";
        public string? @ref { get; set; } = null;

    }
}
