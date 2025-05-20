using Microsoft.AspNetCore.Mvc;
using RestauranteDemoMVC.Models;
using RestauranteDemoMVC.Services;

namespace RestauranteDemoMVC.Controllers
{
    public class MesaController : Controller
    {
        private readonly CoverManagerService _coverManagerService;

        public MesaController(CoverManagerService coverManagerService)
        {
            _coverManagerService = coverManagerService;
        }

        public async Task<IActionResult> Index()
        {
            var mesas = await _coverManagerService.ObtenerMesasDisponiblesAsync("restaurante", "Fecha"); // Cambiar por datos reales
            return View(mesas);
        }

    }
}
