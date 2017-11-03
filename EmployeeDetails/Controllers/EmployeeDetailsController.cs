using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDetails.Models;

namespace EmployeeDetails.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetails
        public ActionResult Index()
        {
          return  View("~/Views/Employee/EmployeeDetails.cshtml"); 
        }

        public ActionResult ViewEmployeeDetails()
        {
            return View("~/Views/Employee/ViewEmployeeDetails.cshtml");
        }
    }
}