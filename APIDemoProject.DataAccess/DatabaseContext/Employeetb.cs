using System;
using System.Collections.Generic;

namespace APIDemoProject.DataAccess.DatabaseContext
{
    public partial class Employeetb
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int? Salary { get; set; }
    }
}
