using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class IngredientController : Controller
    {


        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }




        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddIngredient(Ingredient ing)
        {
            ing.CreatedAt = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return View("AddIngredient", ing);
            }
            _ingredientService.AddIngredient(ing);
            

            return RedirectToAction("GetAllIngredient");
        }

        [HttpGet]
        public IActionResult AddIngredient()
        {
            Ingredient ingredient = new Ingredient();


            return View(ingredient);
        }

        [HttpGet]
        public IActionResult DeleteIngredient(int id)
        {
            if(id <= 0)
            {
                return NotFound();
            }
            _ingredientService.DeleteIngredient(id);
            return RedirectToAction("GetAllIngredient");
        }

        [HttpGet]
        public IActionResult GetAllIngredient()
        {
            return View(_ingredientService.GetAllIngredient());

        }


        














    }
}
