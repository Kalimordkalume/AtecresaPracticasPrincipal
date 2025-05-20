using RestauranteDemoMVC.Models;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace RestauranteDemoMVC.Services
{
    public class CoverManagerService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CoverManagerService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // Metodo en la API
        // POST Get Client
        public async Task<bool> ObtenerClienteAsync(string restaurant, string idCliente, bool invoiceData = false)
        {
            var client = _httpClientFactory.CreateClient("CoverManager");
            var endpoint = "clients/get_client";

            var body = new
            {
                restaurant = restaurant,
                id_client = idCliente,
                invoice_data = invoiceData ? "1" : "0"
            };

            var content = new StringContent(
                JsonSerializer.Serialize(body),
                Encoding.UTF8,
                "application/json"
            );

            var response = await client.PostAsync(endpoint, content);
            return response.IsSuccessStatusCode;
        }

        // Metodo en la API
        // GET Get Table Availability By Restaurant
        public async Task<List<Mesa>> ObtenerMesasDisponiblesAsync(string restaurant, string date)
        {
            var client = _httpClientFactory.CreateClient("CoverManager");
            var endpoint = $"restaurant/table_availability/{restaurant}/{date}";

            var response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                var mesas = await response.Content.ReadFromJsonAsync<List<Mesa>>();
                return mesas ?? new List<Mesa>();
            }

            return new List<Mesa>();
        }

        // Metodo en la API
        // POST Reserv
        public async Task<bool> HacerReservaAsync(Reserva reserva)
        {
            var client = _httpClientFactory.CreateClient("CoverManager");
            var endpoint = "reserv/reserv";

            var content = new StringContent(
                JsonSerializer.Serialize(reserva),
                Encoding.UTF8,
                "application/json"
            );

            var response = await client.PostAsync(endpoint, content);
            return response.IsSuccessStatusCode;
        }

        // Metodo en la API
        // POST Cancel client
        public async Task<bool> CancelarReservaAsync(string idReserva)
        {
            var client = _httpClientFactory.CreateClient("CoverManager");
            var endpoint = "reserv/cancel_client";

            var body = new { id_reserv = idReserva };

            var content = new StringContent(
                JsonSerializer.Serialize(body),
                Encoding.UTF8,
                "application/json"
            );

            var response = await client.PostAsync(endpoint, content);
            return response.IsSuccessStatusCode;
        }

        // Metodo en la API
        // GET Get Orders
        public async Task<List<Pedido>> ObtenerPedidosPorMesaAsync(string restaurant, string date, int mesaId)
        {
            var client = _httpClientFactory.CreateClient("CoverManager");
            var endpoint = $"coverathome/get_orders/{restaurant}/{date}";

            var response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                Mesa mesa = new Mesa();
                var pedidos = await response.Content.ReadFromJsonAsync<List<Pedido>>();
                return pedidos?.Where(p => mesa.MesaId == mesaId).ToList() ?? new List<Pedido>();
            }

            return new List<Pedido>();
        }
    }
}
