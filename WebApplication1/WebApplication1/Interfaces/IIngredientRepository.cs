using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IIngredientRepository
    {
        public List<Ingredient> GetAllIngredient();

        public Ingredient AddIngredient(Ingredient ing);

        public void DeleteIngredient(int id);

        public Ingredient GetIngredientById(int id);
    }
}
