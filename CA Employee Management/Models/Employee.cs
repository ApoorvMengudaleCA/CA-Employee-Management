using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CA_Employee_Management.Models
{
    public class Employee
    {

        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]

        public string Salary { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

    }
}