using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Recette_Ingredient
    {

        [Key]
        public int Id { get; set; }
        [NotNull]
        public int Recette_Id { get; set; }
        [NotNull]
        public int Ingredient_Id {  get; set; }
        [NotNull]
        public int Quantity { get; set; }

        //----

        public Recette_Ingredient() { }

        public Recette_Ingredient(int id, int recette_id, int ingredient_id, int quantity) 
        { 
            Id = id;
            Recette_Id = recette_id;
            Ingredient_Id = ingredient_id;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Recette_Id: {Recette_Id}, Ingredient_id: {Ingredient_Id},Quantité: {Quantity}";
        }



    }
}
