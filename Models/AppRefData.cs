using System;

namespace WebApplication3.Models
{
    public class AppRefDatax
    {
        public string CustomerName { get; set; }

        public string ProjectName { get; set; }

        public int ProjectID { get; set; }
        public int ProjectId { get; internal set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int? ProjectStatus { get; set; }

        public int LocationGroup { get; set; }

        public int PayRoll { get; set; }

        public string SalesPerson { get; set; }

        public int ProjectCategory { get; set; }

        public int ProjectType { get; set; }

        public int SubDomain { get; set; }

        public string TimeSheetRepresentative { get; set; }

        public int ClientInvoiceGroup { get; set; }

        public int TimeSheetType { get; set; }

        public int IsVMSTimesheet { get; set; }

        public int PracticeType { get; set; }

        public string Recruiter { get; set; }
    }


    public class AppRefData
    {
        public int KeyId { get; set; }
        public string KeyName { get; set; }
    }

    public class Emplist
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}