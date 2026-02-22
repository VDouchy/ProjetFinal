using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Recette
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [NotNull]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [NotNull]
        public string Category { get; set; }

        [Required]
        [NotNull]
        public string Description { get; set; }

        [Required]
        [NotNull]
        public string Instructions { get; set; }

        [StringLength(255)]
        public string Author { get; set; }

        public DateTime CreatedAt { get; set; }

        
        public DateTime? UpdateAt { get; set; }


        //----

        public Recette() { }

        




    }
}
