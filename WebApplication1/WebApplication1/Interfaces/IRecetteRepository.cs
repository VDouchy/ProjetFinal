using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IRecetteRepository
    {
        public List<Recette> GetAllRecette();

        public string GetDetailRecette(int id);

        public Recette AddRecette(Recette rec);

        public Recette ModifyRecette(Recette r);

        
        public void DeleteRecette(Recette r);
        public Recette GetRecetteById(int id);
    }
}
