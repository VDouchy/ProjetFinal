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

        public void DeleteRecette(int id)
        {
            Recette recette = GetRecetteById(id);
            if (recette != null)
            {
                _context.Recette.Remove(recette);
                _context.SaveChanges();
            }
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

        public void GetDetailRecette(int id)
        {
            Recette r = GetRecetteById(id);

            _context.SaveChanges();
            
        }

        public Recette ModifyRecette(Recette r)
        {
            Recette recetteAModifier = GetRecetteById(r.Id);
            _context.Recette.Update(recetteAModifier);
            _context.SaveChanges();
            return r;
        }
    }
}
