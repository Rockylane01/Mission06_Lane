using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Lane.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 9999, ErrorMessage = "Year must be between 1888 and 2100")]
        public int? Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited status is required")]
        public int? Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Copied to Plex status is required")]
        public int? CopiedToPlex { get; set; }

        public string? Notes { get; set; }
    }
}
