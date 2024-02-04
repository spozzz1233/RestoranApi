using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Posts
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string PostName { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }

}
