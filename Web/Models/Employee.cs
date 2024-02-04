using System;
using System.ComponentModel.DataAnnotations;



namespace Web.Models
{

    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeSurnameName { get; set; }
        [Required]
        public string EmployeeMidName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string PassportNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Post { get; set; }
    }
}
