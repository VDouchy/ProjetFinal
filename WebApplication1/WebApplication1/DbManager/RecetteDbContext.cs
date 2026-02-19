using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DbManager
{
    public class RecetteDbContext : DbContext
    {
        public RecetteDbContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<Recette> Recette { get; set; }




        
    }
}
