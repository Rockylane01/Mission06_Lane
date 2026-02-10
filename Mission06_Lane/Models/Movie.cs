using System.ComponentModel.DataAnnotations;

namespace Mission06_Lane.Models
{
    public class Movie
    {
        [Key]
        public required int movieID { get; set; }
        public required string category { get; set; }
        public required string title { get; set; }
        public required int year { get; set; }
        public required string director { get; set; }
        public required string rating { get; set; }
        public int? edited { get; set; }
        public string? lentTo { get; set; }
        public string? notes { get; set; }
    }
}
