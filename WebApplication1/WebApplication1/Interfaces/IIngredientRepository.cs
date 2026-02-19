using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IIngredientRepository
    {


        public List<Ingredient> GetAllIngredient();

        public Ingredient AddIngredient();

        public Ingredient DeleteIngredient();



    }
}
