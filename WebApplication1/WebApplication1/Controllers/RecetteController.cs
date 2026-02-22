
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
            r.CreatedAt = DateTime.Now;
            r.UpdateAt = null;
            if (!ModelState.IsValid)
            {
                return View("AddRecette", r);
            }
            _recetteService.AddRecette(r);
            return RedirectToAction("GetAllRecette");
        }

        [HttpGet]
        public IActionResult AddRecette()
        {
            Recette r = new Recette();
            return View(r);
        }



        public IActionResult GetAllRecette()
        {
            return View(_recetteService.GetAllRecette());
        }

        public IActionResult DeleteRecette(int id)
        {
            _recetteService.DeleteRecette(id);
            return RedirectToAction("GetAllRecette");
        }


        [HttpGet]
        public IActionResult ModifyRecette(int id) 
        {
            Recette recette = _recetteService.GetRecetteById(id);
            if (recette == null) return NotFound();

            return View(recette);
        }

        [HttpPost]
        public IActionResult ModifyRecette(Recette r)
        {
            if (ModelState.IsValid) 
            {
                return RedirectToAction("GetAllRecette");
            }

            return View();
        }

        [HttpGet]
        public IActionResult GetDetail(int id)
        {
            Recette r = _recetteService.GetRecetteById(id);
            if (r == null) 
            {
                return NotFound();
            }
            return View(r);
        }




    }
}
