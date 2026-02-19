using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;


namespace WebApplication1.DbManager
{
    public class IngredientDbContext : DbContext
    {
        public IngredientDbContext(DbContextOptions option): base(option)
        { 
        }


        public DbSet<Ingredient> Ingredient { get; set; }



        
    }
}
