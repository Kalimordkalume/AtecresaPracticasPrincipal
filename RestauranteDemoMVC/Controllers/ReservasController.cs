using Microsoft.AspNetCore.Mvc;
using RestauranteDemoMVC.Models;
using RestauranteDemoMVC.Services;

namespace RestauranteDemoMVC.Controllers
{
    public class ReservasController : Controller
    {
        private readonly CoverManagerService _coverManagerService;

        public ReservasController(CoverManagerService coverManagerService)
        {
            _coverManagerService = coverManagerService;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                var exito = await _coverManagerService.HacerReservaAsync(reserva);
                if (exito) return RedirectToAction("Confirmacion");
                else ModelState.AddModelError("", "Error al realizar la reserva.");
            }

            return View(reserva);
        }

        public IActionResult Confirmacion()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cancelar(string idReserva)
        {
            var exito = await _coverManagerService.CancelarReservaAsync(idReserva);
            if (exito) return RedirectToAction("Cancelada");
            ModelState.AddModelError("", "No se pudo cancelar la reserva.");
            return View("Error");
        }

        public IActionResult Cancelada()
        {
            return View();
        }
    }
}

