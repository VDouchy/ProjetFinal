using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AccueilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
