using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.repository;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
            public ActionResult Index()
            {
                Common objRepo = new Common();

            var appRefStatus = objRepo.GetAppRefData(1800);
            var appRefType = objRepo.GetAppRefData(1220);
            var workinglocation = objRepo.GetEmplists();
            var workcompanies = objRepo.GetWorkingCompany();
            var departments = objRepo.GetDepartment();
            var batchids = objRepo.GetAppRefId();
            var hrrep = objRepo.GetHrRepresentative();
            var rec = objRepo.GetRecrut();

                var empVM = new EmployeeAddEditViewModel
                {
                    StatusList = appRefStatus ,
                   EmployeeType = appRefType,
                   WorkingLocations=workinglocation,
                   WorkingCompanies=workcompanies,
                   Departments=departments ,
                   BatchId= batchids,
                   HrRepo=hrrep,
                   Recruters=rec
                };

                return View(empVM);
            }
        }
    }


//    public ActionResult GetAppRefData()
//        {

//            EmployeeController EmpRepo = new EmployeeController();
//            ModelState.Clear();
//            return View(EmpRepo.Index());
//        }
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public ActionResult Index(EmployeeController Emp)
//        {
//            try
//            {
//                if (ModelState.IsValid)
//                {
//                    EmployeeController EmpRepo = new EmployeeController();

//                    if (EmpRepo.Index(Emp))
//                    {
//                        ViewBag.Message = "Employee details added successfully";
//                    }
//                }

//                return View();
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//    }
//}
