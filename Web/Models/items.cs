using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class items
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image { get; set; }

    }
}
