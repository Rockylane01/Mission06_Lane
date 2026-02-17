using System.ComponentModel.DataAnnotations;

namespace Mission06_Lane.Models
{
    public class Category
    {
        [Key]
        public required int CategoryId { get; set; }
        public required string CategoryName { get; set; }
    }
}
