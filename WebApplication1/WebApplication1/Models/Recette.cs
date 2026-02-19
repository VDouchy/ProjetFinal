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
        [NotNull]

        public string Url { get; set; }

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

        public DateTime Created_at { get; set; }

        [Required]
        [NotNull]
        public DateTime Update { get; set; }


        //----

        public Recette() { }

        public Recette (int id, string title, string url,  string category, string description, string author, DateTime created_at, DateTime update_at)
        {
            Id = id;
            Title = title;
            Url = url;
            Category = category;
            Description = description;
            Author = author;
            Created_at = created_at;
            Update = update_at;

        }





    }
}
