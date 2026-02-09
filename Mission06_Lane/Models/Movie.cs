using System.ComponentModel.DataAnnotations;

namespace Mission06_Lane.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int movieID { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public int edited { get; set; }
        public string lentTo { get; set; }
        public string notes { get; set; }
    }
}
