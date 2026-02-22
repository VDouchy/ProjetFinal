using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;


namespace WebApplication1.DbManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option): base(option)
        { 
        }
        public DbSet<Ingredient> Ingredient { get; set; }

        public DbSet<Recette> Recette { get; set; }

        public DbSet<Recette_Ingredient> Recette_Ingredients { get; set; }
    }
}
