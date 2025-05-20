using Microsoft.AspNetCore.Mvc;
using RestauranteDemoMVC.Models;
using RestauranteDemoMVC.Services;

namespace RestauranteDemoMVC.Controllers
{
    public class MesaController : Controller
    {

        public MesaController()
        {
            this.Mesas = TraerMesas();
        }
        public List<Mesa> Mesas { get; set; }

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

            List<Mesa> MesasNuevas = new List<Mesa>();

            MesasNuevas.Add(mesa);
            MesasNuevas.Add(mesa2);

            return MesasNuevas;
        }

        public IActionResult Index()
        {
            return View(Mesas);
        }

        //private readonly CoverManagerService _coverManagerService;

        //public MesaController(CoverManagerService coverManagerService)
        //{
        //    _coverManagerService = coverManagerService;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var mesas = await _coverManagerService.ObtenerMesasDisponiblesAsync("restaurante", "Fecha"); // Cambiar por datos reales
        //    return View(mesas);
        //}

    }
}
