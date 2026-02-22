namespace WebApplication1.Models
{
    public class RecetteDetailDto
    {

        public Recette Recette { get; set; }

        public List<Ingredient> Ingredients { get; set; } /* AJOUTER UN DTO INGREDIENT ET QUANTITÉ*/

        public List<int> Quantity { get; set; }

        /* CONSTRUCTEUR A FAIRE*/

    }
}
