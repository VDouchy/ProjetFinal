

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        
        [StringLength(100)]
        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public string Category {get;set;}

        public DateTime Created_at { get; set; }


        //----
        public Ingredient() { }

        public Ingredient(int id, string name, string category, DateTime Create_at)
        {
            Id = id;
            Name = name;
            Category = category;
            Created_at = Create_at;
        }








    }
}
