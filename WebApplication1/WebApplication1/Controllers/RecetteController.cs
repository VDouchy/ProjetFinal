
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class RecetteController : Controller
    {

        private readonly IRecetteService _recetteService;
        private readonly IIngredientService _ingredientService;

        public RecetteController(IRecetteService recetteService, IIngredientService ingredientService)
        {
            _recetteService = recetteService;
            _ingredientService = ingredientService;
        }

        [HttpPost]
        public IActionResult AddRecette(RecetteDetailDto r)
        {
            r.Recette.CreatedAt = DateTime.Now;
            r.Recette.UpdateAt = null;
            if (!ModelState.IsValid)
            {
                return View("AddRecette", r);
            }
            _recetteService.AddRecette(r.Recette);
            return RedirectToAction("GetAllRecette");
        }

        [HttpGet]
        public IActionResult AddRecette()
        {
            // Ici, je prépare le modele que m'enverra le formulaire en post
            RecetteDetailDto r = new RecetteDetailDto();
            r.Recette = new Recette();
            r.Ingredients = new List<IngredientDto>();

            // JE recupere tout les ingrédients de ma BDD pour la fournit à mon modèle
            // Je profique que celui-ci possèdes des ingrédients pour pouvoir faire une liste déroulante
            List<Ingredient> listIng = _ingredientService.GetAllIngredient();

            foreach (Ingredient ing in listIng) 
            {
                // Pour chaque ingrédient récupéré, je l'ajoute à ma liste d'ingrédient DTO
                // Pas besoin de donnée la quantité, elle sera uniquement donnée par le formulaire.
                IngredientDto ingredientDto = new IngredientDto();
                ingredientDto.Ingredient = ing;

                r.Ingredients.Add(ingredientDto);
            }

            // Je fournis mon modele quasi vide (à part la liste des ingrédients en BDD)
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
            Recette r = _recetteService.GetRecetteById(id);
            return View(r);
        }

        [HttpPost]
        public IActionResult ModifyRecette(Recette r)
        {
            if (ModelState.IsValid) 
            {
                _recetteService.ModifyRecette(r);
                return RedirectToAction("GetAllRecette");
            }

            return View("ModifyRecette", r);
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
