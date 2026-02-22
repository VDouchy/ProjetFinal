using WebApplication1.DbManager;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly AppDbContext _context;

        public IngredientRepository(AppDbContext context)
        {
            _context = context;
        }
        public Ingredient AddIngredient(Ingredient ing)
        {
            _context.Ingredient.Add(ing);
            _context.SaveChanges();
            return ing;
        }


        public void DeleteIngredient(int id)
        {
            Ingredient ingredient = GetIngredientById(id);
            if (ingredient != null)
            {
                _context.Ingredient.Remove(ingredient);
                _context.SaveChanges();
            }
        }

        public List<Ingredient> GetAllIngredient()
        {
            return _context.Ingredient.ToList();
            
        }

        public Ingredient GetIngredientById(int id)
        {
            Ingredient ing = _context.Ingredient.FirstOrDefault(p => p.Id == id);

            return ing;
        }
    }
}
