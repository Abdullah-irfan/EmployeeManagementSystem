using EmployeeManagement.Core;
using EmployeeManagement.Core.Modal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeManagementController : Controller
    {
        #region Decleraion
        readonly IEmployeeManagementServices _employeeManagementServices;
        public EmployeeManagementController(IEmployeeManagementServices employeeManagementServices)
        {
            _employeeManagementServices = employeeManagementServices;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult EmployeeManagementLogin()
        {
            return View();
        }




        #region login

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(LoginDetails login)
        {
            var logins = _employeeManagementServices.login(login);
            if (logins != null)
            {
                return RedirectToAction("ViewEmployeeDetail");
            }
            else
            {
                ViewBag.Message = "PLEASE ENTER THE CORRECT USERNAME AND PASSWORD";
            }
            return View();
        }
        #endregion


        #region Dashboard
        public IActionResult Dashboard(EmployeeDetails empDetails)
        {
            return View(empDetails);
        }
        #endregion


        #region SaveEmployeeDetails

        [HttpPost]
        public IActionResult SaveEmployeeDetails(EmployeeDetails empDetails)
        {
            _employeeManagementServices.SaveEmployeeDetails(empDetails);
            return RedirectToAction("ViewEmployeeDetails");
        }
        #endregion

        #region EditEmployeeDetails
        public IActionResult EditEmployeeDetails(int id)
        {

            var editDetails = _employeeManagementServices.EditEmployeeDetails(id);

            return RedirectToAction("Dashboard", editDetails);
        }
        #endregion

        #region ViewEmployeeDetails
        public IActionResult ViewEmployeeDetails(EmployeeDetails empDetails)
        {
            var list = _employeeManagementServices.ViewEmployeeDetails(empDetails);
            return View(list);
        }

        public IActionResult ViewEmployeeDetail(EmployeeDetails empDetails)
        {
            var list = _employeeManagementServices.ViewEmployeeDetails(empDetails);
            return View(list);
        }

        #endregion

        #region DeleteEmployeeDetails
        public IActionResult DeleteEmployeeDetails(int id)
        {
            _employeeManagementServices.DeleteEmployeeDetails(id);
            return RedirectToAction("ViewEmployeeDetails");
        }
        #endregion



    }
}
