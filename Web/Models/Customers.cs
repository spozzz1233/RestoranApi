using System;
using System.ComponentModel.DataAnnotations;


namespace Web.Models
{
    public class Customers
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CustomersName { get; set; }
        [Required]
        public string CustomersSurName { get; set; }
        [Required]
        public string CustomersMidName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }

}
