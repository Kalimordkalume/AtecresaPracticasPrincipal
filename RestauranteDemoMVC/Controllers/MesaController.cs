using Microsoft.AspNetCore.Mvc;

namespace RestauranteDemoMVC.Controllers
{
    public class MesaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
