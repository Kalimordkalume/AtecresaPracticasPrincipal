using Microsoft.AspNetCore.Mvc;
using RestauranteDemoMVC.Services;

namespace RestauranteDemoMVC.Controllers
{
    public class PedidosController : Controller
    {
        private readonly CoverManagerService _coverManagerService;

        public PedidosController(CoverManagerService coverManagerService)
        {
            _coverManagerService = coverManagerService;
        }

        public async Task<IActionResult> Index(int mesaId)
        {
            var pedidos = await _coverManagerService.ObtenerPedidosPorMesaAsync("Restaurante", "Fecha", mesaId); // Cambiar a datos reales
            return View(pedidos);
        }
    }
}
