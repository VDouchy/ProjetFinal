using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _recetteRepository;
        public RecetteService (IRecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }



        public Recette AddRecette(Recette rec)
        {
            return _recetteRepository.AddRecette(rec);
        }



        public void DeleteRecette(int id)
        {
            _recetteRepository.DeleteRecette(id);
            
        }

        public List<Recette> GetAllRecette()
        {
            return _recetteRepository.GetAllRecette();
            
        }

        public void GetDetailRecette(int id)
        {
            _recetteRepository.GetDetailRecette(id);
            
        }

        public Recette GetRecetteById(int id)
        {
            return _recetteRepository.GetRecetteById(id);
        }

        public Recette ModifyRecette(Recette r)
        {
            return _recetteRepository.ModifyRecette( r);
        }

    }
}
