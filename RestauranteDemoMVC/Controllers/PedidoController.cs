using Microsoft.AspNetCore.Mvc;

namespace RestauranteDemoMVC.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
