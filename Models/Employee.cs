using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int WorkingCompany { get; set; }

        public int PayRollCompany { get; set; }

        public int EmployeeStatus { get; set; }

        public int EmployeeType { get; set; }

        public int WorkingLocation { get; set; }

        public int? Department { get; set; }

        public string SSN { get; set; }

        public DateTime Date_Of_Birth { get; set; }

        public string PersonalEmailId { get; set; }

        public string OfficialEmailId { get; set; }

        public DateTime Date_Of_Hire { get; set; }

        public int BatchId { get; set; }

        public int HrRepresentative { get; set; }

        public int Recruter { get; set; }
    }
}