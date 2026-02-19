using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IRecetteRepository
    {

        public List<Recette> GetAllRecette();

        public void GetDetailRecette(int id);

        public Recette AddRecette(Recette rec);

        public Recette ModifyRecette(int id);

        public Recette DeleteRecette(int id);






    }
}
