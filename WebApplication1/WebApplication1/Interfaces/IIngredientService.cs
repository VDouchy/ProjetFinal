using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IIngredientService
    {
        public List<Ingredient> GetAllIngredient();

        public Ingredient AddIngredient(Ingredient ing);

        public void DeleteIngredient(Ingredient i);
        public Ingredient GetRecetteById(int id);
    }
}
