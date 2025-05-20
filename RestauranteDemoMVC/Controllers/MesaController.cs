using Microsoft.AspNetCore.Mvc;
using RestauranteDemoMVC.Models;
using RestauranteDemoMVC.Services;

namespace RestauranteDemoMVC.Controllers
{
    public class MesaController : Controller
    {
<<<<<<< HEAD
        private readonly CoverManagerService _coverManagerService;

        public MesaController(CoverManagerService coverManagerService)
        {
            _coverManagerService = coverManagerService;
        }

        public async Task<IActionResult> Index2()
        {
            var mesas = await _coverManagerService.ObtenerMesasDisponiblesAsync("restaurante", "Fecha"); // Cambiar por datos reales
            return View(mesas);
        }
=======
>>>>>>> 7aa6a4b4e78c3a7189baca00e7c58b597070adeb

        public MesaController()
        {
            this.Mesas = TraerMesas();
        }
<<<<<<< HEAD
        public List<Mesa> Mesas { get; set; }
=======
        public List<Mesa> Mesas {get; set; }
>>>>>>> 7aa6a4b4e78c3a7189baca00e7c58b597070adeb

        public List<Mesa> TraerMesas()
        {
            Mesa mesa = new Mesa();
            mesa.MesaId = 1;
            mesa.Capacidad = 4;
            mesa.Ocupada = false;

            Mesa mesa2 = new Mesa();

            mesa2.MesaId = 2;
            mesa2.Capacidad = 5;
            mesa2.Ocupada = false;

<<<<<<< HEAD
            List<Mesa> MesasNuevas = new List<Mesa>();
=======
            List<Mesa>MesasNuevas = new List<Mesa>();
>>>>>>> 7aa6a4b4e78c3a7189baca00e7c58b597070adeb

            MesasNuevas.Add(mesa);
            MesasNuevas.Add(mesa2);

            return MesasNuevas;
        }

        public IActionResult Index()
        {
            return View(Mesas);
        }

    }
}
