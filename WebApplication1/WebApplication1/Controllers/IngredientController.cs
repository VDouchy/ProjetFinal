using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
