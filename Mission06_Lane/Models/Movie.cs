using System.ComponentModel.DataAnnotations;

namespace Mission06_Lane.Models
{
    public class Movie
    {
        [Key]
        public required int MovieID { get; set; }
        public int? CategoryId { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public required int Edited { get; set; }
        public string? LentTo { get; set; }
        public required int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
