using System.Linq;
using WebApplication1.DbManager;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class RecetteRepository : IRecetteRepository
    {

        private readonly AppDbContext _context;

        public RecetteRepository(AppDbContext context)
        {
            _context = context;
        }


        public Recette AddRecette(Recette rec)
        {
            _context.Recette.Add(rec);
            _context.SaveChanges();
            return rec;
        }

        public void DeleteRecette(Recette r)
        {
            _context.Recette.Remove(r);
            _context.SaveChanges();
        }

        public Recette GetRecetteById(int id)
        {
            Recette r = _context.Recette.FirstOrDefault(p => p.Id == id);
            return r;
        }

        public List<Recette> GetAllRecette()
        {
            return _context.Recette.ToList();
        }

        public string GetDetailRecette(int id)
        {
            /*Recette r = _context.Recette.Where();
            _context.SaveChanges();
            return r;*/
            return "";
        }

        public Recette ModifyRecette(Recette r)
        {
            _context.Recette.Update(r);
            _context.SaveChanges();
            return r;
        }
    }
}
