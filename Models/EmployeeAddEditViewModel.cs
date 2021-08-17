using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class EmployeeAddEditViewModel
    {
        public Employee Employee { get; set; }
        public List<AppRefData> StatusList { get; set; }

        public List<AppRefData> EmployeeType { get; set; }

        public List<Emplist> WorkingLocations { get; set; }

        public List<Emplist> WorkingCompanies { get; set; }

        public List<Emplist> Departments { get; set; }

        public List<Emplist> BatchId { get; set; }

        public List<Emplist>  HrRepo { get; set; }

        public List<Emplist> Recruters { get; set; }


    }
}