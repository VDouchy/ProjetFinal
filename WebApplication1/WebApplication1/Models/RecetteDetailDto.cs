namespace WebApplication1.Models
{
    public class RecetteDetailDto
    {

        public Recette Recette { get; set; }

        List<Ingredient> Ingredients { get; set; } /* AJOUTER UN DTO INGREDIENT ET QUANTITÉ*/

        List<int> Quantity { get; set; }

        /* CONSTRUCTEUR A FAIRE*/

    }
}
