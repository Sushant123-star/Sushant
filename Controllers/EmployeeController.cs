using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using EmpCRUD_07_09_24.Models;

namespace EmpCRUD_07_09_24.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult EmpCRUD()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmpCRUD(string B1, Empdetails E)
        {
            Empopeartion Eop = new Empopeartion();
            if (B1.Equals("insert"))
            {
                int i = Eop.AddEmp(E);
                if (i == 0)
                {
                    ViewBag.Message = "Error Occured ";
                }
                else
                {
                    ViewBag.Message = "Emp data Added ";
                }
            }
            else if(B1.Equals("update"))
            {
                int i=Eop.UpdateEmp(E);
                if (i == 0)
                {
                    ViewBag.Message = "Error occured";
                }
                else
                {
                    ViewBag.Message = "Emp data Updated ";
                }
            }
            else if(B1.Equals("delete"))
            {
                int i = Eop.DeleteEmp(E.empid);
                if (i == 0)
                {
                    ViewBag.Message = "Error Occured";
                }
                else
                {
                    ViewBag.Message = "Emp data Deleted ";
                }
            }
            return View(E);
        }
    }
}