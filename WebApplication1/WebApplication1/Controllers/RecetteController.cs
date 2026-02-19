
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class RecetteController : Controller
    {

        private readonly IRecetteService _recetteService;

        public RecetteController(IRecetteService recetteService)
        {
            _recetteService = recetteService;
        }

        [HttpPost]
        public IActionResult AddRecette(Recette r)
        {
            if (!ModelState.IsValid)
            {
                return View("AddRecette", r);
            }
            return RedirectToAction("GetAllRecette");
        }

        [HttpGet]
        public IActionResult AddRecette()
        {
            Recette r = new Recette();
            return View(r);
        }

        public IActionResult GetAllRecette(Recette r)
        {
            return View(_recetteService.GetAllRecette());
        }


        /*
        public IActionResult ModifyRecette(Recette r) 
        {
            

        }*/






    }
}
