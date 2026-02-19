using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Recette_Ingredient
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [NotNull]
        public int RecetteId { get; set; }

        public Recette? Recette { get; set; }

        [Required]
        [NotNull]
        public int IngredientId {  get; set; }
        public Ingredient? Ingredient { get; set; }

        [NotNull]
        public int Quantity { get; set; }

        


        //----

        public Recette_Ingredient() { }

        public Recette_Ingredient(int id, int recette_id, int ingredient_id, int quantity) 
        { 
            Id = id;
            RecetteId = recette_id;
            IngredientId = ingredient_id;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Recette_Id: {RecetteId}, Ingredient_id: {IngredientId},Quantité: {Quantity}";
        }



    }
}
