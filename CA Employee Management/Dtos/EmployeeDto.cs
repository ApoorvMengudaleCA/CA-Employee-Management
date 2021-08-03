using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_Employee_Management.Dtos
{
    public class EmployeeDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public string Salary { get; set; }
        public string PhoneNumber { get; set; }

    }
}