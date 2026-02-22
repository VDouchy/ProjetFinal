

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [NotNull]
        public string Name { get; set; }
        [Required]
        [NotNull]
        public string Category {get;set;}

        public DateTime CreatedAt { get; set; }


        //----
        public Ingredient() { }

        







    }
}
