using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public Ingredient AddIngredient(Ingredient ing)
        {
            return _ingredientRepository.AddIngredient(ing);
        }

        public void DeleteIngredient(int id)
        {
            _ingredientRepository.DeleteIngredient(id);
        }

        public List<Ingredient> GetAllIngredient()
        {
            return _ingredientRepository.GetAllIngredient();
        }

        public Ingredient GetIngredientById(int id)
        {
            return _ingredientRepository.GetIngredientById(id);
        }
    }
}
